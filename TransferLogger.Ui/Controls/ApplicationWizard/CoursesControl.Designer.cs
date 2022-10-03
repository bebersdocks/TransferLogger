namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    partial class CoursesControl
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
            this._splitContainer = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._gbManageCourses = new System.Windows.Forms.GroupBox();
            this._btnManageCourses = new TransferLogger.Ui.Controls.TlButton();
            this._btnAddCourse = new TransferLogger.Ui.Controls.TlButton();
            this._gbManagePrograms = new System.Windows.Forms.GroupBox();
            this._btnManagePrograms = new TransferLogger.Ui.Controls.TlButton();
            this._btnAddProgram = new TransferLogger.Ui.Controls.TlButton();
            this._lInstructions = new System.Windows.Forms.Label();
            this._cbCycles = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lCycle = new System.Windows.Forms.Label();
            this._btnSelectProgram = new TransferLogger.Ui.Controls.TlButton();
            this._cbPrograms = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lCountry = new System.Windows.Forms.Label();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
            this._tbSearchName = new TransferLogger.Ui.Controls.TlTextBox();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._gbManageCourses.SuspendLayout();
            this._gbManagePrograms.SuspendLayout();
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
            this._splitContainer.Panel1.Controls.Add(this._gbManageCourses);
            this._splitContainer.Panel1.Controls.Add(this._gbManagePrograms);
            this._splitContainer.Panel1.Controls.Add(this._lInstructions);
            this._splitContainer.Panel1.Controls.Add(this._cbCycles);
            this._splitContainer.Panel1.Controls.Add(this._lCycle);
            this._splitContainer.Panel1.Controls.Add(this._btnSelectProgram);
            this._splitContainer.Panel1.Controls.Add(this._cbPrograms);
            this._splitContainer.Panel1.Controls.Add(this._lCountry);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel2.Controls.Add(this._grid);
            this._splitContainer.Panel2.Controls.Add(this._tbSearchName);
            this._splitContainer.Size = new System.Drawing.Size(824, 525);
            this._splitContainer.SplitterDistance = 128;
            this._splitContainer.TabIndex = 0;
            // 
            // _gbManageCourses
            // 
            this._gbManageCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._gbManageCourses.Controls.Add(this._btnManageCourses);
            this._gbManageCourses.Controls.Add(this._btnAddCourse);
            this._gbManageCourses.Location = new System.Drawing.Point(541, 32);
            this._gbManageCourses.Name = "_gbManageCourses";
            this._gbManageCourses.Size = new System.Drawing.Size(130, 60);
            this._gbManageCourses.TabIndex = 46;
            this._gbManageCourses.TabStop = false;
            this._gbManageCourses.Text = "Manage Courses";
            // 
            // _btnManageCourses
            // 
            this._btnManageCourses.AutoSize = true;
            this._btnManageCourses.BackColor = System.Drawing.Color.White;
            this._btnManageCourses.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.grid;
            this._btnManageCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnManageCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnManageCourses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnManageCourses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnManageCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnManageCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnManageCourses.ForeColor = System.Drawing.Color.Black;
            this._btnManageCourses.Location = new System.Drawing.Point(46, 20);
            this._btnManageCourses.Name = "_btnManageCourses";
            this._btnManageCourses.Size = new System.Drawing.Size(32, 32);
            this._btnManageCourses.TabIndex = 7;
            this._btnManageCourses.UseVisualStyleBackColor = false;
            // 
            // _btnAddCourse
            // 
            this._btnAddCourse.AutoSize = true;
            this._btnAddCourse.BackColor = System.Drawing.Color.White;
            this._btnAddCourse.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.plus;
            this._btnAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnAddCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnAddCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnAddCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAddCourse.ForeColor = System.Drawing.Color.Black;
            this._btnAddCourse.Location = new System.Drawing.Point(8, 20);
            this._btnAddCourse.Name = "_btnAddCourse";
            this._btnAddCourse.Size = new System.Drawing.Size(32, 32);
            this._btnAddCourse.TabIndex = 6;
            this._btnAddCourse.UseVisualStyleBackColor = false;
            // 
            // _gbManagePrograms
            // 
            this._gbManagePrograms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._gbManagePrograms.Controls.Add(this._btnManagePrograms);
            this._gbManagePrograms.Controls.Add(this._btnAddProgram);
            this._gbManagePrograms.Location = new System.Drawing.Point(677, 32);
            this._gbManagePrograms.Name = "_gbManagePrograms";
            this._gbManagePrograms.Size = new System.Drawing.Size(130, 60);
            this._gbManagePrograms.TabIndex = 45;
            this._gbManagePrograms.TabStop = false;
            this._gbManagePrograms.Text = "Manage Programs";
            // 
            // _btnManagePrograms
            // 
            this._btnManagePrograms.AutoSize = true;
            this._btnManagePrograms.BackColor = System.Drawing.Color.White;
            this._btnManagePrograms.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.grid;
            this._btnManagePrograms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnManagePrograms.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnManagePrograms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnManagePrograms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnManagePrograms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnManagePrograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnManagePrograms.ForeColor = System.Drawing.Color.Black;
            this._btnManagePrograms.Location = new System.Drawing.Point(46, 20);
            this._btnManagePrograms.Name = "_btnManagePrograms";
            this._btnManagePrograms.Size = new System.Drawing.Size(32, 32);
            this._btnManagePrograms.TabIndex = 9;
            this._btnManagePrograms.UseVisualStyleBackColor = false;
            // 
            // _btnAddProgram
            // 
            this._btnAddProgram.AutoSize = true;
            this._btnAddProgram.BackColor = System.Drawing.Color.White;
            this._btnAddProgram.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.plus;
            this._btnAddProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAddProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnAddProgram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnAddProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnAddProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnAddProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAddProgram.ForeColor = System.Drawing.Color.Black;
            this._btnAddProgram.Location = new System.Drawing.Point(8, 20);
            this._btnAddProgram.Name = "_btnAddProgram";
            this._btnAddProgram.Size = new System.Drawing.Size(32, 32);
            this._btnAddProgram.TabIndex = 8;
            this._btnAddProgram.UseVisualStyleBackColor = false;
            // 
            // _lInstructions
            // 
            this._lInstructions.AutoSize = true;
            this._lInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lInstructions.ForeColor = System.Drawing.Color.Black;
            this._lInstructions.Location = new System.Drawing.Point(47, 17);
            this._lInstructions.Name = "_lInstructions";
            this._lInstructions.Size = new System.Drawing.Size(309, 17);
            this._lInstructions.TabIndex = 40;
            this._lInstructions.Text = "Select external courses to be evaluated for transfer.";
            // 
            // _cbCycles
            // 
            this._cbCycles.BackColor = System.Drawing.Color.GhostWhite;
            this._cbCycles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCycles.FormattingEnabled = true;
            this._cbCycles.Location = new System.Drawing.Point(85, 50);
            this._cbCycles.Name = "_cbCycles";
            this._cbCycles.Size = new System.Drawing.Size(325, 23);
            this._cbCycles.TabIndex = 1;
            // 
            // _lCycle
            // 
            this._lCycle.AutoSize = true;
            this._lCycle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCycle.Location = new System.Drawing.Point(38, 51);
            this._lCycle.Name = "_lCycle";
            this._lCycle.Size = new System.Drawing.Size(41, 17);
            this._lCycle.TabIndex = 30;
            this._lCycle.Text = "Cycle:";
            // 
            // _btnSelectProgram
            // 
            this._btnSelectProgram.AutoSize = true;
            this._btnSelectProgram.BackColor = System.Drawing.Color.White;
            this._btnSelectProgram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnSelectProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectProgram.ForeColor = System.Drawing.Color.Black;
            this._btnSelectProgram.Location = new System.Drawing.Point(382, 80);
            this._btnSelectProgram.MaximumSize = new System.Drawing.Size(0, 23);
            this._btnSelectProgram.MinimumSize = new System.Drawing.Size(0, 23);
            this._btnSelectProgram.Name = "_btnSelectProgram";
            this._btnSelectProgram.Size = new System.Drawing.Size(28, 23);
            this._btnSelectProgram.TabIndex = 3;
            this._btnSelectProgram.Text = "...";
            this._btnSelectProgram.UseVisualStyleBackColor = false;
            // 
            // _cbPrograms
            // 
            this._cbPrograms.BackColor = System.Drawing.Color.GhostWhite;
            this._cbPrograms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbPrograms.FormattingEnabled = true;
            this._cbPrograms.Location = new System.Drawing.Point(85, 80);
            this._cbPrograms.Name = "_cbPrograms";
            this._cbPrograms.Size = new System.Drawing.Size(291, 23);
            this._cbPrograms.TabIndex = 2;
            // 
            // _lCountry
            // 
            this._lCountry.AutoSize = true;
            this._lCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCountry.Location = new System.Drawing.Point(17, 82);
            this._lCountry.Name = "_lCountry";
            this._lCountry.Size = new System.Drawing.Size(62, 17);
            this._lCountry.TabIndex = 29;
            this._lCountry.Text = "Program:";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.CourseName,
            this.Program,
            this.Cycle});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.DefaultCellStyle = dataGridViewCellStyle2;
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.EnableHeadersVisualStyles = false;
            this._grid.Location = new System.Drawing.Point(0, 23);
            this._grid.MultiSelect = false;
            this._grid.Name = "_grid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._grid.RowHeadersVisible = false;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(824, 370);
            this._grid.TabIndex = 5;
            // 
            // _tbSearchName
            // 
            this._tbSearchName.BackColor = System.Drawing.Color.GhostWhite;
            this._tbSearchName.BoxWidth = 325;
            this._tbSearchName.Dock = System.Windows.Forms.DockStyle.Top;
            this._tbSearchName.ForeColor = System.Drawing.Color.Black;
            this._tbSearchName.Location = new System.Drawing.Point(0, 0);
            this._tbSearchName.Name = "_tbSearchName";
            this._tbSearchName.PlaceholderText = "Type here to filter courses";
            this._tbSearchName.Size = new System.Drawing.Size(824, 23);
            this._tbSearchName.TabIndex = 4;
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selected";
            this.Selected.FalseValue = "False";
            this.Selected.HeaderText = "Selected";
            this.Selected.Name = "Selected";
            this.Selected.TrueValue = "True";
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "Name";
            this.CourseName.FillWeight = 150F;
            this.CourseName.HeaderText = "Name";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Program
            // 
            this.Program.DataPropertyName = "Program";
            this.Program.FillWeight = 150F;
            this.Program.HeaderText = "Program";
            this.Program.Name = "Program";
            this.Program.ReadOnly = true;
            // 
            // Cycle
            // 
            this.Cycle.DataPropertyName = "Cycle";
            this.Cycle.FillWeight = 105F;
            this.Cycle.HeaderText = "Cycle";
            this.Cycle.Name = "Cycle";
            this.Cycle.ReadOnly = true;
            // 
            // CoursesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._splitContainer);
            this.Name = "CoursesControl";
            this.Size = new System.Drawing.Size(824, 525);
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel1.PerformLayout();
            this._splitContainer.Panel2.ResumeLayout(false);
            this._splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._gbManageCourses.ResumeLayout(false);
            this._gbManageCourses.PerformLayout();
            this._gbManagePrograms.ResumeLayout(false);
            this._gbManagePrograms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TlSplitContainer _splitContainer;
        private TlDropDownList _cbCycles;
        private System.Windows.Forms.Label _lCycle;
        private TlButton _btnSelectProgram;
        private TlDropDownList _cbPrograms;
        private System.Windows.Forms.Label _lCountry;
        private System.Windows.Forms.Label _lInstructions;
        private TlTextBox _tbSearchName;
        private TlDataGrid _grid;
        private System.Windows.Forms.GroupBox _gbManagePrograms;
        private TlButton _btnManagePrograms;
        private TlButton _btnAddProgram;
        private System.Windows.Forms.GroupBox _gbManageCourses;
        private TlButton _btnManageCourses;
        private TlButton _btnAddCourse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycle;
    }
}
