using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;

using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.BusinessLogic.ViewModels.Courses
{
    public class SelectableCourseViewModel : CourseViewModel
    {
        public bool Selected { get; set; }

        public SelectableCourseViewModel(Course course, bool selected) : base(course)
        {
            Selected = selected;
        }

        public static List<SelectableCourseViewModel> GetList(HashSet<int> selectedIds,
            string searchName = "",
            int organizationId = 0,
            Cycle? cycle = null, 
            int programId = 0)
        {
            using var dc = new Dc();

            var selectedCourses = dc.Courses
                .LoadWith(c => c.Organization)
                .LoadWith(c => c.Program)
                .Where(c => selectedIds.Contains(c.CourseId))
                .AsEnumerable();

            return GetQuery(dc, searchName, organizationId, cycle, programId)
                .Where(c => !selectedIds.Contains(c.CourseId))
                .AsEnumerable()
                .Union(selectedCourses)
                .OrderBy(c => c.CourseId)
                .Select(c => new SelectableCourseViewModel(c, selectedIds.Contains(c.CourseId)))
                .ToList();
        }

        public static List<SelectableCourseViewModel> GetList(HashSet<int> selectedIds,
            string searchName,
            object organizationIdObj,
            object cycleObj, 
            object programIdObj)
        {
            Cycle? cycle = null;
            if (cycleObj != null)
                cycle = (Cycle)cycleObj;

            return GetList(selectedIds, searchName, Convert.ToInt32(organizationIdObj), cycle, Convert.ToInt32(programIdObj));
        }
    }
}
