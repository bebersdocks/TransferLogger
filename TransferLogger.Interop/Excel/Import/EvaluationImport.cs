using System;
using System.Linq;

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

        public Evaluation Convert(Dc dc)
        {
            var evaluation = dc.GetEvaluations()
                .First(e => e.EvaluationId == EvaluationId);

            evaluation.EvaluationStatus = EvaluationStatus;
            evaluation.Comment          = Comment;

            if (EvaluationStatus == EvaluationStatus.Matched)
            {
                if ((evaluation.SuggestedCourseId ?? 0) <= 0)
                {
                    throw new Exception($"Evaluation {evaluation.EvaluationId} was detected as matched by suggestion, but suggested course is not set.");
                }

                evaluation.MatchedCourseId = evaluation.SuggestedCourseId;

                return evaluation;
            }
            else if (string.IsNullOrEmpty(AlternativeCourse) || EvaluationStatus == EvaluationStatus.NotMatched)
            {
                evaluation.MatchedCourseId = null;
                evaluation.MatchedCourse   = null;

                return evaluation;
            }
            else // Case of matching by alternative course.
            {
                var tagetProgramId = evaluation.Application.TargetProgramId;

                var course = dc.Courses.FirstOrDefault(c => c.ProgramId == tagetProgramId && c.CourseCode == AlternativeCourse);

                // This is the case when user put another course code in Transfer column and course is already in database,
                // then we automatically set evaluation as matched with this course.
                if (course != null)
                {
                    evaluation.EvaluationStatus = EvaluationStatus.Matched;
                    evaluation.MatchedCourseId  = course.CourseId;
                    evaluation.MatchedCourse    = course;

                    return evaluation;
                }
                else
                {
                    throw new Exception(
                        $"Evaluation {evaluation.EvaluationId} alternative transfer course " +
                        $"{AlternativeCourse} is not presented in the database for " +
                        $"target program {evaluation.Application.TargetProgram.DisplayString}.");
                }
            }
        }
    }
}
