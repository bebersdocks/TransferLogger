using System;
using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Dialogs
{
    public partial class ErrorDialog : Form
    {
        public ErrorDialog(string message, string title)
        {
            InitializeComponent();

            _tbMessage.Text = message;

            Text = title;

            SetEvents();
        }

        public static void Show(string message, string title = "Exception")
        {
            using var errorDlg = new ErrorDialog(message, title);

            errorDlg.ShowDialog();
        }

        public static void Show(Exception ex, string title = "Exception")
        {
            using var errorDlg = new ErrorDialog(ex.Message, title);

            errorDlg.ShowDialog();
        }

        private void SetEvents()
        {
            _btnOk.Click += _btnOk_Click;
        }

        private void _btnOk_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
