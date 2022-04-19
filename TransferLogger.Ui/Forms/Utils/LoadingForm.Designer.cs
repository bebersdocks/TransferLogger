namespace TransferLogger.Ui.Forms.Utils
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this._tbMessage = new TransferLogger.Ui.Controls.TlTextBox();
            this.SuspendLayout();
            // 
            // _tbMessage
            // 
            this._tbMessage.BackColor = System.Drawing.Color.White;
            this._tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tbMessage.BoxWidth = 325;
            this._tbMessage.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this._tbMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbMessage.ForeColor = System.Drawing.Color.Black;
            this._tbMessage.Location = new System.Drawing.Point(0, 16);
            this._tbMessage.Multiline = true;
            this._tbMessage.Name = "_tbMessage";
            this._tbMessage.ReadOnly = true;
            this._tbMessage.Size = new System.Drawing.Size(227, 30);
            this._tbMessage.TabIndex = 4;
            this._tbMessage.TabStop = false;
            this._tbMessage.Text = "Exporting...";
            this._tbMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(227, 65);
            this.ControlBox = false;
            this.Controls.Add(this._tbMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TlTextBox _tbMessage;
    }
}