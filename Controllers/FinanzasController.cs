using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanzasAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanzasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanzasController : ControllerBase
    {
        private readonly FinanzasDB _finanzasDB;

        public FinanzasController(FinanzasDB finanzasDB)
        {
            _finanzasDB = finanzasDB;
        }

        // GET: /finanzas/tasaCambio/:codigoMoneda
        [HttpGet("tasaCambio/{codigoMoneda}")]
        public ActionResult<float> ConsultarTasaCambio(string codigoMoneda) {
            if (string.IsNullOrEmpty(codigoMoneda))
            {
                GuardarDatosReporte(nameof(ConsultarTasaCambio), false);
                return BadRequest("El codigo de moneda debe tener un valor valido");
            }

            var tasaCambio = _finanzasDB.TasaCambio.Where(x => x.CodigoMoneda.Contains(codigoMoneda)).FirstOrDefault();

            if (tasaCambio == null)
            {
                GuardarDatosReporte(nameof(ConsultarTasaCambio), false);
                return NotFound("No se pudo encontrar la tasa de cambio");
            }
            else
            {
                GuardarDatosReporte(nameof(ConsultarTasaCambio), true);
                return Ok(tasaCambio.Cambio);
            }
        }

        // GET: /finanzas/inflacion/:periodo
        [HttpGet("inflacion/{periodo}")]
        public ActionResult<float> ConsultarIndiceInflacion(string periodo)
        {
            if (string.IsNullOrEmpty(periodo))
            {
                GuardarDatosReporte(nameof(ConsultarIndiceInflacion), false);
                return BadRequest("El periodo debe tener un valor valido");
            }

            var inflacion = _finanzasDB.Inflacion.Where(x => x.Fecha.HasValue && x.Fecha.Value.ToString("yyyyMM").Equals(periodo)).FirstOrDefault();

            if (inflacion == null)
            {
                GuardarDatosReporte(nameof(ConsultarIndiceInflacion), false);
                return NotFound("No se pudo encontrar el indice de inflacion");
            }
            else
            {
                GuardarDatosReporte(nameof(ConsultarIndiceInflacion), true);
                return Ok(inflacion.Indice);
            }
        }

        // GET: /finanzas/saludFinanciera/:cedula
        [HttpGet("saludFinanciera/{cedula}")]
        public ActionResult<object> ConsultarSaludFinanciera(string cedula)
        {
            if (string.IsNullOrEmpty(cedula))
            {
                GuardarDatosReporte(nameof(ConsultarSaludFinanciera), false);
                return BadRequest("La cedula debe tener un valor valido");
            }

            cedula = cedula.Replace("-", "");

            var saludFinanciera = _finanzasDB.SaludFinanciera.Where(x => x.Cedula.Replace("-", "").Equals(cedula)).FirstOrDefault();

            if (saludFinanciera == null)
            {
                GuardarDatosReporte(nameof(ConsultarSaludFinanciera), false);
                return NotFound("No se pudo encontrar el indice de inflacion");
            }
            else
            {
                GuardarDatosReporte(nameof(ConsultarSaludFinanciera), true);
                return Ok(new { saludFinanciera.Indicador, saludFinanciera.Comentario, saludFinanciera.TotalAdeudado });
            }
        }

        // GET: /finanzas/historialCrediticio/:cedula
        [HttpGet("historialCrediticio/{cedula}")]
        public ActionResult<object> ConsultarHistorialCrediticio(string cedula)
        {
            if (string.IsNullOrEmpty(cedula))
            {
                GuardarDatosReporte(nameof(ConsultarHistorialCrediticio), false);
                return BadRequest("La cedula debe tener un valor valido");
            }

            cedula = cedula.Replace("-", "");

            var historialCrediticio = _finanzasDB.HistorialCrediticio.Where(x => x.Cedula.Replace("-", "").Equals(cedula)).FirstOrDefault();

            if (historialCrediticio == null)
            {
                GuardarDatosReporte(nameof(ConsultarHistorialCrediticio), false);
                return NotFound("No se pudo encontrar el indice de inflacion");
            }
            else
            {
                GuardarDatosReporte(nameof(ConsultarHistorialCrediticio), true);
                return Ok(new { historialCrediticio.RncEmpresa, historialCrediticio.ConceptoDeuda, historialCrediticio.TotalAdeudado, historialCrediticio.Fecha });
            }
        }

        private void GuardarDatosReporte(string nombre, bool satisfactorio)
        {
            ReporteWebService reporte = new ReporteWebService { Nombre = nombre, Satisfactorio = satisfactorio, URL = $"{HttpContext.Request.Path}", Fecha = DateTime.Now };
            _finanzasDB.ReporteWebService.Add(reporte);
            _finanzasDB.SaveChanges();
        }
    }
}
