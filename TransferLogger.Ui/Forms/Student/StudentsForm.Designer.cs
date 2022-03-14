namespace TransferLogger.Ui.Forms.Student
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this._splitContainer = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._lRef = new System.Windows.Forms.Label();
            this._tbRef = new TransferLogger.Ui.Controls.TlTextBox();
            this._lSearchName = new System.Windows.Forms.Label();
            this._tbSearchName = new TransferLogger.Ui.Controls.TlTextBox();
            this._btnDelete = new TransferLogger.Ui.Controls.TlButton();
            this._btnEdit = new TransferLogger.Ui.Controls.TlButton();
            this._btnAdd = new TransferLogger.Ui.Controls.TlButton();
            this._lStudents = new System.Windows.Forms.Label();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this._splitContainer.Panel1.Controls.Add(this._lRef);
            this._splitContainer.Panel1.Controls.Add(this._tbRef);
            this._splitContainer.Panel1.Controls.Add(this._lSearchName);
            this._splitContainer.Panel1.Controls.Add(this._tbSearchName);
            this._splitContainer.Panel1.Controls.Add(this._btnDelete);
            this._splitContainer.Panel1.Controls.Add(this._btnEdit);
            this._splitContainer.Panel1.Controls.Add(this._btnAdd);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel2.Controls.Add(this._lStudents);
            this._splitContainer.Panel2.Controls.Add(this._grid);
            this._splitContainer.Size = new System.Drawing.Size(1069, 636);
            this._splitContainer.SplitterDistance = 56;
            this._splitContainer.TabIndex = 5;
            // 
            // _lRef
            // 
            this._lRef.AutoSize = true;
            this._lRef.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lRef.Location = new System.Drawing.Point(445, 19);
            this._lRef.Name = "_lRef";
            this._lRef.Size = new System.Drawing.Size(69, 17);
            this._lRef.TabIndex = 12;
            this._lRef.Text = "Reference:";
            // 
            // _tbRef
            // 
            this._tbRef.BackColor = System.Drawing.Color.GhostWhite;
            this._tbRef.BoxWidth = 325;
            this._tbRef.ForeColor = System.Drawing.Color.Black;
            this._tbRef.Location = new System.Drawing.Point(530, 17);
            this._tbRef.Name = "_tbRef";
            this._tbRef.Size = new System.Drawing.Size(325, 23);
            this._tbRef.TabIndex = 1;
            // 
            // _lSearchName
            // 
            this._lSearchName.AutoSize = true;
            this._lSearchName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lSearchName.Location = new System.Drawing.Point(19, 18);
            this._lSearchName.Name = "_lSearchName";
            this._lSearchName.Size = new System.Drawing.Size(46, 17);
            this._lSearchName.TabIndex = 10;
            this._lSearchName.Text = "Name:";
            // 
            // _tbSearchName
            // 
            this._tbSearchName.BackColor = System.Drawing.Color.GhostWhite;
            this._tbSearchName.BoxWidth = 325;
            this._tbSearchName.ForeColor = System.Drawing.Color.Black;
            this._tbSearchName.Location = new System.Drawing.Point(81, 17);
            this._tbSearchName.Name = "_tbSearchName";
            this._tbSearchName.Size = new System.Drawing.Size(325, 23);
            this._tbSearchName.TabIndex = 0;
            // 
            // _btnDelete
            // 
            this._btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDelete.AutoSize = true;
            this._btnDelete.BackColor = System.Drawing.Color.Transparent;
            this._btnDelete.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.trash;
            this._btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDelete.ForeColor = System.Drawing.Color.Black;
            this._btnDelete.HoverColor = System.Drawing.Color.Transparent;
            this._btnDelete.Location = new System.Drawing.Point(1013, 11);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(32, 32);
            this._btnDelete.TabIndex = 4;
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
            this._btnEdit.Location = new System.Drawing.Point(975, 11);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(32, 32);
            this._btnEdit.TabIndex = 3;
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
            this._btnAdd.Location = new System.Drawing.Point(937, 11);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(32, 32);
            this._btnAdd.TabIndex = 2;
            this._btnAdd.TabStop = false;
            this._btnAdd.UseVisualStyleBackColor = false;
            // 
            // _lStudents
            // 
            this._lStudents.BackColor = System.Drawing.Color.AliceBlue;
            this._lStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this._lStudents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lStudents.Location = new System.Drawing.Point(0, 0);
            this._lStudents.Name = "_lStudents";
            this._lStudents.Size = new System.Drawing.Size(1065, 20);
            this._lStudents.TabIndex = 2;
            this._lStudents.Text = "Students";
            this._lStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.StudentId,
            this.StudentName,
            this.Reference,
            this.DocumentNo,
            this.Phone,
            this.Email});
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
            this._grid.Size = new System.Drawing.Size(1069, 549);
            this._grid.TabIndex = 0;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "ID";
            this.StudentId.MinimumWidth = 25;
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Name";
            this.StudentName.FillWeight = 110F;
            this.StudentName.HeaderText = "Name";
            this.StudentName.MinimumWidth = 250;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Reference
            // 
            this.Reference.DataPropertyName = "Reference";
            this.Reference.HeaderText = "Reference";
            this.Reference.MinimumWidth = 100;
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // DocumentNo
            // 
            this.DocumentNo.DataPropertyName = "DocumentNo";
            this.DocumentNo.FillWeight = 95F;
            this.DocumentNo.HeaderText = "Document";
            this.DocumentNo.MinimumWidth = 60;
            this.DocumentNo.Name = "DocumentNo";
            this.DocumentNo.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 75;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 105F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 215;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 636);
            this.Controls.Add(this._splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1085, 675);
            this.Name = "StudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
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
        private Label _lStudents;
        private Controls.TlButton _btnAdd;
        private Controls.TlButton _btnDelete;
        private Controls.TlButton _btnEdit;
        private Controls.TlTextBox _tbSearchName;
        private Label _lSearchName;
        private Label _lRef;
        private Controls.TlTextBox _tbRef;
        private DataGridViewTextBoxColumn StudentId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn DocumentNo;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
    }
}