using System.Linq;

using TransferLogger.Dal;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class ApplicationEvaluationViewModel : ApplicationEvaluation
    {
        public string Course          { get; set; }
        public string Instructor      { get; set; }
        public string SuggestedCourse { get; set; }

        public ApplicationEvaluationViewModel(Dc dc, ApplicationEvaluation evaluation)
        {
            CourseId              = evaluation.CourseId;
            SendEmailNotification = evaluation.SendEmailNotification;
        
            Course = dc.Courses
                .First(c => c.CourseId == evaluation.CourseId).DisplayString;

            if (evaluation.InstructorId > 0)
            {
                Instructor = dc.Instructors
                    .First(i => i.InstructorId == evaluation.InstructorId).DisplayString;
            }

            if (evaluation.SuggestedCourseId > 0)
            {
                SuggestedCourse = dc.Courses
                    .First(c => c.CourseId == evaluation.SuggestedCourseId).DisplayString;
            }
        }
    }
}
