using System;
using System.Linq;

using LinqToDB;

using TransferLogger.Dal.DataModels;

namespace TransferLogger.Dal
{
    public partial class Dc : LinqToDB.Data.DataConnection
    {
        public ITable<Organization>          Organizations          => this.GetTable<Organization>();
        public ITable<Program>               Programs               => this.GetTable<Program>();
        public ITable<Course>                Courses                => this.GetTable<Course>();
        public ITable<Student>               Students               => this.GetTable<Student>();
        public ITable<Transfer>              Transfers              => this.GetTable<Transfer>();
        public ITable<TransferCourse>        TransferCourses        => this.GetTable<TransferCourse>();
        public ITable<TransferExcelLocation> TransferExcelLocations => this.GetTable<TransferExcelLocation>();


        // This value can be anything - it is just internal identifier for configuration.
        private const string defaultConfigurationStr = "TransferLogger";

        public Dc() : base(defaultConfigurationStr) {}

        public Dc(string configurationStr) : base(configurationStr) {}

        public static void CreateDefaultConfiguration(DbSettings dbSettings)
        {
            var connStr = dbSettings.ToString();

            var dataProvider = GetDataProvider(dbSettings.ProviderName, connStr);

            if (dataProvider == null)
                throw new Exception("Unable to get data provider.");

            AddConfiguration(defaultConfigurationStr, connStr, dataProvider);
        }

        public void CreateTables()
        {
            var schemaProvider = DataProvider.GetSchemaProvider();

            var dbSchema = schemaProvider.GetSchema(this);

            void createTable<T>(ITable<T> table)
            {
                if (!dbSchema.Tables.Any(t => t.TableName == table.TableName))
                {
                    this.CreateTable<T>();
                }
            }

            createTable(Organizations);
            createTable(Programs);
            createTable(Courses);
            createTable(Students);
            createTable(Transfers);
            createTable(TransferCourses);
            createTable(TransferExcelLocations);
        }
    }
}
