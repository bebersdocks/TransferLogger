using System;
using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Utils
{
    public partial class ExceptionInfo : Form
    {
        public ExceptionInfo(string message, string title)
        {
            InitializeComponent();

            _tbMessage.Text = message;

            Text = title;

            SetEvents();
        }

        public static void Show(Exception ex)
        {
            using var errorDlg = new ExceptionInfo(ex.Message, ex.GetType().ToString());

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
