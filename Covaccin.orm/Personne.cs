using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Covaccin.orm
{
    public class Personne
    {
        public int Id { get; set; }

        [MaxLength(20)]
        [Required]
        public string Nom { get; set; }

        [MaxLength(20)]
        public string Prenom { get; set; }

        public bool Sexe { get; set; }

        public DateTime? DateNaissance { get; set; }

        [Required]
        public bool EstResident_pasPersonnel { get; set; }

        public List<Injection> Injections { get; set; } = new List<Injection>();
    }
}
