using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class EstadoServicioData
    {
        public static List<EstadoServicio> Listar()
        {
            List<EstadoServicio> oListaEstadoServicio = new List<EstadoServicio>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_EstadoServicio", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaEstadoServicio.Add(new EstadoServicio()
                            {
                                IdEstado = Convert.ToInt32(dr["IdEstado"]),
                                Estado = dr["Estado"].ToString()

                            });

                        }
                    }
                    return oListaEstadoServicio;
                }
                catch (Exception ex)
                {
                    return oListaEstadoServicio;
                }
            }
        }

        public static List<EstadoServicio> ObtenerEstado(int IdEstado)
        {
            List<EstadoServicio> oEstadoServicio = new List<EstadoServicio>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_EstadoServicio_Id", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEstado", IdEstado);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oEstadoServicio.Add(new EstadoServicio()
                            {
                                IdEstado = Convert.ToInt32(dr["IdEstado"]),
                                Estado = dr["Estado"].ToString(),

                            });
                        }
                    }
                    return oEstadoServicio;
                }
                catch (Exception ex)
                {
                    return oEstadoServicio;
                }
            }
        }

    }


}