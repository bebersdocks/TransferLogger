using System.Collections.Generic;
using System.Linq;

using TransferLogger.Dal;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.BusinessLogic
{
    public class Lookup
    {
        public int    Value       { get; set; }
        public string DisplayName { get; set; }

        public Lookup(int value, string displayName)
        {
            Value       = value;
            DisplayName = displayName;
        }
    }

    public static class LookupServices
    {
        public static List<Lookup> GetPrograms(int organizationId, Cycle? cycle)
        {
            if (organizationId > 0)
            {
                using var dc = new Dc();

                var query = dc.Programs.Where(p => p.OrganizationId == organizationId);

                if (cycle.HasValue)
                    query = query.Where(p => p.Cycle == cycle.Value);

                return query
                    .Select(p => new Lookup(p.ProgramId, p.Name))
                    .ToList();
            }
            else
            {
                return new List<Lookup>();
            }
        }

        public static List<Lookup> GetPrograms(object organizationIdObj, object cycleObj)
        {
            Cycle? cycle = null;
            if (cycleObj != null)
                cycle = (Cycle)cycleObj;

            return GetPrograms((int?)organizationIdObj ?? 0, cycle);
        }
    }
}
