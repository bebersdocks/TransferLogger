namespace TransferLogger.Dal
{
    public class DbSettings
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Server   { get; set; }
        public int    Port     { get; set; }
        public string Database { get; set; }

        public override string ToString()
        {
            return $"Server={Server};Port={Port};Database={Database};User Id={Username};Password={Password};CommandTimeout=20";
        }
    }
}
