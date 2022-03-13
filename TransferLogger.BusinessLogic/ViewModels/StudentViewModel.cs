using TransferLogger.Dal.DataModels;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class StudentViewModel
    {
        public int    StudentId { get; set; }
        public string Reference { get; set; }
        public string Name      { get; set; }
        public string IdNumber  { get; set; }
        public string Phone     { get; set; }
        public string Email     { get; set; }

        public StudentViewModel(Student student)
        {
            StudentId = student.StudentId;
            Reference = student.Reference;
            Name      = student.DisplayString;
            IdNumber  = student.IdNumber;
            Phone     = student.Phone;
            Email     = student.Email;
        }
    }
}
