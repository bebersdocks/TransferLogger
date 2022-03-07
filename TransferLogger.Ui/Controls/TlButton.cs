namespace TransferLogger.Ui.Controls
{
    public class TlButton : Button
    {
        public override bool             AutoSize    => true;
        public override Color            BackColor   => Color.FromArgb(250, 250, 255);
        public override Cursor           Cursor      => Cursors.Hand;
        public override Color            ForeColor   => Color.Black;
        public override Size             MaximumSize => new(0, 30);
        public override Size             MinimumSize => new(0, 30);
        public override ContentAlignment TextAlign   => ContentAlignment.MiddleCenter;

        private Color _hoverColor = Color.FromArgb(234, 240, 255);
        public Color HoverColor
        {
            get { return _hoverColor; }
            set { _hoverColor = value; Invalidate(); }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            FlatStyle = FlatStyle.Flat;

            FlatAppearance.BorderColor        = Color.Gainsboro;
            FlatAppearance.BorderSize         = 1;
            FlatAppearance.MouseDownBackColor = BackColor;
            FlatAppearance.MouseOverBackColor = _hoverColor;

            TabStop = false;
        }
    }
}
