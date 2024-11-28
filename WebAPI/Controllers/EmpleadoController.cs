using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class EmpleadoController : ApiController
    {
        // GET api/<controller>
        public List<Empleado> Get()
        {
            return EmpleadoData.Listar();
        }

        // GET api/<controller>/5
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