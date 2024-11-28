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
    public class NotaController : ApiController
    {
        // GET api/<controller>
        public List<Nota> Get()
        {
            return NotaData.Listar();
        }

        // GET api/<controller>/5
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