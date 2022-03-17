using System;
using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Dialogs
{
    public partial class MessageDialog : Form
    {
        public MessageDialog(string title, string message)
        {
            InitializeComponent();

            _tbMessage.Text = $"  {message}";

            Text = title;

            SetEvents();
        }

        public static void Show(string msg, string title = "Validation Error")
        {
            using var messageDlg = new MessageDialog(title, msg);

            messageDlg.ShowDialog();
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
