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
        EvaluatorsAttachments = 4,
        Review                = 5
    }

    public class ApplicationBuild
    {
        public Student   Student         { get; protected set; }
        public int       OrganizationId  { get; set; }
        public int       ExcelLocationId { get; set; }
        public BuildStep CurrentStep     { get; set; }

        public HashSet<int>         CourseIds             { get; set; }
        public Dictionary<int, int> HistoricalEvaluations { get; set; }

        public ApplicationBuild()
        {
            Student               = new();
            CourseIds             = new HashSet<int>();
            HistoricalEvaluations = new Dictionary<int, int>();
        }

        public bool AnyHistoricalEvaluations()
        {
            using var dc = new Dc();

            return dc.Evaluations.Any(e => CourseIds.Contains(e.CourseId));
        }

        public BuildStep? GetNextStep()
        {
            return CurrentStep switch
            {
                BuildStep.Student => BuildStep.Organization,
                BuildStep.Organization => BuildStep.Courses,
                BuildStep.Courses when AnyHistoricalEvaluations() => BuildStep.HistoricalEvaluations,
                BuildStep.Courses or BuildStep.HistoricalEvaluations => BuildStep.EvaluatorsAttachments,
                BuildStep.EvaluatorsAttachments => BuildStep.Review,
                _ => null
            };
        }

        public BuildStep GetPreviousStep()
        {
            return CurrentStep switch
            {
                BuildStep.Review => BuildStep.EvaluatorsAttachments,
                BuildStep.EvaluatorsAttachments when AnyHistoricalEvaluations() => BuildStep.HistoricalEvaluations,
                BuildStep.EvaluatorsAttachments => BuildStep.Courses,
                BuildStep.HistoricalEvaluations => BuildStep.Courses,
                BuildStep.Courses => BuildStep.Organization,
                _ => BuildStep.Student
            };
        }
    }
}
