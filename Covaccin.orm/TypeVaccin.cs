using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Covaccin.orm
{
    public class TypeVaccin
    {

        public int Id { get; set; }

        [MaxLength(20)]
        public string Type { get; set; }
    }
}
