using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOAEntidad
{
    public class Computadora
    {
        public string IdComputadora { get; set; }
        public string Modelo { get; set; }
        public string IdRam { get; set; }
        public string IdProcesador { get; set; }
        public string IdGrafica { get; set; }
        public string IdAlmacenamiento { get; set; }
        public string IdTarjetaMadre { get; set; }
        public string IdFuentePoder { get; set; }
    }

    public class Ram
    {
        public string IdRam { get; set; }
        public string Marca { get; set; }
        public string TipoRam { get; set; }
        public int Frecuencia { get; set; }
        public int Tamaño { get; set; }
        public int VelocidadTransferencia { get; set; }
    }

    public class TarjetaMadre
    {
        public string IdTarjetaMadre { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int RanurasDIMM { get; set; }
        public string Socket { get; set; }
        public string Dimensiones { get; set; }
    }

    public class FuentePoder
    {
        public string IdFuentePoder { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Potencia { get; set; }
        public string Tipo { get; set; }
        public string Certificacion { get; set; }
    }

    public class Procesador
    {
        public string IdProcesador { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }

    public class Grafica
    {
        public string IdGrafica { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public int Vram { get; set; }
    }

    public class Almacenamiento
    {
        public string IdAlmacenamiento { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public int Frecuencia { get; set; }
        public int VelocidadTransferencia { get; set; }
    }

    public class Empleado
    {
        public string IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string RFC { get; set; }
        public int Sueldo { get; set; }
    }

    public class Venta
    {
        public string IdVenta { get; set; }
        public string IdEmpleado { get; set; }
        public string IdComputadora { get; set; }
        public string IdCliente { get; set; }
        public string FechaVenta { get; set; }
        public int PrecioFinal { get; set; }
        public int PrecioBase { get; set; }
        public int Descuento { get; set; }
    }

    public class Inventario
    {
        public string IdInventario { get; set; }
        public string IdComputadora { get; set; }
        public string FechaLlegada { get; set; }
        public int PrecioLlegada { get; set; }
        public int Stock { get; set; }
    }

    public class Cliente
    {
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Correo { get; set; }
    }
}
