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
    public class EstadoServicioController : ApiController
    {
        // GET api/<controller>
        public List<EstadoServicio> Get()
        {
            return EstadoServicioData.Listar();
        }

        // GET api/<controller>/5
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