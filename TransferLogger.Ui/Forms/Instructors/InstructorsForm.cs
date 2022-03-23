using System;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Utils;

namespace TransferLogger.Ui.Forms.Instructors
{
    public partial class InstructorsForm : Form
    {
        public InstructorsForm()
        {
            InitializeComponent();

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            _grid.DataSource = InstructorViewModel.GetList(_tbSearchName.Text, _tbEmail.Text);
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged += (s, e) => SetData();
            _tbEmail.TextChanged      += (s, e) => SetData();

            _grid.DoubleClick += (s, e) => InsertOrReplace();
            _btnAdd.Click     += (s, e) => InsertOrReplace(true);
            _btnEdit.Click    += (s, e) => InsertOrReplace();

            _btnDelete.Click += _btnDelete_Click;
        }

        private void InsertOrReplace(bool isNew = false)
        {
            FormUtils.InsertOrReplace(_grid, id => new InstructorForm(id), () => SetData(), isNew);
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is InstructorViewModel viewModel)
            {
                using var confirmDlg = new ConfirmDialog(
                    "Confirm Deletion",
                    $"Are you sure you want to delete {viewModel.Name} (Id: {viewModel.Id})?");

                if (confirmDlg.ShowDialog() == DialogResult.OK)
                {
                    using var dc = new Dc();

                    dc.Instructors
                        .Where(i => i.InstructorId == viewModel.Id)
                        .Delete();

                    SetData();
                }
            }
        }
    }
}
