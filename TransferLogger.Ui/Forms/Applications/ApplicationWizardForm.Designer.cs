namespace TransferLogger.Ui.Forms.Applications
{
    partial class ApplicationWizardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationWizardForm));
            this._btnNext = new TransferLogger.Ui.Controls.TlButton();
            this._btnBack = new TransferLogger.Ui.Controls.TlButton();
            this._pnlControl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _btnNext
            // 
            this._btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnNext.BackColor = System.Drawing.Color.White;
            this._btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnNext.ForeColor = System.Drawing.Color.Black;
            this._btnNext.Location = new System.Drawing.Point(812, 500);
            this._btnNext.Name = "_btnNext";
            this._btnNext.Size = new System.Drawing.Size(75, 29);
            this._btnNext.TabIndex = 2;
            this._btnNext.Text = "Next";
            this._btnNext.UseVisualStyleBackColor = false;
            // 
            // _btnBack
            // 
            this._btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnBack.BackColor = System.Drawing.Color.White;
            this._btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBack.ForeColor = System.Drawing.Color.Black;
            this._btnBack.Location = new System.Drawing.Point(731, 500);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new System.Drawing.Size(75, 29);
            this._btnBack.TabIndex = 3;
            this._btnBack.Text = "Back";
            this._btnBack.UseVisualStyleBackColor = false;
            // 
            // _pnlControl
            // 
            this._pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._pnlControl.Location = new System.Drawing.Point(-3, -4);
            this._pnlControl.Name = "_pnlControl";
            this._pnlControl.Size = new System.Drawing.Size(905, 491);
            this._pnlControl.TabIndex = 1;
            this._pnlControl.TabStop = true;
            // 
            // ApplicationWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 541);
            this.Controls.Add(this._pnlControl);
            this.Controls.Add(this._btnBack);
            this.Controls.Add(this._btnNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(715, 420);
            this.Name = "ApplicationWizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Wizard";
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.TlButton _btnNext;
        private Controls.TlButton _btnBack;
        private System.Windows.Forms.Panel _pnlControl;
    }
}