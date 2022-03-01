using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    [Table]
    public class Instructor
    {
        [PrimaryKey, Identity] public int    InstructorId   { get; set; }
        [Column, NotNull]      public int    OrganizationId { get; set; }
        [Column, NotNull]      public string Name           { get; set; }
        [Column, NotNull]      public string Surname        { get; set; }
        [Column, Nullable]     public string Phone          { get; set; }
        [Column, NotNull]      public string Email          { get; set; }

        #region Associations 

        [Association(ThisKey = nameof(OrganizationId), OtherKey = nameof(OrganizationId), Relationship = Relationship.OneToOne, CanBeNull = false)]
        public Organization Organization { get; set; }

        #endregion
    }
}
