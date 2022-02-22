using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    [Table]
    public class Transfer
    {
        [PrimaryKey, Identity] public int TransferId     { get; set; }
        [Column, NotNull]      public int OrganizationId { get; set; }
        [Column, NotNull]      public int StudentId      { get; set; }

        #region Associations 

        [Association(ThisKey = nameof(OrganizationId), OtherKey = nameof(OrganizationId), Relationship = Relationship.OneToOne, CanBeNull = false)]
        public Organization Organization { get; set; }

        [Association(ThisKey = nameof(StudentId), OtherKey = nameof(StudentId), Relationship = Relationship.OneToOne, CanBeNull = false)]
        public Student Student { get; set; }

        #endregion
    }
}
