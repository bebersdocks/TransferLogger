using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;

using TransferLogger.BusinessLogic.Settings;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.DataModels.Applications;

namespace TransferLogger.BusinessLogic
{
    public enum BuildStep
    {
        Student               = 0,
        Program               = 1,
        Organization          = 2,
        Courses               = 3,
        HistoricalEvaluations = 4,
        Evaluators            = 5,
        Attachments           = 6,
        Review                = 7
    }

    public class ApplicationEvaluation
    {
        public int CourseId               { get; set; }
        public int HistoricalEvaluationId { get; set; }
        public int InstructorId           { get; set; }
        public int SuggestedCourseId      { get; set; }
    }

    public class ApplicationBuild
    {
        public int       TargetProgramId      { get; set; }
        public int       SourceOrganizationId { get; set; }
        public string    ExcelLocation        { get; set; }
        public BuildStep CurrentStep          { get; set; }

        public readonly Student                                Student;
        public readonly Dictionary<int, ApplicationEvaluation> Evaluations;
        public readonly List<ApplicationAttachment>            Attachments;

        public HashSet<int> CourseIds
        {
            get
            {
                var hashSet = new HashSet<int>();

                foreach (var key in Evaluations.Keys)
                    hashSet.Add(key);

                return hashSet;
            }
        }

        public ApplicationBuild()
        {
            Student     = new();
            Evaluations = new();
            Attachments = new();
        }

        public bool AnyHistoricalEvaluations()
        {
            using var dc = new Dc();

            return dc.Evaluations.Any(e => Evaluations.ContainsKey(e.CourseId) && e.EvaluationStatus != EvaluationStatus.InProcess);
        }

        public BuildStep? GetNextStep()
        {
            if (CurrentStep == BuildStep.Courses && AnyHistoricalEvaluations())
                return BuildStep.HistoricalEvaluations;

            return CurrentStep switch
            {
                BuildStep.Student               => BuildStep.Program,
                BuildStep.Program               => BuildStep.Organization,
                BuildStep.Organization          => BuildStep.Courses,
                BuildStep.Courses               => BuildStep.Evaluators,
                BuildStep.HistoricalEvaluations => BuildStep.Evaluators,
                BuildStep.Evaluators            => BuildStep.Attachments,
                BuildStep.Attachments           => BuildStep.Review,
                _                               => null
            };
        }

        public BuildStep GetPreviousStep()
        {
            if (CurrentStep == BuildStep.Evaluators && AnyHistoricalEvaluations())
                return BuildStep.HistoricalEvaluations;

            return CurrentStep switch
            {
                BuildStep.Review                => BuildStep.Attachments,
                BuildStep.Attachments           => BuildStep.Evaluators,
                BuildStep.Evaluators            => BuildStep.Courses,
                BuildStep.HistoricalEvaluations => BuildStep.Courses,
                BuildStep.Courses               => BuildStep.Organization,
                BuildStep.Organization          => BuildStep.Program,
                _                               => BuildStep.Student
            };
        }

        public int Insert()
        {
            using var dc = new Dc();

            if (!dc.Programs.Any(p => p.ProgramId == TargetProgramId && p.OrganizationId == AppSettings.Instance.OrganizationId))
                throw new ArgumentOutOfRangeException(nameof(TargetProgramId));

            using var tr = dc.BeginTransaction();

            var app = new Application();

            app.ApplicationStatus    = ApplicationStatus.InProcess;
            app.StudentId            = Student.StudentId;
            app.SourceOrganizationId = SourceOrganizationId;
            app.TargetProgramId      = TargetProgramId;
            app.ExcelLocation        = ExcelLocation?.Trim() ?? string.Empty;
            app.CreatedAt            = DateTime.UtcNow;

            var appId = dc.InsertWithInt32Identity(app);

            foreach (var attachment in Attachments)
            {
                attachment.ApplicationId = appId;

                dc.InsertWithInt32Identity(attachment);
            }

            foreach (var evaluation in Evaluations.Values)
            {
                var newEvaluation = new Evaluation();

                newEvaluation.ApplicationId = appId;

                if (evaluation.HistoricalEvaluationId > 0)
                {
                    var historical = dc.Evaluations.First(e => e.EvaluationId == evaluation.HistoricalEvaluationId);

                    if (historical.MatchedCourseId.HasValue)
                        newEvaluation.EvaluationStatus = EvaluationStatus.MatchedByHistory;
                    else
                        newEvaluation.EvaluationStatus = EvaluationStatus.RejectedByHistory;
            
                    newEvaluation.CourseId           = evaluation.CourseId;
                    newEvaluation.InstructorId       = historical.InstructorId;
                    newEvaluation.MatchedCourseId    = historical.MatchedCourseId;
                    newEvaluation.SuggestedCourseId  = historical.SuggestedCourseId;
                    newEvaluation.LinkedEvaluationId = historical.EvaluationId;
                    newEvaluation.Comment            = historical.Comment;
                }
                else
                {
                    newEvaluation.EvaluationStatus  = EvaluationStatus.InProcess;
                    newEvaluation.CourseId          = evaluation.CourseId;
                    newEvaluation.InstructorId      = evaluation.InstructorId;
                    newEvaluation.SuggestedCourseId = evaluation.SuggestedCourseId > 0 ? evaluation.SuggestedCourseId : null;
                }

                dc.InsertWithInt32Identity(newEvaluation);
            }

            tr.Commit();

            return appId;
        }

        /// <summary>
        /// Remove values which are no longer valid, exist or do not correlate with current selections.
        /// This might occur if user selected program, assigned suggested courses and then stepped back and changed target program.
        /// It also applies for deleted entities while inside application wizard.
        /// </summary>
        public void CleanObsoleteResources()
        {
            if (!Evaluations.Any())
                return;

            using var dc = new Dc();

            var organizationCourseIds = dc.Courses
                .Where(c => c.Program.OrganizationId == SourceOrganizationId)
                .Select(c => c.CourseId)
                .ToList();

            var programCourseIds = dc.Courses
                .Where(c => c.ProgramId == TargetProgramId)
                .Select(c => c.CourseId)
                .ToList();

            var instructorIds = dc.Instructors
                .Select(i => i.InstructorId)
                .ToList();

            foreach (var courseId in CourseIds)
            {
                if (!organizationCourseIds.Contains(courseId))
                {
                    Evaluations.Remove(courseId);

                    continue;
                }

                var evaluation = Evaluations[courseId];

                if (!programCourseIds.Contains(evaluation.SuggestedCourseId))
                    evaluation.SuggestedCourseId = 0;
                
                if (!instructorIds.Contains(evaluation.InstructorId))
                    evaluation.InstructorId = 0;
            }
        }
    }
}
