namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    partial class ReviewControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this._splitContainer = new TransferLogger.Ui.Controls.TlSplitContainer();
            this._lInstructions = new System.Windows.Forms.Label();
            this._btnExcel = new TransferLogger.Ui.Controls.TlButton();
            this._tbOrganization = new TransferLogger.Ui.Controls.TlTextBox();
            this._lOrganization = new System.Windows.Forms.Label();
            this._tbStudent = new TransferLogger.Ui.Controls.TlTextBox();
            this._lStudent = new System.Windows.Forms.Label();
            this._lEvaluations = new System.Windows.Forms.Label();
            this._grid = new TransferLogger.Ui.Controls.TlDataGrid();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuggestedOrMatched = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this._splitContainer.Panel1.Controls.Add(this._lInstructions);
            this._splitContainer.Panel1.Controls.Add(this._btnExcel);
            this._splitContainer.Panel1.Controls.Add(this._tbOrganization);
            this._splitContainer.Panel1.Controls.Add(this._lOrganization);
            this._splitContainer.Panel1.Controls.Add(this._tbStudent);
            this._splitContainer.Panel1.Controls.Add(this._lStudent);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this._splitContainer.Panel2.Controls.Add(this._lEvaluations);
            this._splitContainer.Panel2.Controls.Add(this._grid);
            this._splitContainer.Size = new System.Drawing.Size(935, 640);
            this._splitContainer.SplitterDistance = 115;
            this._splitContainer.TabIndex = 0;
            // 
            // _lInstructions
            // 
            this._lInstructions.AutoSize = true;
            this._lInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lInstructions.ForeColor = System.Drawing.Color.Black;
            this._lInstructions.Location = new System.Drawing.Point(79, 16);
            this._lInstructions.Name = "_lInstructions";
            this._lInstructions.Size = new System.Drawing.Size(323, 17);
            this._lInstructions.TabIndex = 40;
            this._lInstructions.Text = "Review evaluations and complete application creation.";
            // 
            // _btnExcel
            // 
            this._btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExcel.AutoSize = true;
            this._btnExcel.BackColor = System.Drawing.Color.Transparent;
            this._btnExcel.BackgroundImage = global::TransferLogger.Ui.Properties.Resources.excel;
            this._btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnExcel.ForeColor = System.Drawing.Color.Black;
            this._btnExcel.Location = new System.Drawing.Point(879, 47);
            this._btnExcel.Name = "_btnExcel";
            this._btnExcel.Size = new System.Drawing.Size(32, 32);
            this._btnExcel.TabIndex = 37;
            this._btnExcel.TabStop = false;
            this._btnExcel.UseVisualStyleBackColor = false;
            // 
            // _tbOrganization
            // 
            this._tbOrganization.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbOrganization.BoxWidth = 325;
            this._tbOrganization.ForeColor = System.Drawing.Color.Black;
            this._tbOrganization.Location = new System.Drawing.Point(116, 76);
            this._tbOrganization.Name = "_tbOrganization";
            this._tbOrganization.ReadOnly = true;
            this._tbOrganization.Size = new System.Drawing.Size(325, 23);
            this._tbOrganization.TabIndex = 7;
            // 
            // _lOrganization
            // 
            this._lOrganization.AutoSize = true;
            this._lOrganization.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganization.Location = new System.Drawing.Point(32, 79);
            this._lOrganization.Name = "_lOrganization";
            this._lOrganization.Size = new System.Drawing.Size(78, 15);
            this._lOrganization.TabIndex = 8;
            this._lOrganization.Text = "Organization:";
            // 
            // _tbStudent
            // 
            this._tbStudent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._tbStudent.BoxWidth = 325;
            this._tbStudent.ForeColor = System.Drawing.Color.Black;
            this._tbStudent.Location = new System.Drawing.Point(116, 47);
            this._tbStudent.Name = "_tbStudent";
            this._tbStudent.Size = new System.Drawing.Size(325, 23);
            this._tbStudent.TabIndex = 5;
            // 
            // _lStudent
            // 
            this._lStudent.AutoSize = true;
            this._lStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lStudent.Location = new System.Drawing.Point(59, 50);
            this._lStudent.Name = "_lStudent";
            this._lStudent.Size = new System.Drawing.Size(51, 15);
            this._lStudent.TabIndex = 6;
            this._lStudent.Text = "Student:";
            // 
            // _lEvaluations
            // 
            this._lEvaluations.BackColor = System.Drawing.Color.AliceBlue;
            this._lEvaluations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lEvaluations.Dock = System.Windows.Forms.DockStyle.Top;
            this._lEvaluations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEvaluations.Location = new System.Drawing.Point(0, 0);
            this._lEvaluations.Name = "_lEvaluations";
            this._lEvaluations.Size = new System.Drawing.Size(935, 21);
            this._lEvaluations.TabIndex = 17;
            this._lEvaluations.Text = "Evaluations";
            this._lEvaluations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.Evaluator,
            this.SuggestedOrMatched,
            this.Status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.DefaultCellStyle = dataGridViewCellStyle5;
            this._grid.EnableHeadersVisualStyles = false;
            this._grid.Location = new System.Drawing.Point(0, 16);
            this._grid.MultiSelect = false;
            this._grid.Name = "_grid";
            this._grid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._grid.RowHeadersVisible = false;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(935, 505);
            this._grid.TabIndex = 16;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.FillWeight = 115F;
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 215;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Evaluator
            // 
            this.Evaluator.DataPropertyName = "Instructor";
            this.Evaluator.HeaderText = "Evaluator";
            this.Evaluator.MinimumWidth = 180;
            this.Evaluator.Name = "Evaluator";
            this.Evaluator.ReadOnly = true;
            // 
            // SuggestedOrMatched
            // 
            this.SuggestedOrMatched.DataPropertyName = "SuggestedOrMatched";
            this.SuggestedOrMatched.HeaderText = "Suggested / Matched Course";
            this.SuggestedOrMatched.MinimumWidth = 215;
            this.SuggestedOrMatched.Name = "SuggestedOrMatched";
            this.SuggestedOrMatched.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StatusDisplayName";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 100;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ReviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._splitContainer);
            this.Name = "ReviewControl";
            this.Size = new System.Drawing.Size(935, 640);
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel1.PerformLayout();
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TlSplitContainer _splitContainer;
        private TlTextBox _tbOrganization;
        private System.Windows.Forms.Label _lOrganization;
        private TlTextBox _tbStudent;
        private System.Windows.Forms.Label _lStudent;
        private TlButton _btnExcel;
        private TlDataGrid _grid;
        private System.Windows.Forms.Label _lEvaluations;
        private System.Windows.Forms.Label _lInstructions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluator;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuggestedOrMatched;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
