using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Models;
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

        private void SetData()
        {
            if (_cbOrganizations.Items.Count == 0)
                _cbOrganizations.FillLookups(_organizations, new Lookup(-1, "All"));

            if (_cbStatuses.Items.Count == 0)
                _cbStatuses.FillLookups<ApplicationStatus>(new Lookup(-1, "All"));

            var apps = ApplicationModel.GetList(_tbSearchName.Text, _cbOrganizations.SelectedValue, _cbStatuses.SelectedValue, _dtFrom.Value, _dtTo.Value);

            var index = _gridApps.CurrentRow?.Index ?? 0;

            _gridApps.DataSource = apps;

            _gridApps.SelectRow(index);

            if (!apps.Any())
                _gridAppEvaluations.DataSource = null;

            _btnOpen.Enabled =
                _btnDelete.Enabled =
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
            _btnImportExcel.Click         += _btnImportExcel_Click;
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
            if (_gridApps.CurrentRow?.DataBoundItem is ApplicationModel model)
            {
                using var confirmBox = new ConfirmBox(
                    "Confirm Deletion",
                    $"Are you sure you want to delete application for {model.Student} (Id: {model.Id})?");

                if (confirmBox.ShowDialog() == DialogResult.OK)
                {
                    var index = _gridApps.CurrentRow.Index;

                    using var dc = new Dc();
                    using var tr = dc.BeginTransaction();

                    dc.Evaluations
                        .Where(a => a.ApplicationId == model.Id)
                        .Delete();

                    dc.Applications
                        .Where(a => a.ApplicationId == model.Id)
                        .Delete();

                    tr.Commit();

                    SetData();

                    _gridApps.SelectRow(index);
                }
            }
        }

        private async void _btnImportExcel_Click(object? sender, EventArgs e)
        {
            var imports = await InteropActions.ImportEvaluations(this);
            if (imports == null)
                return;

            using var dc = new Dc();

            var evaluations = dc.GetEvaluations()
                .Where(e => imports.Any(i => i.EvaluationId == e.EvaluationId))
                .Where(e => e.LinkedEvaluationId == null)
                .ToList();

            var evaluationsIds = evaluations
                .Select(e => e.EvaluationId)
                .ToHashSet();

            if (evaluations.Any())
            {
                var appIds = evaluations
                    .Select(e => e.ApplicationId)
                    .ToHashSet();

                if (appIds.Count > 1)
                {
                    MessageDialog.Show("Evaluations do not belong to the same application.", "Import Error");               
                    return;
                }

                var application = evaluations.First()
                    .Application;

                if (application.ApplicationStatus == ApplicationStatus.Completed)
                {
                    MessageDialog.Show(
                        $"Application for {application.Student.DisplayString} is already completed.", 
                        $"Import Denied (Application Id: {application.ApplicationId})");

                    return;
                }

                var importEvaluations = imports
                    .Where(i => evaluationsIds.Contains(i.EvaluationId))
                    .Select(i => i.Convert(dc))
                    .ToList();

                using var form = new ApplicationImportForm(appIds.Single(), evaluations, importEvaluations);

                form.ShowDialog();
            }
            else
            {
                MessageDialog.Show("There were no evaluations detected for import.", "No Evaluations Detected");
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
            if (_gridApps.CurrentRow?.DataBoundItem is ApplicationModel model)
            {
                _gridAppEvaluations.DataSource = model.Evaluations;

                _btnDelete.Enabled = model.Status != ApplicationStatus.Completed;
            }
        }
    }
}
