using System.Linq;

using LinqToDB;

using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.DataModels.Applications;

namespace TransferLogger.Dal
{
    public static class DcExtensions
    {
        public static Application GetApplication(this Dc dc, int appId)
        {
            return dc.Applications
                .Where(a => a.ApplicationId == appId)
                .LoadWith(a => a.Student)
                .LoadWith(a => a.SourceOrganization)
                .LoadWith(a => a.TargetOrganization)
                .LoadWith(a => a.TargetProgram)
                .LoadWith(a => a.Evaluations)
                .ThenLoad(e => e.Instructor)
                .LoadWith(a => a.Evaluations)
                .ThenLoad(e => e.Course)
                .LoadWith(a => a.Evaluations)
                .ThenLoad(e => e.SuggestedCourse)
                .LoadWith(a => a.Evaluations)
                .ThenLoad(e => e.MatchedCourse)
                .LoadWith(a => a.Attachments)
                .First();
        }

        public static IQueryable<Evaluation> GetEvaluations(this Dc dc)
        {
            return dc.Evaluations
                .LoadWith(e => e.Application)
                .LoadWith(e => e.Application.Student)
                .LoadWith(e => e.Application.SourceOrganization)
                .LoadWith(e => e.Application.TargetProgram)
                .LoadWith(e => e.Course)
                .LoadWith(e => e.SuggestedCourse)
                .LoadWith(e => e.MatchedCourse)
                .LoadWith(e => e.Instructor);
        }
    }
}
