using System;
using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Dialogs
{
    public partial class ConfirmDialog : Form
    {
        public ConfirmDialog(string title, string message)
        {
            InitializeComponent();

            _tbMessage.Text = $"  {message}";

            Text = title;

            SetEvents();

        }

        private void SetEvents()
        {
            _btnAbort.Click   += _btnAbort_Click;
            _btnConfirm.Click += _btnConfirm_Click;
        }

        private void _btnAbort_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;

            Close();
        }

        private void _btnConfirm_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
