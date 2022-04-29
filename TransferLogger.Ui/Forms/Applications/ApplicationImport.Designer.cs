namespace TransferLogger.Ui.Forms.Applications
{
    partial class ApplicationImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationImport));
            this._pnlNewState = new System.Windows.Forms.Panel();
            this._lHorizontalLineImportResults = new System.Windows.Forms.Label();
            this._lImportResults = new System.Windows.Forms.Label();
            this._gridImportResults = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Course2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluator2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuggestedCourse2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchedCourse2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._pnlCurrentEvaluations = new System.Windows.Forms.Panel();
            this._lHorizontalLineEvaluations = new System.Windows.Forms.Label();
            this._lEvaluations = new System.Windows.Forms.Label();
            this._gridEvaluations = new TransferLogger.Ui.Controls.TlDataGrid();
            this._tbTargetProgram = new TransferLogger.Ui.Controls.TlTextBox();
            this._lTargetProgram = new System.Windows.Forms.Label();
            this._lCurrently = new System.Windows.Forms.Label();
            this._tbOrganization = new TransferLogger.Ui.Controls.TlTextBox();
            this._lOrganization = new System.Windows.Forms.Label();
            this._tbStudent = new TransferLogger.Ui.Controls.TlTextBox();
            this._lStudent = new System.Windows.Forms.Label();
            this._tbApplication = new TransferLogger.Ui.Controls.TlTextBox();
            this._lApplication = new System.Windows.Forms.Label();
            this._lAfter = new System.Windows.Forms.Label();
            this._btnCancel = new TransferLogger.Ui.Controls.TlButton();
            this._btnAccept = new TransferLogger.Ui.Controls.TlButton();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuggestedCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchedCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._pnlNewState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridImportResults)).BeginInit();
            this._pnlCurrentEvaluations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridEvaluations)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnlNewState
            // 
            this._pnlNewState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlNewState.Controls.Add(this._lHorizontalLineImportResults);
            this._pnlNewState.Controls.Add(this._lImportResults);
            this._pnlNewState.Controls.Add(this._gridImportResults);
            this._pnlNewState.Location = new System.Drawing.Point(26, 347);
            this._pnlNewState.Name = "_pnlNewState";
            this._pnlNewState.Size = new System.Drawing.Size(889, 200);
            this._pnlNewState.TabIndex = 0;
            // 
            // _lHorizontalLineImportResults
            // 
            this._lHorizontalLineImportResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lHorizontalLineImportResults.Dock = System.Windows.Forms.DockStyle.Top;
            this._lHorizontalLineImportResults.Location = new System.Drawing.Point(0, 20);
            this._lHorizontalLineImportResults.Name = "_lHorizontalLineImportResults";
            this._lHorizontalLineImportResults.Size = new System.Drawing.Size(887, 1);
            this._lHorizontalLineImportResults.TabIndex = 21;
            // 
            // _lImportResults
            // 
            this._lImportResults.BackColor = System.Drawing.Color.AliceBlue;
            this._lImportResults.Dock = System.Windows.Forms.DockStyle.Top;
            this._lImportResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lImportResults.Location = new System.Drawing.Point(0, 0);
            this._lImportResults.Name = "_lImportResults";
            this._lImportResults.Size = new System.Drawing.Size(887, 20);
            this._lImportResults.TabIndex = 20;
            this._lImportResults.Text = "Import Result";
            this._lImportResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gridImportResults
            // 
            this._gridImportResults.AllowUserToAddRows = false;
            this._gridImportResults.AllowUserToDeleteRows = false;
            this._gridImportResults.AllowUserToOrderColumns = true;
            this._gridImportResults.AllowUserToResizeRows = false;
            this._gridImportResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridImportResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridImportResults.BackgroundColor = System.Drawing.Color.White;
            this._gridImportResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gridImportResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridImportResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._gridImportResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridImportResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course2,
            this.Evaluator2,
            this.SuggestedCourse2,
            this.MatchedCourse2,
            this.Status2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridImportResults.DefaultCellStyle = dataGridViewCellStyle2;
            this._gridImportResults.EnableHeadersVisualStyles = false;
            this._gridImportResults.Location = new System.Drawing.Point(-2, 20);
            this._gridImportResults.MultiSelect = false;
            this._gridImportResults.Name = "_gridImportResults";
            this._gridImportResults.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridImportResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._gridImportResults.RowHeadersVisible = false;
            this._gridImportResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridImportResults.Size = new System.Drawing.Size(890, 179);
            this._gridImportResults.TabIndex = 19;
            // 
            // Course2
            // 
            this.Course2.DataPropertyName = "Course";
            this.Course2.HeaderText = "Course";
            this.Course2.Name = "Course2";
            this.Course2.ReadOnly = true;
            // 
            // Evaluator2
            // 
            this.Evaluator2.DataPropertyName = "Instructor";
            this.Evaluator2.HeaderText = "Evaluator";
            this.Evaluator2.Name = "Evaluator2";
            this.Evaluator2.ReadOnly = true;
            // 
            // SuggestedCourse2
            // 
            this.SuggestedCourse2.DataPropertyName = "SuggestedCourse";
            this.SuggestedCourse2.HeaderText = "Suggested Course";
            this.SuggestedCourse2.Name = "SuggestedCourse2";
            this.SuggestedCourse2.ReadOnly = true;
            // 
            // MatchedCourse2
            // 
            this.MatchedCourse2.DataPropertyName = "MatchedCourse";
            this.MatchedCourse2.HeaderText = "Matched Course";
            this.MatchedCourse2.Name = "MatchedCourse2";
            this.MatchedCourse2.ReadOnly = true;
            // 
            // Status2
            // 
            this.Status2.DataPropertyName = "StatusDisplayName";
            this.Status2.HeaderText = "Status";
            this.Status2.Name = "Status2";
            this.Status2.ReadOnly = true;
            // 
            // _pnlCurrentEvaluations
            // 
            this._pnlCurrentEvaluations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlCurrentEvaluations.Controls.Add(this._lHorizontalLineEvaluations);
            this._pnlCurrentEvaluations.Controls.Add(this._lEvaluations);
            this._pnlCurrentEvaluations.Controls.Add(this._gridEvaluations);
            this._pnlCurrentEvaluations.Location = new System.Drawing.Point(25, 123);
            this._pnlCurrentEvaluations.Name = "_pnlCurrentEvaluations";
            this._pnlCurrentEvaluations.Size = new System.Drawing.Size(889, 180);
            this._pnlCurrentEvaluations.TabIndex = 1;
            // 
            // _lHorizontalLineEvaluations
            // 
            this._lHorizontalLineEvaluations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lHorizontalLineEvaluations.Dock = System.Windows.Forms.DockStyle.Top;
            this._lHorizontalLineEvaluations.Location = new System.Drawing.Point(0, 20);
            this._lHorizontalLineEvaluations.Name = "_lHorizontalLineEvaluations";
            this._lHorizontalLineEvaluations.Size = new System.Drawing.Size(887, 1);
            this._lHorizontalLineEvaluations.TabIndex = 21;
            // 
            // _lEvaluations
            // 
            this._lEvaluations.BackColor = System.Drawing.Color.AliceBlue;
            this._lEvaluations.Dock = System.Windows.Forms.DockStyle.Top;
            this._lEvaluations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEvaluations.Location = new System.Drawing.Point(0, 0);
            this._lEvaluations.Name = "_lEvaluations";
            this._lEvaluations.Size = new System.Drawing.Size(887, 20);
            this._lEvaluations.TabIndex = 20;
            this._lEvaluations.Text = "Detected Evaluations";
            this._lEvaluations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gridEvaluations
            // 
            this._gridEvaluations.AllowUserToAddRows = false;
            this._gridEvaluations.AllowUserToDeleteRows = false;
            this._gridEvaluations.AllowUserToOrderColumns = true;
            this._gridEvaluations.AllowUserToResizeRows = false;
            this._gridEvaluations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridEvaluations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridEvaluations.BackgroundColor = System.Drawing.Color.White;
            this._gridEvaluations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gridEvaluations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridEvaluations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._gridEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridEvaluations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.Evaluator,
            this.SuggestedCourse,
            this.MatchedCourse,
            this.Status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridEvaluations.DefaultCellStyle = dataGridViewCellStyle5;
            this._gridEvaluations.EnableHeadersVisualStyles = false;
            this._gridEvaluations.Location = new System.Drawing.Point(-1, 20);
            this._gridEvaluations.MultiSelect = false;
            this._gridEvaluations.Name = "_gridEvaluations";
            this._gridEvaluations.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridEvaluations.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._gridEvaluations.RowHeadersVisible = false;
            this._gridEvaluations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridEvaluations.Size = new System.Drawing.Size(890, 159);
            this._gridEvaluations.TabIndex = 19;
            // 
            // _tbTargetProgram
            // 
            this._tbTargetProgram.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbTargetProgram.BoxWidth = 325;
            this._tbTargetProgram.ForeColor = System.Drawing.Color.Black;
            this._tbTargetProgram.Location = new System.Drawing.Point(559, 23);
            this._tbTargetProgram.Name = "_tbTargetProgram";
            this._tbTargetProgram.ReadOnly = true;
            this._tbTargetProgram.Size = new System.Drawing.Size(325, 23);
            this._tbTargetProgram.TabIndex = 45;
            // 
            // _lTargetProgram
            // 
            this._lTargetProgram.AutoSize = true;
            this._lTargetProgram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lTargetProgram.Location = new System.Drawing.Point(462, 26);
            this._lTargetProgram.Name = "_lTargetProgram";
            this._lTargetProgram.Size = new System.Drawing.Size(91, 15);
            this._lTargetProgram.TabIndex = 49;
            this._lTargetProgram.Text = "Target Program:";
            // 
            // _lCurrently
            // 
            this._lCurrently.AutoSize = true;
            this._lCurrently.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCurrently.ForeColor = System.Drawing.Color.Black;
            this._lCurrently.Location = new System.Drawing.Point(25, 94);
            this._lCurrently.Name = "_lCurrently";
            this._lCurrently.Size = new System.Drawing.Size(295, 17);
            this._lCurrently.TabIndex = 48;
            this._lCurrently.Text = "Changes for following evaluations were detected:";
            // 
            // _tbOrganization
            // 
            this._tbOrganization.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbOrganization.BoxWidth = 325;
            this._tbOrganization.ForeColor = System.Drawing.Color.Black;
            this._tbOrganization.Location = new System.Drawing.Point(559, 52);
            this._tbOrganization.Name = "_tbOrganization";
            this._tbOrganization.ReadOnly = true;
            this._tbOrganization.Size = new System.Drawing.Size(325, 23);
            this._tbOrganization.TabIndex = 44;
            // 
            // _lOrganization
            // 
            this._lOrganization.AutoSize = true;
            this._lOrganization.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganization.Location = new System.Drawing.Point(475, 55);
            this._lOrganization.Name = "_lOrganization";
            this._lOrganization.Size = new System.Drawing.Size(78, 15);
            this._lOrganization.TabIndex = 47;
            this._lOrganization.Text = "Organization:";
            // 
            // _tbStudent
            // 
            this._tbStudent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbStudent.BoxWidth = 325;
            this._tbStudent.ForeColor = System.Drawing.Color.Black;
            this._tbStudent.Location = new System.Drawing.Point(101, 52);
            this._tbStudent.Name = "_tbStudent";
            this._tbStudent.Size = new System.Drawing.Size(325, 23);
            this._tbStudent.TabIndex = 43;
            // 
            // _lStudent
            // 
            this._lStudent.AutoSize = true;
            this._lStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lStudent.Location = new System.Drawing.Point(44, 55);
            this._lStudent.Name = "_lStudent";
            this._lStudent.Size = new System.Drawing.Size(51, 15);
            this._lStudent.TabIndex = 46;
            this._lStudent.Text = "Student:";
            // 
            // _tbApplication
            // 
            this._tbApplication.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbApplication.BoxWidth = 325;
            this._tbApplication.ForeColor = System.Drawing.Color.Black;
            this._tbApplication.Location = new System.Drawing.Point(101, 23);
            this._tbApplication.Name = "_tbApplication";
            this._tbApplication.Size = new System.Drawing.Size(325, 23);
            this._tbApplication.TabIndex = 50;
            // 
            // _lApplication
            // 
            this._lApplication.AutoSize = true;
            this._lApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lApplication.Location = new System.Drawing.Point(24, 26);
            this._lApplication.Name = "_lApplication";
            this._lApplication.Size = new System.Drawing.Size(71, 15);
            this._lApplication.TabIndex = 51;
            this._lApplication.Text = "Application:";
            // 
            // _lAfter
            // 
            this._lAfter.AutoSize = true;
            this._lAfter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lAfter.ForeColor = System.Drawing.Color.Black;
            this._lAfter.Location = new System.Drawing.Point(25, 317);
            this._lAfter.Name = "_lAfter";
            this._lAfter.Size = new System.Drawing.Size(231, 17);
            this._lAfter.TabIndex = 52;
            this._lAfter.Text = "After import, their state will change to:";
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
            this._btnCancel.Location = new System.Drawing.Point(759, 563);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 29);
            this._btnCancel.TabIndex = 54;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            // 
            // _btnAccept
            // 
            this._btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAccept.BackColor = System.Drawing.Color.White;
            this._btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAccept.ForeColor = System.Drawing.Color.Black;
            this._btnAccept.Location = new System.Drawing.Point(840, 563);
            this._btnAccept.Name = "_btnAccept";
            this._btnAccept.Size = new System.Drawing.Size(75, 29);
            this._btnAccept.TabIndex = 53;
            this._btnAccept.Text = "Accept";
            this._btnAccept.UseVisualStyleBackColor = false;
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
            // ApplicationImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(939, 604);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnAccept);
            this.Controls.Add(this._lAfter);
            this.Controls.Add(this._tbApplication);
            this.Controls.Add(this._lApplication);
            this.Controls.Add(this._tbTargetProgram);
            this.Controls.Add(this._lTargetProgram);
            this.Controls.Add(this._lCurrently);
            this.Controls.Add(this._tbOrganization);
            this.Controls.Add(this._lOrganization);
            this.Controls.Add(this._tbStudent);
            this.Controls.Add(this._lStudent);
            this.Controls.Add(this._pnlCurrentEvaluations);
            this.Controls.Add(this._pnlNewState);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationImport";
            this.Text = "Application Import";
            this._pnlNewState.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridImportResults)).EndInit();
            this._pnlCurrentEvaluations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridEvaluations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _pnlNewState;
        private System.Windows.Forms.Label _lImportResults;
        private Controls.TlDataGrid _gridImportResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuggestedCourse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchedCourse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status2;
        private System.Windows.Forms.Panel _pnlCurrentEvaluations;
        private System.Windows.Forms.Label _lEvaluations;
        private Controls.TlDataGrid _gridEvaluations;
        private Controls.TlTextBox _tbTargetProgram;
        private System.Windows.Forms.Label _lTargetProgram;
        private System.Windows.Forms.Label _lCurrently;
        private Controls.TlTextBox _tbOrganization;
        private System.Windows.Forms.Label _lOrganization;
        private Controls.TlTextBox _tbStudent;
        private System.Windows.Forms.Label _lStudent;
        private Controls.TlTextBox _tbApplication;
        private System.Windows.Forms.Label _lApplication;
        private System.Windows.Forms.Label _lAfter;
        private Controls.TlButton _btnCancel;
        private Controls.TlButton _btnAccept;
        private System.Windows.Forms.Label _lHorizontalLineEvaluations;
        private System.Windows.Forms.Label _lHorizontalLineImportResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluator;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuggestedCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchedCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}