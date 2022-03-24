using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels.Applications
{
    [Table]
    public class ApplicationExcelLocation
    {
        [Column, NotNull] public int ApplicationId   { get; set; }
        [Column, NotNull] public int ExcelLocationId { get; set; }

        #region Associations

        [Association(ThisKey = nameof(ApplicationId), OtherKey = nameof(ApplicationId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Application Application { get; set; }

        [Association(ThisKey = nameof(ExcelLocationId), OtherKey = nameof(ExcelLocationId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public ExcelLocation ExcelLocation { get; set; }

        #endregion
    }
}
