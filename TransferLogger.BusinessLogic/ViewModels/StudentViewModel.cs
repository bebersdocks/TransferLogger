using System.Collections.Generic;
using System.Linq;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class StudentViewModel : IIdentifiable
    {
        public int    Id         { get; set; }
        public string Reference  { get; set; }
        public string Name       { get; set; }
        public string DocumentNo { get; set; }
        public string Phone      { get; set; }
        public string Email      { get; set; }

        public StudentViewModel(Student student)
        {
            Id         = student.StudentId;
            Reference  = student.Reference;
            Name       = student.DisplayString;
            DocumentNo = student.DocumentNo;
            Phone      = student.Phone;
            Email      = student.Email;
        }

        public static List<StudentViewModel> GetList(string searchName = "", string reference = "")
        {
            using var dc = new Dc();

            var query = dc.Students.AsQueryable();

            searchName = searchName.Replace(" ", string.Empty);

            if (!string.IsNullOrEmpty(searchName))
                query = query.Where(s => $"{s.Name}{s.Middle}{s.Surname}"
                    .Replace(" ", string.Empty)
                    .Contains(searchName));

            if (!string.IsNullOrEmpty(reference))
                query = query.Where(s => s.Reference.Contains(reference));

            return query
                .Select(s => new StudentViewModel(s))
                .ToList();
        }
    }
}
