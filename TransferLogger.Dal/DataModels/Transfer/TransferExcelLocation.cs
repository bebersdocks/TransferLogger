using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    [Table]
    public class TransferExcelLocation
    {
        [Column, NotNull] public int    TransferId { get; set; }
        [Column, NotNull] public string Path       { get; set; }

        #region Associations

        [Association(ThisKey = nameof(TransferId), OtherKey = nameof(TransferId), Relationship = Relationship.ManyToOne, CanBeNull = false)]
        public Transfer Transfer { get; set; }

        #endregion
    }
}
