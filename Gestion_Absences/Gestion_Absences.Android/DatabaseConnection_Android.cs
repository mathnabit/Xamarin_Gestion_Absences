using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

//[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_Android))]

namespace Gestion_Absences.Droid
{
    public class DatabaseConnection_Android: IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "AbsenceDb.db3";
            String path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),dbName);
            if (!File.Exists(path))
                return new SQLiteConnection(path);
            return new SQLiteConnection(path);
        }
    }
}