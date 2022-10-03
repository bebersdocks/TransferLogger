using System;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Models;
using TransferLogger.Dal;
using TransferLogger.Ui.Forms.Dialogs;

namespace TransferLogger.Ui.Forms.Students
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();

            SetData();
            SetEvents();
        }

        private void SetData(int? index = null)
        {
            index ??= _grid.CurrentRow?.Index;

            _grid.DataSource = StudentModel.GetList(_tbSearchName.Text, _tbRef.Text);

            _grid.SelectRow(index);
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged += (s, e) => SetData();
            _tbRef.TextChanged        += (s, e) => SetData();

            _btnAdd.Click     += _btnAdd_Click;
            _btnEdit.Click    += _btnEdit_Click;
            _btnDelete.Click  += _btnDelete_Click;
            _grid.DoubleClick += _btnEdit_Click;
        }

        private void _btnAdd_Click(object? sender, EventArgs e)
        {
            using var form = new StudentForm();

            if (form.ShowDialog() == DialogResult.OK)
                SetData(_grid.RowCount + 1);
        }

        private void _btnEdit_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is IIdentifiable identifiable)
            {
                using var form = new StudentForm(identifiable.Id);

                if (form.ShowDialog() == DialogResult.OK)
                    SetData(_grid.RowCount + 1);
            }
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is StudentModel student)
            {
                using var confirmBox = new ConfirmBox(
                    "Confirm Deletion",
                    $"Are you sure you want to delete {student.Name} (Id: {student.Id})?");

                if (confirmBox.ShowDialog() == DialogResult.OK)
                {
                    using var dc = new Dc();

                    dc.Students
                        .Where(s => s.StudentId == student.Id)
                        .Delete();

                    SetData();
                }
            }
        }
    }
}
