using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.BusinessLogic.Models.Courses
{
    public class CourseModel : IIdentifiable
    {
        public int    Id           { get; set; }
        public string Name         { get; set; }
        public string Organization { get; set; }
        public string Program      { get; set; }
        public string Cycle        { get; set; }
        public int    Credits      { get; set; }
        public int    WeeklyHours  { get; set; }

        public CourseModel(Course course)
        {
            Id           = course.CourseId;
            Name         = course.DisplayString;
            Organization = course.Program.Organization.DisplayString;
            Program      = course.Program.DisplayString;
            Cycle        = course.Program.Cycle.GetDisplayName();
            Credits      = course.Credits;
            WeeklyHours  = course.WeeklyHours;
        }

        protected static IQueryable<Course> GetQuery(Dc dc, string searchName = "", int organizationId = 0, Cycle? cycle = null, int programId = 0)
        {
            var query = dc.Courses
                .LoadWith(c => c.Program)
                .LoadWith(c => c.Program.Organization)
                .AsQueryable();

            searchName = searchName
                .Replace("-", string.Empty)
                .Replace(" ", string.Empty);

            if (!string.IsNullOrEmpty(searchName))
                query = query.Where(c => $"{c.CourseCode}{c.Name}"
                    .Replace(" ", string.Empty)
                    .Contains(searchName));

            if (organizationId > 0)
                query = query.Where(c => c.Program.OrganizationId == organizationId);

            if (cycle.HasValue)
                query = query.Where(c => c.Program.Cycle == cycle.Value);

            if (programId > 0)
                query = query.Where(c => c.ProgramId == programId);
            
            return query;
        }

        public static List<CourseModel> GetList(string searchName = "", int organizationId = 0, Cycle? cycle = null, int programId = 0)
        {
            using var dc = new Dc();

            return GetQuery(dc, searchName, organizationId, cycle, programId)
                .Select(c => new CourseModel(c))
                .ToList();
        }

        public static List<CourseModel> GetList(string searchName, object organizationIdObj, object cycleObj, object programIdObj)
        {
            Cycle? cycle = null;
            if (cycleObj != null)
                cycle = (Cycle)cycleObj;

            return GetList(searchName, Convert.ToInt32(organizationIdObj), cycle, Convert.ToInt32(programIdObj));
        }
    }
}
