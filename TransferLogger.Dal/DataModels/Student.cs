using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    [Table]
    public class Student
    {
        [PrimaryKey, Identity] public int    StudentId { get; set; }
        [Column, Nullable]     public string Reference { get; set; }
        [Column, NotNull]      public string Name      { get; set; }
        [Column, NotNull]      public string Surname   { get; set; }
        [Column, NotNull]      public string IdNumber  { get; set; }
        [Column, Nullable]     public string Phone     { get; set; }
        [Column, Nullable]     public string Email     { get; set; }

        [NotColumn] public string DisplayString => $"{Name} {Surname}";
    }
}
