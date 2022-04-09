using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Organizations
{
    partial class OrganizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationForm));
            this._lName = new System.Windows.Forms.Label();
            this._lUrl = new System.Windows.Forms.Label();
            this._lOrganizationType = new System.Windows.Forms.Label();
            this._cbOrganizationTypes = new TransferLogger.Ui.Controls.TlDropDownList();
            this._tbName = new TransferLogger.Ui.Controls.TlTextBox();
            this._tbUrl = new TransferLogger.Ui.Controls.TlTextBox();
            this._tbDescription = new TransferLogger.Ui.Controls.TlTextBox();
            this._lDescription = new System.Windows.Forms.Label();
            this._cbCountries = new TransferLogger.Ui.Controls.TlDropDownList();
            this._lCountry = new System.Windows.Forms.Label();
            this._btnOk = new TransferLogger.Ui.Controls.TlButton();
            this._btnSelectCountry = new TransferLogger.Ui.Controls.TlButton();
            this._btnCancel = new TransferLogger.Ui.Controls.TlButton();
            this.SuspendLayout();
            // 
            // _lName
            // 
            this._lName.AutoSize = true;
            this._lName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lName.Location = new System.Drawing.Point(51, 24);
            this._lName.Name = "_lName";
            this._lName.Size = new System.Drawing.Size(46, 17);
            this._lName.TabIndex = 0;
            this._lName.Text = "Name:";
            // 
            // _lUrl
            // 
            this._lUrl.AutoSize = true;
            this._lUrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lUrl.Location = new System.Drawing.Point(63, 176);
            this._lUrl.Name = "_lUrl";
            this._lUrl.Size = new System.Drawing.Size(34, 17);
            this._lUrl.TabIndex = 2;
            this._lUrl.Text = "URL:";
            // 
            // _lOrganizationType
            // 
            this._lOrganizationType.AutoSize = true;
            this._lOrganizationType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lOrganizationType.Location = new System.Drawing.Point(59, 100);
            this._lOrganizationType.Name = "_lOrganizationType";
            this._lOrganizationType.Size = new System.Drawing.Size(38, 17);
            this._lOrganizationType.TabIndex = 13;
            this._lOrganizationType.Text = "Type:";
            // 
            // _cbOrganizationTypes
            // 
            this._cbOrganizationTypes.BackColor = System.Drawing.Color.GhostWhite;
            this._cbOrganizationTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbOrganizationTypes.FormattingEnabled = true;
            this._cbOrganizationTypes.Location = new System.Drawing.Point(103, 97);
            this._cbOrganizationTypes.Name = "_cbOrganizationTypes";
            this._cbOrganizationTypes.Size = new System.Drawing.Size(325, 25);
            this._cbOrganizationTypes.TabIndex = 2;
            // 
            // _tbName
            // 
            this._tbName.BackColor = System.Drawing.Color.GhostWhite;
            this._tbName.BoxWidth = 325;
            this._tbName.ForeColor = System.Drawing.Color.Black;
            this._tbName.Location = new System.Drawing.Point(103, 21);
            this._tbName.Name = "_tbName";
            this._tbName.Size = new System.Drawing.Size(325, 25);
            this._tbName.TabIndex = 0;
            // 
            // _tbUrl
            // 
            this._tbUrl.BackColor = System.Drawing.Color.GhostWhite;
            this._tbUrl.BoxWidth = 325;
            this._tbUrl.ForeColor = System.Drawing.Color.Black;
            this._tbUrl.Location = new System.Drawing.Point(103, 173);
            this._tbUrl.Name = "_tbUrl";
            this._tbUrl.Size = new System.Drawing.Size(325, 25);
            this._tbUrl.TabIndex = 5;
            // 
            // _tbDescription
            // 
            this._tbDescription.BackColor = System.Drawing.Color.GhostWhite;
            this._tbDescription.BoxWidth = 325;
            this._tbDescription.ForeColor = System.Drawing.Color.Black;
            this._tbDescription.Location = new System.Drawing.Point(103, 59);
            this._tbDescription.Name = "_tbDescription";
            this._tbDescription.Size = new System.Drawing.Size(325, 25);
            this._tbDescription.TabIndex = 1;
            // 
            // _lDescription
            // 
            this._lDescription.AutoSize = true;
            this._lDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lDescription.Location = new System.Drawing.Point(20, 62);
            this._lDescription.Name = "_lDescription";
            this._lDescription.Size = new System.Drawing.Size(77, 17);
            this._lDescription.TabIndex = 18;
            this._lDescription.Text = "Description:";
            // 
            // _cbCountries
            // 
            this._cbCountries.BackColor = System.Drawing.Color.GhostWhite;
            this._cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCountries.FormattingEnabled = true;
            this._cbCountries.Location = new System.Drawing.Point(103, 135);
            this._cbCountries.Name = "_cbCountries";
            this._cbCountries.Size = new System.Drawing.Size(290, 25);
            this._cbCountries.TabIndex = 3;
            // 
            // _lCountry
            // 
            this._lCountry.AutoSize = true;
            this._lCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lCountry.Location = new System.Drawing.Point(41, 138);
            this._lCountry.Name = "_lCountry";
            this._lCountry.Size = new System.Drawing.Size(56, 17);
            this._lCountry.TabIndex = 20;
            this._lCountry.Text = "Country:";
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOk.AutoSize = true;
            this._btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnOk.ForeColor = System.Drawing.Color.Black;
            this._btnOk.Location = new System.Drawing.Point(356, 260);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 29);
            this._btnOk.TabIndex = 21;
            this._btnOk.TabStop = false;
            this._btnOk.Text = "Ok";
            this._btnOk.UseVisualStyleBackColor = false;
            // 
            // _btnSelectCountry
            // 
            this._btnSelectCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnSelectCountry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnSelectCountry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectCountry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnSelectCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSelectCountry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnSelectCountry.ForeColor = System.Drawing.Color.Black;
            this._btnSelectCountry.Location = new System.Drawing.Point(400, 135);
            this._btnSelectCountry.Name = "_btnSelectCountry";
            this._btnSelectCountry.Size = new System.Drawing.Size(28, 25);
            this._btnSelectCountry.TabIndex = 22;
            this._btnSelectCountry.TabStop = false;
            this._btnSelectCountry.Text = "...";
            this._btnSelectCountry.UseVisualStyleBackColor = false;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.AutoSize = true;
            this._btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this._btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this._btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this._btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnCancel.ForeColor = System.Drawing.Color.Black;
            this._btnCancel.Location = new System.Drawing.Point(275, 260);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 29);
            this._btnCancel.TabIndex = 23;
            this._btnCancel.TabStop = false;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 301);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSelectCountry);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._lCountry);
            this.Controls.Add(this._cbCountries);
            this.Controls.Add(this._lDescription);
            this.Controls.Add(this._tbDescription);
            this.Controls.Add(this._tbUrl);
            this.Controls.Add(this._tbName);
            this.Controls.Add(this._cbOrganizationTypes);
            this.Controls.Add(this._lOrganizationType);
            this.Controls.Add(this._lUrl);
            this.Controls.Add(this._lName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(470, 340);
            this.Name = "OrganizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Organization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lName;
        private Label _lUrl;
        private Label _lOrganizationType;
        private Controls.TlDropDownList _cbOrganizationTypes;
        private Controls.TlTextBox _tbName;
        private Controls.TlTextBox _tbUrl;
        private Controls.TlTextBox _tbDescription;
        private Label _lDescription;
        private Controls.TlDropDownList _cbCountries;
        private Label _lCountry;
        private Controls.TlButton _btnOk;
        private Controls.TlButton _btnSelectCountry;
        private Controls.TlButton _btnCancel;
    }
}