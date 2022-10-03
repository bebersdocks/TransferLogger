using System;
using System.Collections.Generic;

using LinqToDB.Mapping;

using TransferLogger.Dal.Utils;

namespace TransferLogger.Dal.DataModels.Applications
{
    public enum ApplicationStatus
    {
        [StringValue("In Process")] InProcess = 1,
        [StringValue("Completed")]  Completed = 2
    }

    [Table]
    public class Application
    {
        [PrimaryKey, Identity] public int               ApplicationId        { get; set; }
        [Column, NotNull]      public ApplicationStatus ApplicationStatus    { get; set; }
        [Column, NotNull]      public int               StudentId            { get; set; }
        [Column, NotNull]      public int               SourceOrganizationId { get; set; }
        [Column, NotNull]      public int               TargetProgramId      { get; set; }
        [Column, Nullable]     public string            ExcelLocation        { get; set; }
        [Column, NotNull]      public DateTime          CreatedAt            { get; set; }
        [Column, Nullable]     public DateTime?         UpdatedAt            { get; set; }
        [Column, Nullable]     public DateTime?         CompletedAt          { get; set; }

        #region Associations

        [Association(ThisKey = nameof(StudentId), OtherKey = nameof(StudentId), CanBeNull = false)]
        public Student Student { get; set; }

        [Association(ThisKey = nameof(SourceOrganizationId), OtherKey = nameof(Organization.OrganizationId), CanBeNull = false)]
        public Organization SourceOrganization { get; set; }

        [Association(ThisKey = nameof(TargetProgramId), OtherKey = nameof(Program.ProgramId), CanBeNull = false)]
        public Program TargetProgram { get; set; }

        [Association(ThisKey = nameof(ApplicationId), OtherKey = nameof(ApplicationId))]
        public IEnumerable<Evaluation> Evaluations { get; set; }

        [Association(ThisKey = nameof(ApplicationId), OtherKey = nameof(ApplicationAttachment.ApplicationId))]
        public IEnumerable<ApplicationAttachment> Attachments { get; set; }

        #endregion
    }
}
