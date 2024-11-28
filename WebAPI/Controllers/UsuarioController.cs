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
    public class UsuarioController : ApiController
    {
        // GET: api/Usuario
        public List<Usuario> Get()
        {
            return UsuarioData.Listar();
        }

        // GET: api/Usuario/5
        [HttpGet]
        [Route("api/usuario/{ci}")]
        public Usuario Get(int ci)
        {
            return UsuarioData.Obtener(ci);
        }

        // POST: api/Usuario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
