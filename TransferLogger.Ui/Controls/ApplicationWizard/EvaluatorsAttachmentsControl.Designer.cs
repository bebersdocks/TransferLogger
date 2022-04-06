namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    partial class EvaluatorsAttachmentsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this._pnlAttachments = new System.Windows.Forms.Panel();
            this._btnBrowseExcelLocation = new TransferLogger.Ui.Controls.TlButton();
            this._btnDeleteAttachment = new TransferLogger.Ui.Controls.TlButton();
            this._btnEditAttachment = new TransferLogger.Ui.Controls.TlButton();
            this._btnAddAttachment = new TransferLogger.Ui.Controls.TlButton();
            this._lAttachments = new System.Windows.Forms.Label();
            this._lbAttachments = new System.Windows.Forms.ListBox();
            this._tbExcelLocation = new TransferLogger.Ui.Controls.TlTextBox();
            this._lInstructions = new System.Windows.Forms.Label();
            this._lExcelLocation = new System.Windows.Forms.Label();
            this.tlDataGrid2 = new TransferLogger.Ui.Controls.TlDataGrid();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuggestedCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlDataGrid1 = new TransferLogger.Ui.Controls.TlDataGrid();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
            this._lCourses = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._pnlEvaluator.SuspendLayout();
            this._pnlAttachments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlDataGrid1)).BeginInit();
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
            this._splitContainer.Panel1.Controls.Add(this._pnlAttachments);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel2.Controls.Add(this.tlDataGrid2);
            this._splitContainer.Panel2.Controls.Add(this.tlDataGrid1);
            this._splitContainer.Panel2.Controls.Add(this._grid);
            this._splitContainer.Panel2.Controls.Add(this._lCourses);
            this._splitContainer.Size = new System.Drawing.Size(935, 590);
            this._splitContainer.SplitterDistance = 309;
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
            this._pnlEvaluator.Location = new System.Drawing.Point(0, 177);
            this._pnlEvaluator.Name = "_pnlEvaluator";
            this._pnlEvaluator.Size = new System.Drawing.Size(935, 132);
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
            this._lInstructionsEvaluator.Size = new System.Drawing.Size(354, 17);
            this._lInstructionsEvaluator.TabIndex = 51;
            this._lInstructionsEvaluator.Text = "Assign transfer evaluator and set suggested course (if any).";
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
            // _pnlAttachments
            // 
            this._pnlAttachments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlAttachments.Controls.Add(this._btnBrowseExcelLocation);
            this._pnlAttachments.Controls.Add(this._btnDeleteAttachment);
            this._pnlAttachments.Controls.Add(this._btnEditAttachment);
            this._pnlAttachments.Controls.Add(this._btnAddAttachment);
            this._pnlAttachments.Controls.Add(this._lAttachments);
            this._pnlAttachments.Controls.Add(this._lbAttachments);
            this._pnlAttachments.Controls.Add(this._tbExcelLocation);
            this._pnlAttachments.Controls.Add(this._lInstructions);
            this._pnlAttachments.Controls.Add(this._lExcelLocation);
            this._pnlAttachments.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlAttachments.Location = new System.Drawing.Point(0, 0);
            this._pnlAttachments.Name = "_pnlAttachments";
            this._pnlAttachments.Size = new System.Drawing.Size(935, 177);
            this._pnlAttachments.TabIndex = 47;
            // 
            // _btnBrowseExcelLocation
            // 
            this._btnBrowseExcelLocation.AutoSize = true;
            this._btnBrowseExcelLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnBrowseExcelLocation.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnBrowseExcelLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnBrowseExcelLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnBrowseExcelLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBrowseExcelLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnBrowseExcelLocation.ForeColor = System.Drawing.Color.Black;
            this._btnBrowseExcelLocation.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnBrowseExcelLocation.Location = new System.Drawing.Point(476, 48);
            this._btnBrowseExcelLocation.MaximumSize = new System.Drawing.Size(0, 25);
            this._btnBrowseExcelLocation.MinimumSize = new System.Drawing.Size(0, 25);
            this._btnBrowseExcelLocation.Name = "_btnBrowseExcelLocation";
            this._btnBrowseExcelLocation.Size = new System.Drawing.Size(28, 25);
            this._btnBrowseExcelLocation.TabIndex = 65;
            this._btnBrowseExcelLocation.TabStop = false;
            this._btnBrowseExcelLocation.Text = "...";
            this._btnBrowseExcelLocation.UseVisualStyleBackColor = false;
            // 
            // _btnDeleteAttachment
            // 
            this._btnDeleteAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDeleteAttachment.AutoSize = true;
            this._btnDeleteAttachment.BackColor = System.Drawing.Color.Transparent;
            this._btnDeleteAttachment.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.delete;
            this._btnDeleteAttachment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnDeleteAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDeleteAttachment.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnDeleteAttachment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnDeleteAttachment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnDeleteAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDeleteAttachment.ForeColor = System.Drawing.Color.Black;
            this._btnDeleteAttachment.HoverColor = System.Drawing.Color.Transparent;
            this._btnDeleteAttachment.Location = new System.Drawing.Point(552, 79);
            this._btnDeleteAttachment.Name = "_btnDeleteAttachment";
            this._btnDeleteAttachment.Size = new System.Drawing.Size(32, 32);
            this._btnDeleteAttachment.TabIndex = 64;
            this._btnDeleteAttachment.TabStop = false;
            this._btnDeleteAttachment.UseVisualStyleBackColor = false;
            // 
            // _btnEditAttachment
            // 
            this._btnEditAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnEditAttachment.AutoSize = true;
            this._btnEditAttachment.BackColor = System.Drawing.Color.Transparent;
            this._btnEditAttachment.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.edit;
            this._btnEditAttachment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnEditAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnEditAttachment.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnEditAttachment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnEditAttachment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnEditAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEditAttachment.ForeColor = System.Drawing.Color.Black;
            this._btnEditAttachment.HoverColor = System.Drawing.Color.Transparent;
            this._btnEditAttachment.Location = new System.Drawing.Point(514, 79);
            this._btnEditAttachment.Name = "_btnEditAttachment";
            this._btnEditAttachment.Size = new System.Drawing.Size(32, 32);
            this._btnEditAttachment.TabIndex = 63;
            this._btnEditAttachment.TabStop = false;
            this._btnEditAttachment.UseVisualStyleBackColor = false;
            // 
            // _btnAddAttachment
            // 
            this._btnAddAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAddAttachment.AutoSize = true;
            this._btnAddAttachment.BackColor = System.Drawing.Color.Transparent;
            this._btnAddAttachment.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.add;
            this._btnAddAttachment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAddAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnAddAttachment.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnAddAttachment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnAddAttachment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnAddAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAddAttachment.ForeColor = System.Drawing.Color.Black;
            this._btnAddAttachment.HoverColor = System.Drawing.Color.Transparent;
            this._btnAddAttachment.Location = new System.Drawing.Point(476, 79);
            this._btnAddAttachment.Name = "_btnAddAttachment";
            this._btnAddAttachment.Size = new System.Drawing.Size(32, 32);
            this._btnAddAttachment.TabIndex = 62;
            this._btnAddAttachment.TabStop = false;
            this._btnAddAttachment.UseVisualStyleBackColor = false;
            // 
            // _lAttachments
            // 
            this._lAttachments.AutoSize = true;
            this._lAttachments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lAttachments.Location = new System.Drawing.Point(57, 79);
            this._lAttachments.Name = "_lAttachments";
            this._lAttachments.Size = new System.Drawing.Size(82, 17);
            this._lAttachments.TabIndex = 61;
            this._lAttachments.Text = "Attachments:";
            // 
            // _lbAttachments
            // 
            this._lbAttachments.FormattingEnabled = true;
            this._lbAttachments.ItemHeight = 15;
            this._lbAttachments.Location = new System.Drawing.Point(145, 79);
            this._lbAttachments.Name = "_lbAttachments";
            this._lbAttachments.Size = new System.Drawing.Size(325, 79);
            this._lbAttachments.TabIndex = 60;
            // 
            // _tbExcelLocation
            // 
            this._tbExcelLocation.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbExcelLocation.BoxWidth = 325;
            this._tbExcelLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbExcelLocation.ForeColor = System.Drawing.Color.Black;
            this._tbExcelLocation.Location = new System.Drawing.Point(145, 48);
            this._tbExcelLocation.Name = "_tbExcelLocation";
            this._tbExcelLocation.ReadOnly = true;
            this._tbExcelLocation.Size = new System.Drawing.Size(325, 25);
            this._tbExcelLocation.TabIndex = 59;
            // 
            // _lInstructions
            // 
            this._lInstructions.AutoSize = true;
            this._lInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lInstructions.ForeColor = System.Drawing.Color.Black;
            this._lInstructions.Location = new System.Drawing.Point(57, 14);
            this._lInstructions.Name = "_lInstructions";
            this._lInstructions.Size = new System.Drawing.Size(325, 17);
            this._lInstructions.TabIndex = 40;
            this._lInstructions.Text = "Set excel location and/or add application attachments.";
            // 
            // _lExcelLocation
            // 
            this._lExcelLocation.AutoSize = true;
            this._lExcelLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lExcelLocation.Location = new System.Drawing.Point(46, 51);
            this._lExcelLocation.Name = "_lExcelLocation";
            this._lExcelLocation.Size = new System.Drawing.Size(93, 17);
            this._lExcelLocation.TabIndex = 30;
            this._lExcelLocation.Text = "Excel Location:";
            // 
            // tlDataGrid2
            // 
            this.tlDataGrid2.AllowUserToAddRows = false;
            this.tlDataGrid2.AllowUserToDeleteRows = false;
            this.tlDataGrid2.AllowUserToOrderColumns = true;
            this.tlDataGrid2.AllowUserToResizeRows = false;
            this.tlDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tlDataGrid2.BackgroundColor = System.Drawing.Color.White;
            this.tlDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlDataGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tlDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tlDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.SuggestedCourse});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tlDataGrid2.DefaultCellStyle = dataGridViewCellStyle11;
            this.tlDataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDataGrid2.EnableHeadersVisualStyles = false;
            this.tlDataGrid2.Location = new System.Drawing.Point(0, 21);
            this.tlDataGrid2.MultiSelect = false;
            this.tlDataGrid2.Name = "tlDataGrid2";
            this.tlDataGrid2.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tlDataGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.tlDataGrid2.RowHeadersVisible = false;
            this.tlDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tlDataGrid2.Size = new System.Drawing.Size(935, 256);
            this.tlDataGrid2.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.FillWeight = 95F;
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.FillWeight = 115F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Program";
            this.dataGridViewTextBoxColumn7.HeaderText = "Program";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 140;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Evaluator";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // SuggestedCourse
            // 
            this.SuggestedCourse.HeaderText = "Suggested Course";
            this.SuggestedCourse.Name = "SuggestedCourse";
            this.SuggestedCourse.ReadOnly = true;
            // 
            // tlDataGrid1
            // 
            this.tlDataGrid1.AllowUserToAddRows = false;
            this.tlDataGrid1.AllowUserToDeleteRows = false;
            this.tlDataGrid1.AllowUserToOrderColumns = true;
            this.tlDataGrid1.AllowUserToResizeRows = false;
            this.tlDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tlDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.tlDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tlDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tlDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tlDataGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.tlDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDataGrid1.EnableHeadersVisualStyles = false;
            this.tlDataGrid1.Location = new System.Drawing.Point(0, 21);
            this.tlDataGrid1.MultiSelect = false;
            this.tlDataGrid1.Name = "tlDataGrid1";
            this.tlDataGrid1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tlDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tlDataGrid1.RowHeadersVisible = false;
            this.tlDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tlDataGrid1.Size = new System.Drawing.Size(935, 256);
            this.tlDataGrid1.TabIndex = 13;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.DefaultCellStyle = dataGridViewCellStyle17;
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.EnableHeadersVisualStyles = false;
            this._grid.Location = new System.Drawing.Point(0, 21);
            this._grid.MultiSelect = false;
            this._grid.Name = "_grid";
            this._grid.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this._grid.RowHeadersVisible = false;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(935, 256);
            this._grid.TabIndex = 12;
            // 
            // _lCourses
            // 
            this._lCourses.BackColor = System.Drawing.Color.AliceBlue;
            this._lCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this._lCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCourses.Location = new System.Drawing.Point(0, 0);
            this._lCourses.Name = "_lCourses";
            this._lCourses.Size = new System.Drawing.Size(935, 21);
            this._lCourses.TabIndex = 11;
            this._lCourses.Text = "Courses";
            this._lCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 95F;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 70;
            this.Id.Name = "Id";
            this.Id.Width = 169;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "Name";
            this.CourseName.FillWeight = 115F;
            this.CourseName.HeaderText = "Name";
            this.CourseName.MinimumWidth = 250;
            this.CourseName.Name = "CourseName";
            this.CourseName.Width = 250;
            // 
            // Program
            // 
            this.Program.DataPropertyName = "Program";
            this.Program.HeaderText = "Program";
            this.Program.MinimumWidth = 140;
            this.Program.Name = "Program";
            this.Program.Width = 178;
            // 
            // Cycle
            // 
            this.Cycle.DataPropertyName = "Cycle";
            this.Cycle.FillWeight = 90F;
            this.Cycle.HeaderText = "Cycle";
            this.Cycle.MinimumWidth = 40;
            this.Cycle.Name = "Cycle";
            this.Cycle.Width = 160;
            // 
            // Evaluator
            // 
            this.Evaluator.HeaderText = "Evaluator";
            this.Evaluator.Name = "Evaluator";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 95F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 167;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.FillWeight = 115F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 266;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Program";
            this.dataGridViewTextBoxColumn3.HeaderText = "Program";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 140;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Evaluator";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // EvaluatorsAttachmentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._splitContainer);
            this.Name = "EvaluatorsAttachmentsControl";
            this.Size = new System.Drawing.Size(935, 590);
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._pnlEvaluator.ResumeLayout(false);
            this._pnlEvaluator.PerformLayout();
            this._pnlAttachments.ResumeLayout(false);
            this._pnlAttachments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TlSplitContainer _splitContainer;
        private System.Windows.Forms.Label _lInstructions;
        private System.Windows.Forms.Label _lCourses;
        private TlDataGrid _grid;
        private System.Windows.Forms.Panel _pnlAttachments;
        private System.Windows.Forms.Label _lExcelLocation;
        private TlDropDownList _cbEvaluators;
        private System.Windows.Forms.Label _lEvaluator;
        private TlButton _btnSelectEvaluator;
        private System.Windows.Forms.CheckBox _cbSendEmailNotification;
        private System.Windows.Forms.Label _lInstructionsEvaluator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluator;
        private TlDataGrid tlDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TlDataGrid tlDataGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuggestedCourse;
        private TlButton _btnSelectSuggestedCourse;
        private TlDropDownList _cbSuggestedCourses;
        private System.Windows.Forms.Label _lSuggested;
        private System.Windows.Forms.ListBox _lbAttachments;
        private TlTextBox _tbExcelLocation;
        private System.Windows.Forms.Panel _pnlEvaluator;
        private System.Windows.Forms.Label _lAttachments;
        private TlButton _btnDeleteAttachment;
        private TlButton _btnEditAttachment;
        private TlButton _btnAddAttachment;
        private TlButton _btnBrowseExcelLocation;
    }
}
