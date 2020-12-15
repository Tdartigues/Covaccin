using System;
using System.ComponentModel.DataAnnotations;

namespace Covaccin.orm
{
    public class Personne
    {
        int id { get; set; }

        [MaxLength(20)]
        string nom { get; set; }

        [MaxLength(20)]
        string prenom { get; set; }

        bool sexe { get; set; }

        DateTime? dateNaissance { get; set; }

        bool estResident_pasPersonnel { get; set; }

        public Personne()
        {
        }
    }
}
