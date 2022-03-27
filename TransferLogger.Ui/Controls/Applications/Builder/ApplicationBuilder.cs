using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.ViewModels.Courses;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Forms;

namespace TransferLogger.Ui.Controls.Applications.Builder
{
    public partial class ApplicationBuilder : UserControl
    {
        private readonly ApplicationBuild _appBuild;

        private readonly List<Lookup> _students      = LookupServices.GetStudents();
        private readonly List<Lookup> _organizations = LookupServices.GetOrganizations(true);

        public ApplicationBuilder(ApplicationBuild appBuild)
        {
            InitializeComponent();

            _appBuild = appBuild;

            SetData(true);
            SetPrograms();
            SetEvents();
        }

        public void SetData(bool initial = false)
        {
            if (_cbStudents.Items.Count == 0)
                _cbStudents.FillLookups(_students, _appBuild.StudentId);

            if (_cbOrganizations.Items.Count == 0)
                _cbOrganizations.FillLookups(_organizations, _appBuild.OrganizationId);

            if (_cbCycles.Items.Count == 0)
                _cbCycles.FillLookups<Cycle>();

            if (!initial)
            {
                _appBuild.CourseIds.Clear();

                foreach (DataGridViewRow row in _gridCourses.Rows)
                {
                    if (row.DataBoundItem is SelectableCourseViewModel viewModel && viewModel.Selected)
                    {
                        _appBuild.CourseIds.Add(viewModel.Id);
                    }
                }
            }

            if (Convert.ToInt32(_cbOrganizations.SelectedValue) > 0)
            {
                _gridCourses.DataSource = SelectableCourseViewModel.GetList(_appBuild.CourseIds, 
                    _tbSearchName.Text,
                    _cbOrganizations.SelectedValue,
                    _cbCycles.SelectedValue,
                    _cbPrograms.SelectedValue);
            }
            else
            {
                _gridCourses.DataSource = null;
            }

            _appBuild.StudentId      = Convert.ToInt32(_cbStudents.SelectedValue);
            _appBuild.OrganizationId = Convert.ToInt32(_cbOrganizations.SelectedValue);
        }

        private void SetPrograms()
        {
            var programs = LookupServices.GetPrograms(_cbOrganizations.SelectedValue, _cbCycles.SelectedValue);
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
            _btnSelectStudent.Click      += _btnSelectStudent_Click;
            _btnSelectOrganization.Click += _btnSelectOrganization_Click;
            _btnSelectProgram.Click      += _btnSelectProgram_Click;

            _cbOrganizations.SelectedValueChanged += _cbOrganizations_SelectedValueChanged;

            _cbCycles.SelectedValueChanged += OnValuesChanges;

            _tbSearchName.TextChanged        += (s, e) => SetData();
            _cbPrograms.SelectedValueChanged += (s, e) => SetData();
        }

        private void _cbOrganizations_SelectedValueChanged(object? sender, EventArgs e)
        {
            _gridCourses.DataSource = null;

            OnValuesChanges(sender, e);
        }

        private void OnValuesChanges(object? sender, EventArgs e)
        {
            SetData();
            SetPrograms();
        }

        private void _btnSelectStudent_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Student", _students, _cbStudents.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbStudents.SelectedValue = form.SelectedValue.Value;
            }
        }

        private void _btnSelectOrganization_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Organization", _organizations, _cbOrganizations.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbOrganizations.SelectedValue = form.SelectedValue.Value;

                _gridCourses.DataSource = null;
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
    }
}
