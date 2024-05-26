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
        public void Eliminar(string id, string tablaDelId)
        {
            datos.Eliminar(id, tablaDelId);
        }
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
    }
}

