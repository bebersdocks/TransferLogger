using System;
using System.Linq;

using LinqToDB;

using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.DataModels.Applications;
using TransferLogger.Dal.Utils;

namespace TransferLogger.Dal
{
    public partial class Dc : LinqToDB.Data.DataConnection
    {
        public ITable<Organization>          Organizations          => GetTable<Organization>();
        public ITable<Program>               Programs               => GetTable<Program>();
        public ITable<Course>                Courses                => GetTable<Course>();
        public ITable<Instructor>            Instructors            => GetTable<Instructor>();
        public ITable<Student>               Students               => GetTable<Student>();
        public ITable<Application>           Applications           => GetTable<Application>();
        public ITable<ApplicationAttachment> ApplicationAttachments => GetTable<ApplicationAttachment>();
        public ITable<Evaluation>            Evaluations            => GetTable<Evaluation>();
        public ITable<DbInfo>                DbInfos                => GetTable<DbInfo>();

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
                using var tr = BeginTransaction();

                foreach (var dbScript in EmbeddedResources.DbScripts)
                {
                    var sql = EmbeddedResources.GetDbResourceStr(ProviderName.SqlServer, dbScript);

                    Command.CommandText = sql;

                    ExecuteNonQuery(Command);
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
                        DbInfos.Insert(() => new DbInfo { Version = 1.000M, UpdatedAt = DateTime.UtcNow });
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
            createTable(DbInfos);
        }
    }
}
