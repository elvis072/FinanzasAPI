using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanzasAPI.Models
{
    public class SaludFinanciera
    {
        public int Id { get; set; }

        [Required, MaxLength(11)]
        public string Cedula { get; set; }

        public bool Indicador { get; set; }
        public string Comentario { get; set; }

        [Required]
        public float TotalAdeudado { get; set; }
    }
}
