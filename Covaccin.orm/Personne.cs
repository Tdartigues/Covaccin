using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Covaccin.orm
{
    public class Personne
    {
        int Id { get; set; }

        [MaxLength(20)]
        [Required]
        string Nom { get; set; }

        [MaxLength(20)]
        string Prenom { get; set; }

        bool Sexe { get; set; }

        DateTime? DateNaissance { get; set; }

        [Required]
        bool EstResident_pasPersonnel { get; set; }

        public List<Injection> Injections { get; set; } = new List<Injection>();
    }
}
