using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    [Table]
    public class Instructor
    {
        [PrimaryKey, Identity] public int    InstructorId { get; set; }
        [Column, NotNull]      public string Name         { get; set; }
        [Column, Nullable]     public string Middle       { get; set; }
        [Column, NotNull]      public string Surname      { get; set; }
        [Column, Nullable]     public string Phone        { get; set; }
        [Column, NotNull]      public string Email        { get; set; }

        [NotColumn] public string DisplayString => $"{Name} {Middle} {Surname}".Trim();
    }
}
