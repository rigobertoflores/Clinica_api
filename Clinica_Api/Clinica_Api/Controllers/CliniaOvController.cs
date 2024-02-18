using Clinica_Api.Data;
using Clinica_Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinica_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CliniaOvController : ControllerBase
    {
        private readonly DbOliveraClinicaContext _context;

        public CliniaOvController(DbOliveraClinicaContext context)
        {
            _context = context;
        }


        [HttpGet("CliniaOvController/MostrarTexto")]
        public IActionResult MostrarTexto()
        {
            var contenido = _context.PacientesInformacionGenerals.Take(10).ToList();

            return Ok(contenido);
        }

        [HttpGet("CliniaOvController/UsuarioMasactual")]
        public IActionResult MostrarTexto1()
        {
            var contenido = _context.PacientesInformacionGenerals.OrderByDescending(x => x.FechaConsulta).FirstOrDefault();

            return Ok(contenido);
        }


        [HttpGet("CliniaOvController/GetPacientes")]
        public IActionResult GetPacientes()
        {
            var contenido = _context.PacientesInformacionGenerals.OrderByDescending(x => x.FechaConsulta);

            return Ok(contenido);
        }

        //[HttpGet(Name = "GetPacientes")]
        //public IActionResult GetPacientes()
        //{
        //    var contenido = _context.PacientesInformacionGenerals.Take(10).ToList();

        //    return Ok(contenido);
        //}

        //[HttpGet(Name = "UsuarioMasactual")]
        //public IActionResult GetUsuarioMasactual()
        //{
        //    var contenido = _context.PacientesInformacionGenerals.OrderByDescending(x => x.FechaConsulta).FirstOrDefault();

        //    return Ok(contenido);
        //}
    }
}