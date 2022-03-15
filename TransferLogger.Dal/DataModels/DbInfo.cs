using System;

using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    [Table]
    public class DbInfo
    {
        [Column(Precision = 6, Scale = 3), NotNull] 
        public decimal Version { get; set; }

        [Column, NotNull] 
        public DateTime UpdatedAt { get; set; }
    }
}
