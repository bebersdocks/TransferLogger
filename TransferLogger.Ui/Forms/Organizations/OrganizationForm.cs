using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Utils;

using Lookup = TransferLogger.BusinessLogic.Lookup;

namespace TransferLogger.Ui.Forms.Organizations
{
    public partial class OrganizationForm : Form
    {
        private readonly Organization _organization;
        private readonly List<Lookup> _countries;

        public OrganizationForm(int organizationId = 0)
        {
            InitializeComponent();

            using var dc = new Dc();

            _organization = dc.Organizations.FirstOrDefault(o => o.OrganizationId == organizationId) ?? new();
            _countries    = EnumUtils.GetLookups<Country>();

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            if (_organization.OrganizationId > 0)
            {
                _tbName.Text        = _organization.Name;
                _tbDescription.Text = _organization.Description;
                _tbUrl.Text         = _organization.Url;

                _cbCountries.FillLookups(_organization.Country);
                _cbOrganizationTypes.FillLookups(_organization.OrganizationType);

                Text = $"{_organization.Name} (Id: {_organization.OrganizationId})";
            }
            else
            {
                _cbCountries.FillLookups<Country>(_countries, Country.CY);
                _cbOrganizationTypes.FillLookups(OrganizationType.University);
            }
        }

        private void SetEvents()
        {
            _btnSelectCountry.Click += _btnSelectCountry_Click;
            _btnCancel.Click        += _btnCancel_Click;
            _btnOk.Click            += _btnOk_Click;
        }

        private void _btnSelectCountry_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Country", _countries, _cbCountries.SelectedValue);
            
            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbCountries.SelectedValue = form.SelectedValue.Value;
            }
        }

        private void _btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void _btnOk_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_tbName.Text))
            {
                MessageDialog.Show($"Name can't be empty.");
                _tbName.Focus();
                return;
            }

            if (_cbOrganizationTypes.SelectedValue is null)
            {
                MessageDialog.Show($"You have to specify organization.");
                return;
            }

            if (_cbCountries.SelectedValue is null)
            {
                MessageDialog.Show($"You have to specify country.");
                return;
            }

            _organization.Name             = _tbName.Text;
            _organization.Description      = _tbDescription.Text;
            _organization.OrganizationType = (OrganizationType)_cbOrganizationTypes.SelectedValue;
            _organization.Country          = (Country)_cbCountries.SelectedValue;
            _organization.Url              = _tbUrl.Text;

            if (FormUtils.TryInsertOrReplace(_organization, _organization.OrganizationId))
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }
    }
}
