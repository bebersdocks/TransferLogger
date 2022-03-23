using System;
using System.Collections.Generic;
using System.Linq;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.DataModels.Applications;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class ApplicationViewModel : IIdentifiable
    {
        public int       Id           { get; set; }
        public string    Status       { get; set; }
        public string    Student      { get; set; }
        public string    Organization { get; set; }
        public DateTime  CreatedAt    { get; set; }
        public DateTime? UpdatedAt    { get; set; }
        public DateTime? CompletedAt  { get; set; }

        public ApplicationViewModel() {}

        public ApplicationViewModel(Application app, Student student, Organization organization)
        {
            Id           = app.ApplicationId;
            Status       = app.ApplicationStatus.ToString();
            Student      = student.DisplayString;
            Organization = organization.Name;
            CreatedAt    = app.CreatedAt;
            UpdatedAt    = app.UpdatedAt;
            CompletedAt  = app.CompletedAt;
        }
    }
}
