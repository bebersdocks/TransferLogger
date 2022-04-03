namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    partial class HistoricalEvaluationsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this._splitContainer = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._pnlEvaluation = new System.Windows.Forms.Panel();
            this._btnViewApplication = new TransferLogger.Ui.Controls.TlButton();
            this._tbApplicationDt = new TransferLogger.Ui.Controls.TlTextBox();
            this._btnViewMatchedCourse = new TransferLogger.Ui.Controls.TlButton();
            this._lApplicationDt = new System.Windows.Forms.Label();
            this._lMatchedCourse = new System.Windows.Forms.Label();
            this._lOrganization = new System.Windows.Forms.Label();
            this._tbMatchedCourse = new TransferLogger.Ui.Controls.TlTextBox();
            this._tbOrganization = new TransferLogger.Ui.Controls.TlTextBox();
            this._tbComment = new TransferLogger.Ui.Controls.TlTextBox();
            this._lEvaluationCourse = new System.Windows.Forms.Label();
            this._lComment = new System.Windows.Forms.Label();
            this._tbEvaluationCourse = new TransferLogger.Ui.Controls.TlTextBox();
            this._lStatus = new System.Windows.Forms.Label();
            this._lEvaluator = new System.Windows.Forms.Label();
            this._cbStatuses = new TransferLogger.Ui.Controls.TlDropDownList();
            this._tbEvaluator = new TransferLogger.Ui.Controls.TlTextBox();
            this._tbStudent = new TransferLogger.Ui.Controls.TlTextBox();
            this._lStudent = new System.Windows.Forms.Label();
            this._pnlCourse = new System.Windows.Forms.Panel();
            this._cbCourses = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lInstructions = new System.Windows.Forms.Label();
            this._cbUseHistoricalEvaluation = new System.Windows.Forms.CheckBox();
            this._lCourse = new System.Windows.Forms.Label();
            this._lEvaluations = new System.Windows.Forms.Label();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchedCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._pnlEvaluation.SuspendLayout();
            this._pnlCourse.SuspendLayout();
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
            this._splitContainer.Panel1.Controls.Add(this._pnlEvaluation);
            this._splitContainer.Panel1.Controls.Add(this._pnlCourse);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel2.Controls.Add(this._lEvaluations);
            this._splitContainer.Panel2.Controls.Add(this._grid);
            this._splitContainer.Size = new System.Drawing.Size(933, 639);
            this._splitContainer.SplitterDistance = 284;
            this._splitContainer.TabIndex = 1;
            // 
            // _pnlEvaluation
            // 
            this._pnlEvaluation.Controls.Add(this._btnViewApplication);
            this._pnlEvaluation.Controls.Add(this._tbApplicationDt);
            this._pnlEvaluation.Controls.Add(this._btnViewMatchedCourse);
            this._pnlEvaluation.Controls.Add(this._lApplicationDt);
            this._pnlEvaluation.Controls.Add(this._lMatchedCourse);
            this._pnlEvaluation.Controls.Add(this._lOrganization);
            this._pnlEvaluation.Controls.Add(this._tbMatchedCourse);
            this._pnlEvaluation.Controls.Add(this._tbOrganization);
            this._pnlEvaluation.Controls.Add(this._tbComment);
            this._pnlEvaluation.Controls.Add(this._lEvaluationCourse);
            this._pnlEvaluation.Controls.Add(this._lComment);
            this._pnlEvaluation.Controls.Add(this._tbEvaluationCourse);
            this._pnlEvaluation.Controls.Add(this._lStatus);
            this._pnlEvaluation.Controls.Add(this._lEvaluator);
            this._pnlEvaluation.Controls.Add(this._cbStatuses);
            this._pnlEvaluation.Controls.Add(this._tbEvaluator);
            this._pnlEvaluation.Controls.Add(this._tbStudent);
            this._pnlEvaluation.Controls.Add(this._lStudent);
            this._pnlEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlEvaluation.Location = new System.Drawing.Point(0, 99);
            this._pnlEvaluation.Name = "_pnlEvaluation";
            this._pnlEvaluation.Size = new System.Drawing.Size(933, 185);
            this._pnlEvaluation.TabIndex = 66;
            // 
            // _btnViewApplication
            // 
            this._btnViewApplication.BackColor = System.Drawing.Color.White;
            this._btnViewApplication.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnViewApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnViewApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnViewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnViewApplication.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this._btnViewApplication.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnViewApplication.Location = new System.Drawing.Point(359, 144);
            this._btnViewApplication.Name = "_btnViewApplication";
            this._btnViewApplication.Size = new System.Drawing.Size(96, 25);
            this._btnViewApplication.TabIndex = 65;
            this._btnViewApplication.TabStop = false;
            this._btnViewApplication.Text = "View";
            this._btnViewApplication.UseVisualStyleBackColor = false;
            // 
            // _tbApplicationDt
            // 
            this._tbApplicationDt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbApplicationDt.BoxWidth = 325;
            this._tbApplicationDt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbApplicationDt.ForeColor = System.Drawing.Color.Black;
            this._tbApplicationDt.Location = new System.Drawing.Point(130, 113);
            this._tbApplicationDt.Name = "_tbApplicationDt";
            this._tbApplicationDt.ReadOnly = true;
            this._tbApplicationDt.Size = new System.Drawing.Size(325, 25);
            this._tbApplicationDt.TabIndex = 63;
            // 
            // _btnViewMatchedCourse
            // 
            this._btnViewMatchedCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnViewMatchedCourse.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnViewMatchedCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnViewMatchedCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnViewMatchedCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnViewMatchedCourse.ForeColor = System.Drawing.Color.Black;
            this._btnViewMatchedCourse.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnViewMatchedCourse.Location = new System.Drawing.Point(426, 81);
            this._btnViewMatchedCourse.Name = "_btnViewMatchedCourse";
            this._btnViewMatchedCourse.Size = new System.Drawing.Size(29, 25);
            this._btnViewMatchedCourse.TabIndex = 47;
            this._btnViewMatchedCourse.TabStop = false;
            this._btnViewMatchedCourse.Text = "...";
            this._btnViewMatchedCourse.UseVisualStyleBackColor = false;
            // 
            // _lApplicationDt
            // 
            this._lApplicationDt.AutoSize = true;
            this._lApplicationDt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lApplicationDt.Location = new System.Drawing.Point(17, 116);
            this._lApplicationDt.Name = "_lApplicationDt";
            this._lApplicationDt.Size = new System.Drawing.Size(107, 17);
            this._lApplicationDt.TabIndex = 64;
            this._lApplicationDt.Text = "Application Date:";
            // 
            // _lMatchedCourse
            // 
            this._lMatchedCourse.AutoSize = true;
            this._lMatchedCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lMatchedCourse.Location = new System.Drawing.Point(17, 84);
            this._lMatchedCourse.Name = "_lMatchedCourse";
            this._lMatchedCourse.Size = new System.Drawing.Size(107, 17);
            this._lMatchedCourse.TabIndex = 49;
            this._lMatchedCourse.Text = "Matched Course:";
            // 
            // _lOrganization
            // 
            this._lOrganization.AutoSize = true;
            this._lOrganization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganization.Location = new System.Drawing.Point(467, 18);
            this._lOrganization.Name = "_lOrganization";
            this._lOrganization.Size = new System.Drawing.Size(86, 17);
            this._lOrganization.TabIndex = 61;
            this._lOrganization.Text = "Organization:";
            // 
            // _tbMatchedCourse
            // 
            this._tbMatchedCourse.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbMatchedCourse.BoxWidth = 325;
            this._tbMatchedCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbMatchedCourse.ForeColor = System.Drawing.Color.Black;
            this._tbMatchedCourse.Location = new System.Drawing.Point(130, 81);
            this._tbMatchedCourse.Name = "_tbMatchedCourse";
            this._tbMatchedCourse.ReadOnly = true;
            this._tbMatchedCourse.Size = new System.Drawing.Size(290, 25);
            this._tbMatchedCourse.TabIndex = 48;
            // 
            // _tbOrganization
            // 
            this._tbOrganization.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbOrganization.BoxWidth = 325;
            this._tbOrganization.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbOrganization.ForeColor = System.Drawing.Color.Black;
            this._tbOrganization.Location = new System.Drawing.Point(559, 18);
            this._tbOrganization.Name = "_tbOrganization";
            this._tbOrganization.ReadOnly = true;
            this._tbOrganization.Size = new System.Drawing.Size(325, 23);
            this._tbOrganization.TabIndex = 60;
            // 
            // _tbComment
            // 
            this._tbComment.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbComment.BoxWidth = 325;
            this._tbComment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbComment.ForeColor = System.Drawing.Color.Black;
            this._tbComment.Location = new System.Drawing.Point(559, 113);
            this._tbComment.Name = "_tbComment";
            this._tbComment.ReadOnly = true;
            this._tbComment.Size = new System.Drawing.Size(325, 23);
            this._tbComment.TabIndex = 50;
            // 
            // _lEvaluationCourse
            // 
            this._lEvaluationCourse.AutoSize = true;
            this._lEvaluationCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEvaluationCourse.Location = new System.Drawing.Point(72, 19);
            this._lEvaluationCourse.Name = "_lEvaluationCourse";
            this._lEvaluationCourse.Size = new System.Drawing.Size(52, 17);
            this._lEvaluationCourse.TabIndex = 59;
            this._lEvaluationCourse.Text = "Course:";
            // 
            // _lComment
            // 
            this._lComment.AutoSize = true;
            this._lComment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lComment.Location = new System.Drawing.Point(486, 114);
            this._lComment.Name = "_lComment";
            this._lComment.Size = new System.Drawing.Size(67, 17);
            this._lComment.TabIndex = 51;
            this._lComment.Text = "Comment:";
            // 
            // _tbEvaluationCourse
            // 
            this._tbEvaluationCourse.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbEvaluationCourse.BoxWidth = 325;
            this._tbEvaluationCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbEvaluationCourse.ForeColor = System.Drawing.Color.Black;
            this._tbEvaluationCourse.Location = new System.Drawing.Point(130, 18);
            this._tbEvaluationCourse.Name = "_tbEvaluationCourse";
            this._tbEvaluationCourse.ReadOnly = true;
            this._tbEvaluationCourse.Size = new System.Drawing.Size(325, 23);
            this._tbEvaluationCourse.TabIndex = 58;
            // 
            // _lStatus
            // 
            this._lStatus.AutoSize = true;
            this._lStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lStatus.Location = new System.Drawing.Point(78, 52);
            this._lStatus.Name = "_lStatus";
            this._lStatus.Size = new System.Drawing.Size(46, 17);
            this._lStatus.TabIndex = 53;
            this._lStatus.Text = "Status:";
            // 
            // _lEvaluator
            // 
            this._lEvaluator.AutoSize = true;
            this._lEvaluator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEvaluator.Location = new System.Drawing.Point(488, 82);
            this._lEvaluator.Name = "_lEvaluator";
            this._lEvaluator.Size = new System.Drawing.Size(65, 17);
            this._lEvaluator.TabIndex = 57;
            this._lEvaluator.Text = "Evaluator:";
            // 
            // _cbStatuses
            // 
            this._cbStatuses.BackColor = System.Drawing.Color.GhostWhite;
            this._cbStatuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbStatuses.Enabled = false;
            this._cbStatuses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbStatuses.FormattingEnabled = true;
            this._cbStatuses.Location = new System.Drawing.Point(130, 49);
            this._cbStatuses.Name = "_cbStatuses";
            this._cbStatuses.Size = new System.Drawing.Size(325, 25);
            this._cbStatuses.TabIndex = 52;
            // 
            // _tbEvaluator
            // 
            this._tbEvaluator.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbEvaluator.BoxWidth = 325;
            this._tbEvaluator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbEvaluator.ForeColor = System.Drawing.Color.Black;
            this._tbEvaluator.Location = new System.Drawing.Point(559, 81);
            this._tbEvaluator.Name = "_tbEvaluator";
            this._tbEvaluator.ReadOnly = true;
            this._tbEvaluator.Size = new System.Drawing.Size(325, 23);
            this._tbEvaluator.TabIndex = 56;
            // 
            // _tbStudent
            // 
            this._tbStudent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbStudent.BoxWidth = 325;
            this._tbStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbStudent.ForeColor = System.Drawing.Color.Black;
            this._tbStudent.Location = new System.Drawing.Point(559, 49);
            this._tbStudent.Name = "_tbStudent";
            this._tbStudent.ReadOnly = true;
            this._tbStudent.Size = new System.Drawing.Size(325, 23);
            this._tbStudent.TabIndex = 54;
            // 
            // _lStudent
            // 
            this._lStudent.AutoSize = true;
            this._lStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lStudent.Location = new System.Drawing.Point(498, 50);
            this._lStudent.Name = "_lStudent";
            this._lStudent.Size = new System.Drawing.Size(55, 17);
            this._lStudent.TabIndex = 55;
            this._lStudent.Text = "Student:";
            // 
            // _pnlCourse
            // 
            this._pnlCourse.Controls.Add(this._cbCourses);
            this._pnlCourse.Controls.Add(this._lInstructions);
            this._pnlCourse.Controls.Add(this._cbUseHistoricalEvaluation);
            this._pnlCourse.Controls.Add(this._lCourse);
            this._pnlCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlCourse.Location = new System.Drawing.Point(0, 0);
            this._pnlCourse.Name = "_pnlCourse";
            this._pnlCourse.Size = new System.Drawing.Size(933, 99);
            this._pnlCourse.TabIndex = 47;
            // 
            // _cbCourses
            // 
            this._cbCourses.BackColor = System.Drawing.Color.GhostWhite;
            this._cbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCourses.FormattingEnabled = true;
            this._cbCourses.Location = new System.Drawing.Point(130, 58);
            this._cbCourses.Name = "_cbCourses";
            this._cbCourses.Size = new System.Drawing.Size(325, 23);
            this._cbCourses.TabIndex = 31;
            // 
            // _lInstructions
            // 
            this._lInstructions.AutoSize = true;
            this._lInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lInstructions.ForeColor = System.Drawing.Color.Black;
            this._lInstructions.Location = new System.Drawing.Point(49, 23);
            this._lInstructions.Name = "_lInstructions";
            this._lInstructions.Size = new System.Drawing.Size(541, 17);
            this._lInstructions.TabIndex = 40;
            this._lInstructions.Text = "There were historical evaluations found for some courses, you can re-use them or " +
    "continue.";
            // 
            // _cbUseHistoricalEvaluation
            // 
            this._cbUseHistoricalEvaluation.AutoSize = true;
            this._cbUseHistoricalEvaluation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbUseHistoricalEvaluation.Location = new System.Drawing.Point(488, 60);
            this._cbUseHistoricalEvaluation.Name = "_cbUseHistoricalEvaluation";
            this._cbUseHistoricalEvaluation.Size = new System.Drawing.Size(168, 21);
            this._cbUseHistoricalEvaluation.TabIndex = 45;
            this._cbUseHistoricalEvaluation.Text = "Use historical evaluation";
            this._cbUseHistoricalEvaluation.UseVisualStyleBackColor = true;
            // 
            // _lCourse
            // 
            this._lCourse.AutoSize = true;
            this._lCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCourse.Location = new System.Drawing.Point(72, 58);
            this._lCourse.Name = "_lCourse";
            this._lCourse.Size = new System.Drawing.Size(52, 17);
            this._lCourse.TabIndex = 30;
            this._lCourse.Text = "Course:";
            // 
            // _lEvaluations
            // 
            this._lEvaluations.BackColor = System.Drawing.Color.AliceBlue;
            this._lEvaluations.Dock = System.Windows.Forms.DockStyle.Top;
            this._lEvaluations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEvaluations.Location = new System.Drawing.Point(0, 0);
            this._lEvaluations.Name = "_lEvaluations";
            this._lEvaluations.Size = new System.Drawing.Size(933, 20);
            this._lEvaluations.TabIndex = 11;
            this._lEvaluations.Text = "Historical Evaluations";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseId,
            this.Course,
            this.Organization,
            this.MatchedCourse,
            this.Status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.DefaultCellStyle = dataGridViewCellStyle5;
            this._grid.EnableHeadersVisualStyles = false;
            this._grid.Location = new System.Drawing.Point(0, 21);
            this._grid.MultiSelect = false;
            this._grid.Name = "_grid";
            this._grid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._grid.RowHeadersVisible = false;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(933, 330);
            this._grid.TabIndex = 10;
            // 
            // CourseId
            // 
            this.CourseId.DataPropertyName = "CourseId";
            this.CourseId.FillWeight = 115F;
            this.CourseId.HeaderText = "Course Id";
            this.CourseId.MinimumWidth = 250;
            this.CourseId.Name = "CourseId";
            this.CourseId.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 140;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Organization
            // 
            this.Organization.HeaderText = "Organization";
            this.Organization.Name = "Organization";
            this.Organization.ReadOnly = true;
            // 
            // MatchedCourse
            // 
            this.MatchedCourse.HeaderText = "Matched Course";
            this.MatchedCourse.Name = "MatchedCourse";
            this.MatchedCourse.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // HistoricalEvaluationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._splitContainer);
            this.Name = "HistoricalEvaluationsControl";
            this.Size = new System.Drawing.Size(933, 639);
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._pnlEvaluation.ResumeLayout(false);
            this._pnlEvaluation.PerformLayout();
            this._pnlCourse.ResumeLayout(false);
            this._pnlCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TlSplitContainer _splitContainer;
        private System.Windows.Forms.Label _lInstructions;
        private TlDropDownList _cbCourses;
        private System.Windows.Forms.Label _lCourse;
        private TlDataGrid _grid;
        private System.Windows.Forms.CheckBox _cbUseHistoricalEvaluation;
        private System.Windows.Forms.Label _lEvaluations;
        private TlTextBox _tbMatchedCourse;
        private System.Windows.Forms.Label _lMatchedCourse;
        private TlButton _btnViewMatchedCourse;
        private TlTextBox _tbComment;
        private System.Windows.Forms.Label _lComment;
        private TlDropDownList _cbStatuses;
        private System.Windows.Forms.Label _lStatus;
        private System.Windows.Forms.Label _lStudent;
        private TlTextBox _tbStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchedCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private TlButton _btnViewApplication;
        private TlTextBox _tbApplicationDt;
        private System.Windows.Forms.Label _lApplicationDt;
        private System.Windows.Forms.Label _lOrganization;
        private TlTextBox _tbOrganization;
        private System.Windows.Forms.Label _lEvaluationCourse;
        private TlTextBox _tbEvaluationCourse;
        private System.Windows.Forms.Label _lEvaluator;
        private TlTextBox _tbEvaluator;
        private System.Windows.Forms.Panel _pnlCourse;
        private System.Windows.Forms.Panel _pnlEvaluation;
    }
}
