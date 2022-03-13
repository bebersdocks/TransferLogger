namespace TransferLogger.Ui.Utils
{
    public static class FormUtils
    {
        public static void ShowValidationMsg(this Form form, string msg)
        {
            MessageBox.Show(form, msg, "Validation error");
        }
    }
}
