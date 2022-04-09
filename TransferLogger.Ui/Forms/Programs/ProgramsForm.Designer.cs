using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Programs
{
    partial class ProgramsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramsForm));
            this._splitContainer = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._btnSelectOrganization = new TransferLogger.Ui.Controls.TlButton();
            this._cbOrganizations = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lOrganization = new System.Windows.Forms.Label();
            this._cbCycles = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lCycle = new System.Windows.Forms.Label();
            this._lSearchName = new System.Windows.Forms.Label();
            this._tbSearchName = new TransferLogger.Ui.Controls.TlTextBox();
            this._btnDelete = new TransferLogger.Ui.Controls.TlButton();
            this._btnEdit = new TransferLogger.Ui.Controls.TlButton();
            this._btnAdd = new TransferLogger.Ui.Controls.TlButton();
            this._lPrograms = new System.Windows.Forms.Label();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this.SuspendLayout();
            // 
            // _splitContainer
            // 
            this._splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._splitContainer.BackColor = System.Drawing.Color.GhostWhite;
            this._splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._splitContainer.IsSplitterFixed = true;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            this._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel1.Controls.Add(this._btnSelectOrganization);
            this._splitContainer.Panel1.Controls.Add(this._cbOrganizations);
            this._splitContainer.Panel1.Controls.Add(this._lOrganization);
            this._splitContainer.Panel1.Controls.Add(this._cbCycles);
            this._splitContainer.Panel1.Controls.Add(this._lCycle);
            this._splitContainer.Panel1.Controls.Add(this._lSearchName);
            this._splitContainer.Panel1.Controls.Add(this._tbSearchName);
            this._splitContainer.Panel1.Controls.Add(this._btnDelete);
            this._splitContainer.Panel1.Controls.Add(this._btnEdit);
            this._splitContainer.Panel1.Controls.Add(this._btnAdd);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel2.Controls.Add(this._lPrograms);
            this._splitContainer.Panel2.Controls.Add(this._grid);
            this._splitContainer.Size = new System.Drawing.Size(1069, 636);
            this._splitContainer.SplitterDistance = 99;
            this._splitContainer.TabIndex = 5;
            // 
            // _btnSelectOrganization
            // 
            this._btnSelectOrganization.AutoSize = true;
            this._btnSelectOrganization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectOrganization.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnSelectOrganization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectOrganization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectOrganization.ForeColor = System.Drawing.Color.Black;
            this._btnSelectOrganization.Location = new System.Drawing.Point(823, 17);
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
            this._cbOrganizations.Location = new System.Drawing.Point(526, 17);
            this._cbOrganizations.Name = "_cbOrganizations";
            this._cbOrganizations.Size = new System.Drawing.Size(291, 23);
            this._cbOrganizations.TabIndex = 2;
            // 
            // _lOrganization
            // 
            this._lOrganization.AutoSize = true;
            this._lOrganization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganization.Location = new System.Drawing.Point(434, 19);
            this._lOrganization.Name = "_lOrganization";
            this._lOrganization.Size = new System.Drawing.Size(86, 17);
            this._lOrganization.TabIndex = 21;
            this._lOrganization.Text = "Organization:";
            // 
            // _cbCycles
            // 
            this._cbCycles.BackColor = System.Drawing.Color.GhostWhite;
            this._cbCycles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCycles.FormattingEnabled = true;
            this._cbCycles.Location = new System.Drawing.Point(71, 55);
            this._cbCycles.Name = "_cbCycles";
            this._cbCycles.Size = new System.Drawing.Size(325, 23);
            this._cbCycles.TabIndex = 1;
            // 
            // _lCycle
            // 
            this._lCycle.AutoSize = true;
            this._lCycle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCycle.Location = new System.Drawing.Point(24, 56);
            this._lCycle.Name = "_lCycle";
            this._lCycle.Size = new System.Drawing.Size(41, 17);
            this._lCycle.TabIndex = 14;
            this._lCycle.Text = "Cycle:";
            // 
            // _lSearchName
            // 
            this._lSearchName.AutoSize = true;
            this._lSearchName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lSearchName.Location = new System.Drawing.Point(19, 19);
            this._lSearchName.Name = "_lSearchName";
            this._lSearchName.Size = new System.Drawing.Size(46, 17);
            this._lSearchName.TabIndex = 10;
            this._lSearchName.Text = "Name:";
            // 
            // _tbSearchName
            // 
            this._tbSearchName.BackColor = System.Drawing.Color.GhostWhite;
            this._tbSearchName.BoxWidth = 325;
            this._tbSearchName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbSearchName.ForeColor = System.Drawing.Color.Black;
            this._tbSearchName.Location = new System.Drawing.Point(71, 17);
            this._tbSearchName.Name = "_tbSearchName";
            this._tbSearchName.Size = new System.Drawing.Size(325, 23);
            this._tbSearchName.TabIndex = 0;
            // 
            // _btnDelete
            // 
            this._btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDelete.AutoSize = true;
            this._btnDelete.BackColor = System.Drawing.Color.Transparent;
            this._btnDelete.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.delete;
            this._btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDelete.ForeColor = System.Drawing.Color.Black;
            this._btnDelete.Location = new System.Drawing.Point(1013, 12);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(32, 32);
            this._btnDelete.TabIndex = 6;
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
            this._btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEdit.ForeColor = System.Drawing.Color.Black;
            this._btnEdit.Location = new System.Drawing.Point(975, 12);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(32, 32);
            this._btnEdit.TabIndex = 5;
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
            this._btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAdd.ForeColor = System.Drawing.Color.Black;
            this._btnAdd.Location = new System.Drawing.Point(937, 12);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(32, 32);
            this._btnAdd.TabIndex = 4;
            this._btnAdd.TabStop = false;
            this._btnAdd.UseVisualStyleBackColor = false;
            // 
            // _lPrograms
            // 
            this._lPrograms.BackColor = System.Drawing.Color.AliceBlue;
            this._lPrograms.Dock = System.Windows.Forms.DockStyle.Top;
            this._lPrograms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lPrograms.Location = new System.Drawing.Point(0, 0);
            this._lPrograms.Name = "_lPrograms";
            this._lPrograms.Size = new System.Drawing.Size(1065, 20);
            this._lPrograms.TabIndex = 2;
            this._lPrograms.Text = "Programs";
            this._lPrograms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProgramName,
            this.Organization,
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
            this._grid.EnableHeadersVisualStyles = false;
            this._grid.Location = new System.Drawing.Point(-2, 21);
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
            this._grid.RowTemplate.Height = 25;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(1069, 506);
            this._grid.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 75;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ProgramName
            // 
            this.ProgramName.DataPropertyName = "Name";
            this.ProgramName.FillWeight = 110F;
            this.ProgramName.HeaderText = "Name";
            this.ProgramName.MinimumWidth = 300;
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.ReadOnly = true;
            // 
            // Organization
            // 
            this.Organization.DataPropertyName = "Organization";
            this.Organization.FillWeight = 130F;
            this.Organization.HeaderText = "Organization";
            this.Organization.MinimumWidth = 275;
            this.Organization.Name = "Organization";
            this.Organization.ReadOnly = true;
            // 
            // Cycle
            // 
            this.Cycle.DataPropertyName = "Cycle";
            this.Cycle.FillWeight = 105F;
            this.Cycle.HeaderText = "Cycle";
            this.Cycle.MinimumWidth = 120;
            this.Cycle.Name = "Cycle";
            this.Cycle.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 50;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // ProgramsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 636);
            this.Controls.Add(this._splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1085, 675);
            this.Name = "ProgramsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programs";
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel1.PerformLayout();
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.TlDataGrid _grid;
        private Controls.TlSplitContainer _splitContainer;
        private Label _lPrograms;
        private Controls.TlButton _btnAdd;
        private Controls.TlButton _btnDelete;
        private Controls.TlButton _btnEdit;
        private Controls.TlTextBox _tbSearchName;
        private Label _lSearchName;
        private Label _lCycle;
        private Controls.TlDropDownList _cbCycles;
        private Label _lOrganization;
        private Controls.TlDropDownList _cbOrganizations;
        private Controls.TlButton _btnSelectOrganization;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProgramName;
        private DataGridViewTextBoxColumn Organization;
        private DataGridViewTextBoxColumn Cycle;
        private DataGridViewTextBoxColumn Year;
    }
}