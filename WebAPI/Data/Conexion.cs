using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Data
{
    public class Conexion
    {
        //public static string RutaConexion = "Data Source=DESKTOP-QKAS8N9\\SQLEXPRESS;Initial Catalog=ProyectoServicio20231101;Integrated Security=True";
        public static string RutaConexion = "Server=tcp:db-server-rpm-tecno-dev.database.windows.net,1433;Initial Catalog=db-rpm-tecno;Persist Security Info=False;User ID=admin-rpm-tecno;Password=Password.01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}