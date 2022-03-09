using LinqToDB;

using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Ui.Controls;

using Org = TransferLogger.Dal.DataModels.Organization;

namespace TransferLogger.Ui.Forms.Organization
{
    public partial class OrganizationForm : Form
    {
        private readonly Org _organization;

        public OrganizationForm(int organizationId = 0)
        {
            InitializeComponent();

            using var dc = new Dc();

            _organization = dc.Organizations.FirstOrDefault(o => o.OrganizationId == organizationId) ?? new();

            SetEvents();
            SetData();
        }

        private void SetEvents()
        {
            _btnCancel.Click += _btnCancel_Click;
            _btnOk.Click     += _btnOk_Click;
        }

        private void SetData()
        {
            if (_organization.OrganizationId > 0)
            {
                _tbName.Text        = _organization.Name;
                _tbDescription.Text = _organization.Description;
                _tbUrl.Text         = _organization.Url;

                _cbOrganizationTypes.FillLookups(_organization.OrganizationType);

                Text = $"{_organization.Name} (Id: {_organization.OrganizationId})";
            }
            else
            {
                _cbOrganizationTypes.FillLookups(OrganizationType.University);
            }
        }

        private void _btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void _btnOk_Click(object? sender, EventArgs e)
        {
            _organization.Name             = _tbName.Text;
            _organization.Description      = _tbDescription.Text;
            _organization.OrganizationType = (OrganizationType)_cbOrganizationTypes.SelectedValue;
            _organization.Url              = _tbUrl.Text;

            using var dc = new Dc();

            if (_organization.OrganizationId == 0)
                dc.InsertWithIdentity(_organization);
            else
                dc.Update(_organization);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
