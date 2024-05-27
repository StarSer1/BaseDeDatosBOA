using BOAEntidad;
using BOALogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BOALogica.CLogica;

namespace BaseDeDatosBOA
{
    public partial class Consulta : Form
    {
        private CLogica logica;
        public string tablaDeDondeViene { get; set; }

        public Consulta()
        {
            logica = new CLogica();
            InitializeComponent();
            ValidadorForm.AgregarValidacion(btnBuscar, txtId);
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (tablaDeDondeViene)
            {
                case "VENTA":
                    string pattern = @"^V\d+$"; // Expresión regular para validar el formato "V" seguido de un número
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtId.Text, pattern))
                    {
                        MessageBox.Show("Formato incorrecto. Debe empezar con 'V' seguido de un número.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var ventas = logica.ConsultarVenta(txtId.Text);
                        dgvConsulta.DataSource = ventas;
                    }
                    break;
                case "INVENTARIO":
                    string pattern2 = @"^I\d+$"; // Expresión regular para validar el formato "V" seguido de un número
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtId.Text, pattern2))
                    {
                        MessageBox.Show("Formato incorrecto. Debe empezar con 'I' seguido de un número.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var inventarios = logica.ConsultarInventario(txtId.Text);
                        dgvConsulta.DataSource = inventarios;
                    }
                    break;
                case "CLIENTES":
                    string pattern3 = @"^C\d+$"; // Expresión regular para validar el formato "V" seguido de un número
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtId.Text, pattern3))
                    {
                        MessageBox.Show("Formato incorrecto. Debe empezar con 'C' seguido de un número.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var clientes = logica.ConsultarCliente(txtId.Text);
                        dgvConsulta.DataSource = clientes;
                    }
                    break;
                case "EMPLEADO":
                    string pattern4 = @"^E\d+$"; // Expresión regular para validar el formato "V" seguido de un número
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtId.Text, pattern4))
                    {
                        MessageBox.Show("Formato incorrecto. Debe empezar con 'E' seguido de un número.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var empleado = logica.ConsultarEmpleado(txtId.Text);
                        dgvConsulta.DataSource = empleado;
                    }
                    break;
                case "COMPUTADORA":
                    string pattern5 = @"^COM\d+$"; // Expresión regular para validar el formato "V" seguido de un número
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtId.Text, pattern5))
                    {
                        MessageBox.Show("Formato incorrecto. Debe empezar con 'COM' seguido de un número.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var computadora = logica.ConsultarComputadora(txtId.Text);
                        dgvConsulta.DataSource = computadora;
                    }
                    break;
                case "TARJETAMADRE":
                    string pattern6 = @"^T\d+$"; // Expresión regular para validar el formato "V" seguido de un número
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtId.Text, pattern6))
                    {
                        MessageBox.Show("Formato incorrecto. Debe empezar con 'T' seguido de un número.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var tarjetaMadre = logica.ConsultarTarjetaMadre(txtId.Text);
                        dgvConsulta.DataSource = tarjetaMadre;
                    }
                    break;
                case "PROCESADOR":
                    string pattern7 = @"^P\d+$"; // Expresión regular para validar el formato "V" seguido de un número
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtId.Text, pattern7))
                    {
                        MessageBox.Show("Formato incorrecto. Debe empezar con 'P' seguido de un número.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var procesador = logica.ConsultarProcesador(txtId.Text);
                        dgvConsulta.DataSource = procesador;
                    }
                    break;
                case "GRAFICA":
                    string pattern8 = @"^G\d+$"; // Expresión regular para validar el formato "V" seguido de un número
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtId.Text, pattern8))
                    {
                        MessageBox.Show("Formato incorrecto. Debe empezar con 'G' seguido de un número.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var grafica = logica.ConsultarGrafica(txtId.Text);
                        dgvConsulta.DataSource = grafica;
                    }
                    break;
                case "RAM":
                    string pattern9 = @"^R\d+$"; // Expresión regular para validar el formato "V" seguido de un número
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtId.Text, pattern9))
                    {
                        MessageBox.Show("Formato incorrecto. Debe empezar con 'R' seguido de un número.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var ram = logica.ConsultarRam(txtId.Text);
                        dgvConsulta.DataSource = ram;
                    }
                    break;
                case "ALMACENAMIENTO":
                    string pattern10 = @"^A\d+$"; // Expresión regular para validar el formato "V" seguido de un número
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtId.Text, pattern10))
                    {
                        MessageBox.Show("Formato incorrecto. Debe empezar con 'A' seguido de un número.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var almacenamiento = logica.ConsultarAlmacenamiento(txtId.Text);
                        dgvConsulta.DataSource = almacenamiento;
                    }
                    break;
                case "FUENTEPODER":
                    string pattern11 = @"^F\d+$"; // Expresión regular para validar el formato "V" seguido de un número
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtId.Text, pattern11))
                    {
                        MessageBox.Show("Formato incorrecto. Debe empezar con 'F' seguido de un número.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var fuentePoder = logica.ConsultarFuentePoder(txtId.Text);
                        dgvConsulta.DataSource = fuentePoder;
                    }
                    break;
            }
        }
    }
}
