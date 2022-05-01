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
                evaluation.MatchedCourseId = evaluation.SuggestedCourseId;

                if (evaluation.MatchedCourseId <= 0)
                {
                    throw new Exception($"Evaluation {evaluation.EvaluationId} was detected as matched, but matched course is not set.");
                }

                return evaluation;
            }
            else if (string.IsNullOrEmpty(AlternativeCourse) || EvaluationStatus == EvaluationStatus.NotMatched)
            {
                return evaluation;
            }
            else
            {
                var tagetProgramId = evaluation.Application.TargetProgramId;

                var course = dc.Courses.FirstOrDefault(c => c.ProgramId == tagetProgramId && c.CourseCode == AlternativeCourse);

                // This is the case when user put another course code in Transfer column and course is already in database,
                // then we automatically set evaluation as matched with this course.
                if (course != null)
                {
                    evaluation.MatchedCourseId  = course.CourseId;
                    evaluation.EvaluationStatus = EvaluationStatus.Matched;

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
