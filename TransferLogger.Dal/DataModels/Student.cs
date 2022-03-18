﻿using LinqToDB.Mapping;

namespace TransferLogger.Dal.DataModels
{
    [Table]
    public class Student
    {
        [PrimaryKey, Identity] public int    StudentId  { get; set; }
        [Column, Nullable]     public string Reference  { get; set; }
        [Column, NotNull]      public string Name       { get; set; }
        [Column, Nullable]     public string Middle     { get; set; }
        [Column, NotNull]      public string Surname    { get; set; }
        [Column, NotNull]      public string DocumentNo { get; set; }
        [Column, Nullable]     public string Phone      { get; set; }
        [Column, Nullable]     public string Email      { get; set; }

        [NotColumn]
        public string DisplayString => $"{Name} {Middle} {Surname}".Trim();
    }
}
