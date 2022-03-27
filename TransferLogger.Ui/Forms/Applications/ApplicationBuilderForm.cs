using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels.Applications;
using TransferLogger.Ui.Controls.Applications.Builder;

namespace TransferLogger.Ui.Forms.Applications
{
    public enum BuilderStep
    {
        Main                  = 0,
        HistoricalEvaluations = 1,
        CoursesEvaluators     = 2,
        Confirmation          = 3
    }

    public partial class ApplicationBuilderForm : Form
    {
        private readonly ApplicationBuild _appBuild = new();
        public ApplicationBuild AppBuild => _appBuild;

        private readonly ApplicationBuilder               _appBuilder;
        private readonly ApplicationHistoricalEvaluations _appHistoricalEvaluations;
        private readonly ApplicationCoursesEvaluators     _appCourseEvaluators;

        public ApplicationBuilderForm()
        {
            InitializeComponent();

            _appBuilder               = new ApplicationBuilder(_appBuild);
            _appHistoricalEvaluations = new ApplicationHistoricalEvaluations(_appBuild);
            _appCourseEvaluators      = new ApplicationCoursesEvaluators();

            _appBuilder.Dock               = DockStyle.Fill;
            _appHistoricalEvaluations.Dock = DockStyle.Fill;
            _appCourseEvaluators.Dock      = DockStyle.Fill;

            _pnlControl.Controls.Add(_appBuilder);
            _pnlControl.Controls.Add(_appHistoricalEvaluations);
            _pnlControl.Controls.Add(_appCourseEvaluators);

            SetCurrentStep(BuilderStep.Main);
            SetEvents();
        } 

        private void SetEvents()
        {
            _btnBack.Click += (s, e) => Back();
            _btnNext.Click += (s, e) => NextStep();
        }

        private BuilderStep _currentStep;
        private void SetCurrentStep(BuilderStep step)
        {
            if (_currentStep == BuilderStep.Main)
                _appBuilder.SetData();

            _currentStep = step;

            _btnBack.Visible = step != BuilderStep.Main;
            _btnNext.Text    = step == BuilderStep.Confirmation ? "Confirm" : "Next";

            if (step == BuilderStep.Main)
                _appBuilder.BringToFront();
            else if (step == BuilderStep.HistoricalEvaluations)
                _appHistoricalEvaluations.BringToFront();
            else if (step == BuilderStep.CoursesEvaluators)
                _appCourseEvaluators.BringToFront();
        }

        private bool AnyHistoricalEvaluations()
        {
            using var dc = new Dc();

            return dc.ApplicationCourses.Any(c => _appBuild.CourseIds.Contains(c.CourseId));
        }

        public void NextStep()
        {
            if (_currentStep == BuilderStep.Main && AnyHistoricalEvaluations())
                SetCurrentStep(BuilderStep.HistoricalEvaluations);
            else if (_currentStep == BuilderStep.Main)
                SetCurrentStep(BuilderStep.CoursesEvaluators);
            else if (_currentStep == BuilderStep.HistoricalEvaluations)
                SetCurrentStep(BuilderStep.CoursesEvaluators);
            else if (_currentStep == BuilderStep.CoursesEvaluators)
                SetCurrentStep(BuilderStep.Confirmation);
            else if (_currentStep == BuilderStep.Confirmation)
                CreateApplication();
        }

        public void Back()
        {
            if (_currentStep == BuilderStep.Confirmation)
                SetCurrentStep(BuilderStep.CoursesEvaluators);
            else if (_currentStep == BuilderStep.CoursesEvaluators && AnyHistoricalEvaluations())
                SetCurrentStep(BuilderStep.HistoricalEvaluations);
            else
                SetCurrentStep(BuilderStep.Main);
        }

        public void CreateApplication()
        {
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
