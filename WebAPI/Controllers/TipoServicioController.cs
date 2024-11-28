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
    public class TipoServicioController : ApiController
    {
        // GET api/<controller>
        public List<TipoServicio> Get()
        {
            return TipoServicioData.Listar();
        }

        // GET api/<controller>/5
        public List<TipoServicio> Get(int IdEstado)
        {
            return TipoServicioData.ObtenerEstado(IdEstado);
        }

        // POST api/<controller>
        public bool Post([FromBody] TipoServicio oTipoServicio)
        {
            return TipoServicioData.Registrar(oTipoServicio);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return TipoServicioData.Eliminar(id);
        }
    }
}