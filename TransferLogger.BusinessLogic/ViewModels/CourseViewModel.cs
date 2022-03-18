using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal.DataModels;

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

        public CourseViewModel() {}

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
    }
}
