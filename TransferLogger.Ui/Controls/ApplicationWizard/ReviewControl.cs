using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.Dal;
using TransferLogger.BusinessLogic.ViewModels;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class ReviewControl : UserControl, IWizardControl
    {
        private readonly ApplicationBuild _appBuild;

        public ReviewControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;
        }

        public void Activate()
        {
            SetData();

            BringToFront();
        }

        private void SetData()
        {
            using var dc = new Dc();

            _tbStudent.Text      = dc.Students.First(s => s.StudentId == _appBuild.Student.StudentId).DisplayString;
            _tbOrganization.Text = dc.Organizations.First(o => o.OrganizationId == _appBuild.OrganizationId).DisplayString;

            _grid.DataSource = _appBuild.Evaluations.Values
                .Select(e => new ApplicationEvaluationViewModel(dc, e))
                .OrderByDescending(e => e.Status)
                .ToList();
        }

        public bool Complete()
        {
            return true;
        }
    }
}
