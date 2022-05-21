using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Programs
{
    partial class ProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramForm));
            this._lName = new System.Windows.Forms.Label();
            this._lYear = new System.Windows.Forms.Label();
            this._lOrganization = new System.Windows.Forms.Label();
            this._cbOrganizations = new TransferLogger.Ui.Controls.TlDropDownList();
            this._tbName = new TransferLogger.Ui.Controls.TlTextBox();
            this._cbCycle = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lCycle = new System.Windows.Forms.Label();
            this._numericYear = new System.Windows.Forms.NumericUpDown();
            this._btnOk = new TransferLogger.Ui.Controls.TlButton();
            this._btnCancel = new TransferLogger.Ui.Controls.TlButton();
            this._btnSelectOrganization = new TransferLogger.Ui.Controls.TlButton();
            ((System.ComponentModel.ISupportInitialize)(this._numericYear)).BeginInit();
            this.SuspendLayout();
            // 
            // _lName
            // 
            this._lName.AutoSize = true;
            this._lName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lName.Location = new System.Drawing.Point(52, 24);
            this._lName.Name = "_lName";
            this._lName.Size = new System.Drawing.Size(46, 17);
            this._lName.TabIndex = 0;
            this._lName.Text = "Name:";
            // 
            // _lYear
            // 
            this._lYear.AutoSize = true;
            this._lYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lYear.Location = new System.Drawing.Point(62, 125);
            this._lYear.Name = "_lYear";
            this._lYear.Size = new System.Drawing.Size(36, 17);
            this._lYear.TabIndex = 2;
            this._lYear.Text = "Year:";
            // 
            // _lOrganization
            // 
            this._lOrganization.AutoSize = true;
            this._lOrganization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganization.Location = new System.Drawing.Point(12, 58);
            this._lOrganization.Name = "_lOrganization";
            this._lOrganization.Size = new System.Drawing.Size(86, 17);
            this._lOrganization.TabIndex = 13;
            this._lOrganization.Text = "Organization:";
            // 
            // _cbOrganizations
            // 
            this._cbOrganizations.BackColor = System.Drawing.Color.GhostWhite;
            this._cbOrganizations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbOrganizations.FormattingEnabled = true;
            this._cbOrganizations.Location = new System.Drawing.Point(104, 55);
            this._cbOrganizations.Name = "_cbOrganizations";
            this._cbOrganizations.Size = new System.Drawing.Size(291, 25);
            this._cbOrganizations.TabIndex = 2;
            // 
            // _tbName
            // 
            this._tbName.BackColor = System.Drawing.Color.GhostWhite;
            this._tbName.BoxWidth = 325;
            this._tbName.ForeColor = System.Drawing.Color.Black;
            this._tbName.Location = new System.Drawing.Point(104, 21);
            this._tbName.Name = "_tbName";
            this._tbName.Size = new System.Drawing.Size(325, 25);
            this._tbName.TabIndex = 1;
            // 
            // _cbCycle
            // 
            this._cbCycle.BackColor = System.Drawing.Color.GhostWhite;
            this._cbCycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCycle.FormattingEnabled = true;
            this._cbCycle.Location = new System.Drawing.Point(104, 89);
            this._cbCycle.Name = "_cbCycle";
            this._cbCycle.Size = new System.Drawing.Size(325, 25);
            this._cbCycle.TabIndex = 4;
            // 
            // _lCycle
            // 
            this._lCycle.AutoSize = true;
            this._lCycle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCycle.Location = new System.Drawing.Point(57, 92);
            this._lCycle.Name = "_lCycle";
            this._lCycle.Size = new System.Drawing.Size(41, 17);
            this._lCycle.TabIndex = 20;
            this._lCycle.Text = "Cycle:";
            // 
            // _numericYear
            // 
            this._numericYear.BackColor = System.Drawing.Color.GhostWhite;
            this._numericYear.Location = new System.Drawing.Point(104, 123);
            this._numericYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this._numericYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this._numericYear.Name = "_numericYear";
            this._numericYear.Size = new System.Drawing.Size(325, 25);
            this._numericYear.TabIndex = 5;
            this._numericYear.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOk.AutoSize = true;
            this._btnOk.BackColor = System.Drawing.Color.White;
            this._btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOk.ForeColor = System.Drawing.Color.Black;
            this._btnOk.Location = new System.Drawing.Point(354, 175);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 29);
            this._btnOk.TabIndex = 6;
            this._btnOk.Text = "Ok";
            this._btnOk.UseVisualStyleBackColor = false;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.AutoSize = true;
            this._btnCancel.BackColor = System.Drawing.Color.White;
            this._btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCancel.ForeColor = System.Drawing.Color.Black;
            this._btnCancel.Location = new System.Drawing.Point(273, 175);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 29);
            this._btnCancel.TabIndex = 7;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            // 
            // _btnSelectOrganization
            // 
            this._btnSelectOrganization.BackColor = System.Drawing.Color.White;
            this._btnSelectOrganization.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnSelectOrganization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectOrganization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectOrganization.ForeColor = System.Drawing.Color.Black;
            this._btnSelectOrganization.Location = new System.Drawing.Point(401, 55);
            this._btnSelectOrganization.Name = "_btnSelectOrganization";
            this._btnSelectOrganization.Size = new System.Drawing.Size(28, 25);
            this._btnSelectOrganization.TabIndex = 3;
            this._btnSelectOrganization.Text = "...";
            this._btnSelectOrganization.UseVisualStyleBackColor = false;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 216);
            this.Controls.Add(this._btnSelectOrganization);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._numericYear);
            this.Controls.Add(this._lCycle);
            this.Controls.Add(this._cbCycle);
            this.Controls.Add(this._tbName);
            this.Controls.Add(this._cbOrganizations);
            this.Controls.Add(this._lOrganization);
            this.Controls.Add(this._lYear);
            this.Controls.Add(this._lName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(475, 255);
            this.Name = "ProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Program";
            ((System.ComponentModel.ISupportInitialize)(this._numericYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lName;
        private Label _lYear;
        private Label _lOrganization;
        private Controls.TlDropDownList _cbOrganizations;
        private Controls.TlTextBox _tbName;
        private Controls.TlDropDownList _cbCycle;
        private Label _lCycle;
        private NumericUpDown _numericYear;
        private Controls.TlButton _btnOk;
        private Controls.TlButton _btnCancel;
        private Controls.TlButton _btnSelectOrganization;
    }
}