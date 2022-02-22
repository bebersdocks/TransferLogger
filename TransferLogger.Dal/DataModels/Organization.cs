using System.Collections.Generic;

using LinqToDB.Mapping;

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
        [PrimaryKey, Identity] public string           OrganizationId { get; set; }
        [Column, NotNull]      public OrganizationType Type           { get; set; }
        [Column, NotNull]      public string           Name           { get; set; }

        #region Associations 

        [Association(ThisKey = nameof(OrganizationId), OtherKey = nameof(OrganizationId), Relationship = Relationship.OneToMany)]
        public IEnumerable<Transfer> Transfers { get; set; }

        #endregion
    }
}
