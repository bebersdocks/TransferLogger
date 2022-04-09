using System.Drawing;
using System.Windows.Forms;

namespace TransferLogger.Ui.Controls
{
    public class TlButton : Button
    {
        public override Color BackColor => Color.White;
        public override Font Font => new("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

        public TlButton()
        {
            Cursor    = Cursors.Hand;
            FlatStyle = FlatStyle.Flat;
            ForeColor = Color.Black;
            TabStop   = false;
            TextAlign = ContentAlignment.MiddleCenter;

            FlatAppearance.BorderColor        = Color.FromArgb(204, 206, 219);
            FlatAppearance.BorderSize         = 1;
            FlatAppearance.MouseDownBackColor = Color.GhostWhite;
            FlatAppearance.MouseOverBackColor = Color.GhostWhite;
        }
    }
}
