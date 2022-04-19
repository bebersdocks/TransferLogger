namespace TransferLogger.Ui.Forms.Dialogs
{
    partial class ConfirmBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmBox));
            this._tbMessage = new TransferLogger.Ui.Controls.TlTextBox();
            this._btnConfirm = new TransferLogger.Ui.Controls.TlButton();
            this._btnAbort = new TransferLogger.Ui.Controls.TlButton();
            this.SuspendLayout();
            // 
            // _tbMessage
            // 
            this._tbMessage.BackColor = System.Drawing.Color.White;
            this._tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tbMessage.BoxWidth = 325;
            this._tbMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbMessage.ForeColor = System.Drawing.Color.Black;
            this._tbMessage.Location = new System.Drawing.Point(12, 29);
            this._tbMessage.Multiline = true;
            this._tbMessage.Name = "_tbMessage";
            this._tbMessage.ReadOnly = true;
            this._tbMessage.Size = new System.Drawing.Size(380, 45);
            this._tbMessage.TabIndex = 5;
            this._tbMessage.TabStop = false;
            this._tbMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _btnConfirm
            // 
            this._btnConfirm.BackColor = System.Drawing.Color.White;
            this._btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnConfirm.ForeColor = System.Drawing.Color.Black;
            this._btnConfirm.Location = new System.Drawing.Point(123, 80);
            this._btnConfirm.Name = "_btnConfirm";
            this._btnConfirm.Size = new System.Drawing.Size(75, 29);
            this._btnConfirm.TabIndex = 4;
            this._btnConfirm.TabStop = false;
            this._btnConfirm.Text = "Yes";
            this._btnConfirm.UseVisualStyleBackColor = false;
            // 
            // _btnAbort
            // 
            this._btnAbort.BackColor = System.Drawing.Color.White;
            this._btnAbort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnAbort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnAbort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAbort.ForeColor = System.Drawing.Color.Black;
            this._btnAbort.Location = new System.Drawing.Point(204, 80);
            this._btnAbort.Name = "_btnAbort";
            this._btnAbort.Size = new System.Drawing.Size(75, 29);
            this._btnAbort.TabIndex = 6;
            this._btnAbort.TabStop = false;
            this._btnAbort.Text = "No";
            this._btnAbort.UseVisualStyleBackColor = false;
            // 
            // ConfirmBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 126);
            this.ControlBox = false;
            this.Controls.Add(this._btnAbort);
            this.Controls.Add(this._tbMessage);
            this.Controls.Add(this._btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 165);
            this.MinimumSize = new System.Drawing.Size(420, 165);
            this.Name = "ConfirmBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TlTextBox _tbMessage;
        private Controls.TlButton _btnConfirm;
        private Controls.TlButton _btnAbort;
    }
}