using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadoServicioController : ControllerBase
    {
        // GET api/estadoservicio
        [HttpGet]
        public List<EstadoServicio> Get()
        {
            return EstadoServicioData.Listar();
        }

        // GET api/estadoservicio/5
        [HttpGet("{IdEstado:int}")]
        public List<EstadoServicio> Get(int IdEstado)
        {
            return EstadoServicioData.ObtenerEstado(IdEstado);
        }

        // POST api/estadoservicio
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // Implementar lógica para agregar un nuevo EstadoServicio
        }

        // PUT api/estadoservicio/5
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] string value)
        {
            // Implementar lógica para actualizar un EstadoServicio
        }

        // DELETE api/estadoservicio/5
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            // Implementar lógica para eliminar un EstadoServicio
        }
    }
}
