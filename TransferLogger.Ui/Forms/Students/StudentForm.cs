using System;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.Dal;
using TransferLogger.Ui.Controls.Students;

namespace TransferLogger.Ui.Forms.Students
{
    public partial class StudentForm : Form
    {
        private readonly StudentControl _control;

        public StudentForm(int studentId = 0)
        {
            InitializeComponent();

            using var dc = new Dc();

            var student = dc.Students.FirstOrDefault(s => s.StudentId == studentId);

            _control = new StudentControl(student);

            _pnl.Controls.Add(_control);

            if (student != null)
            {
                Text = $"{student.DisplayString} (Id: {student.StudentId})";
            }

            SetEvents();
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
            if (_control.ValidateData() && _control.Save(out var _))
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }
    }
}
