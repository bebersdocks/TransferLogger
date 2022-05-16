using System;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic.Models;
using TransferLogger.Dal;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Utils;

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

        private void SetData()
        {
            _grid.DataSource = StudentModel.GetList(_tbSearchName.Text, _tbRef.Text);
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
            FormUtils.InsertOrReplace(_grid, id => new StudentForm(id), () => SetData(), isNew);
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is StudentModel model)
            {
                using var confirmBox = new ConfirmBox(
                    "Confirm Deletion",
                    $"Are you sure you want to delete {model.Name} (Id: {model.Id})?");

                if (confirmBox.ShowDialog() == DialogResult.OK)
                {
                    var index = _grid.CurrentRow.Index;

                    using var dc = new Dc();

                    dc.Students
                        .Where(s => s.StudentId == model.Id)
                        .Delete();

                    SetData();

                    _grid.SelectRow(index);
                }
            }
        }
    }
}
