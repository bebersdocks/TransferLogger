using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.ViewModels.Courses;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Forms;
using TransferLogger.Ui.Forms.Courses;
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

            SetData(true);
            SetPrograms();
            SetEvents();
        }

        public void Activate()
        {
            SetData(true);
            SetPrograms();

            BringToFront();
        }

        private void SetData(bool initial = false)
        {
            if (_cbCycles.Items.Count == 0)
                _cbCycles.FillLookups<Cycle>();

            if (!initial)
            {
                _appBuild.CourseIds.Clear();

                foreach (DataGridViewRow row in _grid.Rows)
                {
                    if (row.DataBoundItem is SelectableCourseViewModel viewModel && viewModel.Selected)
                    {
                        _appBuild.CourseIds.Add(viewModel.Id);
                    }
                }
            }

            _grid.DataSource = SelectableCourseViewModel.GetList(_appBuild.CourseIds,
                _tbSearchName.Text, 
                _appBuild.OrganizationId, 
                _cbCycles.SelectedValue, 
                _cbPrograms.SelectedValue);
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

            _cbCycles.SelectedValueChanged += OnValuesChanges;

            _btnAddCourse.Click      += _btnAddCourse_Click;
            _btnManageCourses.Click  += _btnManageCourses_Click;
            _btnAddProgram.Click     += _btnAddProgram_Click;
            _btnManagePrograms.Click += _btnManagePrograms_Click;
            _btnSelectProgram.Click  += _btnSelectProgram_Click;

            _grid.SelectionChanged += _grid_SelectionChanged;
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
            throw new NotImplementedException();
        }


        private void _btnManagePrograms_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _btnAddCourse_Click(object? sender, EventArgs e)
        {
            var (programId, cycle) = GetSelectedValues();

            FormUtils.InsertOrReplace(_grid, id => new CourseForm(id, _appBuild.OrganizationId, true, programId, cycle), () => SetData(), true);
        }

        private void _btnManageCourses_Click(object? sender, EventArgs e)
        {
            var (_, cycle) = GetSelectedValues();

            using var form = new CoursesForm(_appBuild.OrganizationId, true, cycle);

            form.ShowDialog();
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

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {
            if (_grid.DataSource is List<SelectableCourseViewModel> courses)
            {
                _grid.Refresh();
            }
        }

        public bool Complete()
        {
            return true;
        }
    }
}
