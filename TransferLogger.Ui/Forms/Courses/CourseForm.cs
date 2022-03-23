using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Dialogs;

using Lookup = TransferLogger.BusinessLogic.Lookup;

namespace TransferLogger.Ui.Forms.Courses
{
    public partial class CourseForm : Form
    {
        private readonly Course       _course;
        private readonly List<Lookup> _organizations;

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
            SetPrograms();
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
            _cbOrganizations.FillLookups<Lookup>(_organizations, _course.OrganizationId);
        }

        private void SetPrograms()
        {
            var programs = LookupServices.GetPrograms(_cbOrganizations.SelectedValue, _cbCycles.SelectedValue);
            if (programs.Any())
            {
                _cbPrograms.FillLookups<Lookup>(programs, _course.ProgramId);
                _cbPrograms.Enabled = _btnSelectProgram.Enabled = true;
            }
            else
            {
                _cbPrograms.DataSource = null;
                _cbPrograms.Enabled    = _btnSelectProgram.Enabled = false;
            }
        }

        private void SetEvents()
        {
            _btnSelectOrganization.Click += _btnSelectOrganization_Click;
            _btnSelectProgram.Click      += _btnSelectProgram_Click;

            _cbCycles.SelectedValueChanged        += (s, e) => SetPrograms();
            _cbOrganizations.SelectedValueChanged += (s, e) => SetPrograms();

            _numericCredits.ValueChanged     += _numeric_ValueChanged;
            _numericWeeklyHours.ValueChanged += _numeric_ValueChanged;

            _btnOk.Click     += _btnOk_Click;
            _btnCancel.Click += _btnCancel_Click;
        }

        private void _numeric_ValueChanged(object? sender, EventArgs e)
        {
            if (sender is NumericUpDown numericCredits)
            {
                if (numericCredits.Value < numericCredits.Minimum)
                {
                    numericCredits.Value = numericCredits.Minimum;
                }
                else if (numericCredits.Value > numericCredits.Maximum)
                {
                    numericCredits.Value = numericCredits.Maximum;
                }
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

        private void _btnOk_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_tbCode.Text))
            {
                MessageDialog.Show($"Code can't be empty.");
                _tbCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(_tbName.Text))
            {
                MessageDialog.Show($"Name can't be empty.");
                _tbName.Focus();
                return;
            }

            if (_cbOrganizations.SelectedValue is null)
            {
                MessageDialog.Show($"You have to select organization.");
                return;
            }

            if (_cbPrograms.SelectedValue is null)
            {
                MessageDialog.Show($"You have to select program.");
                return;
            }

            _course.CourseCode     = _tbCode.Text;
            _course.OrganizationId = (int)_cbOrganizations.SelectedValue;
            _course.ProgramId      = (int)_cbPrograms.SelectedValue;
            _course.Name           = _tbName.Text;
            _course.Description    = _tbDescription.Text;
            _course.Credits        = Convert.ToInt32(_numericCredits.Value);
            _course.WeeklyHours    = Convert.ToInt32(_numericWeeklyHours.Value);

            using var dc = new Dc();

            if (_course.CourseId == 0)
                dc.InsertWithIdentity(_course);
            else
                dc.Update(_course);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void _btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
