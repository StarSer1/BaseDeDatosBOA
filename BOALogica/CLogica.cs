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
            return datos.ObtenerComputadoras();
        }
        public List<Venta> ObtenerVentas()
        {
            return datos.ObtenerVentas();
        }
        public void RegistrarVenta(Venta venta)
        {
            //Falta validacion
            datos.InsertarVentas(venta);
        }
        public void ModificarVenta(Venta venta)
        {
            datos.ActualizarVentas(venta);
        }
        public void Eliminar(string id, string tablaDelId)
        {
            datos.Eliminar(id, tablaDelId);
        }
    }
}
