namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    partial class AttachmentsControl
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
            this._lAttachments = new System.Windows.Forms.Label();
            this._tbExcelLocation = new TransferLogger.Ui.Controls.TlTextBox();
            this._lInstructions = new System.Windows.Forms.Label();
            this._lExcelLocation = new System.Windows.Forms.Label();
            this._btnDelete = new TransferLogger.Ui.Controls.TlButton();
            this._btnAdd = new TransferLogger.Ui.Controls.TlButton();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._pnlAttachments = new System.Windows.Forms.Panel();
            this._btnBrowse = new TransferLogger.Ui.Controls.TlButton();
            this._btnView = new TransferLogger.Ui.Controls.TlButton();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this._pnlAttachments.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lAttachments
            // 
            this._lAttachments.AutoSize = true;
            this._lAttachments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lAttachments.Location = new System.Drawing.Point(32, 83);
            this._lAttachments.Name = "_lAttachments";
            this._lAttachments.Size = new System.Drawing.Size(82, 17);
            this._lAttachments.TabIndex = 61;
            this._lAttachments.Text = "Attachments:";
            // 
            // _tbExcelLocation
            // 
            this._tbExcelLocation.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbExcelLocation.BoxWidth = 325;
            this._tbExcelLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbExcelLocation.ForeColor = System.Drawing.Color.Black;
            this._tbExcelLocation.Location = new System.Drawing.Point(120, 51);
            this._tbExcelLocation.Name = "_tbExcelLocation";
            this._tbExcelLocation.ReadOnly = true;
            this._tbExcelLocation.Size = new System.Drawing.Size(391, 25);
            this._tbExcelLocation.TabIndex = 59;
            // 
            // _lInstructions
            // 
            this._lInstructions.AutoSize = true;
            this._lInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lInstructions.ForeColor = System.Drawing.Color.Black;
            this._lInstructions.Location = new System.Drawing.Point(39, 17);
            this._lInstructions.Name = "_lInstructions";
            this._lInstructions.Size = new System.Drawing.Size(325, 17);
            this._lInstructions.TabIndex = 40;
            this._lInstructions.Text = "Set excel location and/or add application attachments.";
            // 
            // _lExcelLocation
            // 
            this._lExcelLocation.AutoSize = true;
            this._lExcelLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lExcelLocation.Location = new System.Drawing.Point(21, 54);
            this._lExcelLocation.Name = "_lExcelLocation";
            this._lExcelLocation.Size = new System.Drawing.Size(93, 17);
            this._lExcelLocation.TabIndex = 30;
            this._lExcelLocation.Text = "Excel Location:";
            // 
            // _btnDelete
            // 
            this._btnDelete.AutoSize = true;
            this._btnDelete.BackColor = System.Drawing.Color.White;
            this._btnDelete.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.delete;
            this._btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDelete.ForeColor = System.Drawing.Color.Black;
            this._btnDelete.Location = new System.Drawing.Point(592, 82);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(32, 32);
            this._btnDelete.TabIndex = 68;
            this._btnDelete.TabStop = false;
            this._btnDelete.UseVisualStyleBackColor = false;
            // 
            // _btnAdd
            // 
            this._btnAdd.AutoSize = true;
            this._btnAdd.BackColor = System.Drawing.Color.White;
            this._btnAdd.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.add;
            this._btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAdd.ForeColor = System.Drawing.Color.Black;
            this._btnAdd.Location = new System.Drawing.Point(516, 82);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(32, 32);
            this._btnAdd.TabIndex = 66;
            this._btnAdd.TabStop = false;
            this._btnAdd.UseVisualStyleBackColor = false;
            // 
            // _grid
            // 
            this._grid.AllowUserToAddRows = false;
            this._grid.AllowUserToDeleteRows = false;
            this._grid.AllowUserToOrderColumns = true;
            this._grid.AllowUserToResizeRows = false;
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
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.DefaultCellStyle = dataGridViewCellStyle2;
            this._grid.EnableHeadersVisualStyles = false;
            this._grid.Location = new System.Drawing.Point(-1, -1);
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
            this._grid.RowTemplate.Height = 25;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(391, 247);
            this._grid.TabIndex = 69;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.FillWeight = 105F;
            this.FileName.HeaderText = "FileName";
            this.FileName.MinimumWidth = 280;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // _pnlAttachments
            // 
            this._pnlAttachments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlAttachments.Controls.Add(this._grid);
            this._pnlAttachments.Location = new System.Drawing.Point(120, 82);
            this._pnlAttachments.Name = "_pnlAttachments";
            this._pnlAttachments.Size = new System.Drawing.Size(391, 248);
            this._pnlAttachments.TabIndex = 70;
            // 
            // _btnBrowse
            // 
            this._btnBrowse.BackColor = System.Drawing.Color.White;
            this._btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBrowse.ForeColor = System.Drawing.Color.Black;
            this._btnBrowse.Location = new System.Drawing.Point(516, 51);
            this._btnBrowse.Name = "_btnBrowse";
            this._btnBrowse.Size = new System.Drawing.Size(108, 25);
            this._btnBrowse.TabIndex = 71;
            this._btnBrowse.TabStop = false;
            this._btnBrowse.Text = "Browse";
            this._btnBrowse.UseVisualStyleBackColor = false;
            // 
            // _btnView
            // 
            this._btnView.AutoSize = true;
            this._btnView.BackColor = System.Drawing.Color.White;
            this._btnView.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.view;
            this._btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnView.ForeColor = System.Drawing.Color.Black;
            this._btnView.Location = new System.Drawing.Point(554, 82);
            this._btnView.Name = "_btnView";
            this._btnView.Size = new System.Drawing.Size(32, 32);
            this._btnView.TabIndex = 72;
            this._btnView.TabStop = false;
            this._btnView.UseVisualStyleBackColor = false;
            // 
            // AttachmentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._btnView);
            this.Controls.Add(this._btnBrowse);
            this.Controls.Add(this._pnlAttachments);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._lAttachments);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._lExcelLocation);
            this.Controls.Add(this._lInstructions);
            this.Controls.Add(this._tbExcelLocation);
            this.Name = "AttachmentsControl";
            this.Size = new System.Drawing.Size(682, 376);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this._pnlAttachments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _lAttachments;
        private TlTextBox _tbExcelLocation;
        private System.Windows.Forms.Label _lInstructions;
        private System.Windows.Forms.Label _lExcelLocation;
        private TlButton _btnDelete;
        private TlButton _btnAdd;
        private TlDataGrid _grid;
        private System.Windows.Forms.Panel _pnlAttachments;
        private TlButton _btnBrowse;
        private TlButton _btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
    }
}
