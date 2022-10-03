using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Models.Organizations;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Forms;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Forms.Organizations;
using TransferLogger.Ui.Utils;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class OrganizationControl : UserControl, IWizardControl
    {
        private BindingList<SelectableOrganizationModel> _organizations = new();
       
        private readonly ApplicationBuild _appBuild;
        private readonly List<Lookup>     _countries = EnumUtils.GetLookups<Country>();

        public OrganizationControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;

            SetData();
            SetEvents();
        }

        public void Activate()
        {
            BringToFront();

            _grid.Focus();
        }

        private void SetData()
        {
            if (_cbOrganizationTypes.Items.Count == 0)
                _cbOrganizationTypes.FillLookups<OrganizationType>();

            if (_cbCountries.Items.Count == 0)
                _cbCountries.FillLookups(_countries);

            var selectedIds = new HashSet<int>();

            if (_organizations.SingleOrDefault(i => i.Selected) is IIdentifiable identifiable)
                selectedIds.Add(identifiable.Id);

            var organizations = SelectableOrganizationModel.GetList(
                selectedIds,
                _tbSearchName.Text,
                _cbOrganizationTypes.GetSelectedValue<OrganizationType>(),
                _cbCountries.GetSelectedValue<Country>());

            _organizations = new BindingList<SelectableOrganizationModel>(organizations);

            _grid.DataSource = _organizations;
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged                 += (s, e) => SetData();
            _cbOrganizationTypes.SelectedValueChanged += (s, e) => SetData();
            _cbCountries.SelectedValueChanged         += (s, e) => SetData();
            _grid.CellClick                           += (s, e) => SetCurrentRowAsSelected();
            _grid.CellDoubleClick                     += (s, e) => SetCurrentRowAsSelected();

            _btnAdd.Click           += _btnAdd_Click;
            _btnManage.Click        += _btnManage_Click;
            _btnSelectCountry.Click += _btnSelectCountry_Click;
            _grid.KeyDown           += _grid_KeyDown;
        }

        private void _grid_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetCurrentRowAsSelected();

                e.SuppressKeyPress = true;
            }
        }

        private void SetCurrentRowAsSelected()
        {
            if (_grid.CurrentRow?.DataBoundItem is SelectableOrganizationModel organization)
                organization.Selected = !organization.Selected;
        }

        private void _btnAdd_Click(object? sender, EventArgs e)
        {
            var organizationType = _cbOrganizationTypes.GetSelectedValue<OrganizationType>();
            var country          = _cbCountries.GetSelectedValue<Country>();

            using var form = new OrganizationForm(0, organizationType, country);

            if (form.ShowDialog() == DialogResult.OK)
                SetData();
        }

        private void _btnManage_Click(object? sender, EventArgs e)
        {
            var organizationType = _cbOrganizationTypes.GetSelectedValue<OrganizationType>();
            var country          = _cbCountries.GetSelectedValue<Country>();

            using var form = new OrganizationsForm(organizationType, country);

            form.ShowDialog();

            SetData();
        }

        private void _btnSelectCountry_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Country", _countries, _cbCountries.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
                _cbCountries.SelectedValue = form.SelectedValue.Value;
        }

        public bool Complete()
        {
            if (_organizations.SingleOrDefault(i => i.Selected) is not IIdentifiable identifiable)
            {
                MessageDialog.Show("You have to select organization.", "Wizard Validation");

                return false;
            }
            else
            {
                _appBuild.SourceOrganizationId = identifiable.Id;
                _appBuild.CleanObsoleteResources();

                return true;
            }
        }
    }
}
