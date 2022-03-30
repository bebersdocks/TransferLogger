using System.Drawing;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.Ui.Controls.Applications.Builder;

namespace TransferLogger.Ui.Forms.Applications
{
    public partial class ApplicationBuilderForm : Form
    {
        private readonly ApplicationBuild     _appBuild;
        private readonly SelectStudentControl _selectStudent;

        public ApplicationBuilderForm()
        {
            InitializeComponent();

            _appBuild      = new ApplicationBuild();
            _selectStudent = new SelectStudentControl();

            _pnlControl.Controls.Add(_selectStudent);

            SetCurrentStep(BuildStep.Student);

            SetEvents();
        } 

        private void SetEvents()
        {
            _btnBack.Click += (s, e) => Back();
            _btnNext.Click += (s, e) => NextStep();
        }

        private Size GetSize(BuildStep step)
        {
            return step switch
            {
                BuildStep.Student => new Size(615, 410),
                _ => new Size(600, 600)
            };
        }

        private void SetCurrentStep(BuildStep step)
        {
            _appBuild.CurrentStep = step;

            Size = MinimumSize = GetSize(step);

            _btnBack.Visible = step != BuildStep.Student;

            if (step == BuildStep.Student)
                _selectStudent.BringToFront();
        }

        public void NextStep()
        {
            var nextStep = _appBuild.GetNextStep();
            if (nextStep.HasValue)
                SetCurrentStep(nextStep.Value);
            else
                CreateApplication();
        }

        public void Back()
        {
            SetCurrentStep(_appBuild.GetPreviousStep());
        }

        public void CreateApplication()
        {
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
