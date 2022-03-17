﻿using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Tranfser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationsForm));
            this._splitContainerForm = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._pnlMain = new System.Windows.Forms.Panel();
            this._menu = new System.Windows.Forms.MenuStrip();
            this._menuOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this._miOrganizations = new System.Windows.Forms.ToolStripMenuItem();
            this._miPrograms = new System.Windows.Forms.ToolStripMenuItem();
            this._miCourses = new System.Windows.Forms.ToolStripMenuItem();
            this._miStudents = new System.Windows.Forms.ToolStripMenuItem();
            this._miInstructors = new System.Windows.Forms.ToolStripMenuItem();
            this._splitContainerBottom = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._pnlInfo = new System.Windows.Forms.Panel();
            this._pnlApplications = new System.Windows.Forms.Panel();
            this._lApplications = new System.Windows.Forms.Label();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
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
            this._menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerBottom)).BeginInit();
            this._splitContainerBottom.Panel1.SuspendLayout();
            this._splitContainerBottom.Panel2.SuspendLayout();
            this._splitContainerBottom.SuspendLayout();
            this._pnlApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
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
            this._splitContainerForm.Panel1.Controls.Add(this._pnlMain);
            this._splitContainerForm.Panel1.Controls.Add(this._menu);
            // 
            // _splitContainerForm.Panel2
            // 
            this._splitContainerForm.Panel2.Controls.Add(this._splitContainerBottom);
            this._splitContainerForm.Size = new System.Drawing.Size(1176, 650);
            this._splitContainerForm.SplitterDistance = 158;
            this._splitContainerForm.TabIndex = 5;
            // 
            // _pnlMain
            // 
            this._pnlMain.BackColor = System.Drawing.Color.White;
            this._pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlMain.Location = new System.Drawing.Point(-2, 24);
            this._pnlMain.Name = "_pnlMain";
            this._pnlMain.Size = new System.Drawing.Size(1178, 132);
            this._pnlMain.TabIndex = 1;
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
            this._menu.Size = new System.Drawing.Size(1172, 24);
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
            this._miOrganizations.Size = new System.Drawing.Size(180, 22);
            this._miOrganizations.Text = "Organizations";
            // 
            // _miPrograms
            // 
            this._miPrograms.Name = "_miPrograms";
            this._miPrograms.Size = new System.Drawing.Size(180, 22);
            this._miPrograms.Text = "Programs";
            // 
            // _miCourses
            // 
            this._miCourses.Name = "_miCourses";
            this._miCourses.Size = new System.Drawing.Size(180, 22);
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
            this._splitContainerBottom.Panel1.Controls.Add(this._pnlInfo);
            // 
            // _splitContainerBottom.Panel2
            // 
            this._splitContainerBottom.Panel2.Controls.Add(this._pnlApplications);
            this._splitContainerBottom.Size = new System.Drawing.Size(1176, 488);
            this._splitContainerBottom.SplitterDistance = 238;
            this._splitContainerBottom.TabIndex = 0;
            // 
            // _pnlInfo
            // 
            this._pnlInfo.BackColor = System.Drawing.Color.White;
            this._pnlInfo.Location = new System.Drawing.Point(-3, -1);
            this._pnlInfo.Name = "_pnlInfo";
            this._pnlInfo.Size = new System.Drawing.Size(239, 486);
            this._pnlInfo.TabIndex = 1;
            // 
            // _pnlApplications
            // 
            this._pnlApplications.BackColor = System.Drawing.Color.White;
            this._pnlApplications.Controls.Add(this._lApplications);
            this._pnlApplications.Controls.Add(this._grid);
            this._pnlApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlApplications.Location = new System.Drawing.Point(0, 0);
            this._pnlApplications.Name = "_pnlApplications";
            this._pnlApplications.Size = new System.Drawing.Size(930, 484);
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
            // _grid
            // 
            this._grid.AllowUserToAddRows = false;
            this._grid.AllowUserToDeleteRows = false;
            this._grid.AllowUserToOrderColumns = true;
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
            this.ApplicationId,
            this.Status,
            this.Student,
            this.Organization,
            this.Courses,
            this.Date,
            this.SubmittedAt});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.DefaultCellStyle = dataGridViewCellStyle5;
            this._grid.EnableHeadersVisualStyles = false;
            this._grid.Location = new System.Drawing.Point(-6, 21);
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
            this._grid.Size = new System.Drawing.Size(941, 470);
            this._grid.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(1176, 650);
            this.Controls.Add(this._splitContainerForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Logger";
            this._splitContainerForm.Panel1.ResumeLayout(false);
            this._splitContainerForm.Panel1.PerformLayout();
            this._splitContainerForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerForm)).EndInit();
            this._splitContainerForm.ResumeLayout(false);
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this._splitContainerBottom.Panel1.ResumeLayout(false);
            this._splitContainerBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerBottom)).EndInit();
            this._splitContainerBottom.ResumeLayout(false);
            this._pnlApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TransferLogger.Ui.Controls.TlSplitContainer _splitContainerForm;
        private TransferLogger.Ui.Controls.TlSplitContainer _splitContainerBottom;
        private Panel _pnlInfo;
        private Panel _pnlApplications;
        private MenuStrip _menu;
        private TransferLogger.Ui.Controls.TlDataGrid _grid;
        private Panel _pnlMain;
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
    }
}