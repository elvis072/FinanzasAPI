using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanzasAPI.Models
{
    public class ReporteWebService
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string URL { get; set; }
        public bool Satisfactorio { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
    }
}
