using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BOAEntidad;

namespace BOADatos
{
    public class CDatos
    {
        private string connectionString;

        public CDatos()
        {
            connectionString = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;
        }

        public List<Computadora> ObtenerComputadoras()
        {
            List<Computadora> computadoras = new List<Computadora>();

            string query = "SELECT * FROM COMPUTADORA";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Computadora computadora = new Computadora
                        {
                            IdComputadora = reader["idComputadora"].ToString(),
                            Modelo = reader["modelo"].ToString(),
                            IdRam = reader["idRam"].ToString(),
                            IdProcesador = reader["idProcesador"].ToString(),
                            IdGrafica = reader["idGrafica"].ToString(),
                            IdAlmacenamiento = reader["idAlmacenamiento"].ToString(),
                            IdTarjetaMadre = reader["idTarjetaMadre"].ToString(),
                            IdFuentePoder = reader["idFuentePoder"].ToString()
                        };

                        computadoras.Add(computadora);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener computadoras: " + ex.Message);
                }
            }

            return computadoras;
        }
    }
}
