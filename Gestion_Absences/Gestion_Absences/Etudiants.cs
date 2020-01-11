using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Absences
{
    [Table("Etudiants")]
    public class Etudiants
    {
        [PrimaryKey]
        public String cne { get; set; }

        [MaxLength(200)]
        public string nomEtud { get; set; }

        [MaxLength(200)]
        public string prenomEtud { get; set; }

        [MaxLength(200)]
        public string email { get; set; }

        [MaxLength(200)]
        public string tele { get; set; }

        [MaxLength(200)]
        public string filiere { get; set; }

        public override string ToString()
        {
            return  this.nomEtud + " " + this.prenomEtud + " " + this.filiere ;
        }
    }
}
