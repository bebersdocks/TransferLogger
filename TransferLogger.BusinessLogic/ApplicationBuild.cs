using System.Collections.Generic;
using System.Linq;

using TransferLogger.Dal;

namespace TransferLogger.BusinessLogic
{
    public class ApplicationBuild
    {
        public int StudentId       { get; set; }
        public int OrganizationId  { get; set; }
        public int ExcelLocationId { get; set; }

        public HashSet<int>         CourseIds             { get; set; }
        public Dictionary<int, int> HistoricalEvaluations { get; set; }

        public ApplicationBuild()
        {
            CourseIds             = new HashSet<int>();
            HistoricalEvaluations = new Dictionary<int, int>();
        }

        public bool AnyHistoricalEvaluations()
        {
            using var dc = new Dc();

            return dc.Evaluations.Any(e => CourseIds.Contains(e.CourseId));
        }
    }
}
