using TransferLogger.BusinessLogic.Intefaces;
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
    }
}
