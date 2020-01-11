using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Absences
{
    class CoursDataAccess
    {
        private SQLiteConnection database;

        public CoursDataAccess()
        {
            database = ConnexionDB.connexion();
            database.CreateTable<Cours>();

        }

        //ajouter un cours
        public void AjouterCours(String nomCours, int nbreSeances)
        {
            Cours cour = new Cours()
            {
                nom_cours = nomCours,
                nbre_seances = nbreSeances

            };
            database.Insert(cour);
        }
    }
}
