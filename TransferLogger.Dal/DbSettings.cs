namespace TransferLogger.Dal
{
    public class DbSettings
    {
        public string Username                 { get; set; }
        public string Password                 { get; set; }
        public string Server                   { get; set; }
        public int    Port                     { get; set; }
        public string Database                 { get; set; }
        public string ProviderName             { get; set; }
        public bool   UseWindowsAuthentication { get; set; }

        public override string ToString()
        {
            if (string.Equals(ProviderName, LinqToDB.ProviderName.SqlServer))
            {
                if (UseWindowsAuthentication)
                {
                    return $"Integrated Security=SSPI;Server={Server};Database={Database};Connect Timeout=20";
                }
                else
                {
                    return $"User Id={Username};Password={Password};Server={Server};Database={Database};Connect Timeout=20";
                }
            }
            else
            {
                return $"User Id={Username};Password={Password};Server={Server};Port={Port};Database={Database};CommandTimeout=20";
            }
        }
    }
}
