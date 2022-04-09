﻿using System.Linq;

using LinqToDB;

using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class ApplicationEvaluationViewModel : ApplicationEvaluation
    {
        public string           Course             { get; set; }
        public EvaluationStatus Status             { get; set; }
        public string           StatusDisplayName  { get; set; }
        public string           Instructor         { get; set; }
        public string           SuggestedOrMatched { get; set; }

        public ApplicationEvaluationViewModel(Dc dc, ApplicationEvaluation evaluation)
        {
            CourseId = evaluation.CourseId;
            Course   = dc.Courses.First(c => c.CourseId == evaluation.CourseId).DisplayString;

            if (evaluation.HistoricalEvaluationId > 0)
            {
                var historical = dc.Evaluations
                    .LoadWith(e => e.Instructor)
                    .LoadWith(e => e.MatchedCourse)
                    .First(e => e.EvaluationId == evaluation.HistoricalEvaluationId);

                Status             = EvaluationStatus.MatchedByHistory;
                Instructor         = historical.Instructor.DisplayString;
                SuggestedOrMatched = historical.MatchedCourse.DisplayString;
            }
            else
            {
                Status = EvaluationStatus.InProcess;

                if (evaluation.InstructorId > 0)
                {
                    Instructor = dc.Instructors.First(i => i.InstructorId == evaluation.InstructorId).DisplayString;
                }

                if (evaluation.SuggestedCourseId > 0)
                {
                    SuggestedOrMatched = dc.Courses.First(c => c.CourseId == evaluation.SuggestedCourseId).DisplayString;
                }
            }

            StatusDisplayName = Status.GetDisplayName();
        }
    }
}
