using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadoController : ControllerBase
    {
        [HttpGet()]
        public List<Empleado> Get()
        {
            return EmpleadoData.Listar();
        }

        // GET api/<controller>/5
        [HttpGet("{id:int}")]
        public Empleado Get(int id)
        {
            return EmpleadoData.Obtener(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Empleado oEmpleado)
        {
            return EmpleadoData.Registrar(oEmpleado);
        }

        // PUT api/<controller>/5
        public bool Put(int id, [FromBody] Empleado oEmpleado)
        {
            return EmpleadoData.Modificar(oEmpleado);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return EmpleadoData.Eliminar(id);
        }
    }
}