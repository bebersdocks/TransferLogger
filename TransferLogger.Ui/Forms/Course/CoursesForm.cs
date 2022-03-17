using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Utils;

using Lookup = TransferLogger.BusinessLogic.Lookup;

namespace TransferLogger.Ui.Forms.Course
{
    public partial class CoursesForm : Form
    {
        private readonly List<Lookup> _organizations;

        public CoursesForm()
        {
            InitializeComponent();

            using var dc = new Dc();

            _organizations = dc.Organizations
                .Select(o => new Lookup(o.OrganizationId, o.DisplayString))
                .ToList();

            SetData();
            SetPrograms();
            SetEvents();
        }

        private void SetData()
        {
            if (_cbOrganizations.Items.Count == 0)
                _cbOrganizations.FillLookups<Lookup>(_organizations);

            if (_cbCycles.Items.Count == 0)
                _cbCycles.FillLookups<Dal.Definitions.Cycle>();

            using var dc = new Dc();

            var query = dc.Courses.AsQueryable();

            if (!string.IsNullOrEmpty(_tbSearchName.Text))
                query = query.Where(c => $"{c.CourseCode} - {c.Name}".Contains(_tbSearchName.Text, StringComparison.OrdinalIgnoreCase));

            if (_cbOrganizations.SelectedValue != null)
                query = query.Where(c => c.OrganizationId == (int)_cbOrganizations.SelectedValue);

            if (_cbCycles.SelectedValue != null)
                query = query.Where(c => c.Program.Cycle == (Cycle)_cbCycles.SelectedValue);

            if (_cbPrograms.SelectedValue != null)
                query = query.Where(c => c.ProgramId == (int)_cbPrograms.SelectedValue);

            _grid.DataSource = query
                .Select(c => new CourseViewModel(c, c.Program, c.Organization))
                .ToList();
        }

        private void SetPrograms()
        {
            var programs = LookupServices.GetPrograms(_cbOrganizations.SelectedValue, _cbCycles.SelectedValue);
            if (programs.Any())
            {
                _cbPrograms.FillLookups<Lookup>(programs, (int?)_cbPrograms.SelectedValue ?? -1);
                _cbPrograms.Enabled = _btnSelectProgram.Enabled = true;
            }
            else
            {
                _cbPrograms.DataSource = null;
                _cbPrograms.Enabled = _btnSelectProgram.Enabled = false;
            }
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged             += OnValuesChanges;
            _cbOrganizations.SelectedValueChanged += OnValuesChanges;
            _cbCycles.SelectedValueChanged        += OnValuesChanges;

            _cbPrograms.SelectedValueChanged += (s, e) => SetData();

            _btnSelectOrganization.Click += _btnSelectOrganization_Click;
            _btnSelectProgram.Click      += _btnSelectProgram_Click;

            _grid.DoubleClick += (s, e) => InsertOrReplace();
            _btnAdd.Click     += (s, e) => InsertOrReplace(true);
            _btnEdit.Click    += (s, e) => InsertOrReplace();

            _btnDelete.Click += _btnDelete_Click;
        }

        private void OnValuesChanges(object? sender, EventArgs e)
        {
            SetData();
            SetPrograms();
        }

        private void _btnSelectOrganization_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Organization", _organizations, _cbOrganizations.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbOrganizations.SelectedValue = form.SelectedValue.Value;
            }
        }

        private void _btnSelectProgram_Click(object? sender, EventArgs e)
        {
            var programs = LookupServices.GetPrograms(_cbOrganizations.SelectedValue, _cbCycles.SelectedValue);
            using var form = new LookupSelectionForm("Select Program", programs, _cbPrograms.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbPrograms.SelectedValue = form.SelectedValue.Value;
            }
        }

        private void InsertOrReplace(bool isNew = false)
        {
            FormUtils.InsertOrReplace(_grid, id => new CourseForm(id), () => SetData(), isNew);
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is CourseViewModel viewModel)
            {
                using var confirmDlg = new ConfirmDialog(
                    "Confirm Deletion",
                    $"Are you sure you want to delete {viewModel.Name} (Id: {viewModel.Id})?");

                if (confirmDlg.ShowDialog() == DialogResult.OK)
                {
                    using var dc = new Dc();

                    dc.Courses
                        .Where(c => c.CourseId == viewModel.Id)
                        .Delete();

                    SetData();
                }
            }
        }
    }
}
