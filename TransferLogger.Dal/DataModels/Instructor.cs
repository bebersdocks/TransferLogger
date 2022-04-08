using System;
using System.Text;

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

                if (!string.IsNullOrEmpty(Phone))
                    sb.Append($" (Phone: {Phone})");
                else if (!string.IsNullOrEmpty(Email))
                    sb.Append($" (Email: {Email})");

                return sb.ToString();
            }
        }
    }
}
