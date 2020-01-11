using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.IO;

namespace Gestion_Absences
{
    class ProfsDataAccess
    {
        private SQLiteConnection database;
       

        public ProfsDataAccess()
        {

            //database = DependencyService.Get<IDatabaseConnection>().DbConnection();
          
            database = ConnexionDB.connexion();
            database.CreateTable<Profs>();
            
        }
        //ajouter un prof
        public void AjouterProf(String nomProf, String mdpProf)
        {
            Profs prof = new Profs()
            {
                nom = nomProf,
                mdp = mdpProf
            };
            database.Insert(prof);
        }
        
    }
}
