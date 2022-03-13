namespace TransferLogger.Ui.Forms
{
    partial class LookupSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookupSelectionForm));
            this._gridLookups = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tbSearchLookup = new TransferLogger.Ui.Controls.TlTextBox();
            this._btnOk = new TransferLogger.Ui.Controls.TlButton();
            this._btnCancel = new TransferLogger.Ui.Controls.TlButton();
            ((System.ComponentModel.ISupportInitialize)(this._gridLookups)).BeginInit();
            this.SuspendLayout();
            // 
            // _gridLookups
            // 
            this._gridLookups.AllowUserToAddRows = false;
            this._gridLookups.AllowUserToDeleteRows = false;
            this._gridLookups.AllowUserToOrderColumns = true;
            this._gridLookups.AllowUserToResizeRows = false;
            this._gridLookups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridLookups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridLookups.BackgroundColor = System.Drawing.Color.White;
            this._gridLookups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._gridLookups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridLookups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._gridLookups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridLookups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value,
            this.DisplayName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridLookups.DefaultCellStyle = dataGridViewCellStyle2;
            this._gridLookups.EnableHeadersVisualStyles = false;
            this._gridLookups.Location = new System.Drawing.Point(0, 21);
            this._gridLookups.MultiSelect = false;
            this._gridLookups.Name = "_gridLookups";
            this._gridLookups.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridLookups.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._gridLookups.RowHeadersVisible = false;
            this._gridLookups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridLookups.Size = new System.Drawing.Size(473, 387);
            this._gridLookups.TabIndex = 1;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.FillWeight = 5.076141F;
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 90;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.FillWeight = 194.9239F;
            this.DisplayName.HeaderText = "Display Name";
            this.DisplayName.MinimumWidth = 285;
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            // 
            // _tbSearchLookup
            // 
            this._tbSearchLookup.BackColor = System.Drawing.Color.GhostWhite;
            this._tbSearchLookup.BoxWidth = 325;
            this._tbSearchLookup.Dock = System.Windows.Forms.DockStyle.Top;
            this._tbSearchLookup.ForeColor = System.Drawing.Color.Black;
            this._tbSearchLookup.Location = new System.Drawing.Point(0, 0);
            this._tbSearchLookup.Name = "_tbSearchLookup";
            this._tbSearchLookup.Size = new System.Drawing.Size(473, 23);
            this._tbSearchLookup.TabIndex = 0;
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOk.AutoSize = true;
            this._btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnOk.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOk.ForeColor = System.Drawing.Color.Black;
            this._btnOk.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnOk.Location = new System.Drawing.Point(381, 424);
            this._btnOk.MaximumSize = new System.Drawing.Size(0, 28);
            this._btnOk.MinimumSize = new System.Drawing.Size(0, 28);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(80, 28);
            this._btnOk.TabIndex = 2;
            this._btnOk.TabStop = false;
            this._btnOk.Text = "Ok";
            this._btnOk.UseVisualStyleBackColor = false;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.AutoSize = true;
            this._btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this._btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCancel.ForeColor = System.Drawing.Color.Black;
            this._btnCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._btnCancel.Location = new System.Drawing.Point(295, 424);
            this._btnCancel.MaximumSize = new System.Drawing.Size(0, 28);
            this._btnCancel.MinimumSize = new System.Drawing.Size(0, 28);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(80, 28);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.TabStop = false;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            // 
            // LookupSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 464);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._tbSearchLookup);
            this.Controls.Add(this._gridLookups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LookupSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LookupSelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this._gridLookups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TlDataGrid _gridLookups;
        private Controls.TlTextBox _tbSearchLookup;
        private Controls.TlButton _btnOk;
        private Controls.TlButton _btnCancel;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewTextBoxColumn DisplayName;
    }
}