﻿using System;
using System.Linq;

using LinqToDB;

using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.DataModels.Transfer;

namespace TransferLogger.Dal
{
    public partial class Dc : LinqToDB.Data.DataConnection
    {
        public ITable<Organization>             Organizations             => this.GetTable<Organization>();
        public ITable<Program>                  Programs                  => this.GetTable<Program>();
        public ITable<Course>                   Courses                   => this.GetTable<Course>();
        public ITable<Instructor>               Instructors               => this.GetTable<Instructor>();
        public ITable<Student>                  Students                  => this.GetTable<Student>();
        public ITable<Application>              Applications              => this.GetTable<Application>();
        public ITable<ApplicationCourse>        ApplicationCourses        => this.GetTable<ApplicationCourse>();
        public ITable<ApplicationExcelLocation> ApplicationExcelLocations => this.GetTable<ApplicationExcelLocation>();


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
            createTable(Instructors);
            createTable(Students);
            createTable(Applications);
            createTable(ApplicationCourses);
            createTable(ApplicationExcelLocations);
        }
    }
}
