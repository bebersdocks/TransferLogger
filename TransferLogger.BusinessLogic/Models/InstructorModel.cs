using System.Collections.Generic;
using System.Linq;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.BusinessLogic.Models
{
    public class InstructorModel : IIdentifiable
    {
        public int    Id    { get; set; }
        public string Name  { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public InstructorModel(Instructor intructor)
        {
            Id    = intructor.InstructorId;
            Name  = intructor.DisplayString;
            Phone = intructor.Phone;
            Email = intructor.Email;
        }

        public static List<InstructorModel> GetList(string searchName = "", string email = "")
        {
            using var dc = new Dc();

            var query = dc.Instructors.AsQueryable();

            searchName = searchName.Replace(" ", string.Empty);

            if (!string.IsNullOrEmpty(searchName))
                query = query.Where(i => $"{i.Name}{i.Middle}{i.Surname}"
                    .Replace(" ", string.Empty)
                    .Contains(searchName));

            if (!string.IsNullOrEmpty(email))
                query = query.Where(i => i.Email.Contains(email));

            return query
                .Select(i => new InstructorModel(i))
                .ToList();
        }
    }
}
