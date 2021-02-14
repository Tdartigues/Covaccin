using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Covaccin.orm
{
    public class TypeVaccin
    {

        public int Id { get; set; }

        [MaxLength(20)]
        public string Vaccin { get; set; }

        public List<Injection> Injections {get;set;} = new List<Injection> ();
    }
}
