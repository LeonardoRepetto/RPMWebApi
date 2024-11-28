using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Data
{
    public class Conexion
    {
        //public static string RutaConexion = "Data Source=DESKTOP-QKAS8N9\\SQLEXPRESS;Initial Catalog=ProyectoServicio20231101;Integrated Security=True";
        public static string RutaConexion = "Server =tcp:rpmtecnoadmin2023.database.windows.net,1433;Initial Catalog = TestRPMTecno; Persist Security Info=False;User ID = AdminRpmTecno; Password=RpmTecno2023; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";
    }
}