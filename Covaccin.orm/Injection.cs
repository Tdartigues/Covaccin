using System;
using System.ComponentModel.DataAnnotations;

namespace Covaccin.orm
{
    public class Injection
    {
        int Id { get; set; }

        [Required]
        int IdPersonne { get; set; }

        [Required]
        int IdType { get; set; }

        [MaxLength(20)]
        public string Prenom { get; set; }

        [MaxLength(20)]
        public string Marque { get; set; }

        public int IdLot { get; set; }

        public Personne personne { get; set; }

        public Type type { get; set; }
    }
}
