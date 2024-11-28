using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Nota
    {
        public int IdNota { get; set; }
        public string Texto { get; set; }
        public int NumeroOrden { get; set; }
        public string FechaNota { get; set; }

    }
}