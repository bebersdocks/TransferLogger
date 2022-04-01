namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    partial class StudentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._pnlNewStudent = new System.Windows.Forms.Panel();
            this._btnSelectStudent = new TransferLogger.Ui.Controls.TlButton();
            this._cbStudents = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lStudent = new System.Windows.Forms.Label();
            this._rbNewStudent = new System.Windows.Forms.RadioButton();
            this._rbExistingStudent = new System.Windows.Forms.RadioButton();
            this._lInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _pnlNewStudent
            // 
            this._pnlNewStudent.Enabled = false;
            this._pnlNewStudent.Location = new System.Drawing.Point(128, 86);
            this._pnlNewStudent.Name = "_pnlNewStudent";
            this._pnlNewStudent.Size = new System.Drawing.Size(441, 287);
            this._pnlNewStudent.TabIndex = 32;
            // 
            // _btnSelectStudent
            // 
            this._btnSelectStudent.AutoSize = true;
            this._btnSelectStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectStudent.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnSelectStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectStudent.ForeColor = System.Drawing.Color.Black;
            this._btnSelectStudent.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectStudent.Location = new System.Drawing.Point(526, 60);
            this._btnSelectStudent.MaximumSize = new System.Drawing.Size(0, 23);
            this._btnSelectStudent.MinimumSize = new System.Drawing.Size(0, 23);
            this._btnSelectStudent.Name = "_btnSelectStudent";
            this._btnSelectStudent.Size = new System.Drawing.Size(28, 23);
            this._btnSelectStudent.TabIndex = 34;
            this._btnSelectStudent.TabStop = false;
            this._btnSelectStudent.Text = "...";
            this._btnSelectStudent.UseVisualStyleBackColor = false;
            // 
            // _cbStudents
            // 
            this._cbStudents.BackColor = System.Drawing.Color.GhostWhite;
            this._cbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbStudents.FormattingEnabled = true;
            this._cbStudents.Location = new System.Drawing.Point(229, 60);
            this._cbStudents.Name = "_cbStudents";
            this._cbStudents.Size = new System.Drawing.Size(291, 23);
            this._cbStudents.TabIndex = 33;
            // 
            // _lStudent
            // 
            this._lStudent.AutoSize = true;
            this._lStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lStudent.Location = new System.Drawing.Point(168, 61);
            this._lStudent.Name = "_lStudent";
            this._lStudent.Size = new System.Drawing.Size(55, 17);
            this._lStudent.TabIndex = 35;
            this._lStudent.Text = "Student:";
            // 
            // _rbNewStudent
            // 
            this._rbNewStudent.AutoSize = true;
            this._rbNewStudent.BackColor = System.Drawing.Color.White;
            this._rbNewStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this._rbNewStudent.Location = new System.Drawing.Point(27, 86);
            this._rbNewStudent.Name = "_rbNewStudent";
            this._rbNewStudent.Size = new System.Drawing.Size(93, 19);
            this._rbNewStudent.TabIndex = 36;
            this._rbNewStudent.Text = "New Student";
            this._rbNewStudent.UseVisualStyleBackColor = false;
            // 
            // _rbExistingStudent
            // 
            this._rbExistingStudent.AutoSize = true;
            this._rbExistingStudent.Checked = true;
            this._rbExistingStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this._rbExistingStudent.Location = new System.Drawing.Point(27, 61);
            this._rbExistingStudent.Name = "_rbExistingStudent";
            this._rbExistingStudent.Size = new System.Drawing.Size(110, 19);
            this._rbExistingStudent.TabIndex = 37;
            this._rbExistingStudent.TabStop = true;
            this._rbExistingStudent.Text = "Existing Student";
            this._rbExistingStudent.UseVisualStyleBackColor = true;
            // 
            // _lInstructions
            // 
            this._lInstructions.AutoSize = true;
            this._lInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lInstructions.ForeColor = System.Drawing.Color.Black;
            this._lInstructions.Location = new System.Drawing.Point(27, 20);
            this._lInstructions.Name = "_lInstructions";
            this._lInstructions.Size = new System.Drawing.Size(324, 17);
            this._lInstructions.TabIndex = 38;
            this._lInstructions.Text = "Select existing student from the list or create new one.";
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this._lInstructions);
            this.Controls.Add(this._rbExistingStudent);
            this.Controls.Add(this._rbNewStudent);
            this.Controls.Add(this._btnSelectStudent);
            this.Controls.Add(this._cbStudents);
            this.Controls.Add(this._lStudent);
            this.Controls.Add(this._pnlNewStudent);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(569, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _pnlNewStudent;
        private TlButton _btnSelectStudent;
        private TlDropDownList _cbStudents;
        private System.Windows.Forms.Label _lStudent;
        private System.Windows.Forms.RadioButton _rbNewStudent;
        private System.Windows.Forms.RadioButton _rbExistingStudent;
        private System.Windows.Forms.Label _lInstructions;
    }
}
