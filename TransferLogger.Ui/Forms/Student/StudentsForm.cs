using LinqToDB;

using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;

namespace TransferLogger.Ui.Forms.Student
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            using var dc = new Dc();

            var query = dc.Students.AsQueryable();

            if (!string.IsNullOrEmpty(_tbSearchName.Text))
                query = query.Where(s => s.Name.Contains(_tbSearchName.Text, StringComparison.OrdinalIgnoreCase) || s.Surname.Contains(_tbSearchName.Text, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(_tbRef.Text))
                query = query.Where(s => s.Reference.Contains(_tbRef.Text, StringComparison.OrdinalIgnoreCase));

            _grid.DataSource = query
                .Select(s => new StudentViewModel(s))
                .ToList();
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged += (s, e) => SetData();
            _tbRef.TextChanged        += (s, e) => SetData();

            _grid.DoubleClick += (s, e) => InsertOrReplaceStudent();
            _btnAdd.Click     += (s, e) => InsertOrReplaceStudent(true);
            _btnEdit.Click    += (s, e) => InsertOrReplaceStudent();

            _btnDelete.Click += _btnDelete_Click;
        }

        private void InsertOrReplaceStudent(bool isNew = false)
        {
            var studentId = 0;

            if (_grid.CurrentRow?.DataBoundItem is StudentViewModel studentViewModel)
            {
                studentId = studentViewModel.StudentId;
            }

            if (!isNew && studentId == 0)
            {
                return;
            }

            using var form = new StudentForm(isNew ? 0 : studentId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                SetData();
            }

            if (studentId != 0)
                _grid.SelectRow<StudentViewModel>(o => o.StudentId == studentId);
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is StudentViewModel studentViewModel)
            {
                using var dc = new Dc();

                dc.Students
                    .Where(o => o.StudentId == studentViewModel.StudentId)
                    .Delete();

                SetData();
            }
        }
    }
}
