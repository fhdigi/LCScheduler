using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using LCScheduler.Model;
using SQLite;

namespace LCScheduler.Data
{
    public static class DataExtender
    {
        public static string DataBaseNameAndPath = "LCSchedulerData.db";

    //    private static readonly string ApplicationDataDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Properties.Settings.Default.CompanyName);

    //    private static readonly string _databaseName = "LCSchedulerData.db";

    //    public static readonly string DataBaseNameAndPath = Path.Combine(ApplicationDataDirectory, _databaseName);

        public static void CreateProgramTables()
        {
            // create the folder if it does not exist
            //if (!Directory.Exists(ApplicationDataDirectory))
            //{
            //    Directory.CreateDirectory(ApplicationDataDirectory);
            //}

            var db = new SQLiteConnection(DataBaseNameAndPath);
            db.CreateTable<ClientInformation>();
            db.CreateTable<ProgressNoteInformation>();
            db.CreateTable<ClientAppointment>();
            db.CreateTable<AgencyResource>();
            db.CreateTable<ClientAssessment>();
        }
    }

}
