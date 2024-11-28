using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
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
