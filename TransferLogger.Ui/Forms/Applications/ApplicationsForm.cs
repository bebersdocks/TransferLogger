using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal.DataModels.Applications;
using TransferLogger.Interop;
using TransferLogger.Interop.Excel;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Courses;
using TransferLogger.Ui.Forms.Instructors;
using TransferLogger.Ui.Forms.Organizations;
using TransferLogger.Ui.Forms.Programs;
using TransferLogger.Ui.Forms.Students;
using TransferLogger.Ui.Forms.Utils;
using TransferLogger.Ui.Properties;

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

            _gridApps.DataSource = ApplicationViewModel.GetList(_tbSearchName.Text, _cbOrganizations.SelectedValue, _cbStatuses.SelectedValue, _dtFrom.Value, _dtTo.Value);
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

            _btnAdd.Click                += _btnAdd_Click;
            _btnExportExcel.Click        += _btnExportExcel_Click;
            _btnSendEmail.Click          += _btnSendEmail_Click;
            _btnSelectOrganization.Click += _btnSelectOrganization_Click;

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

        private async void _btnExportExcel_Click(object? sender, EventArgs e)
        {
            if (_gridApps.CurrentRow?.DataBoundItem is ApplicationViewModel viewModel)
            {
                var task = Task.Run(() => new ExcelExporter(viewModel.Id).Export());

                using var form = new LoadingForm("Excel Export", "Exporting...");

                BeginInvoke((Action)(() => form.ShowDialog()));

                var excelPath = await task;

                new ExcelViewer(excelPath).Open();
            }
        }

        private async void _btnSendEmail_Click(object? sender, EventArgs e)
        {
            if (_gridApps.CurrentRow?.DataBoundItem is ApplicationViewModel viewModel)
            {
                var task = Task.Run(() => EmailService.PrepareEmail(viewModel.Id));

                using var form = new LoadingForm("Email", "Preparing email...");

                BeginInvoke((Action)(() => form.ShowDialog()));

                await task;
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

        private void _gridApps_SelectionChanged(object? sender, EventArgs e)
        {
            if (_gridApps.CurrentRow?.DataBoundItem is ApplicationViewModel viewModel)
            {
                _gridAppEvaluations.DataSource = viewModel.Evaluations;
            }
        }
    }
}
