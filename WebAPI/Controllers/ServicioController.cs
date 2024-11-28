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
    public class ServicioController : ApiController
    {
        // GET api/<controller>
        public List<Servicio> Get()
        {
            return ServicioData.Listar();
        }

        // GET api/<controller>/5
        public Servicio Get(int id)
        {
            return ServicioData.Obtener(id);
        }



        // POST api/<controller>
        public bool Post([FromBody] Servicio oServicio)
        {
            return ServicioData.Registrar(oServicio);
        }



        // PUT api/<controller>/5
        [HttpPut]
        [Route("api/servicio/ActualizarDetalles/{id}")]
        public IHttpActionResult PutActualizarDetalles(int id, [FromBody] Servicio oServicio)
        {
            bool resultado = ServicioData.Modificar(oServicio);

            if (resultado)
            {
                return Ok("Actualización de detalles exitosa");
            }
            else
            {
                return BadRequest("La actualización de detalles ha fallado");
            }
        }

        // PUT api/<controller>/5
        [HttpPut]
        [Route("api/servicio/ModificarEstado/{id}")]
        public IHttpActionResult PutModificarEstado(int id, [FromBody] Servicio oServicio)
        {
            bool resultado = ServicioData.ModificarEstado(oServicio);

            if (resultado)
            {
                return Ok("Actualización de detalles exitosa");
            }
            else
            {
                return BadRequest("La actualización de detalles ha fallado");
            }
        }




        //public IHttpActionResult PutModificarTodoServicio(int id, [FromBody] Servicio oServicio)

        //{

        //    bool resultado = ServicioData.ModificarTodoServicio(id, oServicio);

        //    if (resultado)

        //    {

        //        return Ok("Modificacion exitosa");

        //    }

        //    else

        //    {

        //        return BadRequest("La modificacion ha fallado");

        //    }

        //}



        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return ServicioData.Eliminar(id);
        }
    }
}
