using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class ProgramViewModel : IIdentifiable
    {
        public int    Id           { get; set; }
        public string Name         { get; set; }
        public string Organization { get; set; }
        public string Cycle        { get; set; }

        public ProgramViewModel() {}

        public ProgramViewModel(Program program, Organization organization)
        {
            Id           = program.ProgramId;
            Name         = program.Name;
            Organization = organization.DisplayString;
            Cycle        = program.Cycle.GetDisplayName();
        }
    }
}
