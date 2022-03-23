using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Ui.Forms.Courses;
using TransferLogger.Ui.Forms.Instructors;
using TransferLogger.Ui.Forms.Organizations;
using TransferLogger.Ui.Forms.Programs;
using TransferLogger.Ui.Forms.Students;

using static TransferLogger.Ui.Utils.FormUtils;

namespace TransferLogger.Ui.Forms.Applications
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

            apps.Add(new ApplicationViewModel() { Id = 5, Status = "Processed", CreatedAt = DateTime.Today });
            apps.Add(new ApplicationViewModel() { Id = 6, Status = "Processed", Student = "Arseniy Mak" });

            _gridApps.DataSource = apps;
        }

        private void SetEvents()
        {
            _miCourses.Click       += (s, e) => ShowForm(() => new CoursesForm());
            _miInstructors.Click   += (s, e) => ShowForm(() => new InstructorsForm());
            _miOrganizations.Click += (s, e) => ShowForm(() => new OrganizationsForm());
            _miPrograms.Click      += (s, e) => ShowForm(() => new ProgramsForm());
            _miStudents.Click      += (s, e) => ShowForm(() => new StudentsForm());
        }
    }
}
