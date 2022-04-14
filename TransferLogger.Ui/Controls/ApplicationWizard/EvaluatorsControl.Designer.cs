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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this._splitContainer = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._pnlEvaluator = new System.Windows.Forms.Panel();
            this._btnSelectSuggestedCourse = new TransferLogger.Ui.Controls.TlButton();
            this._cbSuggestedCourses = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lEvaluator = new System.Windows.Forms.Label();
            this._btnSelectEvaluator = new TransferLogger.Ui.Controls.TlButton();
            this._lInstructionsEvaluator = new System.Windows.Forms.Label();
            this._lSuggested = new System.Windows.Forms.Label();
            this._cbEvaluators = new TransferLogger.Ui.Controls.TlDropDownList();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this._splitContainer.IsSplitterFixed = true;
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
            this._splitContainer.Size = new System.Drawing.Size(925, 525);
            this._splitContainer.SplitterDistance = 121;
            this._splitContainer.TabIndex = 2;
            // 
            // _pnlEvaluator
            // 
            this._pnlEvaluator.Controls.Add(this._btnSelectSuggestedCourse);
            this._pnlEvaluator.Controls.Add(this._cbSuggestedCourses);
            this._pnlEvaluator.Controls.Add(this._lEvaluator);
            this._pnlEvaluator.Controls.Add(this._btnSelectEvaluator);
            this._pnlEvaluator.Controls.Add(this._lInstructionsEvaluator);
            this._pnlEvaluator.Controls.Add(this._lSuggested);
            this._pnlEvaluator.Controls.Add(this._cbEvaluators);
            this._pnlEvaluator.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlEvaluator.Location = new System.Drawing.Point(0, 0);
            this._pnlEvaluator.Name = "_pnlEvaluator";
            this._pnlEvaluator.Size = new System.Drawing.Size(925, 121);
            this._pnlEvaluator.TabIndex = 48;
            // 
            // _btnSelectSuggestedCourse
            // 
            this._btnSelectSuggestedCourse.AutoSize = true;
            this._btnSelectSuggestedCourse.BackColor = System.Drawing.Color.White;
            this._btnSelectSuggestedCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnSelectSuggestedCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectSuggestedCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectSuggestedCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectSuggestedCourse.ForeColor = System.Drawing.Color.Black;
            this._btnSelectSuggestedCourse.Location = new System.Drawing.Point(443, 80);
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
            this._cbSuggestedCourses.Location = new System.Drawing.Point(146, 80);
            this._cbSuggestedCourses.Name = "_cbSuggestedCourses";
            this._cbSuggestedCourses.Size = new System.Drawing.Size(291, 23);
            this._cbSuggestedCourses.TabIndex = 54;
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
            this._btnSelectEvaluator.BackColor = System.Drawing.Color.White;
            this._btnSelectEvaluator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnSelectEvaluator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectEvaluator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectEvaluator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectEvaluator.ForeColor = System.Drawing.Color.Black;
            this._btnSelectEvaluator.Location = new System.Drawing.Point(443, 50);
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
            this._lInstructionsEvaluator.Size = new System.Drawing.Size(360, 17);
            this._lInstructionsEvaluator.TabIndex = 51;
            this._lInstructionsEvaluator.Text = "Assign tranfer evaluators and set suggested courses (if any).";
            // 
            // _lSuggested
            // 
            this._lSuggested.AutoSize = true;
            this._lSuggested.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lSuggested.Location = new System.Drawing.Point(22, 82);
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
            this._grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._grid.BackgroundColor = System.Drawing.Color.White;
            this._grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.DefaultCellStyle = dataGridViewCellStyle8;
            this._grid.EnableHeadersVisualStyles = false;
            this._grid.Location = new System.Drawing.Point(0, 20);
            this._grid.MultiSelect = false;
            this._grid.Name = "_grid";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this._grid.RowHeadersVisible = false;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(925, 378);
            this._grid.TabIndex = 12;
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
            // _lCourses
            // 
            this._lCourses.BackColor = System.Drawing.Color.AliceBlue;
            this._lCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this._lCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCourses.Location = new System.Drawing.Point(0, 0);
            this._lCourses.Name = "_lCourses";
            this._lCourses.Size = new System.Drawing.Size(925, 21);
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
            this.Size = new System.Drawing.Size(925, 525);
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
        private System.Windows.Forms.Label _lInstructionsEvaluator;
        private TlButton _btnSelectSuggestedCourse;
        private TlDropDownList _cbSuggestedCourses;
        private System.Windows.Forms.Label _lSuggested;
        private System.Windows.Forms.Panel _pnlEvaluator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
    }
}
