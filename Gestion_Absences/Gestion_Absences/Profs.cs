using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using SQLite;
namespace Gestion_Absences
{
    [Table("Profs")]

    public class Profs
    {
        [PrimaryKey, AutoIncrement]
        public int id_prof { get; set; }

        [MaxLength(200)]
        public string nom { get; set; }

        [MaxLength(200)]
        public string mdp { get; set; }

        public override string ToString()
        {
            return this.id_prof + " " + this.nom + " " + this.mdp;
        }
    }
}
