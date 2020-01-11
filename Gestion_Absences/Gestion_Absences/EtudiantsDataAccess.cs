using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Absences
{
    public class EtudiantsDataAccess
    {
        private SQLiteConnection database;

        public EtudiantsDataAccess()
        {
            database = ConnexionDB.connexion();
            database.CreateTable<Etudiants>();
            
        }

        //ajouter un etudiant
        public void AjouterEtudiant(String cne, String nomEtud, String prenomEtud, String email, String tele, String filiere)
        {
            Etudiants etudiant = new Etudiants()
            {
                cne = cne,
                nomEtud = nomEtud,
                prenomEtud = prenomEtud,
                email = email,
                tele = tele,
                filiere = filiere

            };
            database.Insert(etudiant);
        }

    }
}
