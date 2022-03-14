﻿using System.Collections.Generic;

using LinqToDB.Mapping;

using TransferLogger.Dal.DataModels.Transfer;
using TransferLogger.Dal.Definitions;

namespace TransferLogger.Dal.DataModels
{
    // If you have existing db with data - add new types only to the end.
    public enum OrganizationType
    {
        School     = 0,
        College    = 1,
        University = 2,
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

        [NotColumn] public string DisplayString => $"{Name} {Description}".Trim();

        #region Associations 

        [Association(ThisKey = nameof(OrganizationId), OtherKey = nameof(OrganizationId), Relationship = Relationship.OneToMany)]
        public IEnumerable<Application> Applications { get; set; }

        #endregion
    }
}
