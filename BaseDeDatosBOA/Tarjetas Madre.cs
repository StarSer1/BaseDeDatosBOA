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
            bool checkFormat = logica.CheckAllFormats(txtIdTarjetaMadre.Text, @"^V\d+$");
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

        private void txtRanurasDIMM_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.SoloNumeros(sender, e);
        }

        //Validaciones para rellenar txtbox
        private void ValidateTextBoxes()
        {
            if (!string.IsNullOrWhiteSpace(txtDimensiones.Text) &&
                !string.IsNullOrWhiteSpace(txtIdModelo.Text) &&
                !string.IsNullOrWhiteSpace(txtIdTarjetaMadre.Text) &&
                !string.IsNullOrWhiteSpace(txtMarca.Text) &&
                !string.IsNullOrWhiteSpace(txtRanurasDIMM.Text) &&
                !string.IsNullOrWhiteSpace(txtSocket.Text))
            {
                btnInsertar.Enabled = true;
            }
            else
            {
                btnInsertar.Enabled = false;
            }
        }

        private void txtIdTarjetaMadre_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtIdModelo_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtRanurasDIMM_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtSocket_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtDimensiones_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }
    }
}