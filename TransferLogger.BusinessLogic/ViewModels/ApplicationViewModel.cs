using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class ApplicationViewModel : IIdentifiable
    {
        public int               Id                { get; set; }
        public ApplicationStatus Status            { get; set; }
        public string            StatusDisplayName { get; set; }
        public string            Student           { get; set; }
        public string            Organization      { get; set; }
        public DateTime          CreatedAt         { get; set; }
        public DateTime?         UpdatedAt         { get; set; }
        public DateTime?         CompletedAt       { get; set; }

        public List<EvaluationViewModel> Courses { get; set; }

        public ApplicationViewModel(Application app)
        {
            Id                = app.ApplicationId;
            Status            = app.ApplicationStatus;
            StatusDisplayName = app.ApplicationStatus.GetDisplayName();
            Student           = app.Student.DisplayString;
            Organization      = app.SourceOrganization.Name;
            CreatedAt         = app.CreatedAt;
            UpdatedAt         = app.UpdatedAt;
            CompletedAt       = app.CompletedAt;
        }

        public static List<ApplicationViewModel> GetList(string studentName = "", int organizationId = 0, ApplicationStatus? status = null, DateTime? from = null, DateTime? to = null)
        {
            using var dc = new Dc();

            var query = dc.Applications.AsQueryable();

            if (!string.IsNullOrEmpty(studentName))
                query = query.Where(a => $"{a.Student.Name} {a.Student.Middle} {a.Student.Middle}".Contains(studentName, StringComparison.OrdinalIgnoreCase));

            if (organizationId > 0)
                query = query.Where(a => a.SourceOrganizationId == organizationId);

            if (status.HasValue)
                query = query.Where(a => a.ApplicationStatus == status.Value);

            if (from.HasValue)
                query = query.Where(a => a.CreatedAt > from.Value);

            if (to.HasValue)
                query = query.Where(a => a.CreatedAt < to.Value);

            return query
                .LoadWith(a => a.Student)
                .LoadWith(a => a.SourceOrganization)
                .LoadWith(a => a.Evaluations)
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
