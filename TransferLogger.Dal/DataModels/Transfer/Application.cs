using System;
using System.Collections.Generic;

using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels.Transfer
{
    [Table]
    public class Application
    {
        [PrimaryKey, Identity] public int       ApplicationId  { get; set; }
        [Column, NotNull]      public int       StudentId   { get; set; }
        [Column, NotNull]      public DateTime  CreatedDt   { get; set; }
        [Column, Nullable]     public DateTime? SubmittedDt { get; set; }

        #region Associations 

        [Association(ThisKey = nameof(StudentId), OtherKey = nameof(StudentId), Relationship = Relationship.OneToOne, CanBeNull = false)]
        public Student Student { get; set; }

        [Association(ThisKey = nameof(ApplicationId), OtherKey = nameof(ApplicationId), Relationship = Relationship.OneToMany)]
        public IEnumerable<ApplicationExcelLocation> ExcelLocations { get; set; }

        #endregion
    }
}
