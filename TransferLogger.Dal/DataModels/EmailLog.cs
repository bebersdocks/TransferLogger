using System;

using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    public enum EmailStatus
    {
        Pending = 1,
        Error   = 2,
        Sent    = 3
    }

    [Table]
    public class EmailLog
    {
        [PrimaryKey, Identity] public int         EmailLogId    { get; set; }
        [Column, NotNull]      public EmailStatus EmailStatus   { get; set; }
        [Column, NotNull]      public int         ApplicationId { get; set; }  
        [Column, NotNull]      public string      Address       { get; set; }
        [Column, NotNull]      public string      Recipient     { get; set; }
        [Column, Nullable]     public string      Subject       { get; set; }
        [Column, Nullable]     public string      Body          { get; set; }
        [Column, NotNull]      public DateTime    CreatedAt     { get; set; }
        [Column, Nullable]     public DateTime?   CompletedAt   { get; set; }
    }
}
