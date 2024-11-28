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
    public class ClienteController : ApiController
    {
        // GET api/<controller>
        public List<Cliente> Get()
        {
            return ClienteData.Listar();
        }

        //public List<Cliente> Get(string idCategoria)
        //{
        //    return ClienteData.ListarPorCategoria(idCategoria);
        //}

        // GET api/<controller>/5
        public Cliente Get(int id)
        {
            return ClienteData.Obtener(id);
        }

        public List<Cliente> Get(string NombreCliente)
        {
            return ClienteData.ListarPorNombre(NombreCliente);
        }

        // POST api/<controller>
        public bool Post([FromBody] Cliente oCliente)
        {
            return ClienteData.Registrar(oCliente);
        }

        // PUT api/<controller>/5
        public bool Put(int id, [FromBody] Cliente oCliente)
        {
            return ClienteData.Modificar(oCliente);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return ClienteData.Eliminar(id);
        }
    }
}