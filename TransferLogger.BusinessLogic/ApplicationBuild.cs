using System.Collections.Generic;
using System.Linq;

using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

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
        public int  CourseId               { get; set; }
        public int  HistoricalEvaluationId { get; set; }
        public int  InstructorId           { get; set; }
        public bool SendEmailNotification  { get; set; }
        public int  SuggestedCourseId      { get; set; }
    }

    public class ApplicationBuild
    {
        public Student   Student        { get; private set; }
        public int       OrganizationId { get; set; }
        public string    ExcelLocation  { get; set; }
        public BuildStep CurrentStep    { get; set; }

        public Dictionary<int, ApplicationEvaluation> Evaluations { get; private set; }

        public HashSet<int> CourseIds => Evaluations.Keys.ToHashSet();

        public ApplicationBuild()
        {
            Student     = new();
            Evaluations = new();
        }

        public bool AnyHistoricalEvaluations()
        {
            using var dc = new Dc();

            return dc.Evaluations.Any(e => Evaluations.ContainsKey(e.CourseId));
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
    }
}
