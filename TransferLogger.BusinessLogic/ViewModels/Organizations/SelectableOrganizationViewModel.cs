using System.Collections.Generic;
using System.Linq;

using TransferLogger.BusinessLogic.Settings;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.BusinessLogic.ViewModels.Organizations
{
    public class SelectableOrganizationViewModel : OrganizationViewModel
    {
        public bool Selected { get; set; }

        public SelectableOrganizationViewModel(Organization organization, bool selected) : base(organization)
        {
            Selected = selected;
        }

        public static List<SelectableOrganizationViewModel> GetList(HashSet<int> selectedIds,
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
                .Select(o => new SelectableOrganizationViewModel(o, selectedIds.Contains(o.OrganizationId)))
                .ToList();
        }

        public static List<SelectableOrganizationViewModel> GetList(HashSet<int> selectedIds,
            string searchName, 
            object organizationTypeObj, 
            object countryObj)
        {
            Country? country = null;
            if (countryObj != null)
                country = (Country)countryObj;

            OrganizationType? organizationType = null;
            if (organizationTypeObj != null)
                organizationType = (OrganizationType)organizationTypeObj;

            return GetList(selectedIds, searchName, organizationType, country);
        }
    }
}
