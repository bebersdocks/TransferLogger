using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Ui.Forms.Instructor;
using TransferLogger.Ui.Forms.Organization;
using TransferLogger.Ui.Forms.Program;
using TransferLogger.Ui.Forms.Student;

using static TransferLogger.Ui.Utils.FormUtils;

namespace TransferLogger.Ui.Forms
{
    public partial class ApplicationsForm : Form
    {
        public ApplicationsForm()
        {
            InitializeComponent();

            SetData();
            SetEvents();
        }

        public void SetData()
        {
            using var dc = new Dc();

            var apps = new List<ApplicationViewModel>();

            apps.Add(new ApplicationViewModel() { ApplicationId = 5, ApplicationStatus = "Processed", CreatedAt = DateTime.Today });
            apps.Add(new ApplicationViewModel() { ApplicationId = 6, ApplicationStatus = "Processed", Student = "Arseniy Mak" });

            _grid.DataSource = apps;
        }

        private void SetEvents()
        {
            _menuItemInstructors.Click   += (s, e) => ShowForm(() => new InstructorsForm());
            _menuItemOrganizations.Click += (s, e) => ShowForm(() => new OrganizationsForm());
            _menuItemPrograms.Click      += (s, e) => ShowForm(() => new ProgramsForm());
            _menuItemStudents.Click      += (s, e) => ShowForm(() => new StudentsForm());
        }
    }
}
