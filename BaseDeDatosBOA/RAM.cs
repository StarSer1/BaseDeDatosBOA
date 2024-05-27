using BOAEntidad;
using BOALogica;
using Guna.UI2.WinForms;
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
            logica.TurnOffLabels(label2, label3, label4, label5, label6);//agregado
            logica.TurnOffTxtB(txtFrecuencia, txtMarca, txtTipoRam, txtVelocidadTrans, txtTamaño);//agregado

            ValidadorForm.AgregarValidacion(btnInsertar, txtIdRam, txtMarca, txtTipoRam, txtFrecuencia, txtTamaño, txtVelocidadTrans);
            ValidadorForm.AgregarValidacion(btnModificar, txtIdRam, txtMarca, txtTipoRam, txtFrecuencia, txtTamaño, txtVelocidadTrans);//agregado
        }
        public void LoadData()
        {
            try
            {
                rams = logica.ObtenerRam();//agregado
                dgvRam.DataSource = rams;
                dgvRam.Tag = "ram";
                dgvRam.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(logica.dgvVentasChangeSize);

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

        private void btnInsertar_Click(object sender, EventArgs e)//agregado
        {
            bool checkFormat = logica.CheckAllFormats(txtIdRam.Text, @"^R\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
            {
                bool checkId = logica.VerifyID(txtIdRam.Text, rams, item => item.IdRam.ToString());
                if (checkId == true)
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
                //agregado
                //logica.ClearTextBoxs(this.Controls.OfType<Guna2TextBox>().Where((button) => button.Name.ToString() != "txtIdRam").ToArray());
                logica.ClearTextBoxs(this.Controls.OfType<Guna2TextBox>().ToArray());
                txtIdRam.Enabled = true;
                logica.TurnOffLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                logica.TurnOffTxtB(this.Controls.OfType<Guna2TextBox>().Where((button) => button.Name.ToString() != "txtIdRam").ToArray());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)//agregado
        {
            bool checkFormat = logica.CheckAllFormats(txtIdRam.Text, @"^R\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
            {
                    try
                    {
                        Ram ram = null;
                        ram = new Ram
                        {
                            IdRam = txtIdRam.Text,
                            Marca = txtMarca.Text,
                            TipoRam = txtTipoRam.Text,
                            Frecuencia = int.Parse(txtFrecuencia.Text),
                            Tamaño = int.Parse(txtTamaño.Text),
                            VelocidadTransferencia = int.Parse(txtVelocidadTrans.Text),
                        };
                        logica.ModificarRam(ram);
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show(exe.Message);
                    }
                    //agregado
                    txtIdRam.Enabled = true;
                    btnInsertar.Enabled = true;
                    logica.TurnOffLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                    logica.TurnOffTxtB(this.Controls.OfType<Guna2TextBox>().Where((button) => button.Name.ToString() != "txtIdRam").ToArray());
                    logica.ClearTextBoxs(this.Controls.OfType<Guna2TextBox>().ToArray());
                
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
            logica.CambioAMayusculas(sender, e);
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtTipoRam_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtFrecuencia_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtTamaño_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtVelocidadTrans_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void btnVerificar_Click(object sender, EventArgs e)//agregado
        {
            bool checkId = logica.VerifyID(txtIdRam.Text, rams, item => item.IdRam.ToString());
            if (checkId == true)
            {
                logica.TurnOnLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                logica.TurnOnTxtB(this.Controls.OfType<Guna2TextBox>().ToArray());
            }
            else
            {
                for (int i = 0; i < rams.Count; i++)
                {
                    if (rams[i].IdRam.ToString() == txtIdRam.Text)
                    {
                        logica.TurnOnLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                        logica.TurnOnTxtB(this.Controls.OfType<Guna2TextBox>().ToArray());

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