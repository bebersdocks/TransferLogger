namespace TransferLogger.Ui.Forms.Organization
{
    partial class OrganizationsForms
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
            this._splitContainerTop = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._splitContainerBottom = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._gridOrganizations = new TransferLogger.Ui.Controls.TlDataGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lOrganizations = new System.Windows.Forms.Label();
            this._btnDelete = new TransferLogger.Ui.Controls.TlButton();
            this._btnEdit = new TransferLogger.Ui.Controls.TlButton();
            this._btnAdd = new TransferLogger.Ui.Controls.TlButton();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerTop)).BeginInit();
            this._splitContainerTop.Panel2.SuspendLayout();
            this._splitContainerTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerBottom)).BeginInit();
            this._splitContainerBottom.Panel1.SuspendLayout();
            this._splitContainerBottom.Panel2.SuspendLayout();
            this._splitContainerBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridOrganizations)).BeginInit();
            this.SuspendLayout();
            // 
            // _splitContainerTop
            // 
            this._splitContainerTop.BackColor = System.Drawing.Color.GhostWhite;
            this._splitContainerTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerTop.IsSplitterFixed = true;
            this._splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this._splitContainerTop.Name = "_splitContainerTop";
            this._splitContainerTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainerTop.Panel1
            // 
            this._splitContainerTop.Panel1.BackColor = System.Drawing.Color.White;
            // 
            // _splitContainerTop.Panel2
            // 
            this._splitContainerTop.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainerTop.Panel2.Controls.Add(this._splitContainerBottom);
            this._splitContainerTop.Size = new System.Drawing.Size(924, 595);
            this._splitContainerTop.SplitterDistance = 82;
            this._splitContainerTop.TabIndex = 0;
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
            this._splitContainerBottom.Panel1.BackColor = System.Drawing.Color.White;
            this._splitContainerBottom.Panel1.Controls.Add(this._gridOrganizations);
            this._splitContainerBottom.Panel1.Controls.Add(this._lOrganizations);
            // 
            // _splitContainerBottom.Panel2
            // 
            this._splitContainerBottom.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainerBottom.Panel2.Controls.Add(this._btnDelete);
            this._splitContainerBottom.Panel2.Controls.Add(this._btnEdit);
            this._splitContainerBottom.Panel2.Controls.Add(this._btnAdd);
            this._splitContainerBottom.Size = new System.Drawing.Size(924, 509);
            this._splitContainerBottom.SplitterDistance = 799;
            this._splitContainerBottom.TabIndex = 0;
            // 
            // _gridOrganizations
            // 
            this._gridOrganizations.AllowUserToAddRows = false;
            this._gridOrganizations.AllowUserToDeleteRows = false;
            this._gridOrganizations.AllowUserToOrderColumns = true;
            this._gridOrganizations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridOrganizations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridOrganizations.BackgroundColor = System.Drawing.Color.White;
            this._gridOrganizations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gridOrganizations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridOrganizations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._gridOrganizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridOrganizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.OrganizationName,
            this.Description,
            this.Type,
            this.Country,
            this.URL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridOrganizations.DefaultCellStyle = dataGridViewCellStyle2;
            this._gridOrganizations.EnableHeadersVisualStyles = false;
            this._gridOrganizations.Location = new System.Drawing.Point(-1, 17);
            this._gridOrganizations.MultiSelect = false;
            this._gridOrganizations.Name = "_gridOrganizations";
            this._gridOrganizations.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridOrganizations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._gridOrganizations.RowHeadersVisible = false;
            this._gridOrganizations.RowTemplate.Height = 25;
            this._gridOrganizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridOrganizations.Size = new System.Drawing.Size(797, 488);
            this._gridOrganizations.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "OrganizationId";
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 75;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // OrganizationName
            // 
            this.OrganizationName.DataPropertyName = "Name";
            this.OrganizationName.FillWeight = 74.31472F;
            this.OrganizationName.HeaderText = "Name";
            this.OrganizationName.Name = "OrganizationName";
            this.OrganizationName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 130F;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 180;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.FillWeight = 74.31472F;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.FillWeight = 74.31472F;
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.FillWeight = 74.31472F;
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            // 
            // _lOrganizations
            // 
            this._lOrganizations.BackColor = System.Drawing.Color.AliceBlue;
            this._lOrganizations.Dock = System.Windows.Forms.DockStyle.Top;
            this._lOrganizations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganizations.Location = new System.Drawing.Point(0, 0);
            this._lOrganizations.Name = "_lOrganizations";
            this._lOrganizations.Size = new System.Drawing.Size(795, 17);
            this._lOrganizations.TabIndex = 2;
            this._lOrganizations.Text = "Organizations";
            this._lOrganizations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnDelete
            // 
            this._btnDelete.AutoSize = true;
            this._btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDelete.ForeColor = System.Drawing.Color.Black;
            this._btnDelete.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnDelete.Location = new System.Drawing.Point(16, 87);
            this._btnDelete.MaximumSize = new System.Drawing.Size(0, 28);
            this._btnDelete.MinimumSize = new System.Drawing.Size(0, 28);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(87, 28);
            this._btnDelete.TabIndex = 2;
            this._btnDelete.TabStop = false;
            this._btnDelete.Text = "Delete";
            this._btnDelete.UseVisualStyleBackColor = false;
            // 
            // _btnEdit
            // 
            this._btnEdit.AutoSize = true;
            this._btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEdit.ForeColor = System.Drawing.Color.Black;
            this._btnEdit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnEdit.Location = new System.Drawing.Point(16, 53);
            this._btnEdit.MaximumSize = new System.Drawing.Size(0, 28);
            this._btnEdit.MinimumSize = new System.Drawing.Size(0, 28);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(87, 28);
            this._btnEdit.TabIndex = 1;
            this._btnEdit.TabStop = false;
            this._btnEdit.Text = "Edit";
            this._btnEdit.UseVisualStyleBackColor = false;
            // 
            // _btnAdd
            // 
            this._btnAdd.AutoSize = true;
            this._btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAdd.ForeColor = System.Drawing.Color.Black;
            this._btnAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnAdd.Location = new System.Drawing.Point(16, 17);
            this._btnAdd.MaximumSize = new System.Drawing.Size(0, 28);
            this._btnAdd.MinimumSize = new System.Drawing.Size(0, 28);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(87, 28);
            this._btnAdd.TabIndex = 0;
            this._btnAdd.TabStop = false;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = false;
            // 
            // OrganizationsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 595);
            this.Controls.Add(this._splitContainerTop);
            this.Name = "OrganizationsForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrganizationsForms";
            this._splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerTop)).EndInit();
            this._splitContainerTop.ResumeLayout(false);
            this._splitContainerBottom.Panel1.ResumeLayout(false);
            this._splitContainerBottom.Panel2.ResumeLayout(false);
            this._splitContainerBottom.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerBottom)).EndInit();
            this._splitContainerBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridOrganizations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.TlDataGrid _gridOrganizations;
        private Controls.TlSplitContainer _splitContainerTop;
        private Controls.TlSplitContainer _splitContainerBottom;
        private Controls.TlButton _btnDelete;
        private Controls.TlButton _btnEdit;
        private Controls.TlButton _btnAdd;
        private Label _lOrganizations;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn OrganizationName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn URL;
    }
}