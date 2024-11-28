using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GarantiaController : ControllerBase
    {
        // GET api/<controller>
        public List<Garantia> Get()
        {
            return GarantiaData.Listar();
        }

        // GET api/<controller>/5
       //public List<Garantia> Get(int IdEstado)
       // {
       //     return GarantiaData.ObtenerEstado(IdEstado);
       // }

        // POST api/<controller>
        public bool Post([FromBody] Garantia oGarantia)
        {
            return GarantiaData.Registrar(oGarantia);
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