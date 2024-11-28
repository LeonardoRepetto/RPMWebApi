using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GarantiaController : ControllerBase
    {
        // GET api/garantia
        [HttpGet]
        public List<Garantia> Get()
        {
            return GarantiaData.Listar();
        }

        // GET api/garantia/5
        //public List<Garantia> Get(int IdEstado)
        //{
        //    return GarantiaData.ObtenerEstado(IdEstado);
        //}

        // POST api/garantia
        [HttpPost]
        public bool Post([FromBody] Garantia oGarantia)
        {
            return GarantiaData.Registrar(oGarantia);
        }

        // PUT api/garantia/5
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] string value)
        {
            // Implementar la lógica de actualización de Garantia
        }

        // DELETE api/garantia/5
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            // Implementar la lógica de eliminación de Garantia
        }
    }
}
