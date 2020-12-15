using System;
using System.ComponentModel.DataAnnotations;

namespace Covaccin.orm
{
    public class Injection
    {
        public int Id { get; set; }

        [Required]
        public int IdPersonne { get; set; }

        [Required]
        public int IdType { get; set; }

        [MaxLength(20)]
        public string Prenom { get; set; }

        [MaxLength(20)]
        public string Marque { get; set; }

        public int IdLot { get; set; }

        public Personne Personne { get; set; }

        public TypeVaccin TypeVaccin { get; set; }
    }
}
