﻿using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    public enum CourseStatus
    {
        Matched    = 0,
        NotMatched = 1,
    }

    [Table]
    public class TransferCourse
    {
        [Column, NotNull]  public int           TransferId   { get; set; }
        [Column, NotNull]  public int           CourseId     { get; set; }
        [Column, NotNull]  public int           InstructorId { get; set; }
        [Column, Nullable] public CourseStatus? Status       { get; set; }
        [Column, Nullable] public string        Comment      { get; set; }

        #region Associations 

        [Association(ThisKey = nameof(TransferId), OtherKey = nameof(TransferId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Transfer Transfer { get; set; }

        [Association(ThisKey = nameof(CourseId), OtherKey = nameof(CourseId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Course Course { get; set; }

        [Association(ThisKey = nameof(InstructorId), OtherKey = nameof(InstructorId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Instructor Instructor { get; set; }

        #endregion
    }
}
