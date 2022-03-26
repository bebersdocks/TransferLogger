namespace TransferLogger.Ui.Controls.Applications.Builder
{
    partial class ApplicationBuilder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._splitContainerTop = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._btnSelectStudent = new TransferLogger.Ui.Controls.TlButton();
            this._cbStudents = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lStudent = new System.Windows.Forms.Label();
            this._btnSelectOrganization = new TransferLogger.Ui.Controls.TlButton();
            this._cbOrganizations = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lOrganization = new System.Windows.Forms.Label();
            this._cbCycles = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lCycle = new System.Windows.Forms.Label();
            this._btnSelectProgram = new TransferLogger.Ui.Controls.TlButton();
            this._cbPrograms = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lCountry = new System.Windows.Forms.Label();
            this._lSearchName = new System.Windows.Forms.Label();
            this._tbSearchName = new TransferLogger.Ui.Controls.TlTextBox();
            this._lHorizontalLine = new System.Windows.Forms.Label();
            this._pnlCourses = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._gridCourses = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lCourses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerTop)).BeginInit();
            this._splitContainerTop.Panel1.SuspendLayout();
            this._splitContainerTop.Panel2.SuspendLayout();
            this._splitContainerTop.SuspendLayout();
            this._pnlCourses.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridCourses)).BeginInit();
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
            this._splitContainer.Panel1.Controls.Add(this._splitContainerTop);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this._pnlCourses);
            this._splitContainer.Size = new System.Drawing.Size(939, 605);
            this._splitContainer.SplitterDistance = 167;
            this._splitContainer.TabIndex = 3;
            // 
            // _splitContainerTop
            // 
            this._splitContainerTop.BackColor = System.Drawing.Color.White;
            this._splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerTop.IsSplitterFixed = true;
            this._splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this._splitContainerTop.Name = "_splitContainerTop";
            this._splitContainerTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainerTop.Panel1
            // 
            this._splitContainerTop.Panel1.BackColor = System.Drawing.Color.White;
            this._splitContainerTop.Panel1.Controls.Add(this._btnSelectStudent);
            this._splitContainerTop.Panel1.Controls.Add(this._cbStudents);
            this._splitContainerTop.Panel1.Controls.Add(this._lStudent);
            this._splitContainerTop.Panel1.Controls.Add(this._btnSelectOrganization);
            this._splitContainerTop.Panel1.Controls.Add(this._cbOrganizations);
            this._splitContainerTop.Panel1.Controls.Add(this._lOrganization);
            // 
            // _splitContainerTop.Panel2
            // 
            this._splitContainerTop.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainerTop.Panel2.Controls.Add(this._cbCycles);
            this._splitContainerTop.Panel2.Controls.Add(this._lCycle);
            this._splitContainerTop.Panel2.Controls.Add(this._btnSelectProgram);
            this._splitContainerTop.Panel2.Controls.Add(this._cbPrograms);
            this._splitContainerTop.Panel2.Controls.Add(this._lCountry);
            this._splitContainerTop.Panel2.Controls.Add(this._lSearchName);
            this._splitContainerTop.Panel2.Controls.Add(this._tbSearchName);
            this._splitContainerTop.Panel2.Controls.Add(this._lHorizontalLine);
            this._splitContainerTop.Size = new System.Drawing.Size(939, 167);
            this._splitContainerTop.SplitterDistance = 57;
            this._splitContainerTop.TabIndex = 0;
            // 
            // _btnSelectStudent
            // 
            this._btnSelectStudent.AutoSize = true;
            this._btnSelectStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectStudent.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnSelectStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectStudent.ForeColor = System.Drawing.Color.Black;
            this._btnSelectStudent.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectStudent.Location = new System.Drawing.Point(386, 20);
            this._btnSelectStudent.MaximumSize = new System.Drawing.Size(0, 23);
            this._btnSelectStudent.MinimumSize = new System.Drawing.Size(0, 23);
            this._btnSelectStudent.Name = "_btnSelectStudent";
            this._btnSelectStudent.Size = new System.Drawing.Size(28, 23);
            this._btnSelectStudent.TabIndex = 1;
            this._btnSelectStudent.TabStop = false;
            this._btnSelectStudent.Text = "...";
            this._btnSelectStudent.UseVisualStyleBackColor = false;
            // 
            // _cbStudents
            // 
            this._cbStudents.BackColor = System.Drawing.Color.GhostWhite;
            this._cbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbStudents.FormattingEnabled = true;
            this._cbStudents.Location = new System.Drawing.Point(89, 20);
            this._cbStudents.Name = "_cbStudents";
            this._cbStudents.Size = new System.Drawing.Size(291, 23);
            this._cbStudents.TabIndex = 0;
            // 
            // _lStudent
            // 
            this._lStudent.AutoSize = true;
            this._lStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lStudent.Location = new System.Drawing.Point(28, 22);
            this._lStudent.Name = "_lStudent";
            this._lStudent.Size = new System.Drawing.Size(55, 17);
            this._lStudent.TabIndex = 30;
            this._lStudent.Text = "Student:";
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
            this._btnSelectOrganization.Location = new System.Drawing.Point(844, 21);
            this._btnSelectOrganization.MaximumSize = new System.Drawing.Size(0, 23);
            this._btnSelectOrganization.MinimumSize = new System.Drawing.Size(0, 23);
            this._btnSelectOrganization.Name = "_btnSelectOrganization";
            this._btnSelectOrganization.Size = new System.Drawing.Size(28, 23);
            this._btnSelectOrganization.TabIndex = 3;
            this._btnSelectOrganization.TabStop = false;
            this._btnSelectOrganization.Text = "...";
            this._btnSelectOrganization.UseVisualStyleBackColor = false;
            // 
            // _cbOrganizations
            // 
            this._cbOrganizations.BackColor = System.Drawing.Color.GhostWhite;
            this._cbOrganizations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbOrganizations.FormattingEnabled = true;
            this._cbOrganizations.Location = new System.Drawing.Point(547, 21);
            this._cbOrganizations.Name = "_cbOrganizations";
            this._cbOrganizations.Size = new System.Drawing.Size(291, 23);
            this._cbOrganizations.TabIndex = 2;
            // 
            // _lOrganization
            // 
            this._lOrganization.AutoSize = true;
            this._lOrganization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganization.Location = new System.Drawing.Point(455, 23);
            this._lOrganization.Name = "_lOrganization";
            this._lOrganization.Size = new System.Drawing.Size(86, 17);
            this._lOrganization.TabIndex = 27;
            this._lOrganization.Text = "Organization:";
            // 
            // _cbCycles
            // 
            this._cbCycles.BackColor = System.Drawing.Color.GhostWhite;
            this._cbCycles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCycles.FormattingEnabled = true;
            this._cbCycles.Location = new System.Drawing.Point(547, 60);
            this._cbCycles.Name = "_cbCycles";
            this._cbCycles.Size = new System.Drawing.Size(325, 23);
            this._cbCycles.TabIndex = 7;
            // 
            // _lCycle
            // 
            this._lCycle.AutoSize = true;
            this._lCycle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCycle.Location = new System.Drawing.Point(500, 61);
            this._lCycle.Name = "_lCycle";
            this._lCycle.Size = new System.Drawing.Size(41, 17);
            this._lCycle.TabIndex = 27;
            this._lCycle.Text = "Cycle:";
            // 
            // _btnSelectProgram
            // 
            this._btnSelectProgram.AutoSize = true;
            this._btnSelectProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectProgram.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnSelectProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectProgram.ForeColor = System.Drawing.Color.Black;
            this._btnSelectProgram.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectProgram.Location = new System.Drawing.Point(386, 58);
            this._btnSelectProgram.MaximumSize = new System.Drawing.Size(0, 23);
            this._btnSelectProgram.MinimumSize = new System.Drawing.Size(0, 23);
            this._btnSelectProgram.Name = "_btnSelectProgram";
            this._btnSelectProgram.Size = new System.Drawing.Size(28, 23);
            this._btnSelectProgram.TabIndex = 6;
            this._btnSelectProgram.TabStop = false;
            this._btnSelectProgram.Text = "...";
            this._btnSelectProgram.UseVisualStyleBackColor = false;
            // 
            // _cbPrograms
            // 
            this._cbPrograms.BackColor = System.Drawing.Color.GhostWhite;
            this._cbPrograms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbPrograms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbPrograms.FormattingEnabled = true;
            this._cbPrograms.Location = new System.Drawing.Point(89, 58);
            this._cbPrograms.Name = "_cbPrograms";
            this._cbPrograms.Size = new System.Drawing.Size(291, 23);
            this._cbPrograms.TabIndex = 5;
            // 
            // _lCountry
            // 
            this._lCountry.AutoSize = true;
            this._lCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCountry.Location = new System.Drawing.Point(21, 60);
            this._lCountry.Name = "_lCountry";
            this._lCountry.Size = new System.Drawing.Size(62, 17);
            this._lCountry.TabIndex = 24;
            this._lCountry.Text = "Program:";
            // 
            // _lSearchName
            // 
            this._lSearchName.AutoSize = true;
            this._lSearchName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lSearchName.Location = new System.Drawing.Point(37, 21);
            this._lSearchName.Name = "_lSearchName";
            this._lSearchName.Size = new System.Drawing.Size(46, 17);
            this._lSearchName.TabIndex = 12;
            this._lSearchName.Text = "Name:";
            // 
            // _tbSearchName
            // 
            this._tbSearchName.BackColor = System.Drawing.Color.GhostWhite;
            this._tbSearchName.BoxWidth = 325;
            this._tbSearchName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbSearchName.ForeColor = System.Drawing.Color.Black;
            this._tbSearchName.Location = new System.Drawing.Point(89, 20);
            this._tbSearchName.Name = "_tbSearchName";
            this._tbSearchName.Size = new System.Drawing.Size(325, 23);
            this._tbSearchName.TabIndex = 4;
            // 
            // _lHorizontalLine
            // 
            this._lHorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lHorizontalLine.Dock = System.Windows.Forms.DockStyle.Top;
            this._lHorizontalLine.Location = new System.Drawing.Point(0, 0);
            this._lHorizontalLine.Name = "_lHorizontalLine";
            this._lHorizontalLine.Size = new System.Drawing.Size(939, 1);
            this._lHorizontalLine.TabIndex = 0;
            // 
            // _pnlCourses
            // 
            this._pnlCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlCourses.BackColor = System.Drawing.Color.GhostWhite;
            this._pnlCourses.Controls.Add(this.panel1);
            this._pnlCourses.Location = new System.Drawing.Point(-2, 0);
            this._pnlCourses.Name = "_pnlCourses";
            this._pnlCourses.Size = new System.Drawing.Size(941, 434);
            this._pnlCourses.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._gridCourses);
            this.panel1.Controls.Add(this._lCourses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 434);
            this.panel1.TabIndex = 0;
            // 
            // _gridCourses
            // 
            this._gridCourses.AllowUserToAddRows = false;
            this._gridCourses.AllowUserToDeleteRows = false;
            this._gridCourses.AllowUserToOrderColumns = true;
            this._gridCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridCourses.BackgroundColor = System.Drawing.Color.White;
            this._gridCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gridCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this._gridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.Id,
            this.CourseName,
            this.Program,
            this.Cycle});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridCourses.DefaultCellStyle = dataGridViewCellStyle8;
            this._gridCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridCourses.EnableHeadersVisualStyles = false;
            this._gridCourses.Location = new System.Drawing.Point(0, 20);
            this._gridCourses.MultiSelect = false;
            this._gridCourses.Name = "_gridCourses";
            this._gridCourses.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this._gridCourses.RowHeadersVisible = false;
            this._gridCourses.RowTemplate.Height = 25;
            this._gridCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridCourses.Size = new System.Drawing.Size(941, 414);
            this._gridCourses.TabIndex = 8;
            // 
            // Selected
            // 
            this.Selected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Selected.FillWeight = 90F;
            this.Selected.HeaderText = "Selected";
            this.Selected.MinimumWidth = 75;
            this.Selected.Name = "Selected";
            this.Selected.ReadOnly = true;
            this.Selected.Width = 75;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 75;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "Name";
            this.CourseName.FillWeight = 115F;
            this.CourseName.HeaderText = "Name";
            this.CourseName.MinimumWidth = 300;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Program
            // 
            this.Program.DataPropertyName = "Program";
            this.Program.FillWeight = 115F;
            this.Program.HeaderText = "Program";
            this.Program.MinimumWidth = 300;
            this.Program.Name = "Program";
            this.Program.ReadOnly = true;
            // 
            // Cycle
            // 
            this.Cycle.DataPropertyName = "Cycle";
            this.Cycle.HeaderText = "Cycle";
            this.Cycle.MinimumWidth = 100;
            this.Cycle.Name = "Cycle";
            this.Cycle.ReadOnly = true;
            // 
            // _lCourses
            // 
            this._lCourses.BackColor = System.Drawing.Color.AliceBlue;
            this._lCourses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._lCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this._lCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCourses.Location = new System.Drawing.Point(0, 0);
            this._lCourses.Name = "_lCourses";
            this._lCourses.Size = new System.Drawing.Size(941, 20);
            this._lCourses.TabIndex = 4;
            this._lCourses.Text = "Courses";
            this._lCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApplicationBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this._splitContainer);
            this.Name = "ApplicationBuilder";
            this.Size = new System.Drawing.Size(939, 605);
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._splitContainerTop.Panel1.ResumeLayout(false);
            this._splitContainerTop.Panel1.PerformLayout();
            this._splitContainerTop.Panel2.ResumeLayout(false);
            this._splitContainerTop.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerTop)).EndInit();
            this._splitContainerTop.ResumeLayout(false);
            this._pnlCourses.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.Panel _pnlCourses;
        private System.Windows.Forms.Label _lCourses;
        private TlDataGrid _gridCourses;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycle;
        private System.Windows.Forms.Panel panel1;
        private TlSplitContainer _splitContainerTop;
        private System.Windows.Forms.Label _lHorizontalLine;
        private TlButton _btnSelectStudent;
        private TlDropDownList _cbStudents;
        private System.Windows.Forms.Label _lStudent;
        private TlButton _btnSelectOrganization;
        private TlDropDownList _cbOrganizations;
        private System.Windows.Forms.Label _lOrganization;
        private System.Windows.Forms.Label _lSearchName;
        private TlTextBox _tbSearchName;
        private TlButton _btnSelectProgram;
        private TlDropDownList _cbPrograms;
        private System.Windows.Forms.Label _lCountry;
        private TlDropDownList _cbCycles;
        private System.Windows.Forms.Label _lCycle;
    }
}
