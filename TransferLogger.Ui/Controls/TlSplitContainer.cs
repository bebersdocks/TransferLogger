using System.Drawing;
using System.Windows.Forms;

namespace TransferLogger.Ui.Controls
{
    public class TlSplitContainer : SplitContainer
    {
        public TlSplitContainer()
        {
            BackColor        = Color.GhostWhite;
            BorderStyle      = BorderStyle.None;
            Dock             = DockStyle.Fill;
            Panel1.BackColor = Color.White;
            Panel2.BackColor = Color.White;
        }
    }
}
