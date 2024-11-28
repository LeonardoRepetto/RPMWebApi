using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class GarantiaData
    {
        public static List<Garantia> Listar()
        {
            List<Garantia> oListaGarantia = new List<Garantia>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_Garantia", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaGarantia.Add(new Garantia()
                            {
                                IdGarantia = Convert.ToInt32(dr["IdGarantia"]),
                                NumeroOrden = Convert.ToInt32(dr["NumeroOrden"]),
                                FechaInicio = dr["FechaInicio"].ToString(),
                                FechaFinal = dr["FechaFinal"].ToString()

                            });

                        }
                    }
                    return oListaGarantia;
                }
                catch (Exception ex)
                {
                    return oListaGarantia;
                }
            }
        }

        public static bool Registrar(Garantia oGarantia)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Registrar_Garantia", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroOrden", oGarantia.NumeroOrden);                
                cmd.Parameters.AddWithValue("@FechaInicio", oGarantia.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFinal", oGarantia.FechaFinal);

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