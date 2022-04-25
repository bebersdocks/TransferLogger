﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels.Applications;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Courses;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Forms.Instructors;
using TransferLogger.Ui.Forms.Organizations;
using TransferLogger.Ui.Forms.Programs;
using TransferLogger.Ui.Forms.Students;
using TransferLogger.Ui.Properties;
using TransferLogger.Ui.Utils;

using Lookup = TransferLogger.BusinessLogic.Lookup;

namespace TransferLogger.Ui.Forms.Applications
{
    public partial class ApplicationsForm : Form
    {
        private readonly List<Lookup> _organizations = LookupServices.GetOrganizations(true);

        public ApplicationsForm()
        {
            InitializeComponent();
 
            _dtFrom.Value = DateTime.Now.AddYears(-2);
            _dtTo.Value   = DateTime.Now;

            SetData();
            SetEvents();

            ToggleEvaluations(true);
        }

        public void SetData()
        {
            if (_cbOrganizations.Items.Count == 0)
                _cbOrganizations.FillLookups(_organizations);

            if (_cbStatuses.Items.Count == 0)
                _cbStatuses.FillLookups<ApplicationStatus>();

            var apps = ApplicationViewModel.GetList(_tbSearchName.Text, _cbOrganizations.SelectedValue, _cbStatuses.SelectedValue, _dtFrom.Value, _dtTo.Value);

            _gridApps.DataSource = apps;

            if (!apps.Any())
                _gridAppEvaluations.DataSource = null;

            _btnImportExcel.Enabled =
                _btnSendEmail.Enabled =
                _btnExportExcel.Enabled =
                _btnChangeExcelLocation.Enabled = apps.Any();
        }

        private void SetEvents()
        {
            _miCourses.Click       += (s, e) => ShowForm<CoursesForm>();
            _miInstructors.Click   += (s, e) => ShowForm<InstructorsForm>();
            _miOrganizations.Click += (s, e) => ShowForm<OrganizationsForm>();
            _miPrograms.Click      += (s, e) => ShowForm<ProgramsForm>();
            _miStudents.Click      += (s, e) => ShowForm<StudentsForm>();

            _tbSearchName.TextChanged             += (s, e) => SetData();
            _cbOrganizations.SelectedValueChanged += (s, e) => SetData();
            _cbStatuses.SelectedValueChanged      += (s, e) => SetData();
            _dtFrom.ValueChanged                  += (s, e) => SetData();
            _dtTo.ValueChanged                    += (s, e) => SetData();

            _btnToggleCourses.Click += (s, e) => ToggleEvaluations();

            _btnAdd.Click                 += _btnAdd_Click;
            _btnOpen.Click                += _btnOpen_Click;
            _btnDelete.Click              += _btnDelete_Click;
            _btnSendEmail.Click           += _btnSendEmail_Click;
            _btnExportExcel.Click         += _btnExportExcel_Click;
            _btnChangeExcelLocation.Click += _btnChangeExcelLocation_Click;
            _btnSelectOrganization.Click  += _btnSelectOrganization_Click;

            _gridApps.DoubleClick      += _gridApps_DoubleClick;
            _gridApps.KeyDown          += _gridApps_KeyDown;
            _gridApps.SelectionChanged += _gridApps_SelectionChanged;
        }

        private void ShowForm<T>() where T : Form, new()
        {
            using var form = new T();

            form.ShowDialog();

            SetData();
        }

        private void ToggleEvaluations(bool? collapsed = null)
        {
            _splitContainerBottom.Panel2Collapsed = collapsed ?? !_splitContainerBottom.Panel2Collapsed;

            if (_splitContainerBottom.Panel2Collapsed)
                _btnToggleCourses.BackgroundImage = Resources.expand_arrow;
            else
                _btnToggleCourses.BackgroundImage = Resources.collapse_arrow;
        }

        private void _btnAdd_Click(object? sender, EventArgs e)
        {
            using var form = new ApplicationWizardForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                SetData();
            }
        }

        private void OpenApplication()
        {
            if (_gridApps.CurrentRow?.DataBoundItem is IIdentifiable identifiable)
            {
                using var form = new ApplicationForm(identifiable.Id);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    SetData();
                }
            }
        }

        private void _btnOpen_Click(object? sender, EventArgs e)
        {
            OpenApplication();
        }
        
        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_gridApps.CurrentRow?.DataBoundItem is ApplicationViewModel viewModel)
            {
                using var confirmBox = new ConfirmBox(
                    "Confirm Deletion",
                    $"Are you sure you want to delete application for {viewModel.Student} (Id: {viewModel.Id})?");

                if (confirmBox.ShowDialog() == DialogResult.OK)
                {
                    var index = _gridApps.CurrentRow.Index;

                    using var dc = new Dc();
                    using var tr = dc.BeginTransaction();

                    dc.Evaluations
                        .Where(a => a.ApplicationId == viewModel.Id)
                        .Delete();

                    dc.Applications
                        .Where(a => a.ApplicationId == viewModel.Id)
                        .Delete();

                    tr.Commit();

                    SetData();

                    _gridApps.SelectRow(index);
                }
            }
        }

        private async void _btnSendEmail_Click(object? sender, EventArgs e)
        {
            if (_gridApps.CurrentRow?.DataBoundItem is IIdentifiable identifiable)
            {
                await InteropActions.SendEmail(this, identifiable.Id);
            }
        }

        private async void _btnExportExcel_Click(object? sender, EventArgs e)
        {
            if (_gridApps.CurrentRow?.DataBoundItem is IIdentifiable identifiable)
            {
                await InteropActions.ExportExcel(this, identifiable.Id);
            }
        }

        private void _btnChangeExcelLocation_Click(object? sender, EventArgs e)
        {
            if (_gridApps.CurrentRow?.DataBoundItem is IIdentifiable identifiable)
            {
                using var form = new ChangeExcelLocationForm(identifiable.Id);

                form.ShowDialog();
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

        private void _gridApps_DoubleClick(object? sender, EventArgs e)
        {
            OpenApplication();
        }

        private void _gridApps_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OpenApplication();
        }

        private void _gridApps_SelectionChanged(object? sender, EventArgs e)
        {
            if (_gridApps.CurrentRow?.DataBoundItem is ApplicationViewModel viewModel)
            {
                _gridAppEvaluations.DataSource = viewModel.Evaluations;

                _btnDelete.Enabled = viewModel.Status != ApplicationStatus.Completed;
            }
        }
    }
}
