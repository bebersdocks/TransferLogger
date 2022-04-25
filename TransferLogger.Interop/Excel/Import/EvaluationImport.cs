using TransferLogger.Dal.DataModels;

namespace TransferLogger.Interop.Excel.Import
{
    public class EvaluationImport
    {
        public int              EvaluationId      { get; set; }
        public EvaluationStatus EvaluationStatus  { get; set; }
        public string           AlternativeCourse { get; set; }
        public string           Comment           { get; set; }
    }
}
