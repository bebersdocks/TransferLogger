using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic.Settings;
using TransferLogger.BusinessLogic.Models.Organizations;
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
    public partial class OrganizationsForm : Form
    {
        private readonly List<Lookup> _countries = EnumUtils.GetLookups<Country>();

        public OrganizationsForm() : this(null, null) {}

        public OrganizationsForm(OrganizationType? organizationType = null, Country? country = null)
        {
            InitializeComponent();

            SetData(organizationType, country);
            SetEvents();
        }

        private void SetData(OrganizationType? organizationType = null, Country? country = null)
        {
            if (_cbOrganizationTypes.Items.Count == 0)
                _cbOrganizationTypes.FillLookups<OrganizationType>(Convert.ToInt32(organizationType));

            if (_cbCountries.Items.Count == 0)
                _cbCountries.FillLookups(_countries, Convert.ToInt32(country));

            _grid.DataSource =  OrganizationModel.GetList(_tbSearchName.Text, _cbOrganizationTypes.SelectedValue, _cbCountries.SelectedValue);
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged                 += (s, e) => SetData();
            _cbOrganizationTypes.SelectedValueChanged += (s, e) => SetData();
            _cbCountries.SelectedValueChanged         += (s, e) => SetData();

            _btnSelectCountry.Click += _btnSelectCountry_Click;

            _grid.DoubleClick += (s, e) => InsertOrReplace();
            _btnAdd.Click     += (s, e) => InsertOrReplace(true);
            _btnEdit.Click    += (s, e) => InsertOrReplace();

            _grid.SelectionChanged += _grid_SelectionChanged;

            _btnDelete.Click += _btnDelete_Click;
        }

        private void _btnSelectCountry_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Country", _countries, _cbCountries.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbCountries.SelectedValue = form.SelectedValue.Value;
            }
        }

        private void InsertOrReplace(bool isNew = false)
        {
            OrganizationType? organizationType = null;
            if (_cbOrganizationTypes.SelectedValue != null)
                organizationType = (OrganizationType)_cbOrganizationTypes.SelectedValue;

            Country? country = null;
            if (_cbCountries.SelectedValue != null)
                country = (Country)_cbCountries.SelectedValue;

            FormUtils.InsertOrReplace(_grid, id => new OrganizationForm(id, organizationType, country), () => SetData(), isNew);
        }

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is OrganizationModel model)
            {
                _btnDelete.Enabled = model.Id != AppSettings.Instance.OrganizationId;
            }
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is OrganizationModel model)
            {
                using var confirmBox = new ConfirmBox(
                    "Confirm Deletion",
                    $"Are you sure you want to delete {model.Name} (Id: {model.Id})?");

                if (confirmBox.ShowDialog() == DialogResult.OK)
                {
                    var index = _grid.CurrentRow.Index;

                    using var dc = new Dc();

                    dc.Organizations
                        .Where(o => o.OrganizationId == model.Id)
                        .Delete();

                    SetData();

                    _grid.SelectRow(index);
                }
            }
        }
    }
}
