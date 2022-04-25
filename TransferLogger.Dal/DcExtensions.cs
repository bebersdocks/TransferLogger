using System.Linq;

using LinqToDB;

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
    }
}
