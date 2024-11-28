using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class TipoServicioData
    {

        public static List<TipoServicio> Listar()
        {
            List<TipoServicio> oListaTipoServicio = new List<TipoServicio>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_TipoServicio", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaTipoServicio.Add(new TipoServicio()
                            {
                                IdTipoServicio = Convert.ToInt32(dr["IdTipoServicio"]),
                                NombreServicio = dr["NombreServicio"].ToString()

                            });

                        }
                    }
                    return oListaTipoServicio;
                }
                catch (Exception ex)
                {
                    return oListaTipoServicio;
                }
            }
        }

        public static bool Registrar(TipoServicio oTipoServicio)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Registrar_TipoServicio", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreServicio", oTipoServicio.NombreServicio);


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

        public static List<TipoServicio> ObtenerEstado(int IdTipoServicio)
        {
            List<TipoServicio> oListaTipoServicio = new List<TipoServicio>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_TipoServicio_Id", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoServicio", IdTipoServicio);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaTipoServicio.Add(new TipoServicio()
                            {
                                IdTipoServicio = Convert.ToInt32(dr["IdTipoServicio"]),
                                NombreServicio = dr["NombreServicio"].ToString()

                            });
                        }
                    }
                    return oListaTipoServicio;
                }
                catch (Exception ex)
                {
                    return oListaTipoServicio;
                }
            }
        }

        public static bool Eliminar(int id)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Eliminiar_TipoServicio", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoServicio", id);

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