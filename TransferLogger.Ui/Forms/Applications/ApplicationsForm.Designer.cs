﻿using System.Windows.Forms;

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
            this._btnDelete = new TransferLogger.Ui.Controls.TlButton();
            this._btnChangeExcelLocation = new TransferLogger.Ui.Controls.TlButton();
            this._btnToggleCourses = new TransferLogger.Ui.Controls.TlButton();
            this._btnSendEmail = new TransferLogger.Ui.Controls.TlButton();
            this._btnImportExcel = new TransferLogger.Ui.Controls.TlButton();
            this._btnExportExcel = new TransferLogger.Ui.Controls.TlButton();
            this._btnOpen = new TransferLogger.Ui.Controls.TlButton();
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
            this.TargetProgram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._pnlApplications = new System.Windows.Forms.Panel();
            this._lAppEvaluations = new System.Windows.Forms.Label();
            this._gridAppEvaluations = new TransferLogger.Ui.Controls.TlDataGrid();
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
            ((System.ComponentModel.ISupportInitialize)(this._gridAppEvaluations)).BeginInit();
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
            this._pnlFilters.Controls.Add(this._btnDelete);
            this._pnlFilters.Controls.Add(this._btnChangeExcelLocation);
            this._pnlFilters.Controls.Add(this._btnToggleCourses);
            this._pnlFilters.Controls.Add(this._btnSendEmail);
            this._pnlFilters.Controls.Add(this._btnImportExcel);
            this._pnlFilters.Controls.Add(this._btnExportExcel);
            this._pnlFilters.Controls.Add(this._btnOpen);
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
            // _btnDelete
            // 
            this._btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDelete.AutoSize = true;
            this._btnDelete.BackColor = System.Drawing.Color.White;
            this._btnDelete.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.minus;
            this._btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDelete.ForeColor = System.Drawing.Color.Black;
            this._btnDelete.Location = new System.Drawing.Point(1035, 18);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(32, 32);
            this._btnDelete.TabIndex = 9;
            this._btnDelete.UseVisualStyleBackColor = false;
            // 
            // _btnChangeExcelLocation
            // 
            this._btnChangeExcelLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnChangeExcelLocation.AutoSize = true;
            this._btnChangeExcelLocation.BackColor = System.Drawing.Color.White;
            this._btnChangeExcelLocation.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.project_setup;
            this._btnChangeExcelLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnChangeExcelLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnChangeExcelLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnChangeExcelLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnChangeExcelLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnChangeExcelLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnChangeExcelLocation.ForeColor = System.Drawing.Color.Black;
            this._btnChangeExcelLocation.Location = new System.Drawing.Point(1187, 18);
            this._btnChangeExcelLocation.Name = "_btnChangeExcelLocation";
            this._btnChangeExcelLocation.Size = new System.Drawing.Size(32, 32);
            this._btnChangeExcelLocation.TabIndex = 13;
            this._btnChangeExcelLocation.UseVisualStyleBackColor = false;
            // 
            // _btnToggleCourses
            // 
            this._btnToggleCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnToggleCourses.AutoSize = true;
            this._btnToggleCourses.BackColor = System.Drawing.Color.White;
            this._btnToggleCourses.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.collapse_arrow;
            this._btnToggleCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnToggleCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnToggleCourses.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._btnToggleCourses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btnToggleCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btnToggleCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnToggleCourses.ForeColor = System.Drawing.Color.Black;
            this._btnToggleCourses.Location = new System.Drawing.Point(1187, 78);
            this._btnToggleCourses.Name = "_btnToggleCourses";
            this._btnToggleCourses.Size = new System.Drawing.Size(32, 32);
            this._btnToggleCourses.TabIndex = 14;
            this._btnToggleCourses.UseVisualStyleBackColor = false;
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
            this._btnSendEmail.Location = new System.Drawing.Point(1111, 18);
            this._btnSendEmail.Name = "_btnSendEmail";
            this._btnSendEmail.Size = new System.Drawing.Size(32, 32);
            this._btnSendEmail.TabIndex = 11;
            this._btnSendEmail.UseVisualStyleBackColor = false;
            // 
            // _btnImportExcel
            // 
            this._btnImportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnImportExcel.AutoSize = true;
            this._btnImportExcel.BackColor = System.Drawing.Color.White;
            this._btnImportExcel.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.blockchain;
            this._btnImportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnImportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnImportExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnImportExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnImportExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnImportExcel.ForeColor = System.Drawing.Color.Black;
            this._btnImportExcel.Location = new System.Drawing.Point(1073, 18);
            this._btnImportExcel.Name = "_btnImportExcel";
            this._btnImportExcel.Size = new System.Drawing.Size(32, 32);
            this._btnImportExcel.TabIndex = 10;
            this._btnImportExcel.UseVisualStyleBackColor = false;
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
            this._btnExportExcel.Location = new System.Drawing.Point(1149, 18);
            this._btnExportExcel.Name = "_btnExportExcel";
            this._btnExportExcel.Size = new System.Drawing.Size(32, 32);
            this._btnExportExcel.TabIndex = 12;
            this._btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // _btnOpen
            // 
            this._btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOpen.AutoSize = true;
            this._btnOpen.BackColor = System.Drawing.Color.White;
            this._btnOpen.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.edit;
            this._btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOpen.ForeColor = System.Drawing.Color.Black;
            this._btnOpen.Location = new System.Drawing.Point(997, 18);
            this._btnOpen.Name = "_btnOpen";
            this._btnOpen.Size = new System.Drawing.Size(32, 32);
            this._btnOpen.TabIndex = 8;
            this._btnOpen.UseVisualStyleBackColor = false;
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAdd.AutoSize = true;
            this._btnAdd.BackColor = System.Drawing.Color.White;
            this._btnAdd.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.plus;
            this._btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAdd.ForeColor = System.Drawing.Color.Black;
            this._btnAdd.Location = new System.Drawing.Point(959, 18);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(32, 32);
            this._btnAdd.TabIndex = 7;
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
            this._cbStatuses.TabIndex = 5;
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
            this._dtTo.TabIndex = 6;
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
            this._dtFrom.TabIndex = 4;
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
            this._tbSearchName.TabIndex = 1;
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
            this._btnSelectOrganization.TabIndex = 3;
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
            this._cbOrganizations.TabIndex = 2;
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
            this._menu.TabIndex = 1;
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
            this._splitContainerBottom.SplitterDistance = 891;
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
            this._pnlCourses.Size = new System.Drawing.Size(887, 569);
            this._pnlCourses.TabIndex = 1;
            // 
            // _lApplications
            // 
            this._lApplications.BackColor = System.Drawing.Color.AliceBlue;
            this._lApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this._lApplications.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lApplications.Location = new System.Drawing.Point(0, 0);
            this._lApplications.Name = "_lApplications";
            this._lApplications.Size = new System.Drawing.Size(887, 20);
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
            this.TargetProgram,
            this.CreatedAt,
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
            this._gridApps.Size = new System.Drawing.Size(891, 550);
            this._gridApps.TabIndex = 15;
            this._gridApps.TabStop = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.FillWeight = 155F;
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Organization
            // 
            this.Organization.DataPropertyName = "Organization";
            this.Organization.FillWeight = 155F;
            this.Organization.HeaderText = "Organization";
            this.Organization.Name = "Organization";
            this.Organization.ReadOnly = true;
            // 
            // TargetProgram
            // 
            this.TargetProgram.DataPropertyName = "TargetProgram";
            this.TargetProgram.FillWeight = 155F;
            this.TargetProgram.HeaderText = "Target Program";
            this.TargetProgram.Name = "TargetProgram";
            this.TargetProgram.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAtDisplay";
            this.CreatedAt.HeaderText = "Created Date";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StatusDisplayName";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // _pnlApplications
            // 
            this._pnlApplications.BackColor = System.Drawing.Color.White;
            this._pnlApplications.Controls.Add(this._lAppEvaluations);
            this._pnlApplications.Controls.Add(this._gridAppEvaluations);
            this._pnlApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlApplications.Location = new System.Drawing.Point(0, 0);
            this._pnlApplications.Name = "_pnlApplications";
            this._pnlApplications.Size = new System.Drawing.Size(335, 569);
            this._pnlApplications.TabIndex = 0;
            // 
            // _lAppEvaluations
            // 
            this._lAppEvaluations.BackColor = System.Drawing.Color.AliceBlue;
            this._lAppEvaluations.Dock = System.Windows.Forms.DockStyle.Top;
            this._lAppEvaluations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lAppEvaluations.Location = new System.Drawing.Point(0, 0);
            this._lAppEvaluations.Name = "_lAppEvaluations";
            this._lAppEvaluations.Size = new System.Drawing.Size(335, 20);
            this._lAppEvaluations.TabIndex = 2;
            this._lAppEvaluations.Text = "Courses";
            this._lAppEvaluations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _gridAppEvaluations
            // 
            this._gridAppEvaluations.AllowUserToAddRows = false;
            this._gridAppEvaluations.AllowUserToDeleteRows = false;
            this._gridAppEvaluations.AllowUserToOrderColumns = true;
            this._gridAppEvaluations.AllowUserToResizeRows = false;
            this._gridAppEvaluations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridAppEvaluations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridAppEvaluations.BackgroundColor = System.Drawing.Color.White;
            this._gridAppEvaluations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gridAppEvaluations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridAppEvaluations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._gridAppEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridAppEvaluations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this._gridAppEvaluations.DefaultCellStyle = dataGridViewCellStyle5;
            this._gridAppEvaluations.EnableHeadersVisualStyles = false;
            this._gridAppEvaluations.Location = new System.Drawing.Point(-2, 21);
            this._gridAppEvaluations.MultiSelect = false;
            this._gridAppEvaluations.Name = "_gridAppEvaluations";
            this._gridAppEvaluations.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridAppEvaluations.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._gridAppEvaluations.RowHeadersVisible = false;
            this._gridAppEvaluations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridAppEvaluations.Size = new System.Drawing.Size(341, 550);
            this._gridAppEvaluations.TabIndex = 15;
            this._gridAppEvaluations.TabStop = false;
            // 
            // CourseCode
            // 
            this.CourseCode.DataPropertyName = "CourseCode";
            this.CourseCode.HeaderText = "Code";
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.ReadOnly = true;
            // 
            // Instructor
            // 
            this.Instructor.DataPropertyName = "Instructor";
            this.Instructor.FillWeight = 125F;
            this.Instructor.HeaderText = "Evaluator";
            this.Instructor.Name = "Instructor";
            this.Instructor.ReadOnly = true;
            // 
            // EvaluationStatus
            // 
            this.EvaluationStatus.DataPropertyName = "StatusDisplayName";
            this.EvaluationStatus.HeaderText = "Status";
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
            this.MinimumSize = new System.Drawing.Size(1190, 375);
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
            ((System.ComponentModel.ISupportInitialize)(this._gridAppEvaluations)).EndInit();
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
        private Controls.TlDataGrid _gridAppEvaluations;
        private Label _lAppEvaluations;
        private Controls.TlButton _btnOpen;
        private Controls.TlButton _btnAdd;
        private Controls.TlButton _btnImportExcel;
        private Controls.TlButton _btnExportExcel;
        private Controls.TlButton _btnSendEmail;
        private DataGridViewTextBoxColumn CourseCode;
        private DataGridViewTextBoxColumn Instructor;
        private DataGridViewTextBoxColumn EvaluationStatus;
        private Controls.TlButton _btnToggleCourses;
        private Controls.TlButton _btnChangeExcelLocation;
        private Controls.TlButton _btnDelete;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Organization;
        private DataGridViewTextBoxColumn TargetProgram;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn Status;
    }
}