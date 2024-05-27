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
    public partial class Fuentes_De_Poder : Form
    {
        private CLogica logica;
        List<FuentePoder> fuentesPoder = null;

        public Fuentes_De_Poder()
        {
            logica = new CLogica();
            InitializeComponent();

            ValidadorForm.AgregarValidacion(btnInsertar, txtIdFuentePoder, txtMarca, txtModelo, txtPotencia, txtTipo, txtCertificacion);
        }
        public void LoadData()
        {
            try
            {
                List<FuentePoder> fuentePoder = logica.ObtenerFuentesDePoder();
                dgvFuentesDePoder.DataSource = fuentePoder;
                //dgvFuentesDePoder.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvVentas_DataBindingComplete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //private void dgvVentas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //{
        //    DataGridView dgv = sender as DataGridView;

        //    if (dgv != null)
        //    {
        //        dgv.Columns["idVenta"].Width = 55;
        //        dgv.Columns["idEmpleado"].Width = 95;
        //        dgv.Columns["idComputadora"].Width = 115;
        //        dgv.Columns["idCliente"].Width = 65;
        //        dgv.Columns["fechaVenta"].Width = 100;
        //        dgv.Columns["precioFinal"].Width = 90;
        //        dgv.Columns["precioBase"].Width = 90;
        //        dgv.Columns["Descuento"].Width = 80;
        //    }
        //}
        private void btnInsertar_Click(object sender, EventArgs e)
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
                    logica.RegistrarFuentesPoder(fuentePoder);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPotencia_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCertificacion_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdFuentePoder.Text, fuentesPoder, item => item.IdFuentePoder.ToString());
            if (checkId == true)
            {
                txtMarca.Visible = true;
                txtModelo.Visible = true;
                txtPotencia.Visible = true;
                txtTipo.Visible = true;
                txtCertificacion.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
            else
            {
                for (int i = 0; i < fuentesPoder.Count; i++)
                {
                    if (fuentesPoder[i].IdFuentePoder.ToString() == txtIdFuentePoder.Text)
                    {
                        txtMarca.Visible = true;
                        txtModelo.Visible = true;
                        txtPotencia.Visible = true;
                        txtTipo.Visible = true;
                        txtCertificacion.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;

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
