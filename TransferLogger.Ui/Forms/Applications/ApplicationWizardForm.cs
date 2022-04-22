using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.Interop;
using TransferLogger.Ui.Controls.ApplicationWizard;
using TransferLogger.Ui.Forms.Utils;

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
                { BuildStep.Program, new ProgramControl(_appBuild) },
                { BuildStep.Organization, new OrganizationControl(_appBuild) },
                { BuildStep.Courses, new CoursesControl(_appBuild) },
                { BuildStep.HistoricalEvaluations, new HistoricalEvaluationsControl(_appBuild) },
                { BuildStep.Evaluators, new EvaluatorsControl(_appBuild) },
                { BuildStep.Attachments, new AttachmentsControl(_appBuild) },
                { BuildStep.Review, new ReviewControl(_appBuild) }
            };

            foreach (var wizardControl in _wizardControls.Values)
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
                _ => new Size(935, 640)
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
            _btnNext.Text    = step == BuildStep.Review ? "Create" : "Next";

            if (_wizardControls.TryGetValue(step, out wizardControl))
            {
                wizardControl.Activate();

                CenterToScreen();
            }
        }

        private void NextStep()
        {
            var nextStep = _appBuild.GetNextStep();

            if (nextStep.HasValue)
            {
                try
                {
                    SetCurrentStep(nextStep.Value);
                }
                catch (Exception)
                {
                    Back(); // Revert step back if move failed.

                    throw;
                }
            }
            else
            {
                CreateApplication();
            }
        }

        private void Back()
        {
            SetCurrentStep(_appBuild.GetPreviousStep(), false);
        }

        private async void CreateApplication()
        {
            var appId = _appBuild.Insert();

            var task = Task.Run(() => new OutlookEmail(appId));

            using var form = new LoadingForm("Email", "Preparing email...");

            BeginInvoke((Action)(() => form.ShowDialog()));

            var outlookEmail = await task;

            outlookEmail.Display();

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
