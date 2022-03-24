using TransferLogger.Dal.DataModels.Applications;

namespace TransferLogger.BusinessLogic.ViewModels.Applications
{
    public class ApplicationCourseViewModel
    {
        public int          CourseId        { get; set; }
        public string       Course          { get; set; }
        public int?         MatchedCourseId { get; set; }
        public string       MatchedCourse   { get; set; }
        public int          InstructorId    { get; set; }
        public string       Instructor      { get; set; }
        public CourseStatus Status          { get; set; }
        public string       Comment         { get; set; }
        public string       Grade           { get; set; }

        public ApplicationCourseViewModel(ApplicationCourse course)
        {
            CourseId        = course.CourseId;
            Course          = course.Course.DisplayString;
            MatchedCourseId = course.MatchedCourseId;
            MatchedCourse   = course.MatchedCourse?.DisplayString ?? string.Empty;
            InstructorId    = course.InstructorId;
            Instructor      = course.Instructor.DisplayString;
            Status          = course.Status;
            Comment         = course.Comment;
            Grade           = course.Grade;
        }
    }
}
