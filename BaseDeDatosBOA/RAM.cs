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
    public partial class RAM : Form
    {
        private CLogica logica;

        public RAM()
        {
            logica = new CLogica();
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                List<Venta> ventas = logica.ObtenerVentas();
                dgvRam.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RAM_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Ram ram = null;
            try
            {
                ram = new Ram
                {
                    IdRam = txtIdRam.Text,
                    Marca = txtMarca.Text,
                    TipoRam = txtTipoRam.Text,
                    Frecuencia = int.Parse(txtFrecuencia.Text),
                    Tamaño = int.Parse(txtTamaño.Text),
                    VelocidadTransferencia = int.Parse(txtVelocidadTrans.Text),
                };
                logica.RegistrarRam(ram);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Ram ram = null;
            try
            {
                ram = new Ram
                {
                    IdRam = txtIdRam.Text,
                    Marca = txtMarca.Text,
                    TipoRam = txtTipoRam.Text,
                    Frecuencia = int.Parse(txtFrecuencia.Text),
                    Tamaño = int.Parse(txtTamaño.Text),
                    VelocidadTransferencia = int.Parse(txtVelocidadTrans.Text),
                };
                logica.RegistrarRam(ram);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void AbrirEliminar(string tablaDondeViene)
        {
            Eliminar formEliminar = new Eliminar();
            formEliminar.tablaDeDondeViene = tablaDondeViene;
            formEliminar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirEliminar("idVenta");
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta formConsulta = new Consulta();
            formConsulta.tablaDeDondeViene = "VENTA";
            formConsulta.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}