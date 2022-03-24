using System;
using System.Collections.Generic;
using System.Linq;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class CourseViewModel : IIdentifiable
    {
        public int    Id           { get; set; }
        public string Name         { get; set; }
        public string Organization { get; set; }
        public string Program      { get; set; }
        public string Cycle        { get; set; }
        public int    Credits      { get; set; }
        public int    WeeklyHours  { get; set; }

        public CourseViewModel(Course course, Program program, Organization organization)
        {
            Id           = course.CourseId;
            Name         = course.DisplayString;
            Organization = organization.DisplayString;
            Program      = program.DisplayString;
            Cycle        = program.Cycle.GetDisplayName();
            Credits      = course.Credits;
            WeeklyHours  = course.WeeklyHours;
        }

        public static List<CourseViewModel> GetList(string searchName = "", int organizationId = 0, Cycle? cycle = null, int programId = 0)
        {
            using var dc = new Dc();

            var query = dc.Courses.AsQueryable();

            if (!string.IsNullOrEmpty(searchName))
                query = query.Where(c => $"{c.CourseCode} - {c.Name}".Contains(searchName, StringComparison.OrdinalIgnoreCase));

            if (organizationId > 0)
                query = query.Where(c => c.OrganizationId == organizationId);

            if (cycle.HasValue)
                query = query.Where(c => c.Program.Cycle == cycle.Value);

            if (programId > 0)
                query = query.Where(c => c.ProgramId == programId);

            return query
                .Select(c => new CourseViewModel(c, c.Program, c.Organization))
                .ToList();
        }

        public static List<CourseViewModel> GetList(string searchName, object organizationIdObj, object cycleObj, object programIdObj)
        {
            Cycle? cycle = null;
            if (cycleObj != null)
                cycle = (Cycle)cycleObj;

            return GetList(searchName, Convert.ToInt32(organizationIdObj), cycle, Convert.ToInt32(programIdObj));
        }
    }
}
