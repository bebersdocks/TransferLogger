namespace TransferLogger.Ui.Controls
{
    public class TlSplitContainer : SplitContainer
    {
        public TlSplitContainer()
        {
            BackColor        = Color.GhostWhite;
            BorderStyle      = BorderStyle.None;
            Dock             = DockStyle.Fill;
            IsSplitterFixed  = true;
            Panel1.BackColor = Color.White;
            Panel2.BackColor = Color.White;
        }
    }
}
