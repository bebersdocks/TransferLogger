using System.Linq;

using LinqToDB;

using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class BuildEvaluationViewModel : ApplicationEvaluation
    {
        public string           Course             { get; set; }
        public EvaluationStatus Status             { get; set; }
        public string           StatusDisplayName  { get; set; }
        public string           Instructor         { get; set; }
        public string           SuggestedOrMatched { get; set; }
        public bool             UseHistorical      { get; set; }

        public BuildEvaluationViewModel(Dc dc, ApplicationEvaluation evaluation)
        {
            CourseId          = evaluation.CourseId;
            InstructorId      = evaluation.InstructorId;
            SuggestedCourseId = evaluation.SuggestedCourseId;

            Course = dc.Courses.First(c => c.CourseId == evaluation.CourseId)
                .DisplayString;

            if (evaluation.HistoricalEvaluationId > 0)
            {
                var historical = dc.Evaluations
                    .LoadWith(e => e.Instructor)
                    .LoadWith(e => e.MatchedCourse)
                    .First(e => e.EvaluationId == evaluation.HistoricalEvaluationId);

                if (historical.MatchedCourseId.HasValue)
                    Status = EvaluationStatus.MatchedByHistory;
                else
                    Status = EvaluationStatus.RejectedByHistory;

                Instructor         = historical.Instructor.DisplayString;
                SuggestedOrMatched = historical.MatchedCourse?.DisplayString;
                UseHistorical      = true;
            }
            else
            {
                Status = EvaluationStatus.InProcess;

                if (evaluation.InstructorId > 0)
                {
                    Instructor = dc.Instructors.First(i => i.InstructorId == evaluation.InstructorId)
                        .DisplayString;
                }

                if (evaluation.SuggestedCourseId > 0)
                {
                    SuggestedOrMatched = dc.Courses.First(c => c.CourseId == evaluation.SuggestedCourseId)
                        .DisplayString;
                }
            }

            StatusDisplayName = Status.GetDisplayName();
        }
    }
}
