using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoServicioController : ControllerBase
    {
        // GET api/<controller>
        [HttpGet]
        public List<TipoServicio> Get()
        {
            return TipoServicioData.Listar();
        }

        // GET api/<controller>/5
        [HttpGet("{IdEstado:int}")]
        public List<TipoServicio> Get(int IdEstado)
        {
            return TipoServicioData.ObtenerEstado(IdEstado);
        }

        // POST api/<controller>
        [HttpPost]
        public bool Post([FromBody] TipoServicio oTipoServicio)
        {
            return TipoServicioData.Registrar(oTipoServicio);
        }

        // PUT api/<controller>/5
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return TipoServicioData.Eliminar(id);
        }
    }
}