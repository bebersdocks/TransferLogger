using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels.Applications
{
    [Table]
    public class ApplicationAttachment
    {
        [PrimaryKey, Identity] public int    ApplicationAttachmentId { get; set; }
        [Column, NotNull]      public int    ApplicationId           { get; set; }
        [Column, NotNull]      public string FileName                { get; set; }
        [Column, NotNull]      public byte[] Data                    { get; set; }

        #region Associations

        [Association(ThisKey = nameof(ApplicationId), OtherKey = nameof(ApplicationId), CanBeNull = false)]
        public Application Application { get; set; }

        #endregion
    }
}
