using System.Net.Mail;
using System.Windows.Forms;

using TransferLogger.Dal.DataModels;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Utils;

namespace TransferLogger.Ui.Controls.Students
{
    public partial class StudentControl : UserControl
    {
        private readonly Student _student;
        public Student Student => _student;

        public StudentControl(Student? student = null)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _student = student ?? new();

            SetData();
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
            }
        }

        public bool Save(out int studentId)
        {
            studentId = _student.StudentId;

            if (string.IsNullOrEmpty(_tbName.Text))
            {
                MessageDialog.Show($"Name can't be empty.");
                _tbName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(_tbSurname.Text))
            {
                MessageDialog.Show($"Surname can't be empty.");
                _tbSurname.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(_tbEmail.Text) && !MailAddress.TryCreate(_tbEmail.Text, out var _))
            {
                MessageDialog.Show($"Email is not valid.");
                _tbEmail.Focus();
                return false;
            }

            _student.Reference  = _tbRef.Text.Trim();
            _student.Name       = _tbName.Text.Trim();
            _student.Middle     = _tbMiddle.Text.Trim();
            _student.Surname    = _tbSurname.Text.Trim();
            _student.DocumentNo = _tbDocumentNo.Text.Trim();
            _student.Phone      = _tbPhone.Text.Trim();
            _student.Email      = _tbEmail.Text.Trim();

            return FormUtils.TryInsertOrReplace(_student, ref studentId);
        }
    }
}
