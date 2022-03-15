﻿using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class OrganizationViewModel : IIdentifiable
    {
        public int    OrganizationId { get; set; }
        public string Type           { get; set; }
        public string Name           { get; set; }
        public string Description    { get; set; }
        public string Country        { get; set; }
        public string Url            { get; set; }

        public int Id => OrganizationId;

        public OrganizationViewModel() {}

        public OrganizationViewModel(Organization organization)
        {
            OrganizationId = organization.OrganizationId;
            Type           = organization.OrganizationType.GetDisplayName();
            Name           = organization.Name;
            Description    = organization.Description;
            Country        = organization.Country.GetDisplayName();
            Url            = organization.Url;
        }
    }
}