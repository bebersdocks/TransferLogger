using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class CoursesControl : UserControl, IWizardControl
    {
        private readonly ApplicationBuild  _appBuild;

        private BindingList<SelectableCourseModel> _courses = new();
        public HashSet<int> SelectedCourseIds => _courses
            .Where(i => i.Selected)
            .Select(i => i.Id)
            .ToHashSet();

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

           var courses = SelectableCourseModel.GetList(
                SelectedCourseIds,
                _tbSearchName.Text,
                _appBuild.SourceOrganizationId,
                _cbCycles.GetSelectedValue<Cycle>(),
                Convert.ToInt32(_cbPrograms.SelectedValue));

            _courses = new BindingList<SelectableCourseModel>(courses);

            _grid.DataSource = _courses;
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

                _btnSelectProgram.Enabled = true;
                _cbPrograms.Enabled       = true;
            }
            else
            {
                _btnSelectProgram.Enabled = false;
                _cbPrograms.DataSource    = null;
                _cbPrograms.Enabled       = false;
            }
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged        += (s, e) => SetData();
            _cbPrograms.SelectedValueChanged += (s, e) => SetData();

            _btnAddCourse.Click            += _btnAddCourse_Click;
            _btnManageCourses.Click        += _btnManageCourses_Click;
            _btnAddProgram.Click           += _btnAddProgram_Click;
            _btnManagePrograms.Click       += _btnManagePrograms_Click;
            _btnSelectProgram.Click        += _btnSelectProgram_Click;
            _cbCycles.SelectedValueChanged += _cbCycles_SelectedValueChanged;
            _grid.Click                    += _grid_Click;
        }

        private void _cbCycles_SelectedValueChanged(object? sender, EventArgs e)
        {
            SetData();
            SetPrograms();
        }

        private void _btnAddProgram_Click(object? sender, EventArgs e)
        {
            var cycle = _cbCycles.GetSelectedValue<Cycle>();

            using var form = new ProgramForm(0, _appBuild.SourceOrganizationId, true, cycle);

            if (form.ShowDialog() == DialogResult.OK)
                SetPrograms(form.ProgramId);
        }

        private void _btnManagePrograms_Click(object? sender, EventArgs e)
        {
            var cycle = _cbCycles.GetSelectedValue<Cycle>();

            using var form = new ProgramsForm(_appBuild.SourceOrganizationId, cycle);

            form.ShowDialog();

            _appBuild.CleanObsoleteResources();

            SetPrograms();
        }

        private void _btnAddCourse_Click(object? sender, EventArgs e)
        {
            var (programId, cycle) = (Convert.ToInt32(_cbPrograms.SelectedValue), _cbCycles.GetSelectedValue<Cycle>());

            using var form = new CourseForm(0, _appBuild.SourceOrganizationId, true, programId, cycle);

            if (form.ShowDialog() == DialogResult.OK)
                SetData();
        }

        private void _btnManageCourses_Click(object? sender, EventArgs e)
        {
            var cycle = _cbCycles.GetSelectedValue<Cycle>();

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
                _cbPrograms.SelectedValue = form.SelectedValue.Value;
        }

        private void _grid_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is SelectableCourseModel course)
                course.Selected = !course.Selected;
        }

        public bool Complete()
        {
           if (!SelectedCourseIds.Any())
            {
                MessageDialog.Show("At least 1 course is required.", "Wizard Validation");

                return false;
            }

            var preservedEvaluations = _appBuild.Evaluations.Values
                .Where(i => SelectedCourseIds.Contains(i.CourseId))
                .ToDictionary(i => i.CourseId);

            _appBuild.Evaluations.Clear();

            foreach (var courseId in SelectedCourseIds)
            {
                if (preservedEvaluations.TryGetValue(courseId, out var evaluation))
                    _appBuild.Evaluations[courseId] = evaluation;
                else
                    _appBuild.Evaluations[courseId] = new() { CourseId = courseId };
            }

            return true;
        }
    }
}
