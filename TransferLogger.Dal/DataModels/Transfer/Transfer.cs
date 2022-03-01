using System;
using System.Collections.Generic;

using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    [Table]
    public class Transfer
    {
        [PrimaryKey, Identity] public int       TransferId  { get; set; }
        [Column, NotNull]      public int       StudentId   { get; set; }
        [Column, NotNull]      public DateTime  CreatedDt   { get; set; }
        [Column, Nullable]     public DateTime? SubmittedDt { get; set; }

        #region Associations 

        [Association(ThisKey = nameof(StudentId), OtherKey = nameof(StudentId), Relationship = Relationship.OneToOne, CanBeNull = false)]
        public Student Student { get; set; }

        [Association(ThisKey = nameof(TransferId), OtherKey = nameof(TransferId), Relationship = Relationship.OneToMany)]
        public IEnumerable<TransferExcelLocation> ExcelLocations { get; set; }

        #endregion
    }
}
