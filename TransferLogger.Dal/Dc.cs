using System;
using System.Linq;

using Microsoft.Data.SqlClient;

using LinqToDB;
using LinqToDB.Data;

using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.DataModels.Applications;
using TransferLogger.Dal.Utils;

namespace TransferLogger.Dal
{
    public partial class Dc : LinqToDB.Data.DataConnection
    {
        public ITable<Organization>          Organizations          => this.GetTable<Organization>();
        public ITable<Program>               Programs               => this.GetTable<Program>();
        public ITable<Course>                Courses                => this.GetTable<Course>();
        public ITable<Instructor>            Instructors            => this.GetTable<Instructor>();
        public ITable<Student>               Students               => this.GetTable<Student>();
        public ITable<Application>           Applications           => this.GetTable<Application>();
        public ITable<ApplicationAttachment> ApplicationAttachments => this.GetTable<ApplicationAttachment>();
        public ITable<Evaluation>            Evaluations            => this.GetTable<Evaluation>();
        public ITable<DbInfo>                DbInfo                 => this.GetTable<DbInfo>();

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

        public void CreateOrUpdateDb()
        {
            if (DataProvider.Name.Contains(ProviderName.SqlServer))
            {
                try
                {
                    // On newer versions of MS SQL server, caching feature might cause annoying jump of identity (ID) column by 1000.
                    // It seems to appear more often on personal machines when SQL server shuts down unexpectedly or crashes.
                    // https://www.sqlshack.com/learn-to-avoid-an-identity-jump-issue-identity_cache-with-the-help-of-trace-command-t272/ 
                    var commandInfo = new CommandInfo(this, "ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = OFF");

                    commandInfo.Execute();
                }
                catch (SqlException) {}

                using var tr = BeginTransaction();

                foreach (var dbScript in EmbeddedResources.DbScripts)
                {
                    var sqlScript = EmbeddedResources.GetDbResourceStr(ProviderName.SqlServer, dbScript);

                    var commandInfo = new CommandInfo(this, sqlScript);

                    commandInfo.Execute();
                }

                tr.Commit();
            }
            else
            {
                CreateTables();
            }
        }

        private void CreateTables()
        {
            var schemaProvider = DataProvider.GetSchemaProvider();

            var dbSchema = schemaProvider.GetSchema(this);

            void createTable<T>(ITable<T> table)
            {
                if (!dbSchema.Tables.Any(t => t.TableName == table.TableName))
                {
                    this.CreateTable<T>();

                    if (typeof(T) == typeof(DbInfo))
                    {
                        DbInfo.Insert(() => new DbInfo { Version = 1.000M, UpdatedAt = DateTime.UtcNow });
                    }
                }
            }

            createTable(Organizations);
            createTable(Programs);
            createTable(Courses);
            createTable(Instructors);
            createTable(Students);
            createTable(Applications);
            createTable(ApplicationAttachments);
            createTable(Evaluations);
            createTable(DbInfo);
        }
    }
}
