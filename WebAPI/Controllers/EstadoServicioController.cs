using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadoServicioController : ControllerBase
    {
        // GET api/<controller>
        [HttpGet()]
        public List<EstadoServicio> Get()
        {
            return EstadoServicioData.Listar();
        }

        // GET api/<controller>/5
        [HttpGet("{IdEstado:int}")]
        public List<EstadoServicio> Get(int IdEstado)
        {
            return EstadoServicioData.ObtenerEstado(IdEstado);
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