using System.Collections.Generic;
using System.Linq;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.BusinessLogic.Models.Programs
{
    public class ProgramModel : IIdentifiable
    {
        public int    Id           { get; set; }
        public string Name         { get; set; }
        public string Organization { get; set; }
        public string Cycle        { get; set; }
        public int    Year         { get; set; }

        public ProgramModel(Program program, Organization organization)
        {
            Id           = program.ProgramId;
            Name         = program.Name;
            Organization = organization.DisplayString;
            Cycle        = program.Cycle.GetDisplayName();
            Year         = program.Year;
        }

        protected static IQueryable<Program> GetQuery(Dc dc, string searchName = "", int organizationId = 0, Cycle? cycle = null)
        {
            var query = dc.Programs.AsQueryable();

            if (!string.IsNullOrEmpty(searchName))
                query = query.Where(p => p.Name.Contains(searchName));

            if (organizationId > 0)
                query = query.Where(p => p.OrganizationId == organizationId);

            if (cycle.HasValue)
                query = query.Where(p => p.Cycle == cycle.Value);

            return query;
        }

        public static List<ProgramModel> GetList(string searchName = "", int organizationId = 0, Cycle? cycle = null)
        {
            using var dc = new Dc();

            return GetQuery(dc, searchName, organizationId, cycle)
                .Select(p => new ProgramModel(p, p.Organization))
                .ToList();
        }
    }
}
