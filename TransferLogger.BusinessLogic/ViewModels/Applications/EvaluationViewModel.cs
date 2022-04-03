using TransferLogger.Dal.DataModels;

namespace TransferLogger.BusinessLogic.ViewModels.Applications
{
    public class EvaluationViewModel
    {
        public int              EvaluationId    { get; set; }
        public EvaluationStatus Status          { get; set; }
        public int              CourseId        { get; set; }
        public string           Course          { get; set; }
        public int?             MatchedCourseId { get; set; }
        public string           MatchedCourse   { get; set; }
        public int              InstructorId    { get; set; }
        public string           Instructor      { get; set; }
        public string           Comment         { get; set; }

        public EvaluationViewModel(Evaluation evaluation)
        {
            EvaluationId    = evaluation.EvaluationId;
            Status          = evaluation.EvaluationStatus;
            CourseId        = evaluation.CourseId;
            Course          = evaluation.Course.DisplayString;
            MatchedCourseId = evaluation.MatchedCourseId;
            MatchedCourse   = evaluation.MatchedCourse?.DisplayString ?? string.Empty;
            InstructorId    = evaluation.InstructorId;
            Instructor      = evaluation.Instructor.DisplayString;
            Comment         = evaluation.Comment;
        }
    }
}
