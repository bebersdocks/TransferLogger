using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic;
using TransferLogger.Dal;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Controls;

using Lookup = TransferLogger.BusinessLogic.Lookup;

namespace TransferLogger.Ui.Forms.Course
{
    public partial class CourseForm : Form
    {
        private readonly Dal.DataModels.Course _course;
        private readonly List<Lookup>          _organizations;

        public CourseForm(int courseId = 0)
        {
            InitializeComponent();

            using var dc = new Dc();

            _course = dc.Courses
                .LoadWith(c => c.Program)
                .FirstOrDefault(c => c.CourseId == courseId) ?? new();

            _organizations = dc.Organizations
                .Select(o => new Lookup(o.OrganizationId, o.DisplayString))
                .ToList();

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            if (_course.OrganizationId > 0)
            {
                _tbCode.Text              = _course.CourseCode;
                _tbName.Text              = _course.Name;
                _tbDescription.Text       = _course.Description;
                _numericCredits.Value     = _course.Credits;
                _numericWeeklyHours.Value = _course.WeeklyHours;

                Text = $"{_course.CourseCode} - {_course.Name} (Id: {_course.CourseId})";
            }

            _cbCycles.FillLookups(_course.Program?.Cycle ?? Cycle.Bachelor);
            _cbPrograms.FillLookups<Lookup>(_organizations, _course.OrganizationId);

            SetPrograms();
        }

        private void SetPrograms()
        {
            var programs = LookupServices.GetPrograms((int?)_cbOrganizations.SelectedValue ?? 0, (Cycle)_cbCycles.SelectedValue);
            if (programs.Any())
            {
                _cbPrograms.FillLookups<Lookup>(programs, _course.ProgramId);
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
            _btnSelectOrganization.Click += _btnSelectOrganization_Click;
            _btnSelectProgram.Click      += _btnSelectProgram_Click;

            _cbCycles.SelectedValueChanged        += (s, e) => SetPrograms();
            _cbOrganizations.SelectedValueChanged += (s, e) => SetPrograms();

            _btnCancel.Click += _btnCancel_Click;
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
            var programs = LookupServices.GetPrograms((int?)_cbOrganizations.SelectedValue ?? 0, (Cycle)_cbCycles.SelectedValue);
            using var form = new LookupSelectionForm("Select Program", programs, _cbPrograms.SelectedValue);
            
            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbPrograms.SelectedValue = form.SelectedValue.Value;
            }
        }

        private void _btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
