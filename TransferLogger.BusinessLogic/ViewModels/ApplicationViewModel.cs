using System;
using System.Linq;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.DataModels.Transfer;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class ApplicationViewModel : IIdentifiable
    {
        public int       Id           { get; set; }
        public string    Status       { get; set; }
        public string    Student      { get; set; }
        public string    Organization { get; set; }
        public int       CoursesCount { get; set; }
        public DateTime  CreatedAt    { get; set; }
        public DateTime? SubmittedAt  { get; set; }

        public ApplicationViewModel() {}

        public ApplicationViewModel(Application app, Student student, Organization organization)
        {
            Id           = app.ApplicationId;
            Status       = app.ApplicationStatus.ToString();
            Student      = student.DisplayString;
            Organization = organization.Name;
            CoursesCount = app.Courses.Count();
            CreatedAt    = app.CreatedAt;
            SubmittedAt  = app.SubmittedAt;
        }
    }
}
