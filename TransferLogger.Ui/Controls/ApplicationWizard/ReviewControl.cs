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

            _tbStudent.Text = dc.Students.First(s => s.StudentId == _appBuild.Student.StudentId)
                .DisplayString;

            _tbOrganization.Text = dc.Organizations.First(o => o.OrganizationId == _appBuild.SourceOrganizationId)
                .DisplayString;

            _tbTargetProgram.Text = dc.Programs.First(p => p.ProgramId == _appBuild.TargetProgramId)
                .DisplayString;

            _grid.DataSource = _appBuild.Evaluations.Values
                .Select(e => new BuildEvaluationViewModel(dc, e))
                .OrderByDescending(e => e.Status)
                .ToList();
        }

        public bool Complete()
        {
            return true;
        }
    }
}
