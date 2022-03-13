namespace TransferLogger.Ui.Utils
{
    public static class FormUtils
    {
        public static void ShowForm<T>(Func<T> getForm) where T : Form
        {
            using var form = getForm();

            form.ShowDialog();
        }

        public static void ShowValidationMsg(this Form form, string msg)
        {
            MessageBox.Show(form, msg, "Validation error");
        }
    }
}
