using System.Collections.Generic;
using System.Linq;

using LinqToDB;

using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.BusinessLogic.Models.Courses
{
    public class SelectableCourseModel : CourseModel
    {
        public bool Selected { get; set; }

        public SelectableCourseModel(Course course, bool selected) 
            : base(course)
        {
            Selected = selected;
        }

        public static List<SelectableCourseModel> GetList(
            HashSet<int> selectedIds,
            string searchName = "",
            int organizationId = 0,
            Cycle? cycle = null, 
            int programId = 0)
        {
            using var dc = new Dc();

            var selectedCourses = dc.Courses
                .LoadWith(c => c.Program)
                .LoadWith(c => c.Program.Organization)
                .Where(c => selectedIds.Contains(c.CourseId))
                .AsEnumerable();

            return GetQuery(dc, searchName, organizationId, cycle, programId)
                .Where(c => !selectedIds.Contains(c.CourseId))
                .AsEnumerable()
                .Union(selectedCourses)
                .OrderBy(c => c.CourseId)
                .Select(c => new SelectableCourseModel(c, selectedIds.Contains(c.CourseId)))
                .ToList();
        }
    }
}
