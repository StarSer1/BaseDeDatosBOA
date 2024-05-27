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
        List<TarjetaMadre> tarjetasMadres = null;

        public Tarjetas_Madre()
        {
            logica = new CLogica();
            InitializeComponent();
            logica.TurnOffLabels(label2, label3, label4, label5, label6);
            logica.TurnOffTxtB(txtDimensiones, txtIdModelo, txtMarca, txtRanurasDIMM, txtSocket);

            ValidadorForm.AgregarValidacion(btnInsertar, txtIdTarjetaMadre, txtMarca, txtIdModelo, txtRanurasDIMM, txtSocket, txtDimensiones);
            ValidadorForm.AgregarValidacion(btnModificar, txtIdTarjetaMadre, txtMarca, txtIdModelo, txtRanurasDIMM, txtSocket, txtDimensiones);
        }

        private void Tarjetas_Madre_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                tarjetasMadres = logica.ObtenerTarjetaMadres();
                dgvTarjetasMadre.DataSource = tarjetasMadres;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            bool checkFormat = logica.CheckAllFormats(txtIdTarjetaMadre.Text, @"^T\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("Error de formato en el ID");
            }
            else
            {
                bool checkId = logica.VerifyID(txtIdTarjetaMadre.Text, tarjetasMadres, item => item.IdTarjetaMadre.ToString());
                if (checkId == true)
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
                logica.ClearTextBoxs(txtIdTarjetaMadre, txtMarca, txtSocket, txtDimensiones, txtIdModelo, txtRanurasDIMM);
                txtIdTarjetaMadre.Enabled = true;
                logica.TurnOffLabels(label2, label3, label4, label5, label6);
                logica.TurnOffTxtB(txtDimensiones, txtIdModelo, txtMarca, txtRanurasDIMM, txtSocket);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool checkFormat = logica.CheckAllFormats(txtIdTarjetaMadre.Text, @"^T\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("Error de formato en el ID");
            }
            else
            {
                bool checkId = logica.VerifyID(txtIdTarjetaMadre.Text, tarjetasMadres, item => item.IdTarjetaMadre.ToString());
                if (checkId == true)
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
                    txtIdTarjetaMadre.Enabled = true;
                    btnInsertar.Enabled = true;
                    logica.TurnOffLabels(label2, label3, label4, label5, label6);
                    logica.TurnOffTxtB(txtDimensiones, txtIdModelo, txtMarca, txtRanurasDIMM, txtSocket);
                    logica.ClearTextBoxs(txtIdTarjetaMadre, txtMarca, txtSocket, txtDimensiones, txtIdModelo, txtRanurasDIMM);
                }
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
            bool checkId = logica.VerifyID(txtIdTarjetaMadre.Text, tarjetasMadres, item => item.ToString());
            if (checkId == true)
            {
                logica.TurnOnLabels(label2, label3, label4, label5, label6);
                logica.TurnOnTxtB(txtIdTarjetaMadre, txtDimensiones, txtIdModelo, txtMarca, txtRanurasDIMM, txtSocket);
            }
            else
            {
                for (int i = 0; i < tarjetasMadres.Count; i++)
                {
                    if (tarjetasMadres[i].IdTarjetaMadre.ToString() == txtIdTarjetaMadre.Text)
                    {
                        logica.TurnOnLabels(label2, label3, label4, label5, label6);
                        logica.TurnOnTxtB(txtIdTarjetaMadre, txtDimensiones, txtIdModelo, txtMarca, txtRanurasDIMM, txtSocket);

                        txtIdTarjetaMadre.Text = tarjetasMadres[i].IdTarjetaMadre.ToString();
                        txtDimensiones.Text = tarjetasMadres[i].Dimensiones.ToString();
                        txtIdModelo.Text = tarjetasMadres[i].Modelo.ToString();
                        txtMarca.Text = tarjetasMadres[i].Marca.ToString();
                        txtRanurasDIMM.Text = tarjetasMadres[i].RanurasDIMM.ToString();
                        txtSocket.Text = tarjetasMadres[i].Socket.ToString();

                        txtIdTarjetaMadre.Enabled = false;
                        btnInsertar.Enabled = false;
                    }
                }
            }
        }
    }
}