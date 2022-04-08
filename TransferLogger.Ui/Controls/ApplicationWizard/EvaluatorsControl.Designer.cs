namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    partial class EvaluatorsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._splitContainer = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._pnlEvaluator = new System.Windows.Forms.Panel();
            this._btnSelectSuggestedCourse = new TransferLogger.Ui.Controls.TlButton();
            this._cbSuggestedCourses = new TransferLogger.Ui.Controls.TlDropDownList();
            this._cbSendEmailNotification = new System.Windows.Forms.CheckBox();
            this._lEvaluator = new System.Windows.Forms.Label();
            this._btnSelectEvaluator = new TransferLogger.Ui.Controls.TlButton();
            this._lInstructionsEvaluator = new System.Windows.Forms.Label();
            this._lSuggested = new System.Windows.Forms.Label();
            this._cbEvaluators = new TransferLogger.Ui.Controls.TlDropDownList();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendEmailNotification = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SuggestedCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lCourses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._pnlEvaluator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _splitContainer
            // 
            this._splitContainer.BackColor = System.Drawing.Color.White;
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            this._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel1.Controls.Add(this._pnlEvaluator);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel2.Controls.Add(this._grid);
            this._splitContainer.Panel2.Controls.Add(this._lCourses);
            this._splitContainer.Size = new System.Drawing.Size(824, 525);
            this._splitContainer.SplitterDistance = 121;
            this._splitContainer.TabIndex = 2;
            // 
            // _pnlEvaluator
            // 
            this._pnlEvaluator.Controls.Add(this._btnSelectSuggestedCourse);
            this._pnlEvaluator.Controls.Add(this._cbSuggestedCourses);
            this._pnlEvaluator.Controls.Add(this._cbSendEmailNotification);
            this._pnlEvaluator.Controls.Add(this._lEvaluator);
            this._pnlEvaluator.Controls.Add(this._btnSelectEvaluator);
            this._pnlEvaluator.Controls.Add(this._lInstructionsEvaluator);
            this._pnlEvaluator.Controls.Add(this._lSuggested);
            this._pnlEvaluator.Controls.Add(this._cbEvaluators);
            this._pnlEvaluator.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlEvaluator.Location = new System.Drawing.Point(0, 0);
            this._pnlEvaluator.Name = "_pnlEvaluator";
            this._pnlEvaluator.Size = new System.Drawing.Size(824, 121);
            this._pnlEvaluator.TabIndex = 48;
            // 
            // _btnSelectSuggestedCourse
            // 
            this._btnSelectSuggestedCourse.AutoSize = true;
            this._btnSelectSuggestedCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectSuggestedCourse.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnSelectSuggestedCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectSuggestedCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectSuggestedCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectSuggestedCourse.ForeColor = System.Drawing.Color.Black;
            this._btnSelectSuggestedCourse.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectSuggestedCourse.Location = new System.Drawing.Point(443, 82);
            this._btnSelectSuggestedCourse.MaximumSize = new System.Drawing.Size(0, 23);
            this._btnSelectSuggestedCourse.MinimumSize = new System.Drawing.Size(0, 23);
            this._btnSelectSuggestedCourse.Name = "_btnSelectSuggestedCourse";
            this._btnSelectSuggestedCourse.Size = new System.Drawing.Size(28, 23);
            this._btnSelectSuggestedCourse.TabIndex = 55;
            this._btnSelectSuggestedCourse.TabStop = false;
            this._btnSelectSuggestedCourse.Text = "...";
            this._btnSelectSuggestedCourse.UseVisualStyleBackColor = false;
            // 
            // _cbSuggestedCourses
            // 
            this._cbSuggestedCourses.BackColor = System.Drawing.Color.GhostWhite;
            this._cbSuggestedCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSuggestedCourses.FormattingEnabled = true;
            this._cbSuggestedCourses.Location = new System.Drawing.Point(146, 82);
            this._cbSuggestedCourses.Name = "_cbSuggestedCourses";
            this._cbSuggestedCourses.Size = new System.Drawing.Size(291, 23);
            this._cbSuggestedCourses.TabIndex = 54;
            // 
            // _cbSendEmailNotification
            // 
            this._cbSendEmailNotification.AutoSize = true;
            this._cbSendEmailNotification.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbSendEmailNotification.Location = new System.Drawing.Point(486, 53);
            this._cbSendEmailNotification.Name = "_cbSendEmailNotification";
            this._cbSendEmailNotification.Size = new System.Drawing.Size(159, 21);
            this._cbSendEmailNotification.TabIndex = 52;
            this._cbSendEmailNotification.Text = "Send email notification";
            this._cbSendEmailNotification.UseVisualStyleBackColor = true;
            // 
            // _lEvaluator
            // 
            this._lEvaluator.AutoSize = true;
            this._lEvaluator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEvaluator.Location = new System.Drawing.Point(75, 51);
            this._lEvaluator.Name = "_lEvaluator";
            this._lEvaluator.Size = new System.Drawing.Size(65, 17);
            this._lEvaluator.TabIndex = 48;
            this._lEvaluator.Text = "Evaluator:";
            // 
            // _btnSelectEvaluator
            // 
            this._btnSelectEvaluator.AutoSize = true;
            this._btnSelectEvaluator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectEvaluator.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnSelectEvaluator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectEvaluator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectEvaluator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectEvaluator.ForeColor = System.Drawing.Color.Black;
            this._btnSelectEvaluator.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectEvaluator.Location = new System.Drawing.Point(443, 51);
            this._btnSelectEvaluator.MaximumSize = new System.Drawing.Size(0, 23);
            this._btnSelectEvaluator.MinimumSize = new System.Drawing.Size(0, 23);
            this._btnSelectEvaluator.Name = "_btnSelectEvaluator";
            this._btnSelectEvaluator.Size = new System.Drawing.Size(28, 23);
            this._btnSelectEvaluator.TabIndex = 50;
            this._btnSelectEvaluator.TabStop = false;
            this._btnSelectEvaluator.Text = "...";
            this._btnSelectEvaluator.UseVisualStyleBackColor = false;
            // 
            // _lInstructionsEvaluator
            // 
            this._lInstructionsEvaluator.AutoSize = true;
            this._lInstructionsEvaluator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lInstructionsEvaluator.ForeColor = System.Drawing.Color.Black;
            this._lInstructionsEvaluator.Location = new System.Drawing.Point(58, 14);
            this._lInstructionsEvaluator.Name = "_lInstructionsEvaluator";
            this._lInstructionsEvaluator.Size = new System.Drawing.Size(391, 17);
            this._lInstructionsEvaluator.TabIndex = 51;
            this._lInstructionsEvaluator.Text = "Assign course tranfer evaluator and set suggested course (if any).";
            // 
            // _lSuggested
            // 
            this._lSuggested.AutoSize = true;
            this._lSuggested.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lSuggested.Location = new System.Drawing.Point(22, 84);
            this._lSuggested.Name = "_lSuggested";
            this._lSuggested.Size = new System.Drawing.Size(118, 17);
            this._lSuggested.TabIndex = 53;
            this._lSuggested.Text = "Suggested Course:";
            // 
            // _cbEvaluators
            // 
            this._cbEvaluators.BackColor = System.Drawing.Color.GhostWhite;
            this._cbEvaluators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbEvaluators.FormattingEnabled = true;
            this._cbEvaluators.Location = new System.Drawing.Point(146, 50);
            this._cbEvaluators.Name = "_cbEvaluators";
            this._cbEvaluators.Size = new System.Drawing.Size(291, 23);
            this._cbEvaluators.TabIndex = 49;
            // 
            // _grid
            // 
            this._grid.AllowUserToAddRows = false;
            this._grid.AllowUserToDeleteRows = false;
            this._grid.AllowUserToOrderColumns = true;
            this._grid.AllowUserToResizeRows = false;
            this._grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._grid.BackgroundColor = System.Drawing.Color.White;
            this._grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Course,
            this.Evaluator,
            this.SendEmailNotification,
            this.SuggestedCourse});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.DefaultCellStyle = dataGridViewCellStyle2;
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.EnableHeadersVisualStyles = false;
            this._grid.Location = new System.Drawing.Point(0, 21);
            this._grid.MultiSelect = false;
            this._grid.Name = "_grid";
            this._grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._grid.RowHeadersVisible = false;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(824, 379);
            this._grid.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "CourseId";
            this.Id.FillWeight = 95F;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 70;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.FillWeight = 115F;
            this.Course.HeaderText = "Name";
            this.Course.MinimumWidth = 250;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Evaluator
            // 
            this.Evaluator.DataPropertyName = "Instructor";
            this.Evaluator.HeaderText = "Evaluator";
            this.Evaluator.Name = "Evaluator";
            this.Evaluator.ReadOnly = true;
            // 
            // SendEmailNotification
            // 
            this.SendEmailNotification.DataPropertyName = "SendEmailNotification";
            this.SendEmailNotification.HeaderText = "Send Email";
            this.SendEmailNotification.Name = "SendEmailNotification";
            this.SendEmailNotification.ReadOnly = true;
            // 
            // SuggestedCourse
            // 
            this.SuggestedCourse.DataPropertyName = "SuggestedCourse";
            this.SuggestedCourse.HeaderText = "Suggested Course";
            this.SuggestedCourse.Name = "SuggestedCourse";
            this.SuggestedCourse.ReadOnly = true;
            // 
            // _lCourses
            // 
            this._lCourses.BackColor = System.Drawing.Color.AliceBlue;
            this._lCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this._lCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCourses.Location = new System.Drawing.Point(0, 0);
            this._lCourses.Name = "_lCourses";
            this._lCourses.Size = new System.Drawing.Size(824, 21);
            this._lCourses.TabIndex = 11;
            this._lCourses.Text = "Courses";
            this._lCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EvaluatorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._splitContainer);
            this.Name = "EvaluatorsControl";
            this.Size = new System.Drawing.Size(824, 525);
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._pnlEvaluator.ResumeLayout(false);
            this._pnlEvaluator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TlSplitContainer _splitContainer;
        private System.Windows.Forms.Label _lCourses;
        private TlDataGrid _grid;
        private TlDropDownList _cbEvaluators;
        private System.Windows.Forms.Label _lEvaluator;
        private TlButton _btnSelectEvaluator;
        private System.Windows.Forms.CheckBox _cbSendEmailNotification;
        private System.Windows.Forms.Label _lInstructionsEvaluator;
        private TlButton _btnSelectSuggestedCourse;
        private TlDropDownList _cbSuggestedCourses;
        private System.Windows.Forms.Label _lSuggested;
        private System.Windows.Forms.Panel _pnlEvaluator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluator;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SendEmailNotification;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuggestedCourse;
    }
}
