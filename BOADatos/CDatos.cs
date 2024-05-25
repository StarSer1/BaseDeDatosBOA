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

        #region GetTables
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

        public List<Venta> ObtenerVentas()
        {
            List<Venta> ventas = new List<Venta>();

            string query = "SELECT * FROM VENTAS";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Venta venta = new Venta
                        {
                            IdVenta = reader["idVenta"].ToString(),
                            IdEmpleado = reader["idEmpleado"].ToString(),
                            IdComputadora = reader["idComputadora"].ToString(),
                            IdCliente = reader["idCliente"].ToString(),
                            FechaVenta = reader["fechaVenta"].ToString(),
                            PrecioFinal = (int)reader["precioFinal"],
                            PrecioBase = (int)reader["precioBase"],
                            Descuento = (int)reader["Descuento"]
                        };

                        ventas.Add(venta);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener computadoras: " + ex.Message);
                }
            }

            return ventas;
        }
        #endregion

        public void ActualizarVentas(Venta venta)
        {
            using (SqlConnection conex = new SqlConnection(connectionString))
            {
                conex.Open();
                string CdSql = "UPDATE VENTAS SET idEmpleado=@idE, idComputadora=@idC, idCliente=@idCliente, " +
                    "fechaVenta=@fV, precioFinal=@pF, precioBase=@pB, Descuento=@desc WHERE idVenta=@idV";
                using (SqlCommand Cmd = new SqlCommand(CdSql, conex))
                {
                    Cmd.Parameters.AddWithValue("@idV", venta.IdVenta);
                    Cmd.Parameters.AddWithValue("@idE", venta.IdEmpleado);
                    Cmd.Parameters.AddWithValue("@idC", venta.IdComputadora);
                    Cmd.Parameters.AddWithValue("@idCliente", venta.IdCliente);
                    Cmd.Parameters.AddWithValue("@fV", venta.FechaVenta);
                    Cmd.Parameters.AddWithValue("@pF", venta.PrecioFinal);
                    Cmd.Parameters.AddWithValue("@pB", venta.PrecioBase);
                    Cmd.Parameters.AddWithValue("@Desc", venta.Descuento);
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();
                }
                conex.Close();
            }
        }

        #region InsertarDatos
        public void InsertarVentas(Venta venta)
        {
            using (SqlConnection conex = new SqlConnection(connectionString))
            {
                conex.Open();
                string CdSql = "INSERT INTO VENTAS (idVenta, idEmpleado, idComputadora, idCliente, fechaVenta, precioFinal, " +
                    "precioBase, Descuento) VALUES (@idV, @idE, @idC, @idCliente, @fV, @pF, @pB, @Desc)";
                using (SqlCommand Cmd = new SqlCommand(CdSql, conex))
                {
                    Cmd.Parameters.AddWithValue("@idV", venta.IdVenta);
                    Cmd.Parameters.AddWithValue("@idE", venta.IdEmpleado);
                    Cmd.Parameters.AddWithValue("@idC", venta.IdComputadora);
                    Cmd.Parameters.AddWithValue("@idCliente", venta.IdCliente);
                    Cmd.Parameters.AddWithValue("@fV", venta.FechaVenta);
                    Cmd.Parameters.AddWithValue("@pF", venta.PrecioFinal);
                    Cmd.Parameters.AddWithValue("@pB", venta.PrecioBase);
                    Cmd.Parameters.AddWithValue("@Desc", venta.Descuento);
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();
                }
                conex.Close();
                    
            }
        }
        #endregion

        public void Eliminar(string id, string tablaDelId)
        {
            string fromTable = "";
            switch (tablaDelId)
            {
                case "idVenta":
                    fromTable = "VENTAS";
                    break;
            }
            using (SqlConnection cone = new SqlConnection(connectionString))
            {
                cone.Open();
                string CdSql = "DELETE FROM " + fromTable + " WHERE " + tablaDelId + " =@idV";
                using (SqlCommand Cmd = new SqlCommand(CdSql, cone))
                {
                    Cmd.Parameters.AddWithValue("@idV", id);
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();
                }
                cone.Close();
            }
        }
    }
}
