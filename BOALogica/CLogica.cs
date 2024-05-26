using System;
using System.Collections.Generic;
using BOAEntidad;
using BOADatos;

namespace BOALogica
{
    public class CLogica
    {
        private CDatos datos;

        public CLogica()
        {
            datos = new CDatos();
        }
        #region Obtener Tablas
        public List<Computadora> ObtenerComputadoras()
        {
            return datos.ObtenerTabla("COMPUTADORA", datos.MapComputadora);
        }
        public List<Venta> ObtenerVentas()
        {
            return datos.ObtenerTabla("VENTAS", datos.MapVenta);
        }
        public List<Inventario> ObtenerInventarios()
        {
            return datos.ObtenerTabla("INVENTARIO", datos.MapInventario);
        }
        public List<Cliente> ObtenerClientes()
        {
            return datos.ObtenerTabla("CLIENTES", datos.MapCliente);
        }
        public List<Empleado> ObtenerEmpleado()
        {
            return datos.ObtenerTabla("EMPLEADO", datos.MapEmpleado);
        }
        public List<TarjetaMadre> ObtenerTarjetaMadres()
        {
            return datos.ObtenerTabla("TARJETAMADRE", datos.MapTarjetaMadre);
        }
        public List<Procesador> ObtenerProcesadores()
        {
            return datos.ObtenerTabla("PROCESADOR", datos.MapProcesador);
        }
        public List<Grafica> ObtenerGraficas()
        {
            return datos.ObtenerTabla("GRAFICA", datos.MapGrafica);
        }
        public List<Ram> ObtenerRam()
        {
            return datos.ObtenerTabla("RAM", datos.MapRam);
        }
        public List<Almacenamiento> ObtenerAlmacenamientos()
        {
            return datos.ObtenerTabla("ALMACENAMIENTO", datos.MapAlmacenamiento);
        }
        public List<FuentePoder> ObtenerFuentesDePoder()
        {
            return datos.ObtenerTabla("FUENTEPODER", datos.MapFuentePoder);
        }
        #endregion
        #region Registros
        public void RegistrarVenta(Venta venta)
        {
            //Falta validacion
            datos.Insertar("VENTAS", venta, datos.ConfigureVentaParameters);
        }
        public void RegistrarInventario(Inventario inventario)
        {
            datos.Insertar("INVENTARIO", inventario, datos.ConfigureInventoryParameters);
        }
        public void RegistrarCliente(Cliente cliente)
        {
            datos.Insertar("CLIENTES", cliente, datos.ConfigureClientParameters);
        }
        public void RegistrarEmpleado(Empleado empleado)
        {
            datos.Insertar("CLIENTES", empleado, datos.ConfigureEmployeeParameters);
        }
        public void RegistrarComputadora(Computadora computadora)
        {
            datos.Insertar("COMPUTADORA", computadora, datos.ConfigureComputadoraParameters);
        }
        public void RegistrarTarjetasMadre(TarjetaMadre tarjetaMadre)
        {
            datos.Insertar("TARJETAMADRE", tarjetaMadre, datos.ConfigureTarjetaMadreParameters);
        }
        public void RegistrarProcesador(Procesador procesador)
        {
            datos.Insertar("PROCESADOR", procesador, datos.ConfigureProcesadorParameters);
        }
        public void RegistrarGrafica(Grafica grafica)
        {
            datos.Insertar("GRAFICA", grafica, datos.ConfigureGraficaParameters);
        }
        public void RegistrarRam(Ram ram)
        {
            datos.Insertar("RAM", ram, datos.ConfigureRamParameters);
        }
        public void RegistrarAlmacenamiento(Almacenamiento almacenamiento)
        {
            datos.Insertar("ALMACENAMIENTO", almacenamiento, datos.ConfigureAlmacenamientoParameters);
        }
        public void RegistrarFuentesPoder(FuentePoder fuentePoder)
        {
            datos.Insertar("FUENTEPODER", fuentePoder, datos.ConfigureFuentePoderParameters);
        }
        #endregion
        #region Modificaciones
        public void ModificarVenta(Venta venta)
        {
            datos.ActualizarVentas(venta);
        }
        public void ModificarInventario(Inventario inventario)
        {
            datos.ActualizarInventarios(inventario);
        }
        public void ModificarCliente(Cliente cliente)
        {
            datos.ActualizarClientes(cliente);
        }
        public void ModificarEmpleado(Empleado empleado)
        {
            datos.ActualizarEmpleados(empleado);
        }
        public void ModificarComputadora(Computadora computadora)
        {
            datos.ActualizarComputadora(computadora);
        }
        public void ModificarTarjetasMadre(TarjetaMadre tarjetaMadre)
        {
            datos.ActualizarTarjetaMadre(tarjetaMadre);
        }
        public void ModificarProcesadores(Procesador procesador)
        {
            datos.ActualizarProcesadores(procesador);
        }
        public void ModificarGraficas(Grafica grafica)
        {
            datos.ActualizarGraficas(grafica);
        }
        public void ModificarRam(Ram ram)
        {
            datos.ActualizarRam(ram);
        }
        public void ModificarAlmacenamientos(Almacenamiento almacenamiento)
        {
            datos.ActualizarAlmacenamientos(almacenamiento);
        }
        public void ModificarFuentesPoder(FuentePoder fuentePoder)
        {
            datos.ActualizarFuentePoder(fuentePoder);
        }

        #endregion
        public void Eliminar(string id, string tablaDelId)
        {
            datos.Eliminar(id, tablaDelId);
        }
        #region Consultas
        public List<Venta> ConsultarVenta(string id)
        {
            return datos.Consultar("VENTAS", "idVenta", id, datos.MapVenta);
        }
        public List<Inventario> ConsultarInventario(string id)
        {
            return datos.Consultar("INVENTARIO", "idInventario", id, datos.MapInventario);
        }
        public List<Cliente> ConsultarCliente(string id)
        {
            return datos.Consultar("CLIENTES", "idCliente", id, datos.MapCliente);
        }
        public List<Empleado> ConsultarEmpleado(string id)
        {
            return datos.Consultar("EMPLEADO", "idEmpleado", id, datos.MapEmpleado);
        }
        public List<Computadora> ConsultarComputadora(string id)
        {
            return datos.Consultar("COMPUTADORA", "idComputadora", id, datos.MapComputadora);
        }
        public List<TarjetaMadre> ConsultarTarjetaMadre(string id)
        {
            return datos.Consultar("TARJETAMADRE", "idTarjetaMadre", id, datos.MapTarjetaMadre);
        }
        public List<Procesador> ConsultarProcesador(string id)
        {
            return datos.Consultar("PROCESADOR", "idProcesador", id, datos.MapProcesador);
        }
        public List<Grafica> ConsultarGrafica(string id)
        {
            return datos.Consultar("GRAFICA", "idGrafica", id, datos.MapGrafica);
        }
        public List<Ram> ConsultarRam(string id)
        {
            return datos.Consultar("RAM", "idRam", id, datos.MapRam);
        }
        public List<Almacenamiento> ConsultarAlmacenamiento(string id)
        {
            return datos.Consultar("ALMACENAMIENTO", "idAlmacenamiento", id, datos.MapAlmacenamiento);
        }
        public List<FuentePoder> ConsultarFuentePoder(string id)
        {
            return datos.Consultar("FUENTEPODER", "idFuentePoder", id, datos.MapFuentePoder);
        }
        #endregion
    }
}

