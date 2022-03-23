using System;
using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Dialogs
{
    public partial class ErrorDialog : Form
    {
        public ErrorDialog(string message, string title)
        {
            InitializeComponent();

            _tbError.Text = message;

            Text = title;

            SetEvents();
        }

        public static void Show(string message, string title = "Error")
        {
            using var errorDlg = new ErrorDialog(message, title);

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
