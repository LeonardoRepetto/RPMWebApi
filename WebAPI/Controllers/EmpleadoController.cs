using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadoController : ControllerBase
    {
        // GET api/empleado
        [HttpGet]
        public List<Empleado> Get()
        {
            return EmpleadoData.Listar();
        }

        // GET api/empleado/5
        [HttpGet("{id:int}")]
        public Empleado Get(int id)
        {
            return EmpleadoData.Obtener(id);
        }

        // POST api/empleado
        [HttpPost]
        public bool Post([FromBody] Empleado oEmpleado)
        {
            return EmpleadoData.Registrar(oEmpleado);
        }

        // PUT api/empleado/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] Empleado oEmpleado)
        {
            return EmpleadoData.Modificar(oEmpleado);
        }

        // DELETE api/empleado/5
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return EmpleadoData.Eliminar(id);
        }
    }
}
