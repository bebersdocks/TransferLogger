using System.Collections.Generic;

using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    [Table]
    public class Course
    {
        [PrimaryKey, Identity] public int    CourseId    { get; set; }
        [Column, NotNull]      public string CourseCode  { get; set; }
        [Column, NotNull]      public int    ProgramId   { get; set; }
        [Column, Nullable]     public string Name        { get; set; }
        [Column, Nullable]     public string Description { get; set; }
        [Column, Nullable]     public int    Credits     { get; set; }
        [Column, Nullable]     public int    WeeklyHours { get; set; }

        [NotColumn]
        public string DisplayString => $"{CourseCode} - {Name}";

        #region Associations

        [Association(ThisKey = nameof(ProgramId), OtherKey = nameof(ProgramId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Program Program { get; set; }

        [Association(ThisKey = nameof(CourseId), OtherKey = nameof(CourseId), Relationship = Relationship.OneToMany)]
        public IEnumerable<Evaluation> Evaluations { get; set; }

        #endregion
    }
}
