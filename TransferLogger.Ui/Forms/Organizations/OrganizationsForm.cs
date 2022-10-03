using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Settings;
using TransferLogger.BusinessLogic.Models.Organizations;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Dialogs;

using Lookup = TransferLogger.BusinessLogic.Lookup;

namespace TransferLogger.Ui.Forms.Organizations
{
    public partial class OrganizationsForm : Form
    {
        private readonly List<Lookup> _countries = EnumUtils.GetLookups<Country>();

        public OrganizationsForm() : this(null, null) { }

        public OrganizationsForm(OrganizationType? organizationType = null, Country? country = null)
        {
            InitializeComponent();

            SetData(organizationType, country);
            SetEvents();
        }

        private void SetData(OrganizationType? organizationType = null, Country? country = null, int? index = null)
        {
            index ??= _grid.CurrentRow?.Index;

            if (_cbOrganizationTypes.Items.Count == 0)
                _cbOrganizationTypes.FillLookups<OrganizationType>(Convert.ToInt32(organizationType));

            if (_cbCountries.Items.Count == 0)
                _cbCountries.FillLookups(_countries, Convert.ToInt32(country));

            _grid.DataSource = OrganizationModel.GetList(
                _tbSearchName.Text, 
                _cbOrganizationTypes.GetSelectedValue<OrganizationType>(), 
                _cbCountries.GetSelectedValue<Country>());

            _grid.SelectRow(index);
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged                 += (s, e) => SetData();
            _cbOrganizationTypes.SelectedValueChanged += (s, e) => SetData();
            _cbCountries.SelectedValueChanged         += (s, e) => SetData();

            _btnAdd.Click           += _btnAdd_Click;
            _btnEdit.Click          += _btnEdit_Click;
            _btnDelete.Click        += _btnDelete_Click;
            _btnSelectCountry.Click += _btnSelectCountry_Click;
            _grid.DoubleClick       += _btnEdit_Click;
        }

        private void _btnSelectCountry_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Country", _countries, _cbCountries.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
                _cbCountries.SelectedValue = form.SelectedValue.Value;
        }

        private void _btnAdd_Click(object? sender, EventArgs e)
        {
            using var form = new OrganizationForm(
                0, 
                _cbOrganizationTypes.GetSelectedValue<OrganizationType>(),
                _cbCountries.GetSelectedValue<Country>());

            if (form.ShowDialog() == DialogResult.OK)
                SetData(index: _grid.RowCount + 1);
        }

        private void _btnEdit_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is IIdentifiable identifiable)
            {
                using var form = new OrganizationForm(
                    identifiable.Id,
                    _cbOrganizationTypes.GetSelectedValue<OrganizationType>(),
                    _cbCountries.GetSelectedValue<Country>());

                if (form.ShowDialog() == DialogResult.OK)
                    SetData();
            }
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is OrganizationModel organization)
            {
                if (organization.Id == AppSettings.Instance.OrganizationId)
                {
                    MessageDialog.Show("You can't delete your current organization.", "Aborted");
                    return;
                }

                using var confirmBox = new ConfirmBox(
                    "Confirm Deletion",
                    $"Are you sure you want to delete {organization.Name} (Id: {organization.Id})?");

                if (confirmBox.ShowDialog() == DialogResult.OK)
                {
                    using var dc = new Dc();

                    dc.Organizations
                        .Where(o => o.OrganizationId == organization.Id)
                        .Delete();

                    SetData();
                }
            }
        }
    }
}
