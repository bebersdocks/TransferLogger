using LinqToDB.Mapping;

using TransferLogger.Dal.Utils;

namespace TransferLogger.Dal.DataModels
{
    public enum EvaluationStatus
    {
        [StringValue("Under Evaluation")] InProcess  = 0,
        [StringValue("Matched")]          Matched    = 1,
        [StringValue("Not Matched")]      NotMatched = 2
    }

    [Table]
    public class Evaluation
    {
        [Column, Identity] public int              EvaluationId    { get; set; }
        [Column, NotNull]  public int              ApplicationId   { get; set; }
        [Column, NotNull]  public int              CourseId        { get; set; }
        [Column, Nullable] public int?             MatchedCourseId { get; set; }
        [Column, NotNull]  public int              InstructorId    { get; set; }
        [Column, Nullable] public EvaluationStatus Status          { get; set; }
        [Column, Nullable] public string           Comment         { get; set; }

        #region Associations 

        [Association(ThisKey = nameof(ApplicationId), OtherKey = nameof(ApplicationId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Application Application { get; set; }

        [Association(ThisKey = nameof(CourseId), OtherKey = nameof(CourseId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Course Course { get; set; }

        [Association(ThisKey = nameof(CourseId), OtherKey = nameof(CourseId), Relationship = Relationship.ManyToOne, CanBeNull = true)]
        public Course MatchedCourse { get; set; }

        [Association(ThisKey = nameof(InstructorId), OtherKey = nameof(InstructorId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Instructor Instructor { get; set; }

        #endregion
    }
}
