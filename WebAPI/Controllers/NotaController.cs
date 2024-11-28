using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotaController : ControllerBase
    {
        [HttpGet()]
        public List<Nota> Get()
        {
            return NotaData.Listar();
        }

        [HttpGet("{IdEstado:int}")]
        public List<Nota> Get(int IdEstado)
        {
            return NotaData.ObtenerEstado(IdEstado);
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}