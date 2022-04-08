using System.Collections.Generic;
using System.Linq;

using TransferLogger.BusinessLogic.Settings;
using TransferLogger.Dal;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.BusinessLogic
{
    public class Lookup
    {
        public int    Value       { get; set; }
        public string DisplayName { get; set; }

        public Lookup(int value, string displayName)
        {
            Value       = value;
            DisplayName = displayName;
        }
    }

    public static class LookupServices
    {
        public static List<Lookup> GetOrganizations(bool excludeOurs = false)
        {
            using var dc = new Dc();

            var query = dc.Organizations.AsQueryable();

            if (excludeOurs)
                query = query.Where(o => o.OrganizationId != AppSettings.Instance.OrganizationId);

            return query
                .Select(o => new Lookup(o.OrganizationId, o.DisplayString))
                .ToList();
        }

        public static List<Lookup> GetPrograms(int organizationId, Cycle? cycle)
        {
            if (organizationId > 0)
            {
                using var dc = new Dc();

                var query = dc.Programs.Where(p => p.OrganizationId == organizationId);

                if (cycle.HasValue)
                    query = query.Where(p => p.Cycle == cycle.Value);

                return query
                    .Select(p => new Lookup(p.ProgramId, p.DisplayString))
                    .ToList();
            }
            else
            {
                return new List<Lookup>();
            }
        }

        public static List<Lookup> GetPrograms(object organizationIdObj, object cycleObj)
        {
            Cycle? cycle = null;
            if (cycleObj != null)
                cycle = (Cycle)cycleObj;

            return GetPrograms((int?)organizationIdObj ?? 0, cycle);
        }

        public static List<Lookup> GetCourses(int organizationId)
        {
            using var dc = new Dc();

            return dc.Courses
                .Where(c => c.OrganizationId == organizationId)
                .Select(c => new Lookup(c.CourseId, c.DisplayString))
                .ToList();
        }

        public static List<Lookup> GetStudents()
        {
            using var dc = new Dc();

            return dc.Students
                .Select(s => new Lookup(s.StudentId, s.ExtendedDisplayString))
                .ToList();
        }

        public static List<Lookup> GetInstructors()
        {
            using var dc = new Dc();

            return dc.Instructors
                .Select(i => new Lookup(i.InstructorId, i.ExtendedDisplayString))
                .ToList();
        }
    }
}
