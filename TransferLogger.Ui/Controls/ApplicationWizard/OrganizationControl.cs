using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.BusinessLogic.ViewModels.Organizations;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Forms;
using TransferLogger.Ui.Forms.Organizations;
using TransferLogger.Ui.Utils;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class OrganizationControl : UserControl, IWizardControl
    {
        private readonly ApplicationBuild _appBuild;

        private readonly List<Lookup> _countries = EnumUtils.GetLookups<Country>();

        public OrganizationControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            if (_cbOrganizationTypes.Items.Count == 0)
                _cbOrganizationTypes.FillLookups<OrganizationType>();

            if (_cbCountries.Items.Count == 0)
                _cbCountries.FillLookups(_countries);

            var selectedIds = new HashSet<int>();

            if (_grid.SelectedRows.Count == 1 && _grid.SelectedRows[0].DataBoundItem is IIdentifiable viewModel)
                selectedIds.Add(viewModel.Id);

            _grid.SelectionChanged -= _grid_SelectionChanged;

            _grid.DataSource = SelectableOrganizationViewModel.GetList(selectedIds,
                _tbSearchName.Text, 
                _cbOrganizationTypes.SelectedValue, 
                _cbCountries.SelectedValue);

            if (selectedIds.Any())
                _grid.SelectRow<IIdentifiable>(i => selectedIds.Contains(i.Id));

            _grid.SelectionChanged += _grid_SelectionChanged;
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged                 += (s, e) => SetData();
            _cbOrganizationTypes.SelectedValueChanged += (s, e) => SetData();
            _cbCountries.SelectedValueChanged         += (s, e) => SetData();

            _btnAdd.Click           += _btnAdd_Click;
            _btnSelectCountry.Click += _btnSelectCountry_Click;
        }

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {         
            if (_grid.DataSource is List<SelectableOrganizationViewModel> organizations)
            {
                int selectedId = 0;

                if (_grid.SelectedRows.Count == 1 && _grid.SelectedRows[0].DataBoundItem is IIdentifiable viewModel)
                    selectedId = viewModel.Id;

                foreach (var organization in organizations)
                    organization.Selected = organization.Id == selectedId;

                _grid.Refresh();
            }
        }

        private void _btnAdd_Click(object? sender, EventArgs e)
        {
            FormUtils.InsertOrReplace(_grid, id => new OrganizationForm(id), () => SetData(), true);
        }

        private void _btnSelectCountry_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Country", _countries, _cbCountries.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbCountries.SelectedValue = form.SelectedValue.Value;
            }
        }

        public bool IsCompleted()
        {
            return _grid.SelectedRows.Count == 1;
        }

        public void Save()
        {
            if (_grid.SelectedRows[0].DataBoundItem is IIdentifiable viewModel)
            {
                _appBuild.OrganizationId = viewModel.Id;
            }
        }
    }
}
