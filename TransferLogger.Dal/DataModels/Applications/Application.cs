using System;
using System.Collections.Generic;

using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels.Applications
{
    public enum ApplicationStatus
    {
        InProcess,
        Canceled,
        Completed
    }

    [Table]
    public class Application
    {
        [PrimaryKey, Identity] public int               ApplicationId     { get; set; }
        [Column, NotNull]      public ApplicationStatus ApplicationStatus { get; set; }
        [Column, NotNull]      public int               StudentId         { get; set; }
        [Column, NotNull]      public int               OrganizationId    { get; set; }
        [Column, NotNull]      public DateTime          CreatedAt         { get; set; }
        [Column, Nullable]     public DateTime?         UpdatedAt         { get; set; }
        [Column, Nullable]     public DateTime?         CompletedAt       { get; set; }

        #region Associations 

        [Association(ThisKey = nameof(StudentId), OtherKey = nameof(StudentId), Relationship = Relationship.OneToOne, CanBeNull = false)]
        public Student Student { get; set; }

        [Association(ThisKey = nameof(OrganizationId), OtherKey = nameof(OrganizationId), Relationship = Relationship.OneToOne, CanBeNull = false)]
        public Organization Organization { get; set; }

        [Association(ThisKey = nameof(ApplicationId), OtherKey = nameof(ApplicationId), Relationship = Relationship.OneToMany)]
        public IEnumerable<ApplicationCourse> Courses { get; set; }

        [Association(ThisKey = nameof(ApplicationId), OtherKey = nameof(ApplicationId), Relationship = Relationship.OneToMany)]
        public IEnumerable<ApplicationExcelLocation> ExcelLocations { get; set; }

        [Association(ThisKey = nameof(ApplicationId), OtherKey = nameof(ApplicationId), Relationship = Relationship.OneToMany)]
        public IEnumerable<EmailLog> EmailLogs { get; set; }

        #endregion
    }
}
