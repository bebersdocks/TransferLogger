using System;
using System.Linq;

using LinqToDB;

using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.Interop.Excel.Import
{
    public class EvaluationImport
    {
        public int              EvaluationId      { get; set; }
        public EvaluationStatus EvaluationStatus  { get; set; }
        public string           AlternativeCourse { get; set; }
        public string           Comment           { get; set; }

        /// <returns>False only if user used alternative course code for transfer and this course was not found in the database.</returns>
        public bool TryConvert(Dc dc, out Evaluation evaluation)
        {
            evaluation = dc.Evaluations
                .Where(e => e.EvaluationId == EvaluationId)
                .LoadWith(e => e.Application)
                .First();

            evaluation.EvaluationStatus = EvaluationStatus;
            evaluation.Comment          = Comment;

            if (EvaluationStatus == EvaluationStatus.Matched)
            {
                evaluation.MatchedCourseId = evaluation.SuggestedCourseId;

                if (evaluation.MatchedCourseId <= 0)
                {
                    throw new Exception($"Evaluation {evaluation.EvaluationId} was detected as matched, but matched course is not set.");
                }

                return true;
            }
            else if (string.IsNullOrEmpty(AlternativeCourse) || EvaluationStatus == EvaluationStatus.NotMatched)
            {
                return true;
            }
            else
            {
                var appId = evaluation.Application.TargetProgramId;

                var course = dc.Courses.FirstOrDefault(c => c.ProgramId == appId && c.CourseCode == AlternativeCourse);

                // This is the case when user put another course code in Transfer column and course is already in database,
                // then we automatically set evaluation as matched with this course.
                if (course != null)
                {
                    evaluation.MatchedCourseId  = course.CourseId;
                    evaluation.EvaluationStatus = EvaluationStatus.Matched;

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
