using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Absences
{
    class InscrisDataAccess
    {
        private SQLiteConnection database;

        public InscrisDataAccess()
        {
            database = ConnexionDB.connexion();
            database.CreateTable<Inscris>();

        }

        //ajouter un inscris à un cours
        public void AjouterInscris(String cneEtudiant, String nomCours)
        {
            Inscris inscri = new Inscris()
            {
                cne_etudiant = cneEtudiant,
                nom_cours = nomCours,
                nbre_absences = 0

            };
            database.Insert(inscri);
        }
    }
}
