using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal.DataModels.Applications;
using TransferLogger.Ui.Forms;

using Application = TransferLogger.Dal.DataModels.Applications.Application;

namespace TransferLogger.Ui.Controls.Applications.Builder
{
    public partial class ApplicationBuilder : UserControl
    {
        private readonly List<Lookup> _students      = LookupServices.GetStudents();
        private readonly List<Lookup> _organizations = LookupServices.GetOrganizations();

        public ApplicationBuilder()
        {
            InitializeComponent();

            SetData();
            SetPrograms();
            SetEvents();
        }

        private void SetData()
        {
            if (_cbStudents.Items.Count == 0)
                _cbStudents.FillLookups(_students);

            if (_cbOrganizations.Items.Count == 0)
                _cbOrganizations.FillLookups(_organizations);

            _gridCourses.DataSource = CourseViewModel.GetList(_tbSearchName.Text,
                _cbOrganizations.SelectedValue, 
                _cbCycles.SelectedValue, 
                _cbPrograms.SelectedValue);
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

            _cbOrganizations.SelectedValueChanged += OnValuesChanges;
            _cbCycles.SelectedValueChanged        += OnValuesChanges;

            _tbSearchName.TextChanged             += (s, e) => SetData();
            _cbPrograms.SelectedValueChanged      += (s, e) => SetData();
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

        public Application Save()
        {
            var application = new Application();
      
            application.StudentId      = Convert.ToInt32(_cbStudents.SelectedValue);
            application.OrganizationId = Convert.ToInt32(_cbOrganizations.SelectedValue);

            var courses = new List<ApplicationCourse>();

            foreach (DataGridViewRow selectedRow in _gridCourses.SelectedRows)
            {
                if (selectedRow.DataBoundItem is CourseViewModel viewModel)
                {
                   courses.Add(new ApplicationCourse { CourseId = viewModel.Id });
                }
            }

            application.Courses = courses;

            return application;
        }
    }
}
