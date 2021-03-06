using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Models.Courses;
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

            SetEvents();
        }

        public void Activate()
        {
            SetData();
            SetPrograms();

            BringToFront();

            _grid.Focus();
        }

        private void SetData()
        {
            if (_cbCycles.Items.Count == 0)
                _cbCycles.FillLookups(Dal.Definitions.Cycle.Bachelor);

            _grid.SelectionChanged -= _grid_SelectionChanged;

            _grid.DataSource = SelectableCourseModel.GetList(_appBuild.CourseIds,
                _tbSearchName.Text, 
                _appBuild.SourceOrganizationId, 
                _cbCycles.SelectedValue, 
                _cbPrograms.SelectedValue);

            _grid.SelectionChanged += _grid_SelectionChanged;
        }

        private void SetPrograms(int? programId = null)
        {
            if (programId.HasValue)
            {
                using var dc = new Dc();

                var program = dc.Programs.First(p => p.ProgramId == programId);

                // Do not trigger data refresh twice.
                _cbCycles.SelectedValueChanged -= _cbCycles_SelectedValueChanged;

                _cbCycles.SelectedValue = Convert.ToInt32(program.Cycle);

                _cbCycles.SelectedValueChanged += _cbCycles_SelectedValueChanged;
            }

            var programs = LookupServices.GetPrograms(_appBuild.SourceOrganizationId, _cbCycles.SelectedValue);
            if (programs.Any())
            {
                programId ??= (int?)_cbPrograms.SelectedValue ?? -1;

                _cbPrograms.FillLookups(programs, programId);
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

            _grid.KeyDown += _grid_KeyDown;

            _cbCycles.SelectedValueChanged += _cbCycles_SelectedValueChanged;

            _btnAddCourse.Click      += _btnAddCourse_Click;
            _btnManageCourses.Click  += _btnManageCourses_Click;
            _btnAddProgram.Click     += _btnAddProgram_Click;
            _btnManagePrograms.Click += _btnManagePrograms_Click;
            _btnSelectProgram.Click  += _btnSelectProgram_Click;
        }

        private void UpdateSelectedRows()
        {
            if (_grid.DataSource is List<SelectableCourseModel> courses)
            {
                foreach (var course in courses)
                {
                    course.Selected = _appBuild.Evaluations.ContainsKey(course.Id);
                }

                _grid.Refresh();
            }
        }

        private void SetCurrentRowAsSelected()
        {
            if (_grid.CurrentRow?.DataBoundItem is SelectableCourseModel model)
            {
                model.Selected = !model.Selected;

                if (model.Selected)
                {
                    if (!_appBuild.Evaluations.ContainsKey(model.Id))
                    {
                        var newEvaluation = new ApplicationEvaluation
                        {
                            CourseId = model.Id
                        };

                        _appBuild.Evaluations[model.Id] = newEvaluation;
                    }
                }
                else
                {
                    _appBuild.Evaluations.Remove(model.Id);
                }

                UpdateSelectedRows();
            }
        }

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateSelectedRows();
        }

        private void _grid_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetCurrentRowAsSelected();

                e.SuppressKeyPress = true;
            }
        }

        private void _cbCycles_SelectedValueChanged(object? sender, EventArgs e)
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

            using var form = new ProgramForm(0, _appBuild.SourceOrganizationId, true, cycle);

            if (form.ShowDialog() == DialogResult.OK)
                SetPrograms(form.ProgramId);
        }

        private void _btnManagePrograms_Click(object? sender, EventArgs e)
        {
            var (_, cycle) = GetSelectedValues();

            using var form = new ProgramsForm(_appBuild.SourceOrganizationId, cycle);

            form.ShowDialog();

            _appBuild.CleanObsoleteResources();

            SetPrograms();
        }

        private void _btnAddCourse_Click(object? sender, EventArgs e)
        {
            var (programId, cycle) = GetSelectedValues();

            if (FormUtils.InsertOrReplace(_grid, id => new CourseForm(id, _appBuild.SourceOrganizationId, true, programId, cycle), () => SetData(), true))
                SetCurrentRowAsSelected();
        }

        private void _btnManageCourses_Click(object? sender, EventArgs e)
        {
            var (_, cycle) = GetSelectedValues();

            using var form = new CoursesForm(_appBuild.SourceOrganizationId, cycle);

            form.ShowDialog();

            _appBuild.CleanObsoleteResources();

            SetData();
        }

        private void _btnSelectProgram_Click(object? sender, EventArgs e)
        {
            var programs = LookupServices.GetPrograms(_appBuild.SourceOrganizationId, _cbCycles.SelectedValue);

            using var form = new LookupSelectionForm("Select Program", programs, _cbPrograms.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbPrograms.SelectedValue = form.SelectedValue.Value;
            }
        }

        public bool Complete()
        {
           if (!_appBuild.Evaluations.Any())
            {
                MessageDialog.Show("At least 1 course is required.", "Wizard Validation");

                return false;
            }

            return true;
        }
    }
}
