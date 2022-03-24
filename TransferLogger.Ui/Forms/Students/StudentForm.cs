using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Utils;

namespace TransferLogger.Ui.Forms.Students
{
    public partial class StudentForm : Form
    {
        private readonly Student _student;

        public StudentForm(int studentId = 0)
        {
            InitializeComponent();

            using var dc = new Dc();

            _student = dc.Students.FirstOrDefault(s => s.StudentId == studentId) ?? new();

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            if (_student.StudentId > 0)
            {
                _tbName.Text       = _student.Name;
                _tbMiddle.Text     = _student.Middle;
                _tbSurname.Text    = _student.Surname;
                _tbRef.Text        = _student.Reference;
                _tbDocumentNo.Text = _student.DocumentNo;
                _tbPhone.Text      = _student.Phone;
                _tbEmail.Text      = _student.Email;

                Text = $"{_student.DisplayString} (Id: {_student.StudentId})";
            }
        }

        private void SetEvents()
        {
            _btnCancel.Click += _btnCancel_Click;
            _btnOk.Click     += _btnOk_Click;
        }

        private void _btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void _btnOk_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_tbName.Text))
            {
                MessageDialog.Show($"Name can't be empty.");
                _tbName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(_tbSurname.Text))
            {
                MessageDialog.Show($"Surname can't be empty.");
                _tbSurname.Focus();
                return;
            }

            if (!MailAddress.TryCreate(_tbEmail.Text, out var _))
            {
                MessageDialog.Show($"Email is not valid.");
                _tbEmail.Focus();
                return;
            }

            _student.Reference  = _tbRef.Text;
            _student.Name       = _tbName.Text;
            _student.Middle     = _tbMiddle.Text;
            _student.Surname    = _tbSurname.Text;
            _student.DocumentNo = _tbDocumentNo.Text;
            _student.Phone      = _tbPhone.Text;
            _student.Email      = _tbEmail.Text;

            if (FormUtils.TryInsertOrReplace(_student, _student.StudentId))
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }
    }
}
