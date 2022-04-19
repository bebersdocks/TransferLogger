using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Utils
{
    public partial class LoadingForm : Form
    {
        public LoadingForm(string title, string message)
        {
            InitializeComponent();

            Text = title;

            _tbMessage.Text = message;
        }
    }
}
