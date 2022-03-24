using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels.Applications;

namespace TransferLogger.BusinessLogic.ViewModels.Applications
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

        public List<ApplicationCourseViewModel> Courses { get; set; }

        public ApplicationViewModel(Application app)
        {
            Id           = app.ApplicationId;
            Status       = app.ApplicationStatus.ToString();
            Student      = app.Student.DisplayString;
            Organization = app.Organization.Name;
            CreatedAt    = app.CreatedAt;
            UpdatedAt    = app.UpdatedAt;
            CompletedAt  = app.CompletedAt;

            Courses = app.Courses
                .Select(c => new ApplicationCourseViewModel(c))
                .ToList();
        }

        public static List<ApplicationViewModel> GetList(string studentName = "", int organizationId = 0, ApplicationStatus? status = null, DateTime? from = null, DateTime? to = null)
        {
            using var dc = new Dc();

            var query = dc.Applications.AsQueryable();

            if (!string.IsNullOrEmpty(studentName))
                query = query.Where(a => $"{a.Student.Name} {a.Student.Middle} {a.Student.Middle}".Contains(studentName, StringComparison.OrdinalIgnoreCase));

            if (organizationId > 0)
                query = query.Where(a => a.OrganizationId == organizationId);

            if (status.HasValue)
                query = query.Where(a => a.ApplicationStatus == status.Value);

            if (from.HasValue)
                query = query.Where(a => a.CreatedAt > from.Value);

            if (to.HasValue)
                query = query.Where(a => a.CreatedAt < to.Value);

            return query
                .LoadWith(a => a.Student)
                .LoadWith(a => a.Organization)
                .LoadWith(a => a.Courses)
                .Select(a => new ApplicationViewModel(a))
                .ToList();
        }

        public static List<ApplicationViewModel> GetList(string studentName, object organizationIdObj, object statusObj, DateTime from, DateTime to)
        {
            ApplicationStatus? status = null;
            if (statusObj != null)
                status = (ApplicationStatus)statusObj;

            return GetList(studentName, organizationId: Convert.ToInt32(organizationIdObj), status, from, to);
        }
    }
}
