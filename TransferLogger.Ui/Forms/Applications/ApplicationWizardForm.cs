using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.Ui.Controls.ApplicationWizard;

namespace TransferLogger.Ui.Forms.Applications
{
    public partial class ApplicationWizardForm : Form
    {
        private readonly ApplicationBuild                      _appBuild;
        private readonly Dictionary<BuildStep, IWizardControl> _wizardControls;

        public ApplicationWizardForm()
        {
            InitializeComponent();

            _appBuild = new ApplicationBuild();

            _wizardControls = new Dictionary<BuildStep, IWizardControl>
            {
                { BuildStep.Student, new StudentControl(_appBuild) },
                { BuildStep.Organization, new OrganizationControl(_appBuild) },
                { BuildStep.Courses, new CoursesControl(_appBuild) }
            };

            foreach (var (_, wizardControl) in _wizardControls)
            {
                _pnlControl.Controls.Add(wizardControl as Control);
            }

            SetCurrentStep(BuildStep.Student, false);
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
                _ => new Size(825, 600)
            };
        }

        private void SetCurrentStep(BuildStep step, bool forward = true)
        {
            if (_wizardControls.TryGetValue(_appBuild.CurrentStep, out var wizardControl))
            {
                if (forward && !wizardControl.Complete())
                {
                    return;
                }
            }

            _appBuild.CurrentStep = step;

            Size = MinimumSize = GetSize(step);

            _btnBack.Visible = step != BuildStep.Student;

            if (_wizardControls.TryGetValue(step, out wizardControl))
            {
                wizardControl.Activate();

                CenterToScreen();
            }
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
            SetCurrentStep(_appBuild.GetPreviousStep(), false);
        }

        public void CreateApplication()
        {
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
