using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Garantia
    {
        public int IdGarantia { get; set; }
        public int NumeroOrden { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
    }
}