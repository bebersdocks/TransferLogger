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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this._splitContainer = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._pnlTop = new System.Windows.Forms.Panel();
            this._pnlEvaluationDetails = new System.Windows.Forms.Panel();
            this._lStudent = new System.Windows.Forms.Label();
            this._tbComment = new TransferLogger.Ui.Controls.TlTextBox();
            this._btnViewApplication = new TransferLogger.Ui.Controls.TlButton();
            this._lMatchedCourse = new System.Windows.Forms.Label();
            this._lComment = new System.Windows.Forms.Label();
            this._tbStudent = new TransferLogger.Ui.Controls.TlTextBox();
            this._tbEvaluator = new TransferLogger.Ui.Controls.TlTextBox();
            this._btnViewMatchedCourse = new TransferLogger.Ui.Controls.TlButton();
            this._tbMatchedCourse = new TransferLogger.Ui.Controls.TlTextBox();
            this._lEvaluator = new System.Windows.Forms.Label();
            this._pnlCourses = new System.Windows.Forms.Panel();
            this._gridCourses = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseHistorical = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._lInstructions = new System.Windows.Forms.Label();
            this._lEvaluations = new System.Windows.Forms.Label();
            this._gridHistoricalEvaluations = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchedCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._pnlTop.SuspendLayout();
            this._pnlEvaluationDetails.SuspendLayout();
            this._pnlCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridHistoricalEvaluations)).BeginInit();
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
            this._splitContainer.Panel1.Controls.Add(this._pnlTop);
            this._splitContainer.Panel1.Controls.Add(this._lInstructions);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel2.Controls.Add(this._lEvaluations);
            this._splitContainer.Panel2.Controls.Add(this._gridHistoricalEvaluations);
            this._splitContainer.Size = new System.Drawing.Size(933, 639);
            this._splitContainer.SplitterDistance = 261;
            this._splitContainer.TabIndex = 1;
            // 
            // _pnlTop
            // 
            this._pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlTop.Controls.Add(this._pnlEvaluationDetails);
            this._pnlTop.Controls.Add(this._pnlCourses);
            this._pnlTop.Location = new System.Drawing.Point(13, 55);
            this._pnlTop.Name = "_pnlTop";
            this._pnlTop.Size = new System.Drawing.Size(903, 195);
            this._pnlTop.TabIndex = 68;
            // 
            // _pnlEvaluationDetails
            // 
            this._pnlEvaluationDetails.Controls.Add(this._lStudent);
            this._pnlEvaluationDetails.Controls.Add(this._tbComment);
            this._pnlEvaluationDetails.Controls.Add(this._btnViewApplication);
            this._pnlEvaluationDetails.Controls.Add(this._lMatchedCourse);
            this._pnlEvaluationDetails.Controls.Add(this._lComment);
            this._pnlEvaluationDetails.Controls.Add(this._tbStudent);
            this._pnlEvaluationDetails.Controls.Add(this._tbEvaluator);
            this._pnlEvaluationDetails.Controls.Add(this._btnViewMatchedCourse);
            this._pnlEvaluationDetails.Controls.Add(this._tbMatchedCourse);
            this._pnlEvaluationDetails.Controls.Add(this._lEvaluator);
            this._pnlEvaluationDetails.Location = new System.Drawing.Point(437, -1);
            this._pnlEvaluationDetails.Name = "_pnlEvaluationDetails";
            this._pnlEvaluationDetails.Size = new System.Drawing.Size(465, 195);
            this._pnlEvaluationDetails.TabIndex = 68;
            // 
            // _lStudent
            // 
            this._lStudent.AutoSize = true;
            this._lStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lStudent.Location = new System.Drawing.Point(64, 49);
            this._lStudent.Name = "_lStudent";
            this._lStudent.Size = new System.Drawing.Size(55, 17);
            this._lStudent.TabIndex = 55;
            this._lStudent.Text = "Student:";
            // 
            // _tbComment
            // 
            this._tbComment.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbComment.BoxWidth = 325;
            this._tbComment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbComment.ForeColor = System.Drawing.Color.Black;
            this._tbComment.Location = new System.Drawing.Point(125, 110);
            this._tbComment.Name = "_tbComment";
            this._tbComment.ReadOnly = true;
            this._tbComment.Size = new System.Drawing.Size(325, 25);
            this._tbComment.TabIndex = 50;
            // 
            // _btnViewApplication
            // 
            this._btnViewApplication.BackColor = System.Drawing.Color.White;
            this._btnViewApplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnViewApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnViewApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnViewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnViewApplication.ForeColor = System.Drawing.Color.Black;
            this._btnViewApplication.Location = new System.Drawing.Point(331, 142);
            this._btnViewApplication.Name = "_btnViewApplication";
            this._btnViewApplication.Size = new System.Drawing.Size(119, 29);
            this._btnViewApplication.TabIndex = 65;
            this._btnViewApplication.TabStop = false;
            this._btnViewApplication.Text = "View Application";
            this._btnViewApplication.UseVisualStyleBackColor = false;
            // 
            // _lMatchedCourse
            // 
            this._lMatchedCourse.AutoSize = true;
            this._lMatchedCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lMatchedCourse.Location = new System.Drawing.Point(12, 17);
            this._lMatchedCourse.Name = "_lMatchedCourse";
            this._lMatchedCourse.Size = new System.Drawing.Size(107, 17);
            this._lMatchedCourse.TabIndex = 49;
            this._lMatchedCourse.Text = "Matched Course:";
            // 
            // _lComment
            // 
            this._lComment.AutoSize = true;
            this._lComment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lComment.Location = new System.Drawing.Point(54, 113);
            this._lComment.Name = "_lComment";
            this._lComment.Size = new System.Drawing.Size(67, 17);
            this._lComment.TabIndex = 51;
            this._lComment.Text = "Comment:";
            // 
            // _tbStudent
            // 
            this._tbStudent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbStudent.BoxWidth = 325;
            this._tbStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbStudent.ForeColor = System.Drawing.Color.Black;
            this._tbStudent.Location = new System.Drawing.Point(125, 46);
            this._tbStudent.Name = "_tbStudent";
            this._tbStudent.ReadOnly = true;
            this._tbStudent.Size = new System.Drawing.Size(325, 25);
            this._tbStudent.TabIndex = 54;
            // 
            // _tbEvaluator
            // 
            this._tbEvaluator.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbEvaluator.BoxWidth = 325;
            this._tbEvaluator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbEvaluator.ForeColor = System.Drawing.Color.Black;
            this._tbEvaluator.Location = new System.Drawing.Point(125, 78);
            this._tbEvaluator.Name = "_tbEvaluator";
            this._tbEvaluator.ReadOnly = true;
            this._tbEvaluator.Size = new System.Drawing.Size(325, 25);
            this._tbEvaluator.TabIndex = 56;
            // 
            // _btnViewMatchedCourse
            // 
            this._btnViewMatchedCourse.BackColor = System.Drawing.Color.White;
            this._btnViewMatchedCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnViewMatchedCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnViewMatchedCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnViewMatchedCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnViewMatchedCourse.ForeColor = System.Drawing.Color.Black;
            this._btnViewMatchedCourse.Location = new System.Drawing.Point(421, 14);
            this._btnViewMatchedCourse.Name = "_btnViewMatchedCourse";
            this._btnViewMatchedCourse.Size = new System.Drawing.Size(29, 25);
            this._btnViewMatchedCourse.TabIndex = 47;
            this._btnViewMatchedCourse.TabStop = false;
            this._btnViewMatchedCourse.Text = "...";
            this._btnViewMatchedCourse.UseVisualStyleBackColor = false;
            // 
            // _tbMatchedCourse
            // 
            this._tbMatchedCourse.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbMatchedCourse.BoxWidth = 325;
            this._tbMatchedCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbMatchedCourse.ForeColor = System.Drawing.Color.Black;
            this._tbMatchedCourse.Location = new System.Drawing.Point(125, 14);
            this._tbMatchedCourse.Name = "_tbMatchedCourse";
            this._tbMatchedCourse.ReadOnly = true;
            this._tbMatchedCourse.Size = new System.Drawing.Size(290, 25);
            this._tbMatchedCourse.TabIndex = 48;
            // 
            // _lEvaluator
            // 
            this._lEvaluator.AutoSize = true;
            this._lEvaluator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEvaluator.Location = new System.Drawing.Point(54, 81);
            this._lEvaluator.Name = "_lEvaluator";
            this._lEvaluator.Size = new System.Drawing.Size(65, 17);
            this._lEvaluator.TabIndex = 57;
            this._lEvaluator.Text = "Evaluator:";
            // 
            // _pnlCourses
            // 
            this._pnlCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlCourses.Controls.Add(this._gridCourses);
            this._pnlCourses.Location = new System.Drawing.Point(-1, -1);
            this._pnlCourses.Name = "_pnlCourses";
            this._pnlCourses.Size = new System.Drawing.Size(432, 195);
            this._pnlCourses.TabIndex = 67;
            // 
            // _gridCourses
            // 
            this._gridCourses.AllowUserToAddRows = false;
            this._gridCourses.AllowUserToDeleteRows = false;
            this._gridCourses.AllowUserToOrderColumns = true;
            this._gridCourses.AllowUserToResizeRows = false;
            this._gridCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridCourses.BackgroundColor = System.Drawing.Color.White;
            this._gridCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gridCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._gridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.UseHistorical});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridCourses.DefaultCellStyle = dataGridViewCellStyle2;
            this._gridCourses.EnableHeadersVisualStyles = false;
            this._gridCourses.Location = new System.Drawing.Point(-1, -1);
            this._gridCourses.Name = "_gridCourses";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._gridCourses.RowHeadersVisible = false;
            this._gridCourses.RowTemplate.Height = 25;
            this._gridCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridCourses.Size = new System.Drawing.Size(432, 195);
            this._gridCourses.TabIndex = 66;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.FillWeight = 105F;
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 225;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // UseHistorical
            // 
            this.UseHistorical.DataPropertyName = "UseHistorical";
            this.UseHistorical.FillWeight = 30.45685F;
            this.UseHistorical.HeaderText = "Use Historical";
            this.UseHistorical.MinimumWidth = 30;
            this.UseHistorical.Name = "UseHistorical";
            this.UseHistorical.ReadOnly = true;
            // 
            // _lInstructions
            // 
            this._lInstructions.AutoSize = true;
            this._lInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lInstructions.ForeColor = System.Drawing.Color.Black;
            this._lInstructions.Location = new System.Drawing.Point(40, 19);
            this._lInstructions.Name = "_lInstructions";
            this._lInstructions.Size = new System.Drawing.Size(541, 17);
            this._lInstructions.TabIndex = 40;
            this._lInstructions.Text = "There were historical evaluations found for some courses, you can re-use them or " +
    "continue.";
            // 
            // _lEvaluations
            // 
            this._lEvaluations.BackColor = System.Drawing.Color.AliceBlue;
            this._lEvaluations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lEvaluations.Dock = System.Windows.Forms.DockStyle.Top;
            this._lEvaluations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEvaluations.Location = new System.Drawing.Point(0, 0);
            this._lEvaluations.Name = "_lEvaluations";
            this._lEvaluations.Size = new System.Drawing.Size(933, 21);
            this._lEvaluations.TabIndex = 11;
            this._lEvaluations.Text = "Historical Evaluations";
            this._lEvaluations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gridHistoricalEvaluations
            // 
            this._gridHistoricalEvaluations.AllowUserToAddRows = false;
            this._gridHistoricalEvaluations.AllowUserToDeleteRows = false;
            this._gridHistoricalEvaluations.AllowUserToOrderColumns = true;
            this._gridHistoricalEvaluations.AllowUserToResizeRows = false;
            this._gridHistoricalEvaluations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridHistoricalEvaluations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridHistoricalEvaluations.BackgroundColor = System.Drawing.Color.White;
            this._gridHistoricalEvaluations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gridHistoricalEvaluations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridHistoricalEvaluations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._gridHistoricalEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridHistoricalEvaluations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Status,
            this.Student,
            this.Instructor,
            this.MatchedCourse});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridHistoricalEvaluations.DefaultCellStyle = dataGridViewCellStyle5;
            this._gridHistoricalEvaluations.EnableHeadersVisualStyles = false;
            this._gridHistoricalEvaluations.Location = new System.Drawing.Point(0, 20);
            this._gridHistoricalEvaluations.MultiSelect = false;
            this._gridHistoricalEvaluations.Name = "_gridHistoricalEvaluations";
            this._gridHistoricalEvaluations.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridHistoricalEvaluations.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._gridHistoricalEvaluations.RowHeadersVisible = false;
            this._gridHistoricalEvaluations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridHistoricalEvaluations.Size = new System.Drawing.Size(933, 353);
            this._gridHistoricalEvaluations.TabIndex = 10;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 90F;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 70;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StatusDisplayName";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 100;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.FillWeight = 105F;
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 200;
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Instructor
            // 
            this.Instructor.DataPropertyName = "Instructor";
            this.Instructor.HeaderText = "Evaluator";
            this.Instructor.MinimumWidth = 150;
            this.Instructor.Name = "Instructor";
            this.Instructor.ReadOnly = true;
            // 
            // MatchedCourse
            // 
            this.MatchedCourse.DataPropertyName = "MatchedCourse";
            this.MatchedCourse.HeaderText = "Matched Course";
            this.MatchedCourse.MinimumWidth = 200;
            this.MatchedCourse.Name = "MatchedCourse";
            this.MatchedCourse.ReadOnly = true;
            // 
            // HistoricalEvaluationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._splitContainer);
            this.Name = "HistoricalEvaluationsControl";
            this.Size = new System.Drawing.Size(933, 639);
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel1.PerformLayout();
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._pnlTop.ResumeLayout(false);
            this._pnlEvaluationDetails.ResumeLayout(false);
            this._pnlEvaluationDetails.PerformLayout();
            this._pnlCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridHistoricalEvaluations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TlSplitContainer _splitContainer;
        private System.Windows.Forms.Label _lInstructions;
        private TlDataGrid _gridHistoricalEvaluations;
        private System.Windows.Forms.Label _lEvaluations;
        private TlTextBox _tbMatchedCourse;
        private System.Windows.Forms.Label _lMatchedCourse;
        private TlButton _btnViewMatchedCourse;
        private TlTextBox _tbComment;
        private System.Windows.Forms.Label _lComment;
        private System.Windows.Forms.Label _lStudent;
        private TlTextBox _tbStudent;
        private TlButton _btnViewApplication;
        private System.Windows.Forms.Label _lEvaluator;
        private TlTextBox _tbEvaluator;
        private System.Windows.Forms.Panel _pnlCourses;
        private TlDataGrid _gridCourses;
        private System.Windows.Forms.Panel _pnlTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UseHistorical;
        private System.Windows.Forms.Panel _pnlEvaluationDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchedCourse;
    }
}
