using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
        //Delegados
        public delegate T MapFunction<T>(SqlDataReader reader);
        public delegate void ConfigureParameters(SqlCommand command, object item);

        #region Maps
        public Computadora MapComputadora(SqlDataReader reader)
        {
            return new Computadora
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
        }

        public Venta MapVenta(SqlDataReader reader)
        {
            return new Venta
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
        }

        #endregion

        #region Params

        public void ConfigureVentaParameters(SqlCommand command, object item)
        {
            Venta venta = (Venta)item;
            command.CommandText = "INSERT INTO VENTAS (idVenta, idEmpleado, idComputadora, idCliente, fechaVenta, precioFinal, precioBase, Descuento) VALUES (@idV, @idE, @idC, @idCliente, @fV, @pF, @pB, @Desc)";
            command.Parameters.AddWithValue("@idV", venta.IdVenta);
            command.Parameters.AddWithValue("@idE", venta.IdEmpleado);
            command.Parameters.AddWithValue("@idC", venta.IdComputadora);
            command.Parameters.AddWithValue("@idCliente", venta.IdCliente);
            command.Parameters.AddWithValue("@fV", venta.FechaVenta);
            command.Parameters.AddWithValue("@pF", venta.PrecioFinal);
            command.Parameters.AddWithValue("@pB", venta.PrecioBase);
            command.Parameters.AddWithValue("@Desc", venta.Descuento);
        }

        public void ConfigureVentaActParameters(SqlCommand command, object item)
        {
            Venta venta = (Venta)item;
            command.Parameters.AddWithValue("@idV", venta.IdVenta);
            command.Parameters.AddWithValue("@idE", venta.IdEmpleado);
            command.Parameters.AddWithValue("@idC", venta.IdComputadora);
            command.Parameters.AddWithValue("@idCliente", venta.IdCliente);
            command.Parameters.AddWithValue("@fV", venta.FechaVenta);
            command.Parameters.AddWithValue("@pF", venta.PrecioFinal);
            command.Parameters.AddWithValue("@pB", venta.PrecioBase);
            command.Parameters.AddWithValue("@Desc", venta.Descuento);
        }

        #endregion

        #region GetTables

        public List<T> ObtenerTabla<T>(string tableName, MapFunction<T> mapFunction)
        {
            List<T> items = new List<T>();
            string query = $"SELECT * FROM {tableName}";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        T item = mapFunction(reader);
                        items.Add(item);
                    }

                    reader.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw new Exception($"Error al obtener datos de la tabla {tableName}: " + ex.Message);
                }
            }
            return items;
        }
        
        #endregion

        #region InsertarDatos

        public void Insertar<T>(string tableName, T item, ConfigureParameters configureParameters)
        {
            using (SqlConnection conex = new SqlConnection (connectionString))
            {
                conex.Open();
                string CdSql = $"INSERT INTO {tableName} VALUES (@params)";

                using (SqlCommand cmd = new SqlCommand (CdSql, conex))
                {
                    configureParameters(cmd, item);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conex.Close();
            }
        }

        #endregion

        public List<T> Consultar<T>(string tableName, string idColumnName, string id, MapFunction<T> mapFunction)
        {
            List<T> items = new List<T>();
            string query = $"SELECT * FROM {tableName} WHERE {idColumnName} = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        T item = mapFunction(reader);
                        items.Add(item);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al consultar la tabla {tableName} con ID {id}: " + ex.Message);
                }
            }
            return items;
        }

        //public void Actualizar<T>(string tableName, string whereClause, T item, ConfigureParameters configureParameters)
        //{
        //    using (SqlConnection conex = new SqlConnection(connectionString))
        //    {
        //        conex.Open();
        //        string setClause = GenerateSetClause(item);
        //        string CdSql = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}";

        //        using (SqlCommand cmd = new SqlCommand(CdSql, conex))
        //        {
        //            configureParameters(cmd, item);
        //            cmd.ExecuteNonQuery();
        //            cmd.Dispose();
        //        }

        //        conex.Close();
        //    }
        //}
        private string GenerateSetClause<T>(T item)
        {
            var properties = typeof(T).GetProperties();
            var setClause = string.Join(", ", properties.Select(p => $"{p.Name}=@{p.Name}"));
            return setClause;
        }
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
