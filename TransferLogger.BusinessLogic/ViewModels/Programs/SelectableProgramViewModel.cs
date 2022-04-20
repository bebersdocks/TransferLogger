using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;

using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.BusinessLogic.ViewModels.Programs
{
    public class SelectableProgramViewModel : ProgramViewModel
    {
        public bool Selected { get; set; }

        public SelectableProgramViewModel(Program program, Organization organization, bool selected)
            : base(program, organization)
        {
            Selected = selected;
        }

        public static List<SelectableProgramViewModel> GetList(HashSet<int> selectedIds,
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
                .Select(p => new SelectableProgramViewModel(p, p.Organization, selectedIds.Contains(p.ProgramId)))
                .ToList();
        }

        public static List<SelectableProgramViewModel> GetList(HashSet<int> selectedIds, 
            string searchName, 
            object organizationIdObj, 
            object cycleObj)
        {
            Cycle? cycle = null;
            if (cycleObj != null)
                cycle = (Cycle)cycleObj;

            return GetList(selectedIds, searchName, Convert.ToInt32(organizationIdObj), cycle);
        }
    }
}
