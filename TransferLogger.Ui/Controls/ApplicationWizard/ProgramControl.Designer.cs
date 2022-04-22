namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    partial class ProgramControl
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
            this._gbManageOrganizations = new System.Windows.Forms.GroupBox();
            this._btnManage = new TransferLogger.Ui.Controls.TlButton();
            this._btnAdd = new TransferLogger.Ui.Controls.TlButton();
            this._lInstructions = new System.Windows.Forms.Label();
            this._cbCycles = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lCycle = new System.Windows.Forms.Label();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tbSearchName = new TransferLogger.Ui.Controls.TlTextBox();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._gbManageOrganizations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _splitContainer
            // 
            this._splitContainer.BackColor = System.Drawing.Color.White;
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            this._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel1.Controls.Add(this._gbManageOrganizations);
            this._splitContainer.Panel1.Controls.Add(this._lInstructions);
            this._splitContainer.Panel1.Controls.Add(this._cbCycles);
            this._splitContainer.Panel1.Controls.Add(this._lCycle);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel2.Controls.Add(this._grid);
            this._splitContainer.Panel2.Controls.Add(this._tbSearchName);
            this._splitContainer.Size = new System.Drawing.Size(828, 539);
            this._splitContainer.SplitterDistance = 113;
            this._splitContainer.TabIndex = 0;
            // 
            // _gbManageOrganizations
            // 
            this._gbManageOrganizations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._gbManageOrganizations.Controls.Add(this._btnManage);
            this._gbManageOrganizations.Controls.Add(this._btnAdd);
            this._gbManageOrganizations.Location = new System.Drawing.Point(677, 32);
            this._gbManageOrganizations.Name = "_gbManageOrganizations";
            this._gbManageOrganizations.Size = new System.Drawing.Size(130, 60);
            this._gbManageOrganizations.TabIndex = 47;
            this._gbManageOrganizations.TabStop = false;
            this._gbManageOrganizations.Text = "Manage Programs";
            // 
            // _btnManage
            // 
            this._btnManage.AutoSize = true;
            this._btnManage.BackColor = System.Drawing.Color.White;
            this._btnManage.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.grid;
            this._btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnManage.ForeColor = System.Drawing.Color.Black;
            this._btnManage.Location = new System.Drawing.Point(46, 20);
            this._btnManage.Name = "_btnManage";
            this._btnManage.Size = new System.Drawing.Size(32, 32);
            this._btnManage.TabIndex = 7;
            this._btnManage.TabStop = false;
            this._btnManage.UseVisualStyleBackColor = false;
            // 
            // _btnAdd
            // 
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
            this._btnAdd.Location = new System.Drawing.Point(8, 20);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(32, 32);
            this._btnAdd.TabIndex = 6;
            this._btnAdd.TabStop = false;
            this._btnAdd.UseVisualStyleBackColor = false;
            // 
            // _lInstructions
            // 
            this._lInstructions.AutoSize = true;
            this._lInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lInstructions.ForeColor = System.Drawing.Color.Black;
            this._lInstructions.Location = new System.Drawing.Point(56, 16);
            this._lInstructions.Name = "_lInstructions";
            this._lInstructions.Size = new System.Drawing.Size(247, 17);
            this._lInstructions.TabIndex = 39;
            this._lInstructions.Text = "Choose target program or add new one.";
            // 
            // _cbCycles
            // 
            this._cbCycles.BackColor = System.Drawing.Color.GhostWhite;
            this._cbCycles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCycles.FormattingEnabled = true;
            this._cbCycles.Location = new System.Drawing.Point(84, 50);
            this._cbCycles.Name = "_cbCycles";
            this._cbCycles.Size = new System.Drawing.Size(325, 23);
            this._cbCycles.TabIndex = 22;
            // 
            // _lCycle
            // 
            this._lCycle.AutoSize = true;
            this._lCycle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCycle.Location = new System.Drawing.Point(40, 51);
            this._lCycle.Name = "_lCycle";
            this._lCycle.Size = new System.Drawing.Size(41, 17);
            this._lCycle.TabIndex = 25;
            this._lCycle.Text = "Cycle:";
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
            this.ProgramName,
            this.Cycle,
            this.Year});
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
            this._grid.ReadOnly = true;
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
            this._grid.Size = new System.Drawing.Size(828, 399);
            this._grid.TabIndex = 5;
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selected";
            this.Selected.FalseValue = "False";
            this.Selected.FillWeight = 95F;
            this.Selected.HeaderText = "Selected";
            this.Selected.Name = "Selected";
            this.Selected.ReadOnly = true;
            this.Selected.TrueValue = "True";
            // 
            // ProgramName
            // 
            this.ProgramName.DataPropertyName = "Name";
            this.ProgramName.FillWeight = 200F;
            this.ProgramName.HeaderText = "Name";
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.ReadOnly = true;
            // 
            // Cycle
            // 
            this.Cycle.DataPropertyName = "Cycle";
            this.Cycle.FillWeight = 130F;
            this.Cycle.HeaderText = "Cycle";
            this.Cycle.Name = "Cycle";
            this.Cycle.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // _tbSearchName
            // 
            this._tbSearchName.BackColor = System.Drawing.Color.GhostWhite;
            this._tbSearchName.BoxWidth = 325;
            this._tbSearchName.Dock = System.Windows.Forms.DockStyle.Top;
            this._tbSearchName.ForeColor = System.Drawing.Color.Black;
            this._tbSearchName.Location = new System.Drawing.Point(0, 0);
            this._tbSearchName.Name = "_tbSearchName";
            this._tbSearchName.PlaceholderText = "Type here to filter programs";
            this._tbSearchName.Size = new System.Drawing.Size(828, 23);
            this._tbSearchName.TabIndex = 1;
            // 
            // ProgramControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._splitContainer);
            this.Name = "ProgramControl";
            this.Size = new System.Drawing.Size(828, 539);
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel1.PerformLayout();
            this._splitContainer.Panel2.ResumeLayout(false);
            this._splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._gbManageOrganizations.ResumeLayout(false);
            this._gbManageOrganizations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TlSplitContainer _splitContainer;
        private TlTextBox _tbSearchName;
        private TlDataGrid _grid;
        private TlDropDownList _cbCycles;
        private System.Windows.Forms.Label _lCycle;
        private System.Windows.Forms.Label _lInstructions;
        private System.Windows.Forms.GroupBox _gbManageOrganizations;
        private TlButton _btnManage;
        private TlButton _btnAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
    }
}
