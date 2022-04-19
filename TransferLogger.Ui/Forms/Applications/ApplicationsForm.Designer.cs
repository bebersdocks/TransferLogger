using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Applications
{
    partial class ApplicationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationsForm));
            this._splitContainerForm = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._pnlFilters = new System.Windows.Forms.Panel();
            this._btnSendEmail = new TransferLogger.Ui.Controls.TlButton();
            this._btnEditLocations = new TransferLogger.Ui.Controls.TlButton();
            this._btnExportExcel = new TransferLogger.Ui.Controls.TlButton();
            this._btnEdit = new TransferLogger.Ui.Controls.TlButton();
            this._btnAdd = new TransferLogger.Ui.Controls.TlButton();
            this._cbStatuses = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lStatus = new System.Windows.Forms.Label();
            this._lTo = new System.Windows.Forms.Label();
            this._dtTo = new System.Windows.Forms.DateTimePicker();
            this._lFrom = new System.Windows.Forms.Label();
            this._dtFrom = new System.Windows.Forms.DateTimePicker();
            this._lSearchStudent = new System.Windows.Forms.Label();
            this._tbSearchName = new TransferLogger.Ui.Controls.TlTextBox();
            this._btnSelectOrganization = new TransferLogger.Ui.Controls.TlButton();
            this._cbOrganizations = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lOrganization = new System.Windows.Forms.Label();
            this._menu = new System.Windows.Forms.MenuStrip();
            this._miOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this._miOrganizations = new System.Windows.Forms.ToolStripMenuItem();
            this._miPrograms = new System.Windows.Forms.ToolStripMenuItem();
            this._miCourses = new System.Windows.Forms.ToolStripMenuItem();
            this._miStudents = new System.Windows.Forms.ToolStripMenuItem();
            this._miInstructors = new System.Windows.Forms.ToolStripMenuItem();
            this._splitContainerBottom = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._pnlCourses = new System.Windows.Forms.Panel();
            this._lApplications = new System.Windows.Forms.Label();
            this._gridApps = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._pnlApplications = new System.Windows.Forms.Panel();
            this._lAppCourses = new System.Windows.Forms.Label();
            this._gridAppCourses = new TransferLogger.Ui.Controls.TlDataGrid();
            this.CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerForm)).BeginInit();
            this._splitContainerForm.Panel1.SuspendLayout();
            this._splitContainerForm.Panel2.SuspendLayout();
            this._splitContainerForm.SuspendLayout();
            this._pnlFilters.SuspendLayout();
            this._menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerBottom)).BeginInit();
            this._splitContainerBottom.Panel1.SuspendLayout();
            this._splitContainerBottom.Panel2.SuspendLayout();
            this._splitContainerBottom.SuspendLayout();
            this._pnlCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridApps)).BeginInit();
            this._pnlApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridAppCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // _splitContainerForm
            // 
            this._splitContainerForm.BackColor = System.Drawing.Color.GhostWhite;
            this._splitContainerForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._splitContainerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerForm.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._splitContainerForm.IsSplitterFixed = true;
            this._splitContainerForm.Location = new System.Drawing.Point(0, 0);
            this._splitContainerForm.Name = "_splitContainerForm";
            this._splitContainerForm.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainerForm.Panel1
            // 
            this._splitContainerForm.Panel1.BackColor = System.Drawing.Color.White;
            this._splitContainerForm.Panel1.Controls.Add(this._pnlFilters);
            this._splitContainerForm.Panel1.Controls.Add(this._menu);
            // 
            // _splitContainerForm.Panel2
            // 
            this._splitContainerForm.Panel2.Controls.Add(this._splitContainerBottom);
            this._splitContainerForm.Size = new System.Drawing.Size(1234, 721);
            this._splitContainerForm.SplitterDistance = 144;
            this._splitContainerForm.TabIndex = 5;
            // 
            // _pnlFilters
            // 
            this._pnlFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlFilters.BackColor = System.Drawing.Color.White;
            this._pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlFilters.Controls.Add(this._btnSendEmail);
            this._pnlFilters.Controls.Add(this._btnEditLocations);
            this._pnlFilters.Controls.Add(this._btnExportExcel);
            this._pnlFilters.Controls.Add(this._btnEdit);
            this._pnlFilters.Controls.Add(this._btnAdd);
            this._pnlFilters.Controls.Add(this._cbStatuses);
            this._pnlFilters.Controls.Add(this._lStatus);
            this._pnlFilters.Controls.Add(this._lTo);
            this._pnlFilters.Controls.Add(this._dtTo);
            this._pnlFilters.Controls.Add(this._lFrom);
            this._pnlFilters.Controls.Add(this._dtFrom);
            this._pnlFilters.Controls.Add(this._lSearchStudent);
            this._pnlFilters.Controls.Add(this._tbSearchName);
            this._pnlFilters.Controls.Add(this._btnSelectOrganization);
            this._pnlFilters.Controls.Add(this._cbOrganizations);
            this._pnlFilters.Controls.Add(this._lOrganization);
            this._pnlFilters.Location = new System.Drawing.Point(-2, 24);
            this._pnlFilters.Name = "_pnlFilters";
            this._pnlFilters.Size = new System.Drawing.Size(1236, 117);
            this._pnlFilters.TabIndex = 1;
            // 
            // _btnSendEmail
            // 
            this._btnSendEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this._btnSendEmail.Location = new System.Drawing.Point(1149, 18);
            this._btnSendEmail.Name = "_btnSendEmail";
            this._btnSendEmail.Size = new System.Drawing.Size(32, 32);
            this._btnSendEmail.TabIndex = 38;
            this._btnSendEmail.TabStop = false;
            this._btnSendEmail.UseVisualStyleBackColor = false;
            // 
            // _btnEditLocations
            // 
            this._btnEditLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnEditLocations.AutoSize = true;
            this._btnEditLocations.BackColor = System.Drawing.Color.White;
            this._btnEditLocations.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.folder;
            this._btnEditLocations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnEditLocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnEditLocations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnEditLocations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnEditLocations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnEditLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEditLocations.ForeColor = System.Drawing.Color.Black;
            this._btnEditLocations.Location = new System.Drawing.Point(1187, 18);
            this._btnEditLocations.Name = "_btnEditLocations";
            this._btnEditLocations.Size = new System.Drawing.Size(32, 32);
            this._btnEditLocations.TabIndex = 37;
            this._btnEditLocations.TabStop = false;
            this._btnEditLocations.UseVisualStyleBackColor = false;
            // 
            // _btnExportExcel
            // 
            this._btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this._btnExportExcel.Location = new System.Drawing.Point(1111, 18);
            this._btnExportExcel.Name = "_btnExportExcel";
            this._btnExportExcel.Size = new System.Drawing.Size(32, 32);
            this._btnExportExcel.TabIndex = 36;
            this._btnExportExcel.TabStop = false;
            this._btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // _btnEdit
            // 
            this._btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnEdit.AutoSize = true;
            this._btnEdit.BackColor = System.Drawing.Color.White;
            this._btnEdit.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.edit;
            this._btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEdit.ForeColor = System.Drawing.Color.Black;
            this._btnEdit.Location = new System.Drawing.Point(1073, 18);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(32, 32);
            this._btnEdit.TabIndex = 34;
            this._btnEdit.TabStop = false;
            this._btnEdit.UseVisualStyleBackColor = false;
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAdd.AutoSize = true;
            this._btnAdd.BackColor = System.Drawing.Color.White;
            this._btnAdd.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.add;
            this._btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAdd.ForeColor = System.Drawing.Color.Black;
            this._btnAdd.Location = new System.Drawing.Point(1035, 18);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(32, 32);
            this._btnAdd.TabIndex = 33;
            this._btnAdd.TabStop = false;
            this._btnAdd.UseVisualStyleBackColor = false;
            // 
            // _cbStatuses
            // 
            this._cbStatuses.BackColor = System.Drawing.Color.GhostWhite;
            this._cbStatuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbStatuses.FormattingEnabled = true;
            this._cbStatuses.Location = new System.Drawing.Point(531, 48);
            this._cbStatuses.Name = "_cbStatuses";
            this._cbStatuses.Size = new System.Drawing.Size(325, 23);
            this._cbStatuses.TabIndex = 31;
            // 
            // _lStatus
            // 
            this._lStatus.AutoSize = true;
            this._lStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lStatus.Location = new System.Drawing.Point(479, 49);
            this._lStatus.Name = "_lStatus";
            this._lStatus.Size = new System.Drawing.Size(46, 17);
            this._lStatus.TabIndex = 32;
            this._lStatus.Text = "Status:";
            // 
            // _lTo
            // 
            this._lTo.AutoSize = true;
            this._lTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lTo.Location = new System.Drawing.Point(500, 82);
            this._lTo.Name = "_lTo";
            this._lTo.Size = new System.Drawing.Size(25, 17);
            this._lTo.TabIndex = 30;
            this._lTo.Text = "To:";
            // 
            // _dtTo
            // 
            this._dtTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this._dtTo.CustomFormat = "dd/MM/yyyy";
            this._dtTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this._dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtTo.Location = new System.Drawing.Point(531, 78);
            this._dtTo.Name = "_dtTo";
            this._dtTo.Size = new System.Drawing.Size(325, 23);
            this._dtTo.TabIndex = 29;
            this._dtTo.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // _lFrom
            // 
            this._lFrom.AutoSize = true;
            this._lFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lFrom.Location = new System.Drawing.Point(64, 82);
            this._lFrom.Name = "_lFrom";
            this._lFrom.Size = new System.Drawing.Size(41, 17);
            this._lFrom.TabIndex = 28;
            this._lFrom.Text = "From:";
            // 
            // _dtFrom
            // 
            this._dtFrom.CalendarMonthBackground = System.Drawing.Color.GhostWhite;
            this._dtFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this._dtFrom.CustomFormat = "dd/MM/yyyy";
            this._dtFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this._dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtFrom.Location = new System.Drawing.Point(111, 78);
            this._dtFrom.Name = "_dtFrom";
            this._dtFrom.Size = new System.Drawing.Size(325, 23);
            this._dtFrom.TabIndex = 27;
            this._dtFrom.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // _lSearchStudent
            // 
            this._lSearchStudent.AutoSize = true;
            this._lSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lSearchStudent.Location = new System.Drawing.Point(50, 19);
            this._lSearchStudent.Name = "_lSearchStudent";
            this._lSearchStudent.Size = new System.Drawing.Size(55, 17);
            this._lSearchStudent.TabIndex = 26;
            this._lSearchStudent.Text = "Student:";
            // 
            // _tbSearchName
            // 
            this._tbSearchName.BackColor = System.Drawing.Color.GhostWhite;
            this._tbSearchName.BoxWidth = 325;
            this._tbSearchName.ForeColor = System.Drawing.Color.Black;
            this._tbSearchName.Location = new System.Drawing.Point(111, 18);
            this._tbSearchName.Name = "_tbSearchName";
            this._tbSearchName.Size = new System.Drawing.Size(325, 23);
            this._tbSearchName.TabIndex = 0;
            // 
            // _btnSelectOrganization
            // 
            this._btnSelectOrganization.AutoSize = true;
            this._btnSelectOrganization.BackColor = System.Drawing.Color.White;
            this._btnSelectOrganization.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnSelectOrganization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectOrganization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectOrganization.ForeColor = System.Drawing.Color.Black;
            this._btnSelectOrganization.Location = new System.Drawing.Point(408, 48);
            this._btnSelectOrganization.MaximumSize = new System.Drawing.Size(0, 23);
            this._btnSelectOrganization.MinimumSize = new System.Drawing.Size(0, 23);
            this._btnSelectOrganization.Name = "_btnSelectOrganization";
            this._btnSelectOrganization.Size = new System.Drawing.Size(28, 23);
            this._btnSelectOrganization.TabIndex = 2;
            this._btnSelectOrganization.TabStop = false;
            this._btnSelectOrganization.Text = "...";
            this._btnSelectOrganization.UseVisualStyleBackColor = false;
            // 
            // _cbOrganizations
            // 
            this._cbOrganizations.BackColor = System.Drawing.Color.GhostWhite;
            this._cbOrganizations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbOrganizations.FormattingEnabled = true;
            this._cbOrganizations.Location = new System.Drawing.Point(111, 48);
            this._cbOrganizations.Name = "_cbOrganizations";
            this._cbOrganizations.Size = new System.Drawing.Size(291, 23);
            this._cbOrganizations.TabIndex = 1;
            // 
            // _lOrganization
            // 
            this._lOrganization.AutoSize = true;
            this._lOrganization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganization.Location = new System.Drawing.Point(19, 50);
            this._lOrganization.Name = "_lOrganization";
            this._lOrganization.Size = new System.Drawing.Size(86, 17);
            this._lOrganization.TabIndex = 24;
            this._lOrganization.Text = "Organization:";
            // 
            // _menu
            // 
            this._menu.BackColor = System.Drawing.Color.GhostWhite;
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miOrganization,
            this._miStudents,
            this._miInstructors});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(1230, 24);
            this._menu.TabIndex = 0;
            this._menu.Text = "_menuStrip";
            // 
            // _miOrganization
            // 
            this._miOrganization.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miOrganizations,
            this._miPrograms,
            this._miCourses});
            this._miOrganization.Name = "_miOrganization";
            this._miOrganization.Size = new System.Drawing.Size(87, 20);
            this._miOrganization.Text = "Organization";
            // 
            // _miOrganizations
            // 
            this._miOrganizations.Name = "_miOrganizations";
            this._miOrganizations.Size = new System.Drawing.Size(147, 22);
            this._miOrganizations.Text = "Organizations";
            // 
            // _miPrograms
            // 
            this._miPrograms.Name = "_miPrograms";
            this._miPrograms.Size = new System.Drawing.Size(147, 22);
            this._miPrograms.Text = "Programs";
            // 
            // _miCourses
            // 
            this._miCourses.Name = "_miCourses";
            this._miCourses.Size = new System.Drawing.Size(147, 22);
            this._miCourses.Text = "Courses";
            // 
            // _miStudents
            // 
            this._miStudents.Name = "_miStudents";
            this._miStudents.Size = new System.Drawing.Size(65, 20);
            this._miStudents.Text = "Students";
            // 
            // _miInstructors
            // 
            this._miInstructors.Name = "_miInstructors";
            this._miInstructors.Size = new System.Drawing.Size(75, 20);
            this._miInstructors.Text = "Instructors";
            // 
            // _splitContainerBottom
            // 
            this._splitContainerBottom.BackColor = System.Drawing.Color.GhostWhite;
            this._splitContainerBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._splitContainerBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerBottom.IsSplitterFixed = true;
            this._splitContainerBottom.Location = new System.Drawing.Point(0, 0);
            this._splitContainerBottom.Name = "_splitContainerBottom";
            // 
            // _splitContainerBottom.Panel1
            // 
            this._splitContainerBottom.Panel1.Controls.Add(this._pnlCourses);
            // 
            // _splitContainerBottom.Panel2
            // 
            this._splitContainerBottom.Panel2.Controls.Add(this._pnlApplications);
            this._splitContainerBottom.Size = new System.Drawing.Size(1234, 573);
            this._splitContainerBottom.SplitterDistance = 839;
            this._splitContainerBottom.TabIndex = 0;
            // 
            // _pnlCourses
            // 
            this._pnlCourses.BackColor = System.Drawing.Color.White;
            this._pnlCourses.Controls.Add(this._lApplications);
            this._pnlCourses.Controls.Add(this._gridApps);
            this._pnlCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlCourses.Location = new System.Drawing.Point(0, 0);
            this._pnlCourses.Name = "_pnlCourses";
            this._pnlCourses.Size = new System.Drawing.Size(835, 569);
            this._pnlCourses.TabIndex = 1;
            // 
            // _lApplications
            // 
            this._lApplications.BackColor = System.Drawing.Color.AliceBlue;
            this._lApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this._lApplications.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lApplications.Location = new System.Drawing.Point(0, 0);
            this._lApplications.Name = "_lApplications";
            this._lApplications.Size = new System.Drawing.Size(835, 20);
            this._lApplications.TabIndex = 1;
            this._lApplications.Text = "Applications";
            this._lApplications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gridApps
            // 
            this._gridApps.AllowUserToAddRows = false;
            this._gridApps.AllowUserToDeleteRows = false;
            this._gridApps.AllowUserToOrderColumns = true;
            this._gridApps.AllowUserToResizeRows = false;
            this._gridApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridApps.BackgroundColor = System.Drawing.Color.White;
            this._gridApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gridApps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._gridApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Student,
            this.Organization,
            this.Date,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridApps.DefaultCellStyle = dataGridViewCellStyle2;
            this._gridApps.EnableHeadersVisualStyles = false;
            this._gridApps.Location = new System.Drawing.Point(-2, 21);
            this._gridApps.MultiSelect = false;
            this._gridApps.Name = "_gridApps";
            this._gridApps.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._gridApps.RowHeadersVisible = false;
            this._gridApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridApps.Size = new System.Drawing.Size(839, 550);
            this._gridApps.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 75;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.FillWeight = 105F;
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 250;
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Organization
            // 
            this.Organization.DataPropertyName = "Organization";
            this.Organization.FillWeight = 105F;
            this.Organization.HeaderText = "Organization";
            this.Organization.MinimumWidth = 250;
            this.Organization.Name = "Organization";
            this.Organization.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "CreatedAt";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 80;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StatusDisplayName";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 100;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // _pnlApplications
            // 
            this._pnlApplications.BackColor = System.Drawing.Color.White;
            this._pnlApplications.Controls.Add(this._lAppCourses);
            this._pnlApplications.Controls.Add(this._gridAppCourses);
            this._pnlApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlApplications.Location = new System.Drawing.Point(0, 0);
            this._pnlApplications.Name = "_pnlApplications";
            this._pnlApplications.Size = new System.Drawing.Size(387, 569);
            this._pnlApplications.TabIndex = 0;
            // 
            // _lAppCourses
            // 
            this._lAppCourses.BackColor = System.Drawing.Color.AliceBlue;
            this._lAppCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this._lAppCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lAppCourses.Location = new System.Drawing.Point(0, 0);
            this._lAppCourses.Name = "_lAppCourses";
            this._lAppCourses.Size = new System.Drawing.Size(387, 20);
            this._lAppCourses.TabIndex = 2;
            this._lAppCourses.Text = "Courses";
            this._lAppCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gridAppCourses
            // 
            this._gridAppCourses.AllowUserToAddRows = false;
            this._gridAppCourses.AllowUserToDeleteRows = false;
            this._gridAppCourses.AllowUserToOrderColumns = true;
            this._gridAppCourses.AllowUserToResizeRows = false;
            this._gridAppCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridAppCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridAppCourses.BackgroundColor = System.Drawing.Color.White;
            this._gridAppCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gridAppCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridAppCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._gridAppCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridAppCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseCode,
            this.Instructor,
            this.EvaluationStatus});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridAppCourses.DefaultCellStyle = dataGridViewCellStyle5;
            this._gridAppCourses.EnableHeadersVisualStyles = false;
            this._gridAppCourses.Location = new System.Drawing.Point(-2, 21);
            this._gridAppCourses.MultiSelect = false;
            this._gridAppCourses.Name = "_gridAppCourses";
            this._gridAppCourses.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridAppCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._gridAppCourses.RowHeadersVisible = false;
            this._gridAppCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridAppCourses.Size = new System.Drawing.Size(393, 550);
            this._gridAppCourses.TabIndex = 1;
            // 
            // CourseCode
            // 
            this.CourseCode.DataPropertyName = "CourseCode";
            this.CourseCode.HeaderText = "Code";
            this.CourseCode.MinimumWidth = 110;
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.ReadOnly = true;
            // 
            // Instructor
            // 
            this.Instructor.DataPropertyName = "Instructor";
            this.Instructor.HeaderText = "Evaluator";
            this.Instructor.MinimumWidth = 135;
            this.Instructor.Name = "Instructor";
            this.Instructor.ReadOnly = true;
            // 
            // EvaluationStatus
            // 
            this.EvaluationStatus.DataPropertyName = "StatusDisplayName";
            this.EvaluationStatus.HeaderText = "Status";
            this.EvaluationStatus.MinimumWidth = 110;
            this.EvaluationStatus.Name = "EvaluationStatus";
            this.EvaluationStatus.ReadOnly = true;
            // 
            // ApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 721);
            this.Controls.Add(this._splitContainerForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1250, 760);
            this.Name = "ApplicationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Logger";
            this._splitContainerForm.Panel1.ResumeLayout(false);
            this._splitContainerForm.Panel1.PerformLayout();
            this._splitContainerForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerForm)).EndInit();
            this._splitContainerForm.ResumeLayout(false);
            this._pnlFilters.ResumeLayout(false);
            this._pnlFilters.PerformLayout();
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this._splitContainerBottom.Panel1.ResumeLayout(false);
            this._splitContainerBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerBottom)).EndInit();
            this._splitContainerBottom.ResumeLayout(false);
            this._pnlCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridApps)).EndInit();
            this._pnlApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridAppCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TransferLogger.Ui.Controls.TlSplitContainer _splitContainerForm;
        private TransferLogger.Ui.Controls.TlSplitContainer _splitContainerBottom;
        private Panel _pnlCourses;
        private Panel _pnlApplications;
        private MenuStrip _menu;
        private TransferLogger.Ui.Controls.TlDataGrid _gridApps;
        private Panel _pnlFilters;
        private ToolStripMenuItem _miOrganization;
        private ToolStripMenuItem _miOrganizations;
        private ToolStripMenuItem _miPrograms;
        private ToolStripMenuItem _miCourses;
        private ToolStripMenuItem _miStudents;
        private ToolStripMenuItem _miInstructors;
        private Label _lApplications;
        private Controls.TlButton _btnSelectOrganization;
        private Controls.TlDropDownList _cbOrganizations;
        private Label _lOrganization;
        private Label _lSearchStudent;
        private Controls.TlTextBox _tbSearchName;
        private DateTimePicker _dtFrom;
        private Label _lFrom;
        private Label _lTo;
        private DateTimePicker _dtTo;
        private Controls.TlDropDownList _cbStatuses;
        private Label _lStatus;
        private Controls.TlDataGrid _gridAppCourses;
        private Label _lAppCourses;
        private Controls.TlButton _btnEdit;
        private Controls.TlButton _btnAdd;
        private Controls.TlButton _btnEditLocations;
        private Controls.TlButton _btnExportExcel;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Organization;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Status;
        private Controls.TlButton _btnSendEmail;
        private DataGridViewTextBoxColumn CourseCode;
        private DataGridViewTextBoxColumn Instructor;
        private DataGridViewTextBoxColumn EvaluationStatus;
    }
}