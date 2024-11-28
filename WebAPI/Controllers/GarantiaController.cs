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
    public class GarantiaController : ApiController
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