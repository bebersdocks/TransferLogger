using System;
using System.Linq;

using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.DataModels.Transfer;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class ApplicationViewModel
    {
        public int       ApplicationId     { get; set; }
        public string    ApplicationStatus { get; set; }
        public string    Student           { get; set; }
        public string    Organization      { get; set; }
        public int       CoursesCount      { get; set; }
        public DateTime  CreatedAt         { get; set; }
        public DateTime? SubmittedAt       { get; set; }

        public ApplicationViewModel() {}

        public ApplicationViewModel(Application app, Student student, Organization organization)
        {
            ApplicationId     = app.ApplicationId;
            ApplicationStatus = app.ApplicationStatus.ToString();
            Student           = student.DisplayString;
            Organization      = organization.Name;
            CoursesCount      = app.Courses.Count();
            CreatedAt         = app.CreatedAt;
            SubmittedAt       = app.SubmittedAt;
        }
    }
}
