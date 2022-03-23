namespace TransferLogger.Ui.Forms.Dialogs
{
    partial class ConfirmDialog
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
            this._btnConfirm = new TransferLogger.Ui.Controls.TlButton();
            this._btnAbort = new TransferLogger.Ui.Controls.TlButton();
            this._tbMessage = new TransferLogger.Ui.Controls.TlTextBox();
            this.SuspendLayout();
            // 
            // _btnConfirm
            // 
            this._btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnConfirm.ForeColor = System.Drawing.Color.Black;
            this._btnConfirm.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnConfirm.Location = new System.Drawing.Point(207, 84);
            this._btnConfirm.Name = "_btnConfirm";
            this._btnConfirm.Size = new System.Drawing.Size(75, 29);
            this._btnConfirm.TabIndex = 1;
            this._btnConfirm.TabStop = false;
            this._btnConfirm.Text = "Yes";
            this._btnConfirm.UseVisualStyleBackColor = false;
            // 
            // _btnAbort
            // 
            this._btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAbort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnAbort.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnAbort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnAbort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAbort.ForeColor = System.Drawing.Color.Black;
            this._btnAbort.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnAbort.Location = new System.Drawing.Point(126, 84);
            this._btnAbort.Name = "_btnAbort";
            this._btnAbort.Size = new System.Drawing.Size(75, 29);
            this._btnAbort.TabIndex = 0;
            this._btnAbort.TabStop = false;
            this._btnAbort.Text = "No";
            this._btnAbort.UseVisualStyleBackColor = false;
            // 
            // _tbMessage
            // 
            this._tbMessage.BackColor = System.Drawing.Color.White;
            this._tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tbMessage.BoxWidth = 325;
            this._tbMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbMessage.ForeColor = System.Drawing.Color.Black;
            this._tbMessage.Location = new System.Drawing.Point(29, 26);
            this._tbMessage.Multiline = true;
            this._tbMessage.Name = "_tbMessage";
            this._tbMessage.ReadOnly = true;
            this._tbMessage.Size = new System.Drawing.Size(346, 52);
            this._tbMessage.TabIndex = 3;
            this._tbMessage.TabStop = false;
            this._tbMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfirmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 126);
            this.Controls.Add(this._tbMessage);
            this.Controls.Add(this._btnAbort);
            this.Controls.Add(this._btnConfirm);
            this.MaximumSize = new System.Drawing.Size(420, 165);
            this.MinimumSize = new System.Drawing.Size(420, 165);
            this.Name = "ConfirmDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.TlButton _btnConfirm;
        private Controls.TlButton _btnAbort;
        private Controls.TlTextBox _tbMessage;
    }
}