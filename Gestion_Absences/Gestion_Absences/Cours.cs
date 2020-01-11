using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Absences
{
    [Table("Cours")]
    public class Cours
    {
        [PrimaryKey,AutoIncrement]
        public int id_cours { get; set; }

        [MaxLength(200)]
        public string nom_cours { get; set; }

        public int nbre_seances { get; set; }

        public override string ToString()
        {
            return "Cours : [" + this.nom_cours + "] Seances : [" + nbre_seances + "]";
        }
    }
}
