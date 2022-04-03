using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.ViewModels.Courses;
using TransferLogger.Dal;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Forms;
using TransferLogger.Ui.Forms.Courses;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Forms.Programs;
using TransferLogger.Ui.Utils;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class CoursesControl : UserControl, IWizardControl
    {
        private readonly ApplicationBuild _appBuild;

        public CoursesControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;

            SetData();
            SetPrograms();
            SetEvents();
        }

        public void Activate()
        {
            SetData();
            SetPrograms();

            BringToFront();
        }

        private void SetData()
        {
            if (_cbCycles.Items.Count == 0)
                _cbCycles.FillLookups(Dal.Definitions.Cycle.Bachelor);

            _grid.SelectionChanged -= _grid_SelectionChanged;

            _grid.DataSource = SelectableCourseViewModel.GetList(_appBuild.CourseIds,
                _tbSearchName.Text, 
                _appBuild.OrganizationId, 
                _cbCycles.SelectedValue, 
                _cbPrograms.SelectedValue);

            _grid.SelectionChanged += _grid_SelectionChanged;
        }

        private void SetPrograms()
        {
            var programs = LookupServices.GetPrograms(_appBuild.OrganizationId, _cbCycles.SelectedValue);
            if (programs.Any())
            {
                _cbPrograms.FillLookups(programs, (int?)_cbPrograms.SelectedValue ?? -1);
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
            _tbSearchName.TextChanged        += (s, e) => SetData();
            _cbPrograms.SelectedValueChanged += (s, e) => SetData();

            _grid.CellClick       += (s, e) => SetCurrentRowAsSelected();
            _grid.CellDoubleClick += (s, e) => SetCurrentRowAsSelected();

            _cbCycles.SelectedValueChanged += OnValuesChanges;

            _btnAddCourse.Click      += _btnAddCourse_Click;
            _btnManageCourses.Click  += _btnManageCourses_Click;
            _btnAddProgram.Click     += _btnAddProgram_Click;
            _btnManagePrograms.Click += _btnManagePrograms_Click;
            _btnSelectProgram.Click  += _btnSelectProgram_Click;
        }

        private void UpdateSelectedRows()
        {
            if (_grid.DataSource is List<SelectableCourseViewModel> courses)
            {
                foreach (var course in courses)
                {
                    course.Selected = _appBuild.CourseIds.Contains(course.Id);
                }

                _grid.Refresh();
            }
        }

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateSelectedRows();
        }

        private void SetCurrentRowAsSelected()
        {
            if (_grid.CurrentRow?.DataBoundItem is SelectableCourseViewModel viewModel)
            {
                viewModel.Selected = !viewModel.Selected;

                if (viewModel.Selected)
                    _appBuild.CourseIds.Add(viewModel.Id);
                else
                    _appBuild.CourseIds.Remove(viewModel.Id);

                UpdateSelectedRows();
            }
        }

        private void OnValuesChanges(object? sender, EventArgs e)
        {
            SetData();
            SetPrograms();
        }

        private (int programId, Cycle? cycle) GetSelectedValues()
        {
            Cycle? cycle = null;
            if (_cbCycles.SelectedValue != null)
                cycle = (Cycle)_cbCycles.SelectedValue;

            return (Convert.ToInt32(_cbPrograms.SelectedValue), cycle);
        }

        private void _btnAddProgram_Click(object? sender, EventArgs e)
        {
            var (_, cycle) = GetSelectedValues();

            if (FormUtils.InsertOrReplace(_grid, id => new ProgramForm(id, _appBuild.OrganizationId, true, cycle), () => SetData(), true))
                SetPrograms();
        }

        private void _btnManagePrograms_Click(object? sender, EventArgs e)
        {
            var (_, cycle) = GetSelectedValues();

            using var form = new ProgramsForm(_appBuild.OrganizationId, true, cycle);

            form.ShowDialog();

            SetPrograms();
        }

        private void _btnAddCourse_Click(object? sender, EventArgs e)
        {
            var (programId, cycle) = GetSelectedValues();

            if (FormUtils.InsertOrReplace(_grid, id => new CourseForm(id, _appBuild.OrganizationId, true, programId, cycle), () => SetData(), true))
                SetCurrentRowAsSelected();
        }

        private void _btnManageCourses_Click(object? sender, EventArgs e)
        {
            var (_, cycle) = GetSelectedValues();

            using var form = new CoursesForm(_appBuild.OrganizationId, true, cycle);

            form.ShowDialog();

            using var dc = new Dc();

            var courseIds = dc.Courses
                .Select(c => c.CourseId)
                .ToHashSet();

            // Remove courses from selection which no longer exist.
            _appBuild.CourseIds.Intersect(courseIds);

            SetData();
        }

        private void _btnSelectProgram_Click(object? sender, EventArgs e)
        {
            var programs = LookupServices.GetPrograms(_appBuild.OrganizationId, _cbCycles.SelectedValue);

            using var form = new LookupSelectionForm("Select Program", programs, _cbPrograms.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbPrograms.SelectedValue = form.SelectedValue.Value;
            }
        }

        public bool Complete()
        {
           if (!_appBuild.CourseIds.Any())
            {
                MessageDialog.Show("You have to select at least 1 course.");

                return false;
            }

            return true;
        }
    }
}
