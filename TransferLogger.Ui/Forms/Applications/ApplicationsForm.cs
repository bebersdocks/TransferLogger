using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal.DataModels.Applications;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Courses;
using TransferLogger.Ui.Forms.Instructors;
using TransferLogger.Ui.Forms.Organizations;
using TransferLogger.Ui.Forms.Programs;
using TransferLogger.Ui.Forms.Students;

using static TransferLogger.Ui.Utils.FormUtils;

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
            _miCourses.Click       += (s, e) => ShowForm(() => new CoursesForm());
            _miInstructors.Click   += (s, e) => ShowForm(() => new InstructorsForm());
            _miOrganizations.Click += (s, e) => ShowForm(() => new OrganizationsForm());
            _miPrograms.Click      += (s, e) => ShowForm(() => new ProgramsForm());
            _miStudents.Click      += (s, e) => ShowForm(() => new StudentsForm());

            _tbSearchName.TextChanged             += (s, e) => SetData();
            _cbOrganizations.SelectedValueChanged += (s, e) => SetData();
            _cbStatuses.SelectedValueChanged      += (s, e) => SetData();

            _btnAdd.Click                += _btnAdd_Click;
            _btnSelectOrganization.Click += _btnSelectOrganization_Click;

            _gridApps.SelectionChanged += _gridApps_SelectionChanged;
        }

        private void _btnAdd_Click(object? sender, EventArgs e)
        {
            using var form = new ApplicationWizardForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                SetData();
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
                _gridAppCourses.DataSource = viewModel.Courses;
            }
        }
    }
}
