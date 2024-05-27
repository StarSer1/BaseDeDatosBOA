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
    public partial class Tarjetas_Madre : Form
    {
        private CLogica logica;
        List<TarjetaMadre> tarjetamadre = null;

        public Tarjetas_Madre()
        {
            logica = new CLogica();
            InitializeComponent();

            ValidadorForm.AgregarValidacion(btnInsertar, txtIdTarjetaMadre, txtMarca, txtIdModelo, txtRanurasDIMM, txtSocket, txtDimensiones);
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

        private void txtIdTarjetaMadre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdModelo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtRanurasDIMM_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSocket_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDimensiones_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdTarjetaMadre.Text, tarjetamadre, item => item.ToString());
            if (checkId == true)
            {
                txtIdTarjetaMadre.Visible = true;
                txtDimensiones.Visible = true;
                txtIdModelo.Visible = true;
                txtMarca.Visible = true;
                txtRanurasDIMM.Visible = true;
                txtSocket.Visible = true;

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
            else
            {
                for (int i = 0; i < tarjetamadre.Count; i++)
                {
                    if (tarjetamadre[i].IdTarjetaMadre.ToString() == txtIdTarjetaMadre.Text)
                    {
                        txtIdTarjetaMadre.Visible = true;
                        txtDimensiones.Visible = true;
                        txtIdModelo.Visible = true;
                        txtMarca.Visible = true;
                        txtRanurasDIMM.Visible = true;
                        txtSocket.Visible = true;

                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;

                        txtIdTarjetaMadre.Text = tarjetamadre[i].IdTarjetaMadre.ToString();
                        txtDimensiones.Text = tarjetamadre[i].Dimensiones.ToString();
                        txtIdModelo.Text = tarjetamadre[i].Modelo.ToString();
                        txtMarca.Text = tarjetamadre[i].Marca.ToString();
                        txtRanurasDIMM.Text = tarjetamadre[i].RanurasDIMM.ToString();
                        txtSocket.Text = tarjetamadre[i].Socket.ToString();

                        txtIdTarjetaMadre.Enabled = false;
                        btnInsertar.Enabled = false;
                    }
                }
            }
        }
    }
}