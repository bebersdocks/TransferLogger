using System;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Ui.Utils;

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
                query = query.Where(s => $"{s.Name} {s.Middle} {s.Surname}".Contains(_tbSearchName.Text, StringComparison.OrdinalIgnoreCase));

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

            _grid.DoubleClick += (s, e) => InsertOrReplace();
            _btnAdd.Click     += (s, e) => InsertOrReplace(true);
            _btnEdit.Click    += (s, e) => InsertOrReplace();

            _btnDelete.Click += _btnDelete_Click;
        }

        private void InsertOrReplace(bool isNew = false)
        {
            FormUtils.InsertOrReplace(_grid, studentId => new StudentForm(studentId), () => SetData(), isNew);
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is IIdentifiable viewModel)
            {
                using var dc = new Dc();

                dc.Students
                    .Where(s => s.StudentId == viewModel.Id)
                    .Delete();

                SetData();
            }
        }
    }
}
