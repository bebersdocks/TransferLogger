namespace TransferLogger.Ui.Forms.Applications
{
    partial class ApplicationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this._pnlCourses = new System.Windows.Forms.Panel();
            this._lEvaluations = new System.Windows.Forms.Label();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuggestedCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchedCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._pnlApplication = new System.Windows.Forms.Panel();
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._pnlEvaluation = new System.Windows.Forms.Panel();
            this._cbMatchedCourses = new TransferLogger.Ui.Controls.TlDropDownList();
            this._btnViewSuggestedCourse = new TransferLogger.Ui.Controls.TlButton();
            this._lHorizontalLine = new System.Windows.Forms.Label();
            this._cbEvaluationStatus = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lEvaluationStatus = new System.Windows.Forms.Label();
            this._tbComment = new TransferLogger.Ui.Controls.TlTextBox();
            this._lSuggestedCourse = new System.Windows.Forms.Label();
            this._tbSuggestedCourse = new TransferLogger.Ui.Controls.TlTextBox();
            this._btnViewCourse = new TransferLogger.Ui.Controls.TlButton();
            this._lCourse = new System.Windows.Forms.Label();
            this._tbCourse = new TransferLogger.Ui.Controls.TlTextBox();
            this._lMatchedCourse = new System.Windows.Forms.Label();
            this._lComment = new System.Windows.Forms.Label();
            this._tbEvaluator = new TransferLogger.Ui.Controls.TlTextBox();
            this._btnViewMatchedCourse = new TransferLogger.Ui.Controls.TlButton();
            this._lEvaluator = new System.Windows.Forms.Label();
            this._pnlApplicationDetails = new System.Windows.Forms.Panel();
            this._tbCompletedAt = new TransferLogger.Ui.Controls.TlTextBox();
            this._lCompletedAt = new System.Windows.Forms.Label();
            this._tbCreatedAt = new TransferLogger.Ui.Controls.TlTextBox();
            this._lCreatedAt = new System.Windows.Forms.Label();
            this._cbApplicationStatus = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lApplicationStatus = new System.Windows.Forms.Label();
            this._tbTargetProgram = new TransferLogger.Ui.Controls.TlTextBox();
            this._lTargetProgram = new System.Windows.Forms.Label();
            this._tbOrganization = new TransferLogger.Ui.Controls.TlTextBox();
            this._lOrganization = new System.Windows.Forms.Label();
            this._tbStudent = new TransferLogger.Ui.Controls.TlTextBox();
            this._lStudent = new System.Windows.Forms.Label();
            this._btnSave = new TransferLogger.Ui.Controls.TlButton();
            this._btnCancel = new TransferLogger.Ui.Controls.TlButton();
            this._btnSendEmail = new TransferLogger.Ui.Controls.TlButton();
            this._btnExportExcel = new TransferLogger.Ui.Controls.TlButton();
            this._pnlCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this._pnlApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._pnlEvaluation.SuspendLayout();
            this._pnlApplicationDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnlCourses
            // 
            this._pnlCourses.BackColor = System.Drawing.Color.GhostWhite;
            this._pnlCourses.Controls.Add(this._lEvaluations);
            this._pnlCourses.Controls.Add(this._grid);
            this._pnlCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlCourses.Location = new System.Drawing.Point(0, 0);
            this._pnlCourses.Name = "_pnlCourses";
            this._pnlCourses.Size = new System.Drawing.Size(1016, 297);
            this._pnlCourses.TabIndex = 0;
            // 
            // _lEvaluations
            // 
            this._lEvaluations.BackColor = System.Drawing.Color.AliceBlue;
            this._lEvaluations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lEvaluations.Dock = System.Windows.Forms.DockStyle.Top;
            this._lEvaluations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEvaluations.Location = new System.Drawing.Point(0, 0);
            this._lEvaluations.Name = "_lEvaluations";
            this._lEvaluations.Size = new System.Drawing.Size(1016, 21);
            this._lEvaluations.TabIndex = 18;
            this._lEvaluations.Text = "Evaluations";
            this._lEvaluations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.Evaluator,
            this.SuggestedCourse,
            this.MatchedCourse,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.DefaultCellStyle = dataGridViewCellStyle2;
            this._grid.EnableHeadersVisualStyles = false;
            this._grid.Location = new System.Drawing.Point(0, 19);
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
            this._grid.Size = new System.Drawing.Size(1016, 278);
            this._grid.TabIndex = 6;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.HeaderText = "Course";
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
            // SuggestedCourse
            // 
            this.SuggestedCourse.DataPropertyName = "SuggestedCourse";
            this.SuggestedCourse.HeaderText = "Suggested Course";
            this.SuggestedCourse.Name = "SuggestedCourse";
            this.SuggestedCourse.ReadOnly = true;
            // 
            // MatchedCourse
            // 
            this.MatchedCourse.DataPropertyName = "MatchedCourse";
            this.MatchedCourse.HeaderText = "Matched Course";
            this.MatchedCourse.Name = "MatchedCourse";
            this.MatchedCourse.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StatusDisplayName";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // _pnlApplication
            // 
            this._pnlApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlApplication.BackColor = System.Drawing.Color.GhostWhite;
            this._pnlApplication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlApplication.Controls.Add(this._splitContainer);
            this._pnlApplication.Location = new System.Drawing.Point(12, 12);
            this._pnlApplication.Name = "_pnlApplication";
            this._pnlApplication.Size = new System.Drawing.Size(1018, 595);
            this._pnlApplication.TabIndex = 1;
            // 
            // _splitContainer
            // 
            this._splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._splitContainer.BackColor = System.Drawing.Color.White;
            this._splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._splitContainer.IsSplitterFixed = true;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            this._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel1.Controls.Add(this._pnlEvaluation);
            this._splitContainer.Panel1.Controls.Add(this._pnlApplicationDetails);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this._pnlCourses);
            this._splitContainer.Size = new System.Drawing.Size(1016, 593);
            this._splitContainer.SplitterDistance = 292;
            this._splitContainer.TabIndex = 0;
            // 
            // _pnlEvaluation
            // 
            this._pnlEvaluation.Controls.Add(this._cbMatchedCourses);
            this._pnlEvaluation.Controls.Add(this._btnViewSuggestedCourse);
            this._pnlEvaluation.Controls.Add(this._lHorizontalLine);
            this._pnlEvaluation.Controls.Add(this._cbEvaluationStatus);
            this._pnlEvaluation.Controls.Add(this._lEvaluationStatus);
            this._pnlEvaluation.Controls.Add(this._tbComment);
            this._pnlEvaluation.Controls.Add(this._lSuggestedCourse);
            this._pnlEvaluation.Controls.Add(this._tbSuggestedCourse);
            this._pnlEvaluation.Controls.Add(this._btnViewCourse);
            this._pnlEvaluation.Controls.Add(this._lCourse);
            this._pnlEvaluation.Controls.Add(this._tbCourse);
            this._pnlEvaluation.Controls.Add(this._lMatchedCourse);
            this._pnlEvaluation.Controls.Add(this._lComment);
            this._pnlEvaluation.Controls.Add(this._tbEvaluator);
            this._pnlEvaluation.Controls.Add(this._btnViewMatchedCourse);
            this._pnlEvaluation.Controls.Add(this._lEvaluator);
            this._pnlEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlEvaluation.Location = new System.Drawing.Point(0, 131);
            this._pnlEvaluation.Name = "_pnlEvaluation";
            this._pnlEvaluation.Size = new System.Drawing.Size(1016, 161);
            this._pnlEvaluation.TabIndex = 1;
            // 
            // _cbMatchedCourses
            // 
            this._cbMatchedCourses.BackColor = System.Drawing.Color.GhostWhite;
            this._cbMatchedCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbMatchedCourses.Enabled = false;
            this._cbMatchedCourses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbMatchedCourses.FormattingEnabled = true;
            this._cbMatchedCourses.Location = new System.Drawing.Point(613, 16);
            this._cbMatchedCourses.Name = "_cbMatchedCourses";
            this._cbMatchedCourses.Size = new System.Drawing.Size(290, 25);
            this._cbMatchedCourses.TabIndex = 3;
            // 
            // _btnViewSuggestedCourse
            // 
            this._btnViewSuggestedCourse.BackColor = System.Drawing.Color.White;
            this._btnViewSuggestedCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnViewSuggestedCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnViewSuggestedCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnViewSuggestedCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnViewSuggestedCourse.ForeColor = System.Drawing.Color.Black;
            this._btnViewSuggestedCourse.Location = new System.Drawing.Point(435, 50);
            this._btnViewSuggestedCourse.Name = "_btnViewSuggestedCourse";
            this._btnViewSuggestedCourse.Size = new System.Drawing.Size(29, 25);
            this._btnViewSuggestedCourse.TabIndex = 2;
            this._btnViewSuggestedCourse.Text = "...";
            this._btnViewSuggestedCourse.UseVisualStyleBackColor = false;
            // 
            // _lHorizontalLine
            // 
            this._lHorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lHorizontalLine.Dock = System.Windows.Forms.DockStyle.Top;
            this._lHorizontalLine.Location = new System.Drawing.Point(0, 0);
            this._lHorizontalLine.Name = "_lHorizontalLine";
            this._lHorizontalLine.Size = new System.Drawing.Size(1016, 1);
            this._lHorizontalLine.TabIndex = 75;
            // 
            // _cbEvaluationStatus
            // 
            this._cbEvaluationStatus.BackColor = System.Drawing.Color.GhostWhite;
            this._cbEvaluationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbEvaluationStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbEvaluationStatus.FormattingEnabled = true;
            this._cbEvaluationStatus.Location = new System.Drawing.Point(139, 118);
            this._cbEvaluationStatus.Name = "_cbEvaluationStatus";
            this._cbEvaluationStatus.Size = new System.Drawing.Size(325, 25);
            this._cbEvaluationStatus.TabIndex = 74;
            this._cbEvaluationStatus.TabStop = false;
            // 
            // _lEvaluationStatus
            // 
            this._lEvaluationStatus.AutoSize = true;
            this._lEvaluationStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEvaluationStatus.Location = new System.Drawing.Point(87, 121);
            this._lEvaluationStatus.Name = "_lEvaluationStatus";
            this._lEvaluationStatus.Size = new System.Drawing.Size(46, 17);
            this._lEvaluationStatus.TabIndex = 73;
            this._lEvaluationStatus.Text = "Status:";
            // 
            // _tbComment
            // 
            this._tbComment.BackColor = System.Drawing.Color.GhostWhite;
            this._tbComment.BoxWidth = 325;
            this._tbComment.ForeColor = System.Drawing.Color.Black;
            this._tbComment.Location = new System.Drawing.Point(613, 50);
            this._tbComment.Multiline = true;
            this._tbComment.Name = "_tbComment";
            this._tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._tbComment.Size = new System.Drawing.Size(325, 59);
            this._tbComment.TabIndex = 5;
            // 
            // _lSuggestedCourse
            // 
            this._lSuggestedCourse.AutoSize = true;
            this._lSuggestedCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lSuggestedCourse.Location = new System.Drawing.Point(15, 53);
            this._lSuggestedCourse.Name = "_lSuggestedCourse";
            this._lSuggestedCourse.Size = new System.Drawing.Size(118, 17);
            this._lSuggestedCourse.TabIndex = 71;
            this._lSuggestedCourse.Text = "Suggested Course:";
            // 
            // _tbSuggestedCourse
            // 
            this._tbSuggestedCourse.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbSuggestedCourse.BoxWidth = 325;
            this._tbSuggestedCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbSuggestedCourse.ForeColor = System.Drawing.Color.Black;
            this._tbSuggestedCourse.Location = new System.Drawing.Point(139, 50);
            this._tbSuggestedCourse.Name = "_tbSuggestedCourse";
            this._tbSuggestedCourse.ReadOnly = true;
            this._tbSuggestedCourse.Size = new System.Drawing.Size(290, 25);
            this._tbSuggestedCourse.TabIndex = 70;
            this._tbSuggestedCourse.TabStop = false;
            // 
            // _btnViewCourse
            // 
            this._btnViewCourse.BackColor = System.Drawing.Color.White;
            this._btnViewCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnViewCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnViewCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnViewCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnViewCourse.ForeColor = System.Drawing.Color.Black;
            this._btnViewCourse.Location = new System.Drawing.Point(435, 16);
            this._btnViewCourse.Name = "_btnViewCourse";
            this._btnViewCourse.Size = new System.Drawing.Size(29, 25);
            this._btnViewCourse.TabIndex = 1;
            this._btnViewCourse.Text = "...";
            this._btnViewCourse.UseVisualStyleBackColor = false;
            // 
            // _lCourse
            // 
            this._lCourse.AutoSize = true;
            this._lCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCourse.Location = new System.Drawing.Point(81, 19);
            this._lCourse.Name = "_lCourse";
            this._lCourse.Size = new System.Drawing.Size(52, 17);
            this._lCourse.TabIndex = 68;
            this._lCourse.Text = "Course:";
            // 
            // _tbCourse
            // 
            this._tbCourse.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbCourse.BoxWidth = 325;
            this._tbCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbCourse.ForeColor = System.Drawing.Color.Black;
            this._tbCourse.Location = new System.Drawing.Point(139, 16);
            this._tbCourse.Name = "_tbCourse";
            this._tbCourse.ReadOnly = true;
            this._tbCourse.Size = new System.Drawing.Size(290, 25);
            this._tbCourse.TabIndex = 67;
            this._tbCourse.TabStop = false;
            // 
            // _lMatchedCourse
            // 
            this._lMatchedCourse.AutoSize = true;
            this._lMatchedCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lMatchedCourse.Location = new System.Drawing.Point(500, 19);
            this._lMatchedCourse.Name = "_lMatchedCourse";
            this._lMatchedCourse.Size = new System.Drawing.Size(107, 17);
            this._lMatchedCourse.TabIndex = 63;
            this._lMatchedCourse.Text = "Matched Course:";
            // 
            // _lComment
            // 
            this._lComment.AutoSize = true;
            this._lComment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lComment.Location = new System.Drawing.Point(540, 51);
            this._lComment.Name = "_lComment";
            this._lComment.Size = new System.Drawing.Size(67, 17);
            this._lComment.TabIndex = 64;
            this._lComment.Text = "Comment:";
            // 
            // _tbEvaluator
            // 
            this._tbEvaluator.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbEvaluator.BoxWidth = 325;
            this._tbEvaluator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbEvaluator.ForeColor = System.Drawing.Color.Black;
            this._tbEvaluator.Location = new System.Drawing.Point(139, 84);
            this._tbEvaluator.Name = "_tbEvaluator";
            this._tbEvaluator.ReadOnly = true;
            this._tbEvaluator.Size = new System.Drawing.Size(325, 25);
            this._tbEvaluator.TabIndex = 61;
            this._tbEvaluator.TabStop = false;
            // 
            // _btnViewMatchedCourse
            // 
            this._btnViewMatchedCourse.BackColor = System.Drawing.Color.White;
            this._btnViewMatchedCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnViewMatchedCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnViewMatchedCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnViewMatchedCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnViewMatchedCourse.ForeColor = System.Drawing.Color.Black;
            this._btnViewMatchedCourse.Location = new System.Drawing.Point(909, 16);
            this._btnViewMatchedCourse.Name = "_btnViewMatchedCourse";
            this._btnViewMatchedCourse.Size = new System.Drawing.Size(29, 25);
            this._btnViewMatchedCourse.TabIndex = 4;
            this._btnViewMatchedCourse.Text = "...";
            this._btnViewMatchedCourse.UseVisualStyleBackColor = false;
            // 
            // _lEvaluator
            // 
            this._lEvaluator.AutoSize = true;
            this._lEvaluator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEvaluator.Location = new System.Drawing.Point(68, 87);
            this._lEvaluator.Name = "_lEvaluator";
            this._lEvaluator.Size = new System.Drawing.Size(65, 17);
            this._lEvaluator.TabIndex = 66;
            this._lEvaluator.Text = "Evaluator:";
            // 
            // _pnlApplicationDetails
            // 
            this._pnlApplicationDetails.Controls.Add(this._tbCompletedAt);
            this._pnlApplicationDetails.Controls.Add(this._lCompletedAt);
            this._pnlApplicationDetails.Controls.Add(this._tbCreatedAt);
            this._pnlApplicationDetails.Controls.Add(this._lCreatedAt);
            this._pnlApplicationDetails.Controls.Add(this._cbApplicationStatus);
            this._pnlApplicationDetails.Controls.Add(this._lApplicationStatus);
            this._pnlApplicationDetails.Controls.Add(this._tbTargetProgram);
            this._pnlApplicationDetails.Controls.Add(this._lTargetProgram);
            this._pnlApplicationDetails.Controls.Add(this._tbOrganization);
            this._pnlApplicationDetails.Controls.Add(this._lOrganization);
            this._pnlApplicationDetails.Controls.Add(this._tbStudent);
            this._pnlApplicationDetails.Controls.Add(this._lStudent);
            this._pnlApplicationDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlApplicationDetails.Location = new System.Drawing.Point(0, 0);
            this._pnlApplicationDetails.Name = "_pnlApplicationDetails";
            this._pnlApplicationDetails.Size = new System.Drawing.Size(1016, 131);
            this._pnlApplicationDetails.TabIndex = 0;
            // 
            // _tbCompletedAt
            // 
            this._tbCompletedAt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbCompletedAt.BoxWidth = 325;
            this._tbCompletedAt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbCompletedAt.ForeColor = System.Drawing.Color.Black;
            this._tbCompletedAt.Location = new System.Drawing.Point(613, 86);
            this._tbCompletedAt.Name = "_tbCompletedAt";
            this._tbCompletedAt.ReadOnly = true;
            this._tbCompletedAt.Size = new System.Drawing.Size(325, 25);
            this._tbCompletedAt.TabIndex = 54;
            this._tbCompletedAt.TabStop = false;
            // 
            // _lCompletedAt
            // 
            this._lCompletedAt.AutoSize = true;
            this._lCompletedAt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCompletedAt.Location = new System.Drawing.Point(501, 89);
            this._lCompletedAt.Name = "_lCompletedAt";
            this._lCompletedAt.Size = new System.Drawing.Size(106, 17);
            this._lCompletedAt.TabIndex = 55;
            this._lCompletedAt.Text = "Completed Date:";
            // 
            // _tbCreatedAt
            // 
            this._tbCreatedAt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbCreatedAt.BoxWidth = 325;
            this._tbCreatedAt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbCreatedAt.ForeColor = System.Drawing.Color.Black;
            this._tbCreatedAt.Location = new System.Drawing.Point(613, 52);
            this._tbCreatedAt.Name = "_tbCreatedAt";
            this._tbCreatedAt.ReadOnly = true;
            this._tbCreatedAt.Size = new System.Drawing.Size(325, 25);
            this._tbCreatedAt.TabIndex = 52;
            this._tbCreatedAt.TabStop = false;
            // 
            // _lCreatedAt
            // 
            this._lCreatedAt.AutoSize = true;
            this._lCreatedAt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCreatedAt.Location = new System.Drawing.Point(519, 55);
            this._lCreatedAt.Name = "_lCreatedAt";
            this._lCreatedAt.Size = new System.Drawing.Size(88, 17);
            this._lCreatedAt.TabIndex = 53;
            this._lCreatedAt.Text = "Created Date:";
            // 
            // _cbApplicationStatus
            // 
            this._cbApplicationStatus.BackColor = System.Drawing.Color.GhostWhite;
            this._cbApplicationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbApplicationStatus.Enabled = false;
            this._cbApplicationStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbApplicationStatus.FormattingEnabled = true;
            this._cbApplicationStatus.Location = new System.Drawing.Point(613, 18);
            this._cbApplicationStatus.Name = "_cbApplicationStatus";
            this._cbApplicationStatus.Size = new System.Drawing.Size(325, 25);
            this._cbApplicationStatus.TabIndex = 51;
            this._cbApplicationStatus.TabStop = false;
            // 
            // _lApplicationStatus
            // 
            this._lApplicationStatus.AutoSize = true;
            this._lApplicationStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lApplicationStatus.Location = new System.Drawing.Point(561, 21);
            this._lApplicationStatus.Name = "_lApplicationStatus";
            this._lApplicationStatus.Size = new System.Drawing.Size(46, 17);
            this._lApplicationStatus.TabIndex = 50;
            this._lApplicationStatus.Text = "Status:";
            // 
            // _tbTargetProgram
            // 
            this._tbTargetProgram.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbTargetProgram.BoxWidth = 325;
            this._tbTargetProgram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbTargetProgram.ForeColor = System.Drawing.Color.Black;
            this._tbTargetProgram.Location = new System.Drawing.Point(139, 86);
            this._tbTargetProgram.Name = "_tbTargetProgram";
            this._tbTargetProgram.ReadOnly = true;
            this._tbTargetProgram.Size = new System.Drawing.Size(325, 25);
            this._tbTargetProgram.TabIndex = 45;
            this._tbTargetProgram.TabStop = false;
            // 
            // _lTargetProgram
            // 
            this._lTargetProgram.AutoSize = true;
            this._lTargetProgram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lTargetProgram.Location = new System.Drawing.Point(30, 89);
            this._lTargetProgram.Name = "_lTargetProgram";
            this._lTargetProgram.Size = new System.Drawing.Size(103, 17);
            this._lTargetProgram.TabIndex = 48;
            this._lTargetProgram.Text = "Target Program:";
            // 
            // _tbOrganization
            // 
            this._tbOrganization.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbOrganization.BoxWidth = 325;
            this._tbOrganization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbOrganization.ForeColor = System.Drawing.Color.Black;
            this._tbOrganization.Location = new System.Drawing.Point(139, 52);
            this._tbOrganization.Name = "_tbOrganization";
            this._tbOrganization.ReadOnly = true;
            this._tbOrganization.Size = new System.Drawing.Size(325, 25);
            this._tbOrganization.TabIndex = 44;
            this._tbOrganization.TabStop = false;
            // 
            // _lOrganization
            // 
            this._lOrganization.AutoSize = true;
            this._lOrganization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganization.Location = new System.Drawing.Point(47, 55);
            this._lOrganization.Name = "_lOrganization";
            this._lOrganization.Size = new System.Drawing.Size(86, 17);
            this._lOrganization.TabIndex = 47;
            this._lOrganization.Text = "Organization:";
            // 
            // _tbStudent
            // 
            this._tbStudent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbStudent.BoxWidth = 325;
            this._tbStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbStudent.ForeColor = System.Drawing.Color.Black;
            this._tbStudent.Location = new System.Drawing.Point(139, 18);
            this._tbStudent.Name = "_tbStudent";
            this._tbStudent.Size = new System.Drawing.Size(325, 25);
            this._tbStudent.TabIndex = 43;
            this._tbStudent.TabStop = false;
            // 
            // _lStudent
            // 
            this._lStudent.AutoSize = true;
            this._lStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lStudent.Location = new System.Drawing.Point(82, 21);
            this._lStudent.Name = "_lStudent";
            this._lStudent.Size = new System.Drawing.Size(55, 17);
            this._lStudent.TabIndex = 46;
            this._lStudent.Text = "Student:";
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.BackColor = System.Drawing.Color.White;
            this._btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSave.ForeColor = System.Drawing.Color.Black;
            this._btnSave.Location = new System.Drawing.Point(954, 615);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 29);
            this._btnSave.TabIndex = 10;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = false;
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
            this._btnCancel.Location = new System.Drawing.Point(873, 615);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 29);
            this._btnCancel.TabIndex = 11;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            // 
            // _btnSendEmail
            // 
            this._btnSendEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnSendEmail.AutoSize = true;
            this._btnSendEmail.BackColor = System.Drawing.Color.White;
            this._btnSendEmail.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.mail;
            this._btnSendEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnSendEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnSendEmail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnSendEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnSendEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSendEmail.ForeColor = System.Drawing.Color.Black;
            this._btnSendEmail.Location = new System.Drawing.Point(12, 613);
            this._btnSendEmail.Name = "_btnSendEmail";
            this._btnSendEmail.Size = new System.Drawing.Size(32, 32);
            this._btnSendEmail.TabIndex = 8;
            this._btnSendEmail.UseVisualStyleBackColor = false;
            // 
            // _btnExportExcel
            // 
            this._btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnExportExcel.AutoSize = true;
            this._btnExportExcel.BackColor = System.Drawing.Color.White;
            this._btnExportExcel.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.excel;
            this._btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnExportExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnExportExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnExportExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnExportExcel.ForeColor = System.Drawing.Color.Black;
            this._btnExportExcel.Location = new System.Drawing.Point(50, 613);
            this._btnExportExcel.Name = "_btnExportExcel";
            this._btnExportExcel.Size = new System.Drawing.Size(32, 32);
            this._btnExportExcel.TabIndex = 9;
            this._btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 656);
            this.Controls.Add(this._btnSendEmail);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnExportExcel);
            this.Controls.Add(this._pnlApplication);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApplicationForm";
            this._pnlCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this._pnlApplication.ResumeLayout(false);
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._pnlEvaluation.ResumeLayout(false);
            this._pnlEvaluation.PerformLayout();
            this._pnlApplicationDetails.ResumeLayout(false);
            this._pnlApplicationDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _pnlCourses;
        private System.Windows.Forms.Panel _pnlApplication;
        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.Panel _pnlApplicationDetails;
        private Controls.TlButton _btnSave;
        private Controls.TlButton _btnCancel;
        private Controls.TlDataGrid _grid;
        private System.Windows.Forms.Label _lEvaluations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluator;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuggestedCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchedCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel _pnlEvaluation;
        private Controls.TlTextBox _tbTargetProgram;
        private System.Windows.Forms.Label _lTargetProgram;
        private Controls.TlTextBox _tbOrganization;
        private System.Windows.Forms.Label _lOrganization;
        private Controls.TlTextBox _tbStudent;
        private System.Windows.Forms.Label _lStudent;
        private System.Windows.Forms.Label _lApplicationStatus;
        private System.Windows.Forms.Label _lCourse;
        private Controls.TlTextBox _tbCourse;
        private System.Windows.Forms.Label _lMatchedCourse;
        private System.Windows.Forms.Label _lComment;
        private Controls.TlTextBox _tbEvaluator;
        private Controls.TlButton _btnViewMatchedCourse;
        private System.Windows.Forms.Label _lEvaluator;
        private Controls.TlButton _btnViewCourse;
        private System.Windows.Forms.Label _lSuggestedCourse;
        private Controls.TlTextBox _tbSuggestedCourse;
        private Controls.TlTextBox _tbComment;
        private Controls.TlDropDownList _cbApplicationStatus;
        private Controls.TlDropDownList _cbEvaluationStatus;
        private System.Windows.Forms.Label _lEvaluationStatus;
        private System.Windows.Forms.Label _lHorizontalLine;
        private Controls.TlButton _btnViewSuggestedCourse;
        private Controls.TlTextBox _tbCreatedAt;
        private System.Windows.Forms.Label _lCreatedAt;
        private Controls.TlButton _btnSendEmail;
        private Controls.TlButton _btnExportExcel;
        private Controls.TlTextBox _tbCompletedAt;
        private System.Windows.Forms.Label _lCompletedAt;
        private Controls.TlDropDownList _cbMatchedCourses;
    }
}