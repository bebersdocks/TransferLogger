using System.Collections.Generic;
using System.Linq;

using TransferLogger.BusinessLogic.Settings;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.BusinessLogic.Models.Organizations
{
    public class SelectableOrganizationModel : OrganizationModel
    {
        private bool _selected;
        public bool Selected { get => _selected; set => SetField(ref _selected, value); }

        public SelectableOrganizationModel(Organization organization, bool selected) 
            : base(organization)
        {
            _selected = selected;
        }

        public static IList<SelectableOrganizationModel> GetList(
            HashSet<int> selectedIds,
            string searchName = "", 
            OrganizationType? organizationType = null, 
            Country? country = null)
        {
            using var dc = new Dc();

            var selectedOrganizations = dc.Organizations
                .Where(c => selectedIds.Contains(c.OrganizationId))
                .AsEnumerable();

            return GetQuery(dc, searchName, organizationType, country)
                .Where(o => o.OrganizationId != AppSettings.Instance.OrganizationId)
                .Where(o => !selectedIds.Contains(o.OrganizationId))
                .AsEnumerable()
                .Union(selectedOrganizations)
                .OrderBy(o => o.OrganizationId)
                .Select(o => new SelectableOrganizationModel(o, selectedIds.Contains(o.OrganizationId)))
                .ToList();
        }
    }
}
