﻿namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    partial class OrganizationControl
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
            this._splitContainer = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._btnManage = new TransferLogger.Ui.Controls.TlButton();
            this._lInstructions = new System.Windows.Forms.Label();
            this._btnAdd = new TransferLogger.Ui.Controls.TlButton();
            this._btnSelectCountry = new TransferLogger.Ui.Controls.TlButton();
            this._cbCountries = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lCountry = new System.Windows.Forms.Label();
            this._cbOrganizationTypes = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lOrganizationType = new System.Windows.Forms.Label();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tbSearchName = new TransferLogger.Ui.Controls.TlTextBox();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
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
            this._splitContainer.Panel1.Controls.Add(this._btnManage);
            this._splitContainer.Panel1.Controls.Add(this._lInstructions);
            this._splitContainer.Panel1.Controls.Add(this._btnAdd);
            this._splitContainer.Panel1.Controls.Add(this._btnSelectCountry);
            this._splitContainer.Panel1.Controls.Add(this._cbCountries);
            this._splitContainer.Panel1.Controls.Add(this._lCountry);
            this._splitContainer.Panel1.Controls.Add(this._cbOrganizationTypes);
            this._splitContainer.Panel1.Controls.Add(this._lOrganizationType);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel2.Controls.Add(this._grid);
            this._splitContainer.Panel2.Controls.Add(this._tbSearchName);
            this._splitContainer.Size = new System.Drawing.Size(828, 539);
            this._splitContainer.SplitterDistance = 130;
            this._splitContainer.TabIndex = 0;
            // 
            // _btnManage
            // 
            this._btnManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnManage.BackColor = System.Drawing.Color.White;
            this._btnManage.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnManage.ForeColor = System.Drawing.Color.Navy;
            this._btnManage.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnManage.Location = new System.Drawing.Point(717, 83);
            this._btnManage.Name = "_btnManage";
            this._btnManage.Size = new System.Drawing.Size(97, 30);
            this._btnManage.TabIndex = 40;
            this._btnManage.TabStop = false;
            this._btnManage.Text = "Manage";
            this._btnManage.UseVisualStyleBackColor = false;
            // 
            // _lInstructions
            // 
            this._lInstructions.AutoSize = true;
            this._lInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lInstructions.ForeColor = System.Drawing.Color.Black;
            this._lInstructions.Location = new System.Drawing.Point(56, 16);
            this._lInstructions.Name = "_lInstructions";
            this._lInstructions.Size = new System.Drawing.Size(229, 17);
            this._lInstructions.TabIndex = 39;
            this._lInstructions.Text = "Choose organization or add new one.";
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAdd.BackColor = System.Drawing.Color.White;
            this._btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAdd.ForeColor = System.Drawing.Color.Navy;
            this._btnAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnAdd.Location = new System.Drawing.Point(542, 83);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(169, 30);
            this._btnAdd.TabIndex = 27;
            this._btnAdd.TabStop = false;
            this._btnAdd.Text = "Add New Organization";
            this._btnAdd.UseVisualStyleBackColor = false;
            // 
            // _btnSelectCountry
            // 
            this._btnSelectCountry.AutoSize = true;
            this._btnSelectCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectCountry.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnSelectCountry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectCountry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectCountry.ForeColor = System.Drawing.Color.Black;
            this._btnSelectCountry.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnSelectCountry.Location = new System.Drawing.Point(381, 88);
            this._btnSelectCountry.MaximumSize = new System.Drawing.Size(0, 23);
            this._btnSelectCountry.MinimumSize = new System.Drawing.Size(0, 23);
            this._btnSelectCountry.Name = "_btnSelectCountry";
            this._btnSelectCountry.Size = new System.Drawing.Size(28, 23);
            this._btnSelectCountry.TabIndex = 24;
            this._btnSelectCountry.TabStop = false;
            this._btnSelectCountry.Text = "...";
            this._btnSelectCountry.UseVisualStyleBackColor = false;
            // 
            // _cbCountries
            // 
            this._cbCountries.BackColor = System.Drawing.Color.GhostWhite;
            this._cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCountries.FormattingEnabled = true;
            this._cbCountries.Location = new System.Drawing.Point(84, 88);
            this._cbCountries.Name = "_cbCountries";
            this._cbCountries.Size = new System.Drawing.Size(291, 23);
            this._cbCountries.TabIndex = 23;
            // 
            // _lCountry
            // 
            this._lCountry.AutoSize = true;
            this._lCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCountry.Location = new System.Drawing.Point(22, 89);
            this._lCountry.Name = "_lCountry";
            this._lCountry.Size = new System.Drawing.Size(56, 17);
            this._lCountry.TabIndex = 26;
            this._lCountry.Text = "Country:";
            // 
            // _cbOrganizationTypes
            // 
            this._cbOrganizationTypes.BackColor = System.Drawing.Color.GhostWhite;
            this._cbOrganizationTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbOrganizationTypes.FormattingEnabled = true;
            this._cbOrganizationTypes.Location = new System.Drawing.Point(84, 52);
            this._cbOrganizationTypes.Name = "_cbOrganizationTypes";
            this._cbOrganizationTypes.Size = new System.Drawing.Size(325, 23);
            this._cbOrganizationTypes.TabIndex = 22;
            // 
            // _lOrganizationType
            // 
            this._lOrganizationType.AutoSize = true;
            this._lOrganizationType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganizationType.Location = new System.Drawing.Point(40, 53);
            this._lOrganizationType.Name = "_lOrganizationType";
            this._lOrganizationType.Size = new System.Drawing.Size(38, 17);
            this._lOrganizationType.TabIndex = 25;
            this._lOrganizationType.Text = "Type:";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.Id,
            this.OrganizationName,
            this.Type,
            this.Country});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.DefaultCellStyle = dataGridViewCellStyle8;
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.EnableHeadersVisualStyles = false;
            this._grid.Location = new System.Drawing.Point(0, 23);
            this._grid.MultiSelect = false;
            this._grid.Name = "_grid";
            this._grid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this._grid.RowHeadersVisible = false;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(828, 382);
            this._grid.TabIndex = 5;
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selected";
            this.Selected.FalseValue = "False";
            this.Selected.FillWeight = 95F;
            this.Selected.HeaderText = "Selected";
            this.Selected.MinimumWidth = 55;
            this.Selected.Name = "Selected";
            this.Selected.ReadOnly = true;
            this.Selected.TrueValue = "True";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 95F;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 70;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // OrganizationName
            // 
            this.OrganizationName.DataPropertyName = "Name";
            this.OrganizationName.FillWeight = 115F;
            this.OrganizationName.HeaderText = "Name";
            this.OrganizationName.MinimumWidth = 280;
            this.OrganizationName.Name = "OrganizationName";
            this.OrganizationName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 100;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 145;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // _tbSearchName
            // 
            this._tbSearchName.BackColor = System.Drawing.Color.GhostWhite;
            this._tbSearchName.BoxWidth = 325;
            this._tbSearchName.Dock = System.Windows.Forms.DockStyle.Top;
            this._tbSearchName.ForeColor = System.Drawing.Color.Black;
            this._tbSearchName.Location = new System.Drawing.Point(0, 0);
            this._tbSearchName.Name = "_tbSearchName";
            this._tbSearchName.PlaceholderText = "Type here to filter organizations";
            this._tbSearchName.Size = new System.Drawing.Size(828, 23);
            this._tbSearchName.TabIndex = 1;
            // 
            // OrganizationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._splitContainer);
            this.Name = "OrganizationControl";
            this.Size = new System.Drawing.Size(828, 539);
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel1.PerformLayout();
            this._splitContainer.Panel2.ResumeLayout(false);
            this._splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TlSplitContainer _splitContainer;
        private TlTextBox _tbSearchName;
        private TlDataGrid _grid;
        private TlButton _btnSelectCountry;
        private TlDropDownList _cbCountries;
        private System.Windows.Forms.Label _lCountry;
        private TlDropDownList _cbOrganizationTypes;
        private System.Windows.Forms.Label _lOrganizationType;
        private TlButton _btnAdd;
        private System.Windows.Forms.Label _lInstructions;
        private TlButton _btnManage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
    }
}
