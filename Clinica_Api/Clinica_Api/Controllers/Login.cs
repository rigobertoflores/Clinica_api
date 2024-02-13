using Clinica_Api.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clinica_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Login : ControllerBase
    {
        private readonly DbOliveraContext _context;

        public Login(DbOliveraContext context)
        {
            _context = context;
        }


        [HttpGet(Name = "Login")]
        public IActionResult UserLogin()
        {

            Console.WriteLine("Haciendo login ");
            return Ok("Iniciando sesión...");
        }


        // GET: api/<Login>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Login>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Login>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Login>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Login>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
