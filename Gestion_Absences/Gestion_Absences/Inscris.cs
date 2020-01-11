using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Absences
{
    [Table("Inscris")]
    public class Inscris
    {
        [PrimaryKey, AutoIncrement]
        public int id_inscris { get; set; }

        public String cne_etudiant { get; set; }
        public string nom_cours { get; set; }
        public int nbre_absences { get; set; }
    }
}

