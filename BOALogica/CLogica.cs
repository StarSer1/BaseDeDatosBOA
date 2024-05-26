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
        public void RegistrarVenta(Venta venta)
        {
            //Falta validacion
            datos.Insertar("VENTAS", venta, datos.ConfigureVentaParameters);
        }
        public void RegistrarInventario(Inventario inventario)
        {
            datos.Insertar("INVENTARIO", inventario, datos.ConfigureInventoryParameters);
        }
        public void ModificarVenta(Venta venta)
        {
            datos.ActualizarVentas(venta);
        }
        public void ModificarInventario(Inventario inventario)
        {
            datos.ActualizarInventarios(inventario);
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
    }
}
