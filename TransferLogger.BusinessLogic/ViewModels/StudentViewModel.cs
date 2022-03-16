using TransferLogger.BusinessLogic.Intefaces;
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

        public StudentViewModel() {}

        public StudentViewModel(Student student)
        {
            Id         = student.StudentId;
            Reference  = student.Reference;
            Name       = student.DisplayString;
            DocumentNo = student.DocumentNo;
            Phone      = student.Phone;
            Email      = student.Email;
        }
    }
}
