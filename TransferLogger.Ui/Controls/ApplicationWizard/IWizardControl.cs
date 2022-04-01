namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public interface IWizardControl
    {
        public void BringToFront();
        public bool IsCompleted();
        public void Save();
    }
}
