﻿using System.Collections.Generic;

using LinqToDB.Mapping;

using TransferLogger.Dal.DataModels.Applications;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.Dal.DataModels
{
    public enum OrganizationType
    {
        School     = 1,
        College    = 2,
        University = 3,
    }

    [Table]
    public class Organization
    {
        [PrimaryKey, Identity] public int              OrganizationId   { get; set; }
        [Column, NotNull]      public OrganizationType OrganizationType { get; set; }
        [Column, NotNull]      public string           Name             { get; set; }
        [Column, Nullable]     public string           Description      { get; set; }
        [Column, NotNull]      public Country          Country          { get; set; }
        [Column, Nullable]     public string           Url              { get; set; }

        [NotColumn]
        public string DisplayString => string.IsNullOrEmpty(Description) ? Name : $"{Name} - {Description}";

        #region Associations 

        [Association(ThisKey = nameof(OrganizationId), OtherKey = nameof(OrganizationId))]
        public IEnumerable<Application> Applications { get; set; }

        #endregion
    }
}
