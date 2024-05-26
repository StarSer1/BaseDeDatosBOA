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
    public partial class Tarjetas_Madre : Form
    {
        private CLogica logica;
        public Tarjetas_Madre()
        {
            logica = new CLogica();
            InitializeComponent();
        }

        private void Tarjetas_Madre_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                List<Venta> ventas = logica.ObtenerVentas();
                dgvTarjetasMadre.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            TarjetaMadre tarjetaMadre = null;
            try
            {
                tarjetaMadre = new TarjetaMadre
                {
                    IdTarjetaMadre = txtIdTarjetaMadre.Text,
                    Marca = txtMarca.Text,
                    Modelo = txtIdModelo.Text,
                    RanurasDIMM = int.Parse(txtRanurasDIMM.Text),
                    Socket = txtSocket.Text,
                    Dimensiones = txtDimensiones.Text,
                };
                logica.RegistrarTarjetasMadre(tarjetaMadre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TarjetaMadre tarjetaMadre = null;
            try
            {
                tarjetaMadre = new TarjetaMadre
                {
                    IdTarjetaMadre = txtIdTarjetaMadre.Text,
                    Marca = txtMarca.Text,
                    Modelo = txtIdModelo.Text,
                    RanurasDIMM = int.Parse(txtRanurasDIMM.Text),
                    Socket = txtSocket.Text,
                    Dimensiones = txtDimensiones.Text,
                };
                logica.RegistrarTarjetasMadre(tarjetaMadre);
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