namespace TransferLogger.BusinessLogic
{
    public class  Lookup
    {
        public int    Value       { get; set; }
        public string DisplayName { get; set; }

        public Lookup(int value, string displayName)
        {
            Value       = value;
            DisplayName = displayName;
        }
    }
}
