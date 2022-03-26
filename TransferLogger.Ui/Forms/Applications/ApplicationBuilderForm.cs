using System.Collections.Generic;
using System.Windows.Forms;

using TransferLogger.Ui.Controls.Applications.Builder;

namespace TransferLogger.Ui.Forms.Applications
{
    public enum ApplicationBuilderStep
    {
        Builder               = 0,
        HistoricalEvaluations = 1,
        InstructorAssignments = 2,
        Confirmation          = 3
    }

    public partial class ApplicationBuilderForm : Form
    {
        private ApplicationBuilderStep _currentStep = ApplicationBuilderStep.Builder;

        private readonly Dictionary<ApplicationBuilderStep, UserControl> _stepControls;

        public ApplicationBuilderForm()
        {
            InitializeComponent();

            _stepControls = new Dictionary<ApplicationBuilderStep, UserControl>
            {
                { ApplicationBuilderStep.Builder, new ApplicationBuilder() }
            };

            SetStepControl();
        }

        public void SetEvents()
        {

        }

        public void SetStepControl()
        {
            _stepControls[_currentStep].Dock = DockStyle.Fill;
            _pnlControl.Controls.Add(_stepControls[_currentStep]);
        }

        public void NextStep()
        {
            if (_currentStep == ApplicationBuilderStep.Confirmation)
            {

            }
        }

        public void Back()
        {

        }
    }
}
