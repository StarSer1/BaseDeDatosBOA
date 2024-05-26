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
        public Inventario MapInventario(SqlDataReader reader)
        {
            return new Inventario
            {
                IdInventario = reader["idInventario"].ToString(),
                IdComputadora = reader["idComputadora"].ToString(),
                FechaLlegada = reader["fechaLlegada"].ToString(),
                PrecioLlegada = (int)reader["precioLLegada"],
                Stock = (int)reader["stock"]
            };
        }
        public Cliente MapCliente(SqlDataReader reader)
        {
            return new Cliente
            {
                IdCliente = reader["idCliente"].ToString(),
                Nombre = reader["nombre"].ToString(),
                ApellidoP = reader["apellidoP"].ToString(),
                ApellidoM = reader["apellidoM"].ToString(),
                Correo = reader["correo"].ToString()
            };
        }
        public Almacenamiento MapAlmacenamiento(SqlDataReader reader)
        {
            return new Almacenamiento
            {
                IdAlmacenamiento = reader["idAlmacenamiento"].ToString(),
                Marca = reader["marca"].ToString(),
                Tipo = reader["tipo"].ToString(),
                Capacidad = (int)reader["capacidad"],
                Frecuencia = (int)reader["frecuencia"],
                VelocidadTransferencia = (int)reader["velocidadTransferencia"]
            };
        }

        public Empleado MapEmpleado(SqlDataReader reader)
        {
            return new Empleado
            {
                IdEmpleado = reader["idEmpleado"].ToString(),
                Nombre = reader["nombre"].ToString(),
                ApellidoP = reader["apellidoP"].ToString(),
                ApellidoM = reader["apellidoM"].ToString(),
                RFC = reader["rfc"].ToString(),
                Sueldo = int.Parse(reader["sueldo"].ToString())
            };
        }

        public FuentePoder MapFuentePoder(SqlDataReader reader)
        {
            return new FuentePoder
            {
                IdFuentePoder = reader["idFuentePoder"].ToString(),
                Marca = reader["marca"].ToString(),
                Modelo = reader["modelo"].ToString(),
                Potencia = (int)reader["potencia"],
                Tipo = reader["tipo"].ToString(),
                Certificacion = reader["certificacion"].ToString()
            };
        }

        public Grafica MapGrafica(SqlDataReader reader)
        {
            return new Grafica
            {
                IdGrafica = reader["idGrafica"].ToString(),
                Marca = reader["marca"].ToString(),
                Modelo = reader["modelo"].ToString(),
                Tipo = reader["tipo"].ToString(),
                Vram = (int)reader["vram"]
            };
        }

        public Procesador MapProcesador(SqlDataReader reader)
        {
            return new Procesador
            {
                IdProcesador = reader["idProcesador"].ToString(),
                Marca = reader["marca"].ToString(),
                Modelo = reader["modelo"].ToString(),
            };
        }

        public Ram MapRam(SqlDataReader reader)
        {
            return new Ram
            {
                IdRam = reader["idRam"].ToString(),
                Marca = reader["marca"].ToString(),
                TipoRam = reader["tipoRam"].ToString(),
                Frecuencia = (int)reader["frecuencia"],
                Tamaño = (int)reader["tamaño"],
                VelocidadTransferencia = (int)reader["velocidadTransferencia"]
            };
        }

        public TarjetaMadre MapTarjetaMadre(SqlDataReader reader)
        {
            return new TarjetaMadre
            {
                IdTarjetaMadre = reader["idTarjetaMadre"].ToString(),
                Marca = reader["marca"].ToString(),
                Modelo = reader["modelo"].ToString(),
                RanurasDIMM = (int)reader["RanurasDIMM"],
                Socket = reader["socket"].ToString(),
                Dimensiones = reader["dimensiones"].ToString()
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
        public void ConfigureInventoryParameters(SqlCommand command, object item)
        {
            Inventario inventario = (Inventario)item;
            command.CommandText = "INSERT INTO INVENTARIO (idInventario, idComputadora, fechaLlegada, precioLlegada, stock) VALUES (@idI, @idC, @fL, @pL, @stk)";
            command.Parameters.AddWithValue("@idI", inventario.IdInventario);
            command.Parameters.AddWithValue("@idC", inventario.IdComputadora);
            command.Parameters.AddWithValue("@fL", inventario.FechaLlegada);
            command.Parameters.AddWithValue("@pL", inventario.PrecioLlegada);
            command.Parameters.AddWithValue("@stk", inventario.Stock);
        }
        public void ConfigureClientParameters(SqlCommand command, object item)
        {
            Cliente cliente = (Cliente)item;
            command.CommandText = "INSERT INTO CLIENTES (idCliente, nombre, apellidoP, apellidoM, correo) VALUES (@idC, @nomb, @apeP, @apeM, @correo)";
            command.Parameters.AddWithValue("@idC", cliente.IdCliente);
            command.Parameters.AddWithValue("@nomb", cliente.Nombre);
            command.Parameters.AddWithValue("@apeP", cliente.ApellidoP);
            command.Parameters.AddWithValue("@apeM", cliente.ApellidoM);
            command.Parameters.AddWithValue("@correo", cliente.Correo);
        }
        public void ConfigureEmployeeParameters(SqlCommand command, object item)
        {
            Empleado empleado = (Empleado)item;
            command.CommandText = "INSERT INTO EMPLEADO (idEmpleado, nombre, apellidoP, apellidoM, rfc, sueldo) VALUES (@idE, @nomb, @apeP, @apeM, @rfc, @sueldo)";
            command.Parameters.AddWithValue("@idE", empleado.IdEmpleado);
            command.Parameters.AddWithValue("@nomb", empleado.Nombre);
            command.Parameters.AddWithValue("@apeP", empleado.ApellidoP);
            command.Parameters.AddWithValue("@apeM", empleado.ApellidoM);
            command.Parameters.AddWithValue("@rfc", empleado.RFC);
            command.Parameters.AddWithValue("@sueldo", empleado.Sueldo);
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
            using (SqlConnection conex = new SqlConnection(connectionString))
            {
                conex.Open();
                string CdSql = $"INSERT INTO {tableName} VALUES (@params)";

                using (SqlCommand cmd = new SqlCommand(CdSql, conex))
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
        public void ActualizarInventarios(Inventario inventario)
        {
            using (SqlConnection conex = new SqlConnection(connectionString))
            {
                conex.Open();
                string CdSql = "UPDATE INVENTARIO SET idComputadora=@idC, fechaLlegada=@fL, " +
                    "precioLlegada=@pL, stock=@stk WHERE idInventario=@idI";
                using (SqlCommand Cmd = new SqlCommand(CdSql, conex))
                {
                    Cmd.Parameters.AddWithValue("@idI", inventario.IdInventario);
                    Cmd.Parameters.AddWithValue("@idC", inventario.IdComputadora);
                    Cmd.Parameters.AddWithValue("@fL", inventario.FechaLlegada);
                    Cmd.Parameters.AddWithValue("@pL", inventario.PrecioLlegada);
                    Cmd.Parameters.AddWithValue("@stk", inventario.Stock);
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();
                }
                conex.Close();
            }
        }
        public void ActualizarClientes(Cliente cliente)
        {
            using (SqlConnection conex = new SqlConnection(connectionString))
            {
                conex.Open();
                string CdSql = "UPDATE CLIENTES SET nombre=@nomb, " +
                    "apellidoP=@apeP, apellidoM=@apeM, correo=@correo WHERE idCliente=@idC";
                using (SqlCommand Cmd = new SqlCommand(CdSql, conex))
                {
                    Cmd.Parameters.AddWithValue("@idC", cliente.IdCliente);
                    Cmd.Parameters.AddWithValue("@nomb", cliente.Nombre);
                    Cmd.Parameters.AddWithValue("@apeP", cliente.ApellidoP);
                    Cmd.Parameters.AddWithValue("@apeM", cliente.ApellidoM);
                    Cmd.Parameters.AddWithValue("@correo", cliente.Correo);
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();
                }
                conex.Close();
            }
        }
        public void ActualizarEmpleados(Empleado empleado)
        {
            using (SqlConnection conex = new SqlConnection(connectionString))
            {
                conex.Open();
                string CdSql = "UPDATE EMPLEADO SET nombre=@nomb, " +
                    "apellidoP=@apeP, apellidoM=@apeM, rfc=@rfc, sueldo=@sueldo WHERE idEmpleado=@idE";
                using (SqlCommand Cmd = new SqlCommand(CdSql, conex))
                {
                    Cmd.Parameters.AddWithValue("@idE", empleado.IdEmpleado);
                    Cmd.Parameters.AddWithValue("@nomb", empleado.Nombre);
                    Cmd.Parameters.AddWithValue("@apeP", empleado.ApellidoP);
                    Cmd.Parameters.AddWithValue("@apeM", empleado.ApellidoM);
                    Cmd.Parameters.AddWithValue("@rfc", empleado.RFC);
                    Cmd.Parameters.AddWithValue("@sueldo", empleado.Sueldo);
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
                case "idInventario":
                    fromTable = "INVENTARIO";
                    break;
                case "idCliente":
                    fromTable = "CLIENTES";
                    break;
                case "idEmpleado":
                    fromTable = "EMPLEADO";
                    break;
                case "idComputadora":
                    fromTable = "COMPUTADORA";
                    break;
                case "idTarjetaMadre":
                    fromTable = "TARJETAMADRE";
                    break;
                case "idProcesador":
                    fromTable = "PROCESADOR";
                    break;
                case "idGrafica":
                    fromTable = "GRAFICA";
                    break;
                case "idRam":
                    fromTable = "RAM";
                    break;
                case "idAlmacenamiento":
                    fromTable = "ALMACENAMIENTO";
                    break;
                case "idFuentePoder":
                    fromTable = "FUENTEPODER";
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
