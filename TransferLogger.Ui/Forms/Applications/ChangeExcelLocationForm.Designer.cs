﻿namespace TransferLogger.Ui.Forms.Applications
{
    partial class ChangeExcelLocationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeExcelLocationForm));
            this._btnBrowse = new TransferLogger.Ui.Controls.TlButton();
            this._lExcelLocation = new System.Windows.Forms.Label();
            this._tbExcelLocation = new TransferLogger.Ui.Controls.TlTextBox();
            this._btnOk = new TransferLogger.Ui.Controls.TlButton();
            this._btnCancel = new TransferLogger.Ui.Controls.TlButton();
            this.SuspendLayout();
            // 
            // _btnBrowse
            // 
            this._btnBrowse.BackColor = System.Drawing.Color.White;
            this._btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBrowse.ForeColor = System.Drawing.Color.Black;
            this._btnBrowse.Location = new System.Drawing.Point(506, 26);
            this._btnBrowse.Name = "_btnBrowse";
            this._btnBrowse.Size = new System.Drawing.Size(91, 25);
            this._btnBrowse.TabIndex = 1;
            this._btnBrowse.Text = "Browse";
            this._btnBrowse.UseVisualStyleBackColor = false;
            // 
            // _lExcelLocation
            // 
            this._lExcelLocation.AutoSize = true;
            this._lExcelLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lExcelLocation.Location = new System.Drawing.Point(18, 29);
            this._lExcelLocation.Name = "_lExcelLocation";
            this._lExcelLocation.Size = new System.Drawing.Size(93, 17);
            this._lExcelLocation.TabIndex = 72;
            this._lExcelLocation.Text = "Excel Location:";
            // 
            // _tbExcelLocation
            // 
            this._tbExcelLocation.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbExcelLocation.BoxWidth = 325;
            this._tbExcelLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbExcelLocation.ForeColor = System.Drawing.Color.Black;
            this._tbExcelLocation.Location = new System.Drawing.Point(117, 26);
            this._tbExcelLocation.Name = "_tbExcelLocation";
            this._tbExcelLocation.ReadOnly = true;
            this._tbExcelLocation.Size = new System.Drawing.Size(383, 25);
            this._tbExcelLocation.TabIndex = 73;
            this._tbExcelLocation.TabStop = false;
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOk.BackColor = System.Drawing.Color.White;
            this._btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOk.ForeColor = System.Drawing.Color.Black;
            this._btnOk.Location = new System.Drawing.Point(522, 86);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 29);
            this._btnOk.TabIndex = 2;
            this._btnOk.Text = "Ok";
            this._btnOk.UseVisualStyleBackColor = false;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.BackColor = System.Drawing.Color.White;
            this._btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCancel.ForeColor = System.Drawing.Color.Black;
            this._btnCancel.Location = new System.Drawing.Point(441, 86);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 29);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            // 
            // ChangeExcelLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 127);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._btnBrowse);
            this.Controls.Add(this._lExcelLocation);
            this.Controls.Add(this._tbExcelLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(638, 166);
            this.Name = "ChangeExcelLocationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Excel Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TlButton _btnBrowse;
        private System.Windows.Forms.Label _lExcelLocation;
        private Controls.TlTextBox _tbExcelLocation;
        private Controls.TlButton _btnOk;
        private Controls.TlButton _btnCancel;
    }
}