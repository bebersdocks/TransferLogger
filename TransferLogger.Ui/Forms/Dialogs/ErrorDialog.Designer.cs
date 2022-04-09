namespace TransferLogger.Ui.Forms.Dialogs
{
    partial class ErrorDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnOk = new TransferLogger.Ui.Controls.TlButton();
            this._tbMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOk.ForeColor = System.Drawing.Color.Black;
            this._btnOk.Location = new System.Drawing.Point(329, 221);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 29);
            this._btnOk.TabIndex = 0;
            this._btnOk.TabStop = false;
            this._btnOk.Text = "Ok";
            this._btnOk.UseVisualStyleBackColor = false;
            // 
            // _tbMessage
            // 
            this._tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this._tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._tbMessage.Location = new System.Drawing.Point(12, 12);
            this._tbMessage.Name = "_tbMessage";
            this._tbMessage.Size = new System.Drawing.Size(392, 196);
            this._tbMessage.TabIndex = 4;
            this._tbMessage.Text = "";
            // 
            // ErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 262);
            this.Controls.Add(this._tbMessage);
            this.Controls.Add(this._btnOk);
            this.MinimumSize = new System.Drawing.Size(400, 210);
            this.Name = "ErrorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exception";
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.TlButton _btnOk;
        private System.Windows.Forms.RichTextBox _tbMessage;
    }
}