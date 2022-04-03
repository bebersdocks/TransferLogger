﻿using System;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using Serilog;

using TransferLogger.BusinessLogic.ViewModels;
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
            _grid.DataSource = StudentViewModel.GetList(_tbSearchName.Text, _tbRef.Text);
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
            if (_grid.CurrentRow?.DataBoundItem is StudentViewModel viewModel)
            {
                using var confirmDlg = new ConfirmDialog(
                    "Confirm Deletion",
                    $"Are you sure you want to delete {viewModel.Name} (Id: {viewModel.Id})?");

                if (confirmDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var index = _grid.CurrentRow.Index;

                        using var dc = new Dc();

                        dc.Students
                            .Where(s => s.StudentId == viewModel.Id)
                            .Delete();

                        SetData();

                        _grid.SelectRow(index);
                    }
                    catch (Exception ex)
                    {
                        Log.Error(ex, "failed");

                        ErrorDialog.Show(ex.Message, "Database Error");
                    }
                }
            }
        }
    }
}
