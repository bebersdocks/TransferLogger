using LinqToDB;

using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;

namespace TransferLogger.Ui.Forms.Organization
{
    public partial class OrganizationsForms : Form
    {
        public OrganizationsForms()
        {
            InitializeComponent();

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            using var dc = new Dc();

            var query = dc.Organizations.AsQueryable();

            _gridOrganizations.DataSource = query
                .Select(o => new OrganizationViewModel(o))
                .ToList();
        }

        private void SetEvents()
        {
            _gridOrganizations.DoubleClick += (s, e) => InsertOrReplaceOrganization();
            _btnAdd.Click                  += (s, e) => InsertOrReplaceOrganization(true);
            _btnEdit.Click                 += (s, e) => InsertOrReplaceOrganization();

            _btnDelete.Click += _btnDelete_Click;
        }

        private void InsertOrReplaceOrganization(bool isNew = false)
        {
            var organizationId = 0;

            if (!isNew)
            {
                if (_gridOrganizations.CurrentRow.DataBoundItem is OrganizationViewModel orgViewModel)
                {
                    organizationId = orgViewModel.OrganizationId;
                }
                else
                {
                    return;
                }
            }

            using var form = new OrganizationForm(organizationId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                SetData();
            }
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_gridOrganizations.CurrentRow.DataBoundItem is OrganizationViewModel orgViewModel)
            {
                using var dc = new Dc();

                dc.Organizations
                    .Where(o => o.OrganizationId == orgViewModel.OrganizationId)
                    .Delete();

                SetData();
            }
        }
    }
}
