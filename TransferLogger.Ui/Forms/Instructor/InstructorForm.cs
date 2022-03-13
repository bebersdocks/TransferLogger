using LinqToDB;

using TransferLogger.Dal;
using TransferLogger.Ui.Utils;

namespace TransferLogger.Ui.Forms.Instructor
{
    public partial class InstructorForm : Form
    {
        private readonly Dal.DataModels.Instructor _instructor;

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
                this.ShowValidationMsg($"{_lName.Text} can't be empty.");
                return;
            }

            if (string.IsNullOrEmpty(_tbSurname.Text))
            {
                this.ShowValidationMsg($"{_lSurname.Text} can't be empty.");
                return;
            }

            if (string.IsNullOrEmpty(_tbEmail.Text))
            {
                this.ShowValidationMsg($"{_lEmail.Text} can't be empty.");
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
