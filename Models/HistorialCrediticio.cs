using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanzasAPI.Models
{
    public class HistorialCrediticio
    {
        public int Id { get; set; }

        [Required, MaxLength(11)]
        public string Cedula { get; set; }

        [Required, MaxLength(11)]
        public string RncEmpresa { get; set; }

        [Required]
        public string ConceptoDeuda { get; set; }

        [Required]
        public float TotalAdeudado { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
    }
}
