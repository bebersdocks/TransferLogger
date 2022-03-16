using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Ui.Forms.Course;
using TransferLogger.Ui.Forms.Instructor;
using TransferLogger.Ui.Forms.Organization;
using TransferLogger.Ui.Forms.Program;
using TransferLogger.Ui.Forms.Student;

using static TransferLogger.Ui.Utils.FormUtils;

namespace TransferLogger.Ui.Forms.Tranfser
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

            _grid.DataSource = apps;
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
