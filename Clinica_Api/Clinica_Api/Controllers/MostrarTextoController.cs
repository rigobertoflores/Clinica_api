using Clinica_Api.Data;
using Clinica_Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinica_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MostrarTextoController : ControllerBase
    {
        private readonly DbOliveraContext _context;

        public MostrarTextoController(DbOliveraContext context)
        {
            _context = context;
        }

             
        [HttpGet(Name = "MostrarTexto")]
        public IActionResult Get()
        {
            var contenido = _context.Pacientes.Where(p => p.Expediente != null && p.Expediente != "").Take(10).ToList();

            return Ok(contenido);
        }

    }
}