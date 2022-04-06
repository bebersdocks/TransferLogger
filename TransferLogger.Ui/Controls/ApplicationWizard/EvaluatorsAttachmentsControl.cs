using System;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class EvaluatorsAttachmentsControl : UserControl
    {
        private readonly ApplicationBuild _appBuild;

        public EvaluatorsAttachmentsControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;
        }
    }
}
