using System.Drawing;
using System.Windows.Forms;

namespace TransferLogger.Ui.Controls
{
    public class TlTextBox : TextBox
    {
        private int _boxWidth = 325;
        public int BoxWidth
        {
            get { return _boxWidth; }
            set { _boxWidth = value; Invalidate(); }
        }

        public TlTextBox()
        {
            Width = _boxWidth;
            
            BackColor   = Color.GhostWhite;
            BorderStyle = BorderStyle.Fixed3D;
            ForeColor   = Color.Black;
            TextAlign   = HorizontalAlignment.Left;
        }
    }
}