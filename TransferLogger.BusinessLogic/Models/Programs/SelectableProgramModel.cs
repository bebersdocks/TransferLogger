using System.Collections.Generic;
using System.Linq;

using LinqToDB;

using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.BusinessLogic.Models.Programs
{
    public class SelectableProgramModel : ProgramModel
    {
        public bool Selected { get; set; }

        public SelectableProgramModel(Program program, Organization organization, bool selected)
            : base(program, organization)
        {
            Selected = selected;
        }

        public static List<SelectableProgramModel> GetList(
            HashSet<int> selectedIds,
            string searchName = "", 
            int organizationId = 0, 
            Cycle? cycle = null)
        {
            using var dc = new Dc();

            var selectedPrograms = dc.Programs
                .LoadWith(p => p.Organization)
                .Where(p => selectedIds.Contains(p.ProgramId))
                .AsEnumerable();

            return GetQuery(dc, searchName, organizationId, cycle)
                .Where(p => !selectedIds.Contains(p.ProgramId))
                .LoadWith(p => p.Organization)
                .AsEnumerable()
                .Union(selectedPrograms)
                .OrderBy(p => p.ProgramId)
                .Select(p => new SelectableProgramModel(p, p.Organization, selectedIds.Contains(p.ProgramId)))
                .ToList();
        }
    }
}
