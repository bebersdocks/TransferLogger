namespace TransferLogger.Ui.Controls
{
    public class TlButton : Button
    {
        private Color _hoverColor = Color.FromArgb(234, 240, 255);
        public Color HoverColor
        {
            get { return _hoverColor; }
            set { _hoverColor = value; Invalidate(); }
        }

        public TlButton()
        {
            AutoSize    = true;
            BackColor   = Color.FromArgb(250, 250, 255);
            Cursor      = Cursors.Hand;
            FlatStyle   = FlatStyle.Flat;
            ForeColor   = Color.Black;
            MaximumSize = new Size(0, 28);
            MinimumSize = new Size(0, 28);
            TabStop     = false;
            TextAlign   = ContentAlignment.MiddleCenter;

            FlatAppearance.BorderColor        = Color.Gainsboro;
            FlatAppearance.BorderSize         = 1;
            FlatAppearance.MouseDownBackColor = BackColor;
            FlatAppearance.MouseOverBackColor = _hoverColor;
        }
    }
}
