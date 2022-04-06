﻿using LinqToDB.Mapping;

using TransferLogger.Dal.DataModels.Applications;
using TransferLogger.Dal.Utils;

namespace TransferLogger.Dal.DataModels
{
    public enum EvaluationStatus
    {
        [StringValue("In Process")]         InProcess        = 1,
        [StringValue("Matched")]            Matched          = 2,
        [StringValue("Matched By History")] MatchedByHistory = 3,
        [StringValue("Not Matched")]        NotMatched       = 4,
    }

    [Table]
    public class Evaluation
    {
        [Column, Identity] public int              EvaluationId       { get; set; }
        [Column, NotNull]  public EvaluationStatus EvaluationStatus   { get; set; }
        [Column, NotNull]  public int              ApplicationId      { get; set; }
        [Column, NotNull]  public int              CourseId           { get; set; }
        [Column, Nullable] public int?             MatchedCourseId    { get; set; }
        [Column, NotNull]  public int              InstructorId       { get; set; }
        [Column, Nullable] public Evaluation       LinkedEvaluationId { get; set; }
        [Column, Nullable] public string           Comment            { get; set; }

        #region Associations 

        [Association(ThisKey = nameof(ApplicationId), OtherKey = nameof(ApplicationId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Application Application { get; set; }

        [Association(ThisKey = nameof(CourseId), OtherKey = nameof(CourseId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Course Course { get; set; }

        [Association(ThisKey = nameof(MatchedCourseId), OtherKey = nameof(CourseId), Relationship = Relationship.ManyToOne, CanBeNull = true)]
        public Course MatchedCourse { get; set; }

        [Association(ThisKey = nameof(InstructorId), OtherKey = nameof(InstructorId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Instructor Instructor { get; set; }

        [Association(ThisKey = nameof(LinkedEvaluationId), OtherKey = nameof(Evaluation), Relationship = Relationship.ManyToOne, CanBeNull = true)]
        public Evaluation LinkedEvaluation { get; set; }

        #endregion
    }
}
