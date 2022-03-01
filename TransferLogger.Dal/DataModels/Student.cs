using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    [Table]
    public class Student
    {
        [PrimaryKey, Identity] public int    StudentId      { get; set; }
        [Column, NotNull]      public int    OrganizationId { get; set; }
        [Column, Nullable]     public string Reference      { get; set; }
        [Column, NotNull]      public string Name           { get; set; }
        [Column, NotNull]      public string Surname        { get; set; }
        [Column, Nullable]     public string Phone          { get; set; }
        [Column, Nullable]     public string Email          { get; set; }

        #region Associations 

        [Association(ThisKey = nameof(OrganizationId), OtherKey = nameof(OrganizationId), Relationship = Relationship.OneToOne, CanBeNull = false)]
        public Organization Organization { get; set; }

        #endregion
    }
}
