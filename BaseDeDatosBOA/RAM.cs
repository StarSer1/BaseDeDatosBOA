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
            bool checkFormat = logica.CheckAllFormats(txtIdRam.Text, @"^R\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
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

        private void txtFrecuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.SoloNumeros(sender, e);
        }

        //Validaciones para rellenar txtbox
        private void ValidateTextBoxes()
        {
            if (!string.IsNullOrWhiteSpace(txtFrecuencia.Text) &&
                !string.IsNullOrWhiteSpace(txtIdRam.Text) &&
                !string.IsNullOrWhiteSpace(txtMarca.Text) &&
                !string.IsNullOrWhiteSpace(txtTamaño.Text) &&
                !string.IsNullOrWhiteSpace(txtTipoRam.Text) &&
                !string.IsNullOrWhiteSpace(txtVelocidadTrans.Text))
            {
                btnInsertar.Enabled = true;
            }
            else
            {
                btnInsertar.Enabled = false;
            }
        }

        private void txtIdRam_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtTipoRam_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtFrecuencia_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtTamaño_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtVelocidadTrans_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }
    }
}