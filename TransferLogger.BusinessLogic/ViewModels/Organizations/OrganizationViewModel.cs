using System.Collections.Generic;
using System.Linq;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.BusinessLogic.ViewModels.Organizations
{
    public class OrganizationViewModel : IIdentifiable
    {
        public int    Id      { get; set; }
        public string Type    { get; set; }
        public string Name    { get; set; }
        public string Country { get; set; }
        public string Url     { get; set; }

        public OrganizationViewModel(Organization organization)
        {
            Id      = organization.OrganizationId;
            Type    = organization.OrganizationType.GetDisplayName();
            Name    = organization.DisplayString;
            Country = organization.Country.GetDisplayName();
            Url     = organization.Url;
        }

        protected static IQueryable<Organization> GetQuery(Dc dc, string searchName = "", OrganizationType? organizationType = null, Country? country = null)
        {
            var query = dc.Organizations.AsQueryable();

            searchName = searchName.Replace(" ", string.Empty);

            if (!string.IsNullOrEmpty(searchName))
                query = query.Where(o => (string.IsNullOrEmpty(o.Description) ? o.Name : $"{o.Name} - {o.Description}")
                    .Replace(" ", string.Empty)
                    .Contains(searchName));

            if (organizationType.HasValue)
                query = query.Where(o => o.OrganizationType == organizationType.Value);

            if (country.HasValue)
                query = query.Where(o => o.Country == country.Value);

            return query;
        }

        public static List<OrganizationViewModel> GetList(string searchName = "", OrganizationType? organizationType = null, Country? country = null)
        {
            using var dc = new Dc();

            return GetQuery(dc, searchName, organizationType, country)
                .Select(o => new OrganizationViewModel(o))
                .ToList();
        }

        public static List<OrganizationViewModel> GetList(string searchName, object organizationTypeObj, object countryObj)
        {
            Country? country = null;
            if (countryObj != null)
                country = (Country)countryObj;

            OrganizationType? organizationType = null;
            if (organizationTypeObj != null)
                organizationType = (OrganizationType)organizationTypeObj;

            return GetList(searchName, organizationType, country);
        }
    }
}
