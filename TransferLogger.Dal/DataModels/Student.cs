using System;
using System.Text;

using LinqToDB.Mapping;

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
        [Column, Nullable]     public string DocumentNo { get; set; }
        [Column, Nullable]     public string Phone      { get; set; }
        [Column, Nullable]     public string Email      { get; set; }

        [NotColumn]
        public string DisplayString
        {
            get
            {
                var sb = new StringBuilder();

                sb.Append(Name);

                if (!string.IsNullOrEmpty(Middle))
                    sb.Append($" {Middle}");

                sb.Append($" {Surname}");

                return sb.ToString();
            }
        }

        [NotColumn]
        public string ExtendedDisplayString
        {
            get
            {
                var sb = new StringBuilder(DisplayString);

                if (!string.IsNullOrEmpty(Reference))
                    sb.Append($" (Ref: {Reference})");
                else if (!string.IsNullOrEmpty(DocumentNo))
                    sb.Append($" (Document: {DocumentNo})");
                else if (!string.IsNullOrEmpty(Phone))
                    sb.Append($" (Phone: {Phone})");
                else if (!string.IsNullOrEmpty(Email))
                    sb.Append($" (Email: {Email})");

                return sb.ToString();
            }
        }
    }
}
