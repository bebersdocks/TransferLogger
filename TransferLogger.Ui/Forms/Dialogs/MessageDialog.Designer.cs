namespace TransferLogger.Ui.Forms.Dialogs
{
    partial class MessageDialog
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
            this._tbMessage = new TransferLogger.Ui.Controls.TlTextBox();
            this.SuspendLayout();
            // 
            // _btnOk
            // 
            this._btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOk.ForeColor = System.Drawing.Color.Black;
            this._btnOk.Location = new System.Drawing.Point(132, 70);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 29);
            this._btnOk.TabIndex = 0;
            this._btnOk.TabStop = false;
            this._btnOk.Text = "Ok";
            this._btnOk.UseVisualStyleBackColor = false;
            // 
            // _tbMessage
            // 
            this._tbMessage.BackColor = System.Drawing.Color.White;
            this._tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tbMessage.BoxWidth = 325;
            this._tbMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbMessage.ForeColor = System.Drawing.Color.Black;
            this._tbMessage.Location = new System.Drawing.Point(12, 26);
            this._tbMessage.Multiline = true;
            this._tbMessage.Name = "_tbMessage";
            this._tbMessage.ReadOnly = true;
            this._tbMessage.Size = new System.Drawing.Size(310, 40);
            this._tbMessage.TabIndex = 3;
            this._tbMessage.TabStop = false;
            this._tbMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this._tbMessage);
            this.Controls.Add(this._btnOk);
            this.MaximumSize = new System.Drawing.Size(350, 150);
            this.MinimumSize = new System.Drawing.Size(350, 150);
            this.Name = "MessageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.TlButton _btnOk;
        private Controls.TlTextBox _tbMessage;
    }
}