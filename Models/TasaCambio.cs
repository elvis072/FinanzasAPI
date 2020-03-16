using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanzasAPI.Models
{
    public class TasaCambio
    {
        public int Id { get; set; }

        [Required, MaxLength(3)]
        public string CodigoMoneda { get; set; }

        [Required]
        public float Cambio { get; set; }

        public DateTime? Fecha { get; set; }
    }
}
