using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Gestion_Absences
{
    public class ConnexionDB
    {
        public static SQLiteConnection conn=null;

        public static String path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "AbsenceDb.db3");

        public ConnexionDB () {
            if(!File.Exists(path))
            {
                var database = new SQLiteConnection(path);
               // database.CreateTable<Profs>();
            }
        }

        public static SQLiteConnection connexion()
        {
            /*if (conn == null)
            {
                conn = DependencyService.Get<IDatabaseConnection>().DbConnection();
            }*/
            var conn = new SQLiteConnection(path); 
            
            return conn;
        }
    }
}
