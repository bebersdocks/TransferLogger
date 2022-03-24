using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels.Applications
{
    [Table]
    public class ExcelLocation
    {
        [Column, NotNull] public int    ExcelLocationId { get; set; }
        [Column, NotNull] public string Path            { get; set; }
    }
}
