using System.Windows.Forms;

using TransferLogger.BusinessLogic;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class HistoricalEvaluationsControl : UserControl, IWizardControl
    {
        private readonly ApplicationBuild _appBuild;

        public HistoricalEvaluationsControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;

            SetData();
            SetEvents();
        }

        private void SetData()
        {

        }

        private void SetEvents()
        {

        }

        public void Activate()
        {
            BringToFront();
        }

        public bool Complete()
        {
            return false;
        }
    }
}
