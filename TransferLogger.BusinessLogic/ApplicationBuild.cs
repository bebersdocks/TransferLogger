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
        Organization          = 1,
        Courses               = 2,
        HistoricalEvaluations = 3,
        Evaluators            = 4,
        Attachments           = 5,
        Review                = 6
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
        public Student   Student        { get; private set; }
        public int       OrganizationId { get; set; }
        public string    ExcelLocation  { get; set; }
        public BuildStep CurrentStep    { get; set; }

        public Dictionary<int, ApplicationEvaluation> Evaluations { get; private set; }
        public List<ApplicationAttachment>            Attachments { get; private set; }

        public HashSet<int> CourseIds => Evaluations.Keys.ToHashSet();

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
            return CurrentStep switch
            {
                BuildStep.Student => BuildStep.Organization,
                BuildStep.Organization => BuildStep.Courses,
                BuildStep.Courses when AnyHistoricalEvaluations() => BuildStep.HistoricalEvaluations,
                BuildStep.Courses or BuildStep.HistoricalEvaluations => BuildStep.Evaluators,
                BuildStep.Evaluators => BuildStep.Attachments,
                BuildStep.Attachments => BuildStep.Review,
                _ => null
            };
        }

        public BuildStep GetPreviousStep()
        {
            return CurrentStep switch
            {
                BuildStep.Review => BuildStep.Attachments,
                BuildStep.Attachments => BuildStep.Evaluators,
                BuildStep.Evaluators when AnyHistoricalEvaluations() => BuildStep.HistoricalEvaluations,
                BuildStep.Evaluators => BuildStep.Courses,
                BuildStep.HistoricalEvaluations => BuildStep.Courses,
                BuildStep.Courses => BuildStep.Organization,
                _ => BuildStep.Student
            };
        }

        public void Insert()
        {
            using var dc = new Dc();

            using var tr = dc.BeginTransaction();

            var application = new Application();

            application.ApplicationStatus    = ApplicationStatus.InProcess;
            application.StudentId            = Student.StudentId;
            application.SourceOrganizationId = OrganizationId;
            application.TargetOrganizationId = AppSettings.Instance.OrganizationId;
            application.ExcelLocation        = ExcelLocation.Trim();
            application.CreatedAt            = DateTime.UtcNow;

            var applicationId = dc.InsertWithInt32Identity(application);

            foreach (var attachment in Attachments)
            {
                attachment.ApplicationId = applicationId;

                dc.InsertWithInt32Identity(attachment);
            }

            foreach (var evaluation in Evaluations.Values)
            {
                var newEvaluation = new Evaluation();

                newEvaluation.ApplicationId = applicationId;

                if (evaluation.HistoricalEvaluationId > 0)
                {
                    var historical = dc.Evaluations.First(e => e.EvaluationId == evaluation.HistoricalEvaluationId);

                    newEvaluation.EvaluationStatus   = EvaluationStatus.MatchedByHistory;
                    newEvaluation.CourseId           = evaluation.CourseId;
                    newEvaluation.MatchedCourseId    = historical.MatchedCourseId;
                    newEvaluation.InstructorId       = historical.InstructorId;
                    newEvaluation.LinkedEvaluationId = historical.EvaluationId;
                    newEvaluation.Comment            = historical.Comment;             
                }
                else
                {
                    newEvaluation.EvaluationStatus = EvaluationStatus.InProcess;
                    newEvaluation.CourseId         = evaluation.CourseId;
                    newEvaluation.InstructorId     = evaluation.InstructorId;
                }

                dc.InsertWithInt32Identity(newEvaluation);
            }

            tr.Commit();
        }
    }
}
