namespace TransferLogger.Ui.Forms
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
            this._splitContainerTop = new System.Windows.Forms.SplitContainer();
            this._pnlMain = new System.Windows.Forms.Panel();
            this._menu = new System.Windows.Forms.MenuStrip();
            this._menuOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemOrganizations = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPrograms = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemCourses = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemStudents = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemInstructors = new System.Windows.Forms.ToolStripMenuItem();
            this._splitContainerBottom = new System.Windows.Forms.SplitContainer();
            this._pnlInfo = new System.Windows.Forms.Panel();
            this._pnlApplications = new System.Windows.Forms.Panel();
            this._lApplications = new System.Windows.Forms.Label();
            this._gridApps = new TransferLogger.Ui.Controls.TlDataGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Courses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmittedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerTop)).BeginInit();
            this._splitContainerTop.Panel1.SuspendLayout();
            this._splitContainerTop.Panel2.SuspendLayout();
            this._splitContainerTop.SuspendLayout();
            this._menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerBottom)).BeginInit();
            this._splitContainerBottom.Panel1.SuspendLayout();
            this._splitContainerBottom.Panel2.SuspendLayout();
            this._splitContainerBottom.SuspendLayout();
            this._pnlApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridApps)).BeginInit();
            this.SuspendLayout();
            // 
            // _splitContainerTop
            // 
            this._splitContainerTop.BackColor = System.Drawing.Color.GhostWhite;
            this._splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerTop.IsSplitterFixed = true;
            this._splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this._splitContainerTop.Name = "_splitContainerTop";
            this._splitContainerTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainerTop.Panel1
            // 
            this._splitContainerTop.Panel1.BackColor = System.Drawing.Color.White;
            this._splitContainerTop.Panel1.Controls.Add(this._pnlMain);
            this._splitContainerTop.Panel1.Controls.Add(this._menu);
            // 
            // _splitContainerTop.Panel2
            // 
            this._splitContainerTop.Panel2.Controls.Add(this._splitContainerBottom);
            this._splitContainerTop.Size = new System.Drawing.Size(1176, 650);
            this._splitContainerTop.SplitterDistance = 158;
            this._splitContainerTop.TabIndex = 0;
            // 
            // _pnlMain
            // 
            this._pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlMain.BackColor = System.Drawing.Color.White;
            this._pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._pnlMain.Location = new System.Drawing.Point(0, 24);
            this._pnlMain.Name = "_pnlMain";
            this._pnlMain.Size = new System.Drawing.Size(1176, 134);
            this._pnlMain.TabIndex = 1;
            // 
            // _menu
            // 
            this._menu.BackColor = System.Drawing.Color.GhostWhite;
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuOrganization,
            this._menuItemStudents,
            this._menuItemInstructors});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(1176, 24);
            this._menu.TabIndex = 0;
            this._menu.Text = "_menuStrip";
            // 
            // _menuOrganization
            // 
            this._menuOrganization.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemOrganizations,
            this._menuItemPrograms,
            this._menuItemCourses});
            this._menuOrganization.Name = "_menuOrganization";
            this._menuOrganization.Size = new System.Drawing.Size(87, 20);
            this._menuOrganization.Text = "Organization";
            // 
            // _menuItemOrganizations
            // 
            this._menuItemOrganizations.Name = "_menuItemOrganizations";
            this._menuItemOrganizations.Size = new System.Drawing.Size(180, 22);
            this._menuItemOrganizations.Text = "Organizations";
            // 
            // _menuItemPrograms
            // 
            this._menuItemPrograms.Name = "_menuItemPrograms";
            this._menuItemPrograms.Size = new System.Drawing.Size(180, 22);
            this._menuItemPrograms.Text = "Programs";
            // 
            // _menuItemCourses
            // 
            this._menuItemCourses.Name = "_menuItemCourses";
            this._menuItemCourses.Size = new System.Drawing.Size(180, 22);
            this._menuItemCourses.Text = "Courses";
            // 
            // _menuItemStudents
            // 
            this._menuItemStudents.Name = "_menuItemStudents";
            this._menuItemStudents.Size = new System.Drawing.Size(65, 20);
            this._menuItemStudents.Text = "Students";
            // 
            // _menuItemInstructors
            // 
            this._menuItemInstructors.Name = "_menuItemInstructors";
            this._menuItemInstructors.Size = new System.Drawing.Size(75, 20);
            this._menuItemInstructors.Text = "Instructors";
            // 
            // _splitContainerBottom
            // 
            this._splitContainerBottom.BackColor = System.Drawing.Color.GhostWhite;
            this._splitContainerBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerBottom.IsSplitterFixed = true;
            this._splitContainerBottom.Location = new System.Drawing.Point(0, 0);
            this._splitContainerBottom.Name = "_splitContainerBottom";
            // 
            // _splitContainerBottom.Panel1
            // 
            this._splitContainerBottom.Panel1.Controls.Add(this._pnlInfo);
            // 
            // _splitContainerBottom.Panel2
            // 
            this._splitContainerBottom.Panel2.Controls.Add(this._pnlApplications);
            this._splitContainerBottom.Size = new System.Drawing.Size(1176, 488);
            this._splitContainerBottom.SplitterDistance = 239;
            this._splitContainerBottom.TabIndex = 0;
            // 
            // _pnlInfo
            // 
            this._pnlInfo.BackColor = System.Drawing.Color.White;
            this._pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlInfo.Location = new System.Drawing.Point(0, 0);
            this._pnlInfo.Name = "_pnlInfo";
            this._pnlInfo.Size = new System.Drawing.Size(239, 488);
            this._pnlInfo.TabIndex = 1;
            // 
            // _pnlApplications
            // 
            this._pnlApplications.BackColor = System.Drawing.Color.Transparent;
            this._pnlApplications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._pnlApplications.Controls.Add(this._lApplications);
            this._pnlApplications.Controls.Add(this._gridApps);
            this._pnlApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlApplications.Location = new System.Drawing.Point(0, 0);
            this._pnlApplications.Name = "_pnlApplications";
            this._pnlApplications.Size = new System.Drawing.Size(933, 488);
            this._pnlApplications.TabIndex = 0;
            // 
            // _lApplications
            // 
            this._lApplications.BackColor = System.Drawing.Color.AliceBlue;
            this._lApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this._lApplications.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lApplications.Location = new System.Drawing.Point(0, 0);
            this._lApplications.Name = "_lApplications";
            this._lApplications.Size = new System.Drawing.Size(929, 17);
            this._lApplications.TabIndex = 1;
            this._lApplications.Text = "Applications";
            this._lApplications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gridApps
            // 
            this._gridApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Status,
            this.Student,
            this.Organization,
            this.Courses,
            this.Date,
            this.SubmittedAt});
            this._gridApps.Location = new System.Drawing.Point(-2, 18);
            this._gridApps.Name = "_gridApps";
            this._gridApps.Size = new System.Drawing.Size(933, 464);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ApplicationId";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(1176, 650);
            this.Controls.Add(this._splitContainerTop);
            this.Name = "ApplicationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Logger";
            this._splitContainerTop.Panel1.ResumeLayout(false);
            this._splitContainerTop.Panel1.PerformLayout();
            this._splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerTop)).EndInit();
            this._splitContainerTop.ResumeLayout(false);
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this._splitContainerBottom.Panel1.ResumeLayout(false);
            this._splitContainerBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerBottom)).EndInit();
            this._splitContainerBottom.ResumeLayout(false);
            this._pnlApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridApps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer _splitContainerTop;
        private SplitContainer _splitContainerBottom;
        private Panel _pnlInfo;
        private Panel _pnlApplications;
        private MenuStrip _menu;
        private TransferLogger.Ui.Controls.TlDataGrid _gridApps;
        private Panel _pnlMain;
        private ToolStripMenuItem _menuOrganization;
        private ToolStripMenuItem _menuItemOrganizations;
        private ToolStripMenuItem _menuItemPrograms;
        private ToolStripMenuItem _menuItemCourses;
        private ToolStripMenuItem _menuItemStudents;
        private ToolStripMenuItem _menuItemInstructors;
        private Label _lApplications;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Organization;
        private DataGridViewTextBoxColumn Courses;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn SubmittedAt;
    }
}