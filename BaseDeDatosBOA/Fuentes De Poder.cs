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
    public partial class Fuentes_De_Poder : Form
    {
        private CLogica logica;
        List<FuentePoder> fuentesPoder = null;

        public Fuentes_De_Poder()
        {
            logica = new CLogica();
            InitializeComponent();
            logica.TurnOffLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
            logica.TurnOffTxtB(this.Controls.OfType<Guna2TextBox>().Where((button) => button.Name.ToString() != "txtIdFuentePoder").ToArray());

            ValidadorForm.AgregarValidacion(btnInsertar, txtIdFuentePoder, txtMarca, txtModelo, txtPotencia, txtTipo, txtCertificacion);
            ValidadorForm.AgregarValidacion(btnModificar, txtIdFuentePoder, txtMarca, txtModelo, txtPotencia, txtTipo, txtCertificacion);
        }
        public void LoadData()
        {
            try
            {
                fuentesPoder = logica.ObtenerFuentesDePoder();
                dgvFuentesDePoder.DataSource = fuentesPoder;
                dgvFuentesDePoder.Tag = "fuentePoder";
                dgvFuentesDePoder.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(logica.dgvVentasChangeSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            bool checkFormat = logica.CheckAllFormats(txtIdFuentePoder.Text, @"^F\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
            {
                bool checkId = logica.VerifyID(txtIdFuentePoder.Text, fuentesPoder, item => item.IdFuentePoder.ToString());
                if (checkId == true)
                {
                    try
                    {
                        FuentePoder fuentePoder = null;
                        fuentePoder = new FuentePoder
                        {
                            IdFuentePoder = txtIdFuentePoder.Text,
                            Marca = txtMarca.Text,
                            Modelo = txtModelo.Text,
                            Potencia = int.Parse(txtPotencia.Text),
                            Tipo = txtTipo.Text,
                            Certificacion = txtCertificacion.Text,
                        };
                        logica.RegistrarFuentesPoder(fuentePoder);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    logica.ClearTextBoxs(this.Controls.OfType<Guna2TextBox>().ToArray());
                    txtIdFuentePoder.Enabled = true;
                    logica.TurnOffLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                    logica.TurnOffTxtB(this.Controls.OfType<Guna2TextBox>().Where((button) => button.Name.ToString() != "txtIdFuentePoder").ToArray());
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool checkFormat = logica.CheckAllFormats(txtIdFuentePoder.Text, @"^F\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
            {
                FuentePoder fuentePoder = null;
                try
                {
                    fuentePoder = new FuentePoder
                    {
                        IdFuentePoder = txtIdFuentePoder.Text,
                        Marca = txtMarca.Text,
                        Modelo = txtModelo.Text,
                        Potencia = int.Parse(txtPotencia.Text),
                        Tipo = txtTipo.Text,
                        Certificacion = txtCertificacion.Text,
                    };
                    logica.ModificarFuentesPoder(fuentePoder);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtIdFuentePoder.Enabled = true;
                btnInsertar.Enabled = true;
                logica.TurnOffLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                logica.TurnOffTxtB(this.Controls.OfType<Guna2TextBox>().Where((button) => button.Name.ToString() != "txtIdFuentePoder").ToArray());
                logica.ClearTextBoxs(this.Controls.OfType<Guna2TextBox>().ToArray());
            }
        }

        private void Fuentes_De_Poder_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void AbrirEliminar(string tablaDondeViene)
        {
            Eliminar formEliminar = new Eliminar();
            formEliminar.tablaDeDondeViene = tablaDondeViene;
            formEliminar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirEliminar("idFuentePoder");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta formConsulta = new Consulta();
            formConsulta.tablaDeDondeViene = "FUENTEPODER";
            formConsulta.ShowDialog();
        }

        private void txtPotencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.SoloNumeros(sender, e);
        }

        
        private void txtIdFuentePoder_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtPotencia_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtCertificacion_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdFuentePoder.Text, fuentesPoder, item => item.IdFuentePoder.ToString());
            if (checkId == true)
            {
                logica.TurnOnLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                logica.TurnOnTxtB(this.Controls.OfType<Guna2TextBox>().ToArray());
            }
            else
            {
                for (int i = 0; i < fuentesPoder.Count; i++)
                {
                    if (fuentesPoder[i].IdFuentePoder.ToString() == txtIdFuentePoder.Text)
                    {
                        logica.TurnOnLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                        logica.TurnOnTxtB(this.Controls.OfType<Guna2TextBox>().ToArray());

                        txtIdFuentePoder.Text = fuentesPoder[i].IdFuentePoder.ToString();
                        txtMarca.Text = fuentesPoder[i].Marca.ToString();
                        txtModelo.Text = fuentesPoder[i].Modelo.ToString();
                        txtPotencia.Text = fuentesPoder[i].Potencia.ToString();
                        txtTipo.Text = fuentesPoder[i].Tipo.ToString();
                        txtCertificacion.Text = fuentesPoder[i].Certificacion.ToString();

                        txtIdFuentePoder.Enabled = false;
                        btnInsertar.Enabled = false;

                    }
                }
            }
        }
    }
}
