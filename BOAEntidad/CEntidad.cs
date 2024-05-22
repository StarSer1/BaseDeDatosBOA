using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOAEntidad
{
    public class Computadora
    {
        public int idComputadora { get; set; }
        public string modelo { get; set; }
        public string idRam { get; set; }
        public string idProcesador { get; set; }
        public string idGrafica { get; set; }
        public string idAlmacenamiento { get; set; }
        public string idTarjetaMadre { get; set; }
        public string idFuentePoder { get; set; }
    }
    public class Ram
    {
        public string idRam { get; set; }
        public string Nombre { get; set; }
        public string tipoRam { get; set; }
        public int frecuencia { get; set; }
        public int tamaño { get; set; }
        public int velocidadTransferencia { get; set; }
    }

    public class TarjetaMadre
    {
        public string idTarjetaMadre { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int Ranuras { get; set; }
        public string socket { get; set; }
        public string dimensiones { get; set; }

    }
    public class Fuentepoder
    {
        public string idFuentePoder { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int potencia { get; set; }
        public string tipo { get; set; }
        public string certificacion { get; set; }
    }
    public class Procesador
    {
        public string idProcesador { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
    }
    public class Grafica
    {
        public string idGrafica { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string tipo { get; set; }
        public int vram { get; set; }
    }
    public class Almacenamiento
    {
        public string idAlmacenamiento { get; set; }
        public string marca { get; set; }
        public string tipo { get; set; }
        public int capacidad { get; set; }
        public int frecuencia { get; set; }
        public int velocidadTransferencia { get; set; }
    }
    public class Empleado
    {
        public string idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string rfc { get; set; }
        public int sueldo { get; set; }
    }
    public class Ventas
    {
        public string idVentas { get; set; }
        public string idEmpleado { get; set; }
        public string idComputadora { get; set; }
        public string idCliente { get; set; }
        public string fechaVenta { get; set; }
        public int precioFinal { get; set; }
        public int precioBase { get; set; }
        public int Descuento { get; set; }
    }
    public class Inventario
    {
        public string idInventario { get; set; }
        public string idComputadora { get; set; }
        public string fechaLlegada { get; set; }
        public int precioLlegada { get; set; }
        public int stock { get; set; }

    }
    public class Clientes
    {
        public string idCliente { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string correo { get; set; }
    }
}
