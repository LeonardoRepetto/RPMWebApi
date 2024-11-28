using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotaController : ControllerBase
    {
        [HttpGet]
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
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
        }
    }
}