using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Instructor
{
    partial class InstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorForm));
            this._lName = new System.Windows.Forms.Label();
            this._tbName = new TransferLogger.Ui.Controls.TlTextBox();
            this._lSurname = new System.Windows.Forms.Label();
            this._tbSurname = new TransferLogger.Ui.Controls.TlTextBox();
            this._lPhone = new System.Windows.Forms.Label();
            this._tbPhone = new TransferLogger.Ui.Controls.TlTextBox();
            this._tbEmail = new TransferLogger.Ui.Controls.TlTextBox();
            this._lEmail = new System.Windows.Forms.Label();
            this._lMiddle = new System.Windows.Forms.Label();
            this._tbMiddle = new TransferLogger.Ui.Controls.TlTextBox();
            this._btnOk = new TransferLogger.Ui.Controls.TlButton();
            this._btnCancel = new TransferLogger.Ui.Controls.TlButton();
            this.SuspendLayout();
            // 
            // _lName
            // 
            this._lName.AutoSize = true;
            this._lName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lName.Location = new System.Drawing.Point(21, 24);
            this._lName.Name = "_lName";
            this._lName.Size = new System.Drawing.Size(46, 17);
            this._lName.TabIndex = 0;
            this._lName.Text = "Name:";
            // 
            // _tbName
            // 
            this._tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbName.BackColor = System.Drawing.Color.GhostWhite;
            this._tbName.BoxWidth = 325;
            this._tbName.ForeColor = System.Drawing.Color.Black;
            this._tbName.Location = new System.Drawing.Point(106, 21);
            this._tbName.Name = "_tbName";
            this._tbName.Size = new System.Drawing.Size(325, 25);
            this._tbName.TabIndex = 0;
            // 
            // _lSurname
            // 
            this._lSurname.AutoSize = true;
            this._lSurname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lSurname.Location = new System.Drawing.Point(21, 95);
            this._lSurname.Name = "_lSurname";
            this._lSurname.Size = new System.Drawing.Size(62, 17);
            this._lSurname.TabIndex = 19;
            this._lSurname.Text = "Surname:";
            // 
            // _tbSurname
            // 
            this._tbSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSurname.BackColor = System.Drawing.Color.GhostWhite;
            this._tbSurname.BoxWidth = 325;
            this._tbSurname.ForeColor = System.Drawing.Color.Black;
            this._tbSurname.Location = new System.Drawing.Point(106, 92);
            this._tbSurname.Name = "_tbSurname";
            this._tbSurname.Size = new System.Drawing.Size(325, 25);
            this._tbSurname.TabIndex = 2;
            // 
            // _lPhone
            // 
            this._lPhone.AutoSize = true;
            this._lPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lPhone.Location = new System.Drawing.Point(21, 130);
            this._lPhone.Name = "_lPhone";
            this._lPhone.Size = new System.Drawing.Size(47, 17);
            this._lPhone.TabIndex = 23;
            this._lPhone.Text = "Phone:";
            // 
            // _tbPhone
            // 
            this._tbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbPhone.BackColor = System.Drawing.Color.GhostWhite;
            this._tbPhone.BoxWidth = 325;
            this._tbPhone.ForeColor = System.Drawing.Color.Black;
            this._tbPhone.Location = new System.Drawing.Point(106, 127);
            this._tbPhone.Name = "_tbPhone";
            this._tbPhone.Size = new System.Drawing.Size(325, 25);
            this._tbPhone.TabIndex = 3;
            // 
            // _tbEmail
            // 
            this._tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbEmail.BackColor = System.Drawing.Color.GhostWhite;
            this._tbEmail.BoxWidth = 325;
            this._tbEmail.ForeColor = System.Drawing.Color.Black;
            this._tbEmail.Location = new System.Drawing.Point(106, 163);
            this._tbEmail.Name = "_tbEmail";
            this._tbEmail.Size = new System.Drawing.Size(325, 25);
            this._tbEmail.TabIndex = 4;
            // 
            // _lEmail
            // 
            this._lEmail.AutoSize = true;
            this._lEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEmail.Location = new System.Drawing.Point(21, 166);
            this._lEmail.Name = "_lEmail";
            this._lEmail.Size = new System.Drawing.Size(42, 17);
            this._lEmail.TabIndex = 26;
            this._lEmail.Text = "Email:";
            // 
            // _lMiddle
            // 
            this._lMiddle.AutoSize = true;
            this._lMiddle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lMiddle.Location = new System.Drawing.Point(21, 60);
            this._lMiddle.Name = "_lMiddle";
            this._lMiddle.Size = new System.Drawing.Size(52, 17);
            this._lMiddle.TabIndex = 27;
            this._lMiddle.Text = "Middle:";
            // 
            // _tbMiddle
            // 
            this._tbMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbMiddle.BackColor = System.Drawing.Color.GhostWhite;
            this._tbMiddle.BoxWidth = 325;
            this._tbMiddle.ForeColor = System.Drawing.Color.Black;
            this._tbMiddle.Location = new System.Drawing.Point(106, 57);
            this._tbMiddle.Name = "_tbMiddle";
            this._tbMiddle.Size = new System.Drawing.Size(325, 25);
            this._tbMiddle.TabIndex = 1;
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
            this._btnOk.Location = new System.Drawing.Point(356, 241);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 29);
            this._btnOk.TabIndex = 28;
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
            this._btnCancel.Location = new System.Drawing.Point(268, 241);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(82, 29);
            this._btnCancel.TabIndex = 29;
            this._btnCancel.TabStop = false;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 281);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._tbMiddle);
            this.Controls.Add(this._lMiddle);
            this.Controls.Add(this._lEmail);
            this.Controls.Add(this._tbEmail);
            this.Controls.Add(this._tbPhone);
            this.Controls.Add(this._lPhone);
            this.Controls.Add(this._tbSurname);
            this.Controls.Add(this._lSurname);
            this.Controls.Add(this._tbName);
            this.Controls.Add(this._lName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(470, 320);
            this.Name = "InstructorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Instructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lName;
        private Controls.TlTextBox _tbName;
        private Label _lSurname;
        private Controls.TlTextBox _tbSurname;
        private Label _lPhone;
        private Controls.TlTextBox _tbPhone;
        private Controls.TlTextBox _tbEmail;
        private Label _lEmail;
        private Label _lMiddle;
        private Controls.TlTextBox _tbMiddle;
        private Controls.TlButton _btnOk;
        private Controls.TlButton _btnCancel;
    }
}