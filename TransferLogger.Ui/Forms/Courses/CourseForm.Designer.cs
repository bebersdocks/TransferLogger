using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Courses
{
    partial class CourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            this._lName = new System.Windows.Forms.Label();
            this._tbName = new TransferLogger.Ui.Controls.TlTextBox();
            this._tbDescription = new TransferLogger.Ui.Controls.TlTextBox();
            this._lDescription = new System.Windows.Forms.Label();
            this._cbPrograms = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lProgram = new System.Windows.Forms.Label();
            this._btnOk = new TransferLogger.Ui.Controls.TlButton();
            this._btnSelectProgram = new TransferLogger.Ui.Controls.TlButton();
            this._btnCancel = new TransferLogger.Ui.Controls.TlButton();
            this._btnSelectOrganization = new TransferLogger.Ui.Controls.TlButton();
            this._cbOrganizations = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lOrganization = new System.Windows.Forms.Label();
            this._numericWeeklyHours = new System.Windows.Forms.NumericUpDown();
            this._lWeeklyHours = new System.Windows.Forms.Label();
            this._numericCredits = new System.Windows.Forms.NumericUpDown();
            this._lCredtis = new System.Windows.Forms.Label();
            this._tbCode = new TransferLogger.Ui.Controls.TlTextBox();
            this._lCode = new System.Windows.Forms.Label();
            this._lCycle = new System.Windows.Forms.Label();
            this._cbCycles = new TransferLogger.Ui.Controls.TlDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this._numericWeeklyHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // _lName
            // 
            this._lName.AutoSize = true;
            this._lName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lName.Location = new System.Drawing.Point(64, 62);
            this._lName.Name = "_lName";
            this._lName.Size = new System.Drawing.Size(46, 17);
            this._lName.TabIndex = 0;
            this._lName.Text = "Name:";
            // 
            // _tbName
            // 
            this._tbName.BackColor = System.Drawing.Color.GhostWhite;
            this._tbName.BoxWidth = 325;
            this._tbName.ForeColor = System.Drawing.Color.Black;
            this._tbName.Location = new System.Drawing.Point(116, 59);
            this._tbName.Name = "_tbName";
            this._tbName.Size = new System.Drawing.Size(325, 25);
            this._tbName.TabIndex = 1;
            // 
            // _tbDescription
            // 
            this._tbDescription.BackColor = System.Drawing.Color.GhostWhite;
            this._tbDescription.BoxWidth = 325;
            this._tbDescription.ForeColor = System.Drawing.Color.Black;
            this._tbDescription.Location = new System.Drawing.Point(116, 287);
            this._tbDescription.Multiline = true;
            this._tbDescription.Name = "_tbDescription";
            this._tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._tbDescription.Size = new System.Drawing.Size(326, 81);
            this._tbDescription.TabIndex = 9;
            // 
            // _lDescription
            // 
            this._lDescription.AutoSize = true;
            this._lDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lDescription.Location = new System.Drawing.Point(33, 290);
            this._lDescription.Name = "_lDescription";
            this._lDescription.Size = new System.Drawing.Size(77, 17);
            this._lDescription.TabIndex = 18;
            this._lDescription.Text = "Description:";
            // 
            // _cbPrograms
            // 
            this._cbPrograms.BackColor = System.Drawing.Color.GhostWhite;
            this._cbPrograms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbPrograms.FormattingEnabled = true;
            this._cbPrograms.Location = new System.Drawing.Point(116, 173);
            this._cbPrograms.Name = "_cbPrograms";
            this._cbPrograms.Size = new System.Drawing.Size(292, 25);
            this._cbPrograms.TabIndex = 5;
            // 
            // _lProgram
            // 
            this._lProgram.AutoSize = true;
            this._lProgram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lProgram.Location = new System.Drawing.Point(48, 176);
            this._lProgram.Name = "_lProgram";
            this._lProgram.Size = new System.Drawing.Size(62, 17);
            this._lProgram.TabIndex = 20;
            this._lProgram.Text = "Program:";
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOk.AutoSize = true;
            this._btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnOk.ForeColor = System.Drawing.Color.Black;
            this._btnOk.Location = new System.Drawing.Point(367, 400);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 29);
            this._btnOk.TabIndex = 11;
            this._btnOk.TabStop = false;
            this._btnOk.Text = "Ok";
            this._btnOk.UseVisualStyleBackColor = false;
            // 
            // _btnSelectProgram
            // 
            this._btnSelectProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectProgram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnSelectProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectProgram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnSelectProgram.ForeColor = System.Drawing.Color.Black;
            this._btnSelectProgram.Location = new System.Drawing.Point(414, 173);
            this._btnSelectProgram.Name = "_btnSelectProgram";
            this._btnSelectProgram.Size = new System.Drawing.Size(28, 25);
            this._btnSelectProgram.TabIndex = 6;
            this._btnSelectProgram.TabStop = false;
            this._btnSelectProgram.Text = "...";
            this._btnSelectProgram.UseVisualStyleBackColor = false;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.AutoSize = true;
            this._btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnCancel.ForeColor = System.Drawing.Color.Black;
            this._btnCancel.Location = new System.Drawing.Point(286, 400);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 29);
            this._btnCancel.TabIndex = 10;
            this._btnCancel.TabStop = false;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            // 
            // _btnSelectOrganization
            // 
            this._btnSelectOrganization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectOrganization.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnSelectOrganization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectOrganization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectOrganization.ForeColor = System.Drawing.Color.Black;
            this._btnSelectOrganization.Location = new System.Drawing.Point(413, 97);
            this._btnSelectOrganization.Name = "_btnSelectOrganization";
            this._btnSelectOrganization.Size = new System.Drawing.Size(28, 25);
            this._btnSelectOrganization.TabIndex = 3;
            this._btnSelectOrganization.TabStop = false;
            this._btnSelectOrganization.Text = "...";
            this._btnSelectOrganization.UseVisualStyleBackColor = false;
            // 
            // _cbOrganizations
            // 
            this._cbOrganizations.BackColor = System.Drawing.Color.GhostWhite;
            this._cbOrganizations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbOrganizations.FormattingEnabled = true;
            this._cbOrganizations.Location = new System.Drawing.Point(116, 97);
            this._cbOrganizations.Name = "_cbOrganizations";
            this._cbOrganizations.Size = new System.Drawing.Size(292, 25);
            this._cbOrganizations.TabIndex = 2;
            // 
            // _lOrganization
            // 
            this._lOrganization.AutoSize = true;
            this._lOrganization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganization.Location = new System.Drawing.Point(24, 100);
            this._lOrganization.Name = "_lOrganization";
            this._lOrganization.Size = new System.Drawing.Size(86, 17);
            this._lOrganization.TabIndex = 26;
            this._lOrganization.Text = "Organization:";
            // 
            // _numericWeeklyHours
            // 
            this._numericWeeklyHours.BackColor = System.Drawing.Color.GhostWhite;
            this._numericWeeklyHours.Location = new System.Drawing.Point(117, 249);
            this._numericWeeklyHours.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this._numericWeeklyHours.Name = "_numericWeeklyHours";
            this._numericWeeklyHours.Size = new System.Drawing.Size(325, 25);
            this._numericWeeklyHours.TabIndex = 8;
            this._numericWeeklyHours.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // _lWeeklyHours
            // 
            this._lWeeklyHours.AutoSize = true;
            this._lWeeklyHours.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lWeeklyHours.Location = new System.Drawing.Point(21, 251);
            this._lWeeklyHours.Name = "_lWeeklyHours";
            this._lWeeklyHours.Size = new System.Drawing.Size(90, 17);
            this._lWeeklyHours.TabIndex = 28;
            this._lWeeklyHours.Text = "Weekly Hours:";
            // 
            // _numericCredits
            // 
            this._numericCredits.BackColor = System.Drawing.Color.GhostWhite;
            this._numericCredits.Location = new System.Drawing.Point(116, 211);
            this._numericCredits.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this._numericCredits.Name = "_numericCredits";
            this._numericCredits.Size = new System.Drawing.Size(325, 25);
            this._numericCredits.TabIndex = 7;
            this._numericCredits.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // _lCredtis
            // 
            this._lCredtis.AutoSize = true;
            this._lCredtis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCredtis.Location = new System.Drawing.Point(58, 213);
            this._lCredtis.Name = "_lCredtis";
            this._lCredtis.Size = new System.Drawing.Size(52, 17);
            this._lCredtis.TabIndex = 30;
            this._lCredtis.Text = "Credits:";
            // 
            // _tbCode
            // 
            this._tbCode.BackColor = System.Drawing.Color.GhostWhite;
            this._tbCode.BoxWidth = 325;
            this._tbCode.ForeColor = System.Drawing.Color.Black;
            this._tbCode.Location = new System.Drawing.Point(116, 21);
            this._tbCode.Name = "_tbCode";
            this._tbCode.Size = new System.Drawing.Size(325, 25);
            this._tbCode.TabIndex = 0;
            // 
            // _lCode
            // 
            this._lCode.AutoSize = true;
            this._lCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCode.Location = new System.Drawing.Point(68, 24);
            this._lCode.Name = "_lCode";
            this._lCode.Size = new System.Drawing.Size(42, 17);
            this._lCode.TabIndex = 33;
            this._lCode.Text = "Code:";
            // 
            // _lCycle
            // 
            this._lCycle.AutoSize = true;
            this._lCycle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCycle.Location = new System.Drawing.Point(69, 138);
            this._lCycle.Name = "_lCycle";
            this._lCycle.Size = new System.Drawing.Size(41, 17);
            this._lCycle.TabIndex = 36;
            this._lCycle.Text = "Cycle:";
            // 
            // _cbCycles
            // 
            this._cbCycles.BackColor = System.Drawing.Color.GhostWhite;
            this._cbCycles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCycles.FormattingEnabled = true;
            this._cbCycles.Location = new System.Drawing.Point(116, 135);
            this._cbCycles.Name = "_cbCycles";
            this._cbCycles.Size = new System.Drawing.Size(325, 25);
            this._cbCycles.TabIndex = 4;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 441);
            this.Controls.Add(this._lCycle);
            this.Controls.Add(this._cbCycles);
            this.Controls.Add(this._lCode);
            this.Controls.Add(this._tbCode);
            this.Controls.Add(this._numericCredits);
            this.Controls.Add(this._lCredtis);
            this.Controls.Add(this._numericWeeklyHours);
            this.Controls.Add(this._lWeeklyHours);
            this.Controls.Add(this._btnSelectOrganization);
            this.Controls.Add(this._cbOrganizations);
            this.Controls.Add(this._lOrganization);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSelectProgram);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._lProgram);
            this.Controls.Add(this._cbPrograms);
            this.Controls.Add(this._lDescription);
            this.Controls.Add(this._tbDescription);
            this.Controls.Add(this._tbName);
            this.Controls.Add(this._lName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 480);
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Course";
            ((System.ComponentModel.ISupportInitialize)(this._numericWeeklyHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lName;
        private Controls.TlTextBox _tbName;
        private Controls.TlTextBox _tbDescription;
        private Label _lDescription;
        private Controls.TlDropDownList _cbPrograms;
        private Label _lProgram;
        private Controls.TlButton _btnOk;
        private Controls.TlButton _btnSelectProgram;
        private Controls.TlButton _btnCancel;
        private Controls.TlButton _btnSelectOrganization;
        private Controls.TlDropDownList _cbOrganizations;
        private Label _lOrganization;
        private NumericUpDown _numericWeeklyHours;
        private Label _lWeeklyHours;
        private NumericUpDown _numericCredits;
        private Label _lCredtis;
        private Controls.TlTextBox _tbCode;
        private Label _lCode;
        private Label _lCycle;
        private Controls.TlDropDownList _cbCycles;
    }
}