using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class NotaData
    {

        public static List<Nota> Listar()
        {
            List<Nota> oListaNota = new List<Nota>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_Nota", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaNota.Add(new Nota()
                            {
                                IdNota = Convert.ToInt32(dr["IdNota"]),
                                Texto = dr["Texto"].ToString(),
                                NumeroOrden = Convert.ToInt32(dr["NumeroOrden"]),
                                FechaNota = dr["FechaNota"].ToString()

                            });

                        }
                    }
                    return oListaNota;
                }
                catch (Exception ex)
                {
                    return oListaNota;
                }
            }
        }

        public static List<Nota> ObtenerEstado(int IdNota)
        {
            List<Nota> oListaNota = new List<Nota>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_Nota_Id", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoServicio", IdNota);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaNota.Add(new Nota()
                            {
                                IdNota = Convert.ToInt32(dr["IdNota"]),
                                Texto = dr["Texto"].ToString(),
                                NumeroOrden = Convert.ToInt32(dr["NumeroOrden"]),
                                FechaNota = dr["FechaNota"].ToString()

                            });
                        }
                    }
                    return oListaNota;
                }
                catch (Exception ex)
                {
                    return oListaNota;
                }
            }
        }
    }
}