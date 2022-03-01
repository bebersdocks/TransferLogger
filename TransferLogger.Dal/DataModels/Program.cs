using LinqToDB.Mapping;

using TransferLogger.Dal.Definitions;

namespace TransferLogger.Dal.DataModels
{
    [Table]
    public class Program
    {
        [PrimaryKey, Identity] public int         ProgramId      { get; set; }
        [Column, NotNull]      public int         OrganizationId { get; set; }
        [Column, NotNull]      public string      Name           { get; set; }
        [Column, NotNull]      public DegreeLevel DegreeLevel    { get; set; }
        [Column, NotNull]      public int         Year           { get; set; }

        #region Associations 

        [Association(ThisKey = nameof(OrganizationId), OtherKey = nameof(OrganizationId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Organization Organization { get; set; }

        #endregion
    }
}
