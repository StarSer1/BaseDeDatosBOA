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
    public partial class RAM : Form
    {
        private CLogica logica;
        List<Ram> rams = null;

        public RAM()
        {
            logica = new CLogica();
            InitializeComponent();

            ValidadorForm.AgregarValidacion(btnInsertar, txtIdRam, txtMarca, txtTipoRam, txtFrecuencia, txtTamaño, txtVelocidadTrans);
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

        private void txtIdRam_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTipoRam_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFrecuencia_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTamaño_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtVelocidadTrans_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdRam.Text, rams, item => item.IdRam.ToString());
            if (checkId == true)
            {
                txtMarca.Visible = true;
                txtTipoRam.Visible = true;
                txtFrecuencia.Visible = true;
                txtTamaño.Visible = true;
                txtVelocidadTrans.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
            else
            {
                for (int i = 0; i < rams.Count; i++)
                {
                    if (rams[i].IdRam.ToString() == txtIdRam.Text)
                    {
                        txtMarca.Visible = true;
                        txtTipoRam.Visible = true;
                        txtFrecuencia.Visible = true;
                        txtTamaño.Visible = true;
                        txtVelocidadTrans.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;

                        txtIdRam.Text = rams[i].IdRam.ToString();
                        txtMarca.Text = rams[i].Marca.ToString();
                        txtTipoRam.Text = rams[i].TipoRam.ToString();
                        txtFrecuencia.Text = rams[i].Frecuencia.ToString();
                        txtTamaño.Text = rams[i].Tamaño.ToString();
                        txtVelocidadTrans.Text = rams[i].VelocidadTransferencia.ToString();

                        txtIdRam.Enabled = false;
                        btnInsertar.Enabled = false;

                    }
                }
            }
        }
    }
}