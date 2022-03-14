using LinqToDB;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Utils;

using Lookup = TransferLogger.BusinessLogic.Lookup;

namespace TransferLogger.Ui.Forms.Organization
{
    public partial class OrganizationsForm : Form
    {
        private readonly List<Lookup> _countries;

        public OrganizationsForm()
        {
            InitializeComponent();

            _countries = EnumUtils.GetLookups<Country>();

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            if (_cbOrganizationTypes.Items.Count == 0)
                _cbOrganizationTypes.FillLookups<OrganizationType>();

            if (_cbCountries.Items.Count == 0)
                _cbCountries.FillLookups<Country>(_countries);

            using var dc = new Dc();

            var query = dc.Organizations.AsQueryable();

            if (!string.IsNullOrEmpty(_tbSearchName.Text))
                query = query.Where(o => o.Name.Contains(_tbSearchName.Text, StringComparison.OrdinalIgnoreCase) || o.Description.Contains(_tbSearchName.Text, StringComparison.OrdinalIgnoreCase));

            if (_cbOrganizationTypes.SelectedValue != null)
                query = query.Where(o => o.OrganizationType == (OrganizationType)_cbOrganizationTypes.SelectedValue);

            if (_cbCountries.SelectedValue != null)
                query = query.Where(o => o.Country == (Country)_cbCountries.SelectedValue);

            _grid.DataSource = query
                .Select(o => new OrganizationViewModel(o))
                .ToList();
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
            FormUtils.InsertOrReplace(_grid, organizationId => new OrganizationForm(organizationId), () => SetData(), isNew);
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is IIdentifiable viewModel)
            {
                using var dc = new Dc();

                dc.Organizations
                    .Where(o => o.OrganizationId == viewModel.Id)
                    .Delete();

                SetData();
            }
        }
    }
}
