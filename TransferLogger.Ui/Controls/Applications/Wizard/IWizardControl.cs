namespace TransferLogger.Ui.Controls.Applications.Wizard
{
    public interface IWizardControl
    {
        public void BringToFront();
        public bool IsCompleted();
        public void Save();
    }
}
