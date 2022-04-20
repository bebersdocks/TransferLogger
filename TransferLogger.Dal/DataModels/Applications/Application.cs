using System;
using System.Collections.Generic;

using LinqToDB.Mapping;

using TransferLogger.Dal.Utils;

namespace TransferLogger.Dal.DataModels.Applications
{
    public enum ApplicationStatus
    {
        [StringValue("In Process")] InProcess = 1,
        [StringValue("Canceled")]   Canceled  = 2,
        [StringValue("Completed")]  Completed = 3
    }

    [Table]
    public class Application
    {
        [PrimaryKey, Identity] public int               ApplicationId        { get; set; }
        [Column, NotNull]      public ApplicationStatus ApplicationStatus    { get; set; }
        [Column, NotNull]      public int               StudentId            { get; set; }
        [Column, NotNull]      public int               SourceOrganizationId { get; set; }
        [Column, NotNull]      public int               TargetOrganizationId { get; set; }
        [Column, NotNull]      public int               TargetProgramId      { get; set; }
        [Column, Nullable]     public string            ExcelLocation        { get; set; }
        [Column, NotNull]      public DateTime          CreatedAt            { get; set; }
        [Column, Nullable]     public DateTime?         UpdatedAt            { get; set; }
        [Column, Nullable]     public DateTime?         CompletedAt          { get; set; }

        #region Associations

        [Association(ThisKey = nameof(StudentId), OtherKey = nameof(StudentId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Student Student { get; set; }

        [Association(ThisKey = nameof(SourceOrganizationId), OtherKey = nameof(Organization.OrganizationId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Organization SourceOrganization { get; set; }

        [Association(ThisKey = nameof(TargetOrganizationId), OtherKey = nameof(Organization.OrganizationId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Organization TargetOrganization { get; set; }

        [Association(ThisKey = nameof(TargetProgramId), OtherKey = nameof(Program.ProgramId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Program TargetProgram { get; set; }

        [Association(ThisKey = nameof(ApplicationId), OtherKey = nameof(ApplicationId), Relationship = Relationship.OneToMany)]
        public IEnumerable<Evaluation> Evaluations { get; set; }

        [Association(ThisKey = nameof(ApplicationId), OtherKey = nameof(ApplicationAttachment.ApplicationId), Relationship = Relationship.OneToMany)]
        public IEnumerable<ApplicationAttachment> Attachments { get; set; }

        #endregion
    }
}
