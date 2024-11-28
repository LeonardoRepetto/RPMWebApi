using System.Data.SqlClient;
using System.Data;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class EmpleadoData
    {
        public static List<Empleado> Listar()
        {
            List<Empleado> oListaEmpleado = new List<Empleado>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_Empleado", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaEmpleado.Add(new Empleado()
                            {
                                IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]),
                                NombreEmpleado = dr["NombreEmpleado"].ToString()                               

                            });

                        }
                    }
                    return oListaEmpleado;
                }
                catch (Exception ex)
                {
                    return oListaEmpleado;
                }
            }
        }

        public static bool Registrar(Empleado oEmpleado)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Registrar_Empleado", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreEmpleado", oEmpleado.NombreEmpleado);
                

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }

        }

        public static bool Modificar(Empleado oEmpleado)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Modificar_Empleado", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", oEmpleado.IdEmpleado);
                cmd.Parameters.AddWithValue("@NombreEmpleado", oEmpleado.NombreEmpleado);
                

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }

        public static Empleado Obtener (int idEmpleado)
        {
            Empleado oEmpleado = new Empleado();
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Obtener_Empleado", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oEmpleado = new Empleado()
                            {
                                IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]),
                                NombreEmpleado = dr["Nombre"].ToString(),
                                IdTipoServicio = Convert.ToInt32(dr["IdEmpleado"])
                            };
                        }
                    }
                    return oEmpleado;
                }
                catch (Exception ex)
                {
                    return oEmpleado;
                }
            }
        }

        public static bool Eliminar (int id)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Eliminiar_Empleado", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", id);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                   
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

    }

  
}


