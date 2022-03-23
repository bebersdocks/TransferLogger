using System;
using System.Collections.Generic;
using System.Linq;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class InstructorViewModel : IIdentifiable
    {
        public int    Id    { get; set; }
        public string Name  { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public InstructorViewModel(Instructor intructor)
        {
            Id    = intructor.InstructorId;
            Name  = intructor.DisplayString;
            Phone = intructor.Phone;
            Email = intructor.Email;
        }

        public static List<InstructorViewModel> GetList(string searchName = "", string email = "")
        {
            using var dc = new Dc();

            var query = dc.Instructors.AsQueryable();

            if (!string.IsNullOrEmpty(searchName))
                query = query.Where(i => i.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase) || i.Surname.Contains(searchName, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(email))
                query = query.Where(i => i.Email.Contains(email, StringComparison.OrdinalIgnoreCase));

            return query
                .Select(i => new InstructorViewModel(i))
                .ToList();
        }
    }
}
