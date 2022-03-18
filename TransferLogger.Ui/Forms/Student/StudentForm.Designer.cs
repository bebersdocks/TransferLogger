using System.Windows.Forms;

namespace TransferLogger.Ui.Forms.Student
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this._lName = new System.Windows.Forms.Label();
            this._tbName = new TransferLogger.Ui.Controls.TlTextBox();
            this._tbDocumentNo = new TransferLogger.Ui.Controls.TlTextBox();
            this._lDocumentNo = new System.Windows.Forms.Label();
            this._lSurname = new System.Windows.Forms.Label();
            this._tbSurname = new TransferLogger.Ui.Controls.TlTextBox();
            this._tbRef = new TransferLogger.Ui.Controls.TlTextBox();
            this._lRef = new System.Windows.Forms.Label();
            this._lPhone = new System.Windows.Forms.Label();
            this._tbPhone = new TransferLogger.Ui.Controls.TlTextBox();
            this._tbEmail = new TransferLogger.Ui.Controls.TlTextBox();
            this._lEmail = new System.Windows.Forms.Label();
            this._tbMiddle = new TransferLogger.Ui.Controls.TlTextBox();
            this._lMiddle = new System.Windows.Forms.Label();
            this._btnOk = new TransferLogger.Ui.Controls.TlButton();
            this._btnCancel = new TransferLogger.Ui.Controls.TlButton();
            this.SuspendLayout();
            // 
            // _lName
            // 
            this._lName.AutoSize = true;
            this._lName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lName.Location = new System.Drawing.Point(66, 24);
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
            this._tbName.Location = new System.Drawing.Point(118, 21);
            this._tbName.Name = "_tbName";
            this._tbName.Size = new System.Drawing.Size(325, 25);
            this._tbName.TabIndex = 0;
            // 
            // _tbDocumentNo
            // 
            this._tbDocumentNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbDocumentNo.BackColor = System.Drawing.Color.GhostWhite;
            this._tbDocumentNo.BoxWidth = 325;
            this._tbDocumentNo.ForeColor = System.Drawing.Color.Black;
            this._tbDocumentNo.Location = new System.Drawing.Point(118, 173);
            this._tbDocumentNo.Name = "_tbDocumentNo";
            this._tbDocumentNo.Size = new System.Drawing.Size(325, 25);
            this._tbDocumentNo.TabIndex = 4;
            // 
            // _lDocumentNo
            // 
            this._lDocumentNo.AutoSize = true;
            this._lDocumentNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lDocumentNo.Location = new System.Drawing.Point(21, 176);
            this._lDocumentNo.Name = "_lDocumentNo";
            this._lDocumentNo.Size = new System.Drawing.Size(92, 17);
            this._lDocumentNo.TabIndex = 18;
            this._lDocumentNo.Text = "Document No:";
            // 
            // _lSurname
            // 
            this._lSurname.AutoSize = true;
            this._lSurname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lSurname.Location = new System.Drawing.Point(50, 97);
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
            this._tbSurname.Location = new System.Drawing.Point(118, 97);
            this._tbSurname.Name = "_tbSurname";
            this._tbSurname.Size = new System.Drawing.Size(325, 25);
            this._tbSurname.TabIndex = 2;
            // 
            // _tbRef
            // 
            this._tbRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbRef.BackColor = System.Drawing.Color.GhostWhite;
            this._tbRef.BoxWidth = 325;
            this._tbRef.ForeColor = System.Drawing.Color.Black;
            this._tbRef.Location = new System.Drawing.Point(118, 135);
            this._tbRef.Name = "_tbRef";
            this._tbRef.Size = new System.Drawing.Size(325, 25);
            this._tbRef.TabIndex = 3;
            // 
            // _lRef
            // 
            this._lRef.AutoSize = true;
            this._lRef.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lRef.Location = new System.Drawing.Point(43, 135);
            this._lRef.Name = "_lRef";
            this._lRef.Size = new System.Drawing.Size(69, 17);
            this._lRef.TabIndex = 22;
            this._lRef.Text = "Reference:";
            // 
            // _lPhone
            // 
            this._lPhone.AutoSize = true;
            this._lPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lPhone.Location = new System.Drawing.Point(65, 214);
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
            this._tbPhone.Location = new System.Drawing.Point(118, 211);
            this._tbPhone.Name = "_tbPhone";
            this._tbPhone.Size = new System.Drawing.Size(325, 25);
            this._tbPhone.TabIndex = 5;
            // 
            // _tbEmail
            // 
            this._tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbEmail.BackColor = System.Drawing.Color.GhostWhite;
            this._tbEmail.BoxWidth = 325;
            this._tbEmail.ForeColor = System.Drawing.Color.Black;
            this._tbEmail.Location = new System.Drawing.Point(118, 249);
            this._tbEmail.Name = "_tbEmail";
            this._tbEmail.Size = new System.Drawing.Size(325, 25);
            this._tbEmail.TabIndex = 6;
            // 
            // _lEmail
            // 
            this._lEmail.AutoSize = true;
            this._lEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lEmail.Location = new System.Drawing.Point(70, 252);
            this._lEmail.Name = "_lEmail";
            this._lEmail.Size = new System.Drawing.Size(42, 17);
            this._lEmail.TabIndex = 26;
            this._lEmail.Text = "Email:";
            // 
            // _tbMiddle
            // 
            this._tbMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbMiddle.BackColor = System.Drawing.Color.GhostWhite;
            this._tbMiddle.BoxWidth = 325;
            this._tbMiddle.ForeColor = System.Drawing.Color.Black;
            this._tbMiddle.Location = new System.Drawing.Point(118, 59);
            this._tbMiddle.Name = "_tbMiddle";
            this._tbMiddle.Size = new System.Drawing.Size(325, 25);
            this._tbMiddle.TabIndex = 1;
            // 
            // _lMiddle
            // 
            this._lMiddle.AutoSize = true;
            this._lMiddle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lMiddle.Location = new System.Drawing.Point(60, 62);
            this._lMiddle.Name = "_lMiddle";
            this._lMiddle.Size = new System.Drawing.Size(52, 17);
            this._lMiddle.TabIndex = 28;
            this._lMiddle.Text = "Middle:";
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
            this._btnOk.Location = new System.Drawing.Point(368, 315);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 29);
            this._btnOk.TabIndex = 29;
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
            this._btnCancel.Location = new System.Drawing.Point(287, 315);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 29);
            this._btnCancel.TabIndex = 30;
            this._btnCancel.TabStop = false;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 356);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._lMiddle);
            this.Controls.Add(this._tbMiddle);
            this.Controls.Add(this._lEmail);
            this.Controls.Add(this._tbEmail);
            this.Controls.Add(this._tbPhone);
            this.Controls.Add(this._lPhone);
            this.Controls.Add(this._lRef);
            this.Controls.Add(this._tbRef);
            this.Controls.Add(this._tbSurname);
            this.Controls.Add(this._lSurname);
            this.Controls.Add(this._lDocumentNo);
            this.Controls.Add(this._tbDocumentNo);
            this.Controls.Add(this._tbName);
            this.Controls.Add(this._lName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(485, 395);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lName;
        private Controls.TlTextBox _tbName;
        private Controls.TlTextBox _tbDocumentNo;
        private Label _lDocumentNo;
        private Label _lSurname;
        private Controls.TlTextBox _tbSurname;
        private Controls.TlTextBox _tbRef;
        private Label _lRef;
        private Label _lPhone;
        private Controls.TlTextBox _tbPhone;
        private Controls.TlTextBox _tbEmail;
        private Label _lEmail;
        private Controls.TlTextBox _tbMiddle;
        private Label _lMiddle;
        private Controls.TlButton _btnOk;
        private Controls.TlButton _btnCancel;
    }
}