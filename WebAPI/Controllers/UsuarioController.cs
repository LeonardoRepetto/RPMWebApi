using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        // GET: api/Usuario
        [HttpGet]
        public List<Usuario> Get()
        {
            return UsuarioData.Listar();
        }

        // GET: api/Usuario/5
        [HttpGet("{ci}")]
        public Usuario Get(int ci)
        {
            return UsuarioData.Obtener(ci);
        }

        // POST: api/Usuario
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuario/5
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
        }
    }
}
