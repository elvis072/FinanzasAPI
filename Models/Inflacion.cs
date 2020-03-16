using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanzasAPI.Models
{
    public class Inflacion
    {
        public int Id { get; set; }

        [Required]
        public float Indice { get; set; }

        public DateTime? Fecha { get; set; }
    }
}
