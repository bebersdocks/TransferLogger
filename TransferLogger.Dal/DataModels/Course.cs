using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    [Table]
    public class Course
    {
        [PrimaryKey, Identity] public int    CourseId       { get; set; }
        [Column, NotNull]      public string Code           { get; set; }
        [Column, NotNull]      public int    OrganizationId { get; set; }
        [Column, Nullable]     public string Name           { get; set; }
        [Column, Nullable]     public string Description    { get; set; }

        #region Associations

        [Association(ThisKey = nameof(OrganizationId), OtherKey = nameof(OrganizationId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Organization Organization { get; set; }

        #endregion
    }
}
