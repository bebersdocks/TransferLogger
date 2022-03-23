using System;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Ui.Forms.Dialogs;

namespace TransferLogger.Ui.Forms.Instructors
{
    public partial class InstructorForm : Form
    {
        private readonly Instructor _instructor;

        public InstructorForm(int instructorId = 0)
        {
            InitializeComponent();

            using var dc = new Dc();

            _instructor = dc.Instructors.FirstOrDefault(i => i.InstructorId == instructorId) ?? new();

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            if (_instructor.InstructorId > 0)
            {
                _tbName.Text    = _instructor.Name;
                _tbMiddle.Text  = _instructor.Middle;
                _tbSurname.Text = _instructor.Surname;
                _tbPhone.Text   = _instructor.Phone;
                _tbEmail.Text   = _instructor.Email;

                Text = $"{_instructor.DisplayString} (Id: {_instructor.InstructorId})";
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

            if (string.IsNullOrEmpty(_tbEmail.Text))
            {
                MessageDialog.Show($"Email can't be empty.");
                _tbEmail.Focus();
                return;
            }

            _instructor.Name    = _tbName.Text;
            _instructor.Middle  = _tbMiddle.Text;
            _instructor.Surname = _tbSurname.Text;
            _instructor.Phone   = _tbPhone.Text;
            _instructor.Email   = _tbEmail.Text;

            using var dc = new Dc();

            if (_instructor.InstructorId == 0)
                dc.InsertWithIdentity(_instructor);
            else
                dc.Update(_instructor);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
