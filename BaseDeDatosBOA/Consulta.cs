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
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch(tablaDeDondeViene)
            {
                case "VENTA":
                    var ventas = logica.ConsultarVenta(txtId.Text);
                    dgvConsulta.DataSource = ventas;
                    break;
                case "INVENTARIO":
                    var inventarios = logica.ConsultarInventario(txtId.Text);
                    dgvConsulta.DataSource = inventarios;
                    break;
                case "CLIENTES":
                    var clientes = logica.ConsultarCliente(txtId.Text);
                    dgvConsulta.DataSource = clientes;
                    break;
                case "EMPLEADO":
                    var empleado = logica.ConsultarEmpleado(txtId.Text);
                    dgvConsulta.DataSource = empleado;
                    break;
            }
        }
    }
}
