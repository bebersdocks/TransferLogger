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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationsForm));
            this._splitContainerForm = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._pnlFilters = new System.Windows.Forms.Panel();
            this._btnEditLocations = new TransferLogger.Ui.Controls.TlButton();
            this._btnExport = new TransferLogger.Ui.Controls.TlButton();
            this._btnDelete = new TransferLogger.Ui.Controls.TlButton();
            this._btnEdit = new TransferLogger.Ui.Controls.TlButton();
            this._btnAdd = new TransferLogger.Ui.Controls.TlButton();
            this._cbStatus = new TransferLogger.Ui.Controls.TlDropDownList();
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
            this._menuOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this._miOrganizations = new System.Windows.Forms.ToolStripMenuItem();
            this._miPrograms = new System.Windows.Forms.ToolStripMenuItem();
            this._miCourses = new System.Windows.Forms.ToolStripMenuItem();
            this._miStudents = new System.Windows.Forms.ToolStripMenuItem();
            this._miInstructors = new System.Windows.Forms.ToolStripMenuItem();
            this._splitContainerBottom = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._pnlCourses = new System.Windows.Forms.Panel();
            this._lAppCourses = new System.Windows.Forms.Label();
            this._gridAppCourses = new TransferLogger.Ui.Controls.TlDataGrid();
            this.CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationCourseStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._pnlApplications = new System.Windows.Forms.Panel();
            this._lApplications = new System.Windows.Forms.Label();
            this._gridApps = new TransferLogger.Ui.Controls.TlDataGrid();
            this.ApplicationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Courses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmittedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this._gridAppCourses)).BeginInit();
            this._pnlApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridApps)).BeginInit();
            this.SuspendLayout();
            // 
            // _splitContainerForm
            // 
            this._splitContainerForm.BackColor = System.Drawing.Color.GhostWhite;
            this._splitContainerForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._splitContainerForm.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this._splitContainerForm.Size = new System.Drawing.Size(1174, 646);
            this._splitContainerForm.SplitterDistance = 161;
            this._splitContainerForm.TabIndex = 5;
            // 
            // _pnlFilters
            // 
            this._pnlFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlFilters.BackColor = System.Drawing.Color.White;
            this._pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlFilters.Controls.Add(this._btnEditLocations);
            this._pnlFilters.Controls.Add(this._btnExport);
            this._pnlFilters.Controls.Add(this._btnDelete);
            this._pnlFilters.Controls.Add(this._btnEdit);
            this._pnlFilters.Controls.Add(this._btnAdd);
            this._pnlFilters.Controls.Add(this._cbStatus);
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
            this._pnlFilters.Size = new System.Drawing.Size(1176, 134);
            this._pnlFilters.TabIndex = 1;
            // 
            // _btnEditLocations
            // 
            this._btnEditLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnEditLocations.AutoSize = true;
            this._btnEditLocations.BackColor = System.Drawing.Color.Transparent;
            this._btnEditLocations.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.folder;
            this._btnEditLocations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnEditLocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnEditLocations.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnEditLocations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnEditLocations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnEditLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEditLocations.ForeColor = System.Drawing.Color.Black;
            this._btnEditLocations.HoverColor = System.Drawing.Color.Transparent;
            this._btnEditLocations.Location = new System.Drawing.Point(1129, 17);
            this._btnEditLocations.Name = "_btnEditLocations";
            this._btnEditLocations.Size = new System.Drawing.Size(32, 32);
            this._btnEditLocations.TabIndex = 37;
            this._btnEditLocations.TabStop = false;
            this._btnEditLocations.UseVisualStyleBackColor = false;
            // 
            // _btnExport
            // 
            this._btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExport.AutoSize = true;
            this._btnExport.BackColor = System.Drawing.Color.Transparent;
            this._btnExport.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.excel;
            this._btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnExport.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnExport.ForeColor = System.Drawing.Color.Black;
            this._btnExport.HoverColor = System.Drawing.Color.Transparent;
            this._btnExport.Location = new System.Drawing.Point(1091, 17);
            this._btnExport.Name = "_btnExport";
            this._btnExport.Size = new System.Drawing.Size(32, 32);
            this._btnExport.TabIndex = 36;
            this._btnExport.TabStop = false;
            this._btnExport.UseVisualStyleBackColor = false;
            // 
            // _btnDelete
            // 
            this._btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDelete.AutoSize = true;
            this._btnDelete.BackColor = System.Drawing.Color.Transparent;
            this._btnDelete.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.delete;
            this._btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDelete.ForeColor = System.Drawing.Color.Black;
            this._btnDelete.HoverColor = System.Drawing.Color.Transparent;
            this._btnDelete.Location = new System.Drawing.Point(1053, 17);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(32, 32);
            this._btnDelete.TabIndex = 35;
            this._btnDelete.TabStop = false;
            this._btnDelete.UseVisualStyleBackColor = false;
            // 
            // _btnEdit
            // 
            this._btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnEdit.AutoSize = true;
            this._btnEdit.BackColor = System.Drawing.Color.Transparent;
            this._btnEdit.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.edit;
            this._btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEdit.ForeColor = System.Drawing.Color.Black;
            this._btnEdit.HoverColor = System.Drawing.Color.Transparent;
            this._btnEdit.Location = new System.Drawing.Point(1015, 17);
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
            this._btnAdd.BackColor = System.Drawing.Color.Transparent;
            this._btnAdd.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.add;
            this._btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAdd.ForeColor = System.Drawing.Color.Black;
            this._btnAdd.HoverColor = System.Drawing.Color.Transparent;
            this._btnAdd.Location = new System.Drawing.Point(977, 18);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(32, 32);
            this._btnAdd.TabIndex = 33;
            this._btnAdd.TabStop = false;
            this._btnAdd.UseVisualStyleBackColor = false;
            // 
            // _cbStatus
            // 
            this._cbStatus.BackColor = System.Drawing.Color.GhostWhite;
            this._cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbStatus.FormattingEnabled = true;
            this._cbStatus.Location = new System.Drawing.Point(526, 55);
            this._cbStatus.Name = "_cbStatus";
            this._cbStatus.Size = new System.Drawing.Size(325, 23);
            this._cbStatus.TabIndex = 31;
            // 
            // _lStatus
            // 
            this._lStatus.AutoSize = true;
            this._lStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lStatus.Location = new System.Drawing.Point(474, 56);
            this._lStatus.Name = "_lStatus";
            this._lStatus.Size = new System.Drawing.Size(46, 17);
            this._lStatus.TabIndex = 32;
            this._lStatus.Text = "Status:";
            // 
            // _lTo
            // 
            this._lTo.AutoSize = true;
            this._lTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lTo.Location = new System.Drawing.Point(49, 94);
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
            this._dtTo.Location = new System.Drawing.Point(80, 93);
            this._dtTo.Name = "_dtTo";
            this._dtTo.Size = new System.Drawing.Size(325, 23);
            this._dtTo.TabIndex = 29;
            this._dtTo.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // _lFrom
            // 
            this._lFrom.AutoSize = true;
            this._lFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lFrom.Location = new System.Drawing.Point(33, 56);
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
            this._dtFrom.Location = new System.Drawing.Point(80, 55);
            this._dtFrom.Name = "_dtFrom";
            this._dtFrom.Size = new System.Drawing.Size(325, 23);
            this._dtFrom.TabIndex = 27;
            this._dtFrom.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // _lSearchStudent
            // 
            this._lSearchStudent.AutoSize = true;
            this._lSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lSearchStudent.Location = new System.Drawing.Point(19, 18);
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
            this._tbSearchName.Location = new System.Drawing.Point(80, 17);
            this._tbSearchName.Name = "_tbSearchName";
            this._tbSearchName.Size = new System.Drawing.Size(325, 23);
            this._tbSearchName.TabIndex = 0;
            // 
            // _btnSelectOrganization
            // 
            this._btnSelectOrganization.AutoSize = true;
            this._btnSelectOrganization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectOrganization.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnSelectOrganization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectOrganization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectOrganization.ForeColor = System.Drawing.Color.Black;
            this._btnSelectOrganization.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectOrganization.Location = new System.Drawing.Point(823, 18);
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
            this._cbOrganizations.Location = new System.Drawing.Point(526, 18);
            this._cbOrganizations.Name = "_cbOrganizations";
            this._cbOrganizations.Size = new System.Drawing.Size(291, 23);
            this._cbOrganizations.TabIndex = 1;
            // 
            // _lOrganization
            // 
            this._lOrganization.AutoSize = true;
            this._lOrganization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganization.Location = new System.Drawing.Point(434, 18);
            this._lOrganization.Name = "_lOrganization";
            this._lOrganization.Size = new System.Drawing.Size(86, 17);
            this._lOrganization.TabIndex = 24;
            this._lOrganization.Text = "Organization:";
            // 
            // _menu
            // 
            this._menu.BackColor = System.Drawing.Color.GhostWhite;
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuOrganization,
            this._miStudents,
            this._miInstructors});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(1170, 24);
            this._menu.TabIndex = 0;
            this._menu.Text = "_menuStrip";
            // 
            // _menuOrganization
            // 
            this._menuOrganization.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miOrganizations,
            this._miPrograms,
            this._miCourses});
            this._menuOrganization.Name = "_menuOrganization";
            this._menuOrganization.Size = new System.Drawing.Size(87, 20);
            this._menuOrganization.Text = "Organization";
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
            this._splitContainerBottom.Size = new System.Drawing.Size(1174, 481);
            this._splitContainerBottom.SplitterDistance = 236;
            this._splitContainerBottom.TabIndex = 0;
            // 
            // _pnlCourses
            // 
            this._pnlCourses.BackColor = System.Drawing.Color.White;
            this._pnlCourses.Controls.Add(this._lAppCourses);
            this._pnlCourses.Controls.Add(this._gridAppCourses);
            this._pnlCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlCourses.Location = new System.Drawing.Point(0, 0);
            this._pnlCourses.Name = "_pnlCourses";
            this._pnlCourses.Size = new System.Drawing.Size(232, 477);
            this._pnlCourses.TabIndex = 1;
            // 
            // _lAppCourses
            // 
            this._lAppCourses.BackColor = System.Drawing.Color.AliceBlue;
            this._lAppCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this._lAppCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lAppCourses.Location = new System.Drawing.Point(0, 0);
            this._lAppCourses.Name = "_lAppCourses";
            this._lAppCourses.Size = new System.Drawing.Size(232, 20);
            this._lAppCourses.TabIndex = 2;
            this._lAppCourses.Text = "Courses";
            this._lAppCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gridAppCourses
            // 
            this._gridAppCourses.AllowUserToAddRows = false;
            this._gridAppCourses.AllowUserToDeleteRows = false;
            this._gridAppCourses.AllowUserToOrderColumns = true;
            this._gridAppCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridAppCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridAppCourses.BackgroundColor = System.Drawing.Color.White;
            this._gridAppCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gridAppCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridAppCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this._gridAppCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridAppCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseCode,
            this.ApplicationCourseStatus});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridAppCourses.DefaultCellStyle = dataGridViewCellStyle8;
            this._gridAppCourses.EnableHeadersVisualStyles = false;
            this._gridAppCourses.Location = new System.Drawing.Point(-2, 21);
            this._gridAppCourses.MultiSelect = false;
            this._gridAppCourses.Name = "_gridAppCourses";
            this._gridAppCourses.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridAppCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this._gridAppCourses.RowHeadersVisible = false;
            this._gridAppCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridAppCourses.Size = new System.Drawing.Size(236, 458);
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
            // ApplicationCourseStatus
            // 
            this.ApplicationCourseStatus.DataPropertyName = "Status";
            this.ApplicationCourseStatus.HeaderText = "Status";
            this.ApplicationCourseStatus.MinimumWidth = 110;
            this.ApplicationCourseStatus.Name = "ApplicationCourseStatus";
            this.ApplicationCourseStatus.ReadOnly = true;
            // 
            // _pnlApplications
            // 
            this._pnlApplications.BackColor = System.Drawing.Color.White;
            this._pnlApplications.Controls.Add(this._lApplications);
            this._pnlApplications.Controls.Add(this._gridApps);
            this._pnlApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlApplications.Location = new System.Drawing.Point(0, 0);
            this._pnlApplications.Name = "_pnlApplications";
            this._pnlApplications.Size = new System.Drawing.Size(930, 477);
            this._pnlApplications.TabIndex = 0;
            // 
            // _lApplications
            // 
            this._lApplications.BackColor = System.Drawing.Color.AliceBlue;
            this._lApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this._lApplications.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lApplications.Location = new System.Drawing.Point(0, 0);
            this._lApplications.Name = "_lApplications";
            this._lApplications.Size = new System.Drawing.Size(930, 20);
            this._lApplications.TabIndex = 1;
            this._lApplications.Text = "Applications";
            this._lApplications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gridApps
            // 
            this._gridApps.AllowUserToAddRows = false;
            this._gridApps.AllowUserToDeleteRows = false;
            this._gridApps.AllowUserToOrderColumns = true;
            this._gridApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridApps.BackgroundColor = System.Drawing.Color.White;
            this._gridApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gridApps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this._gridApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationId,
            this.Status,
            this.Student,
            this.Organization,
            this.Courses,
            this.Date,
            this.SubmittedAt});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridApps.DefaultCellStyle = dataGridViewCellStyle11;
            this._gridApps.EnableHeadersVisualStyles = false;
            this._gridApps.Location = new System.Drawing.Point(-6, 21);
            this._gridApps.MultiSelect = false;
            this._gridApps.Name = "_gridApps";
            this._gridApps.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this._gridApps.RowHeadersVisible = false;
            this._gridApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridApps.Size = new System.Drawing.Size(941, 458);
            this._gridApps.TabIndex = 0;
            // 
            // ApplicationId
            // 
            this.ApplicationId.DataPropertyName = "ApplicationId";
            this.ApplicationId.HeaderText = "ID";
            this.ApplicationId.Name = "ApplicationId";
            this.ApplicationId.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "ApplicationStatus";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Organization
            // 
            this.Organization.DataPropertyName = "Organization";
            this.Organization.HeaderText = "Organization";
            this.Organization.Name = "Organization";
            this.Organization.ReadOnly = true;
            // 
            // Courses
            // 
            this.Courses.DataPropertyName = "CoursesCount";
            this.Courses.HeaderText = "Courses";
            this.Courses.Name = "Courses";
            this.Courses.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "CreatedAt";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // SubmittedAt
            // 
            this.SubmittedAt.DataPropertyName = "SubmittedAt";
            this.SubmittedAt.HeaderText = "Submission Date";
            this.SubmittedAt.Name = "SubmittedAt";
            this.SubmittedAt.ReadOnly = true;
            // 
            // ApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 646);
            this.Controls.Add(this._splitContainerForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1190, 685);
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
            ((System.ComponentModel.ISupportInitialize)(this._gridAppCourses)).EndInit();
            this._pnlApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridApps)).EndInit();
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
        private ToolStripMenuItem _menuOrganization;
        private ToolStripMenuItem _miOrganizations;
        private ToolStripMenuItem _miPrograms;
        private ToolStripMenuItem _miCourses;
        private ToolStripMenuItem _miStudents;
        private ToolStripMenuItem _miInstructors;
        private Label _lApplications;
        private DataGridViewTextBoxColumn ApplicationId;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Organization;
        private DataGridViewTextBoxColumn Courses;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn SubmittedAt;
        private Controls.TlButton _btnSelectOrganization;
        private Controls.TlDropDownList _cbOrganizations;
        private Label _lOrganization;
        private Label _lSearchStudent;
        private Controls.TlTextBox _tbSearchName;
        private DateTimePicker _dtFrom;
        private Label _lFrom;
        private Label _lTo;
        private DateTimePicker _dtTo;
        private Controls.TlDropDownList _cbStatus;
        private Label _lStatus;
        private Controls.TlDataGrid _gridAppCourses;
        private Label _lAppCourses;
        private DataGridViewTextBoxColumn CourseCode;
        private DataGridViewTextBoxColumn ApplicationCourseStatus;
        private Controls.TlButton _btnDelete;
        private Controls.TlButton _btnEdit;
        private Controls.TlButton _btnAdd;
        private Controls.TlButton _btnEditLocations;
        private Controls.TlButton _btnExport;
    }
}