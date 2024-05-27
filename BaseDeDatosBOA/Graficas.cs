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
    public partial class Graficas : Form
    {
        private CLogica logica;
        List<Grafica> graficas = null;

        public Graficas()
        {
            logica = new CLogica();
            InitializeComponent();

            ValidadorForm.AgregarValidacion(btnInsertar, txtIdGrafica, txtMarca, txtModelo, txtTipo, txtVram);
        }
        public void LoadData()
        {
            try
            {
                List<Grafica> grafica = logica.ObtenerGraficas();
                dgvGraficas.DataSource = grafica;
                //dgvVentas.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvVentas_DataBindingComplete);
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







        private void AbrirEliminar(string tablaDondeViene)
        {
            Eliminar formEliminar = new Eliminar();
            formEliminar.tablaDeDondeViene = tablaDondeViene;
            formEliminar.ShowDialog();
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            bool checkFormat = logica.CheckAllFormats(txtIdGrafica.Text, @"^G\d+$");
            Grafica grafica = null;
            try
            {
                grafica = new Grafica
                {
                    IdGrafica = txtIdGrafica.Text,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Tipo = txtTipo.Text,
                    Vram = int.Parse(txtVram.Text),
                };
                logica.RegistrarGrafica(grafica);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Grafica grafica = null;
            try
            {
                grafica = new Grafica
                {
                    IdGrafica = txtIdGrafica.Text,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Tipo = txtTipo.Text,
                    Vram = int.Parse(txtVram.Text),
                };
                logica.ModificarGraficas(grafica);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Graficas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirEliminar("idGrafica");
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {
            Consulta formConsulta = new Consulta();
            formConsulta.tablaDeDondeViene = "GRAFICA";
            formConsulta.ShowDialog();
        }

        private void txtVram_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.SoloNumeros(sender, e);
        }

        private void txtIdGrafica_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtVram_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdGrafica.Text, graficas, item => item.IdGrafica.ToString());
            if (checkId == true)
            {
                txtMarca.Visible = true;
                txtModelo.Visible = true;
                txtTipo.Visible = true;
                txtVram.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
            else
            {
                for (int i = 0; i < graficas.Count; i++)
                {
                    if (graficas[i].IdGrafica.ToString() == txtIdGrafica.Text)
                    {
                        txtMarca.Visible = true;
                        txtModelo.Visible = true;
                        txtTipo.Visible = true;
                        txtVram.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;

                        txtIdGrafica.Text = graficas[i].IdGrafica.ToString();
                        txtMarca.Text = graficas[i].Marca.ToString();
                        txtModelo.Text = graficas[i].Modelo.ToString();
                        txtTipo.Text = graficas[i].Tipo.ToString();
                        txtVram.Text = graficas[i].Vram.ToString();

                        txtIdGrafica.Enabled = false;
                        btnInsertar.Enabled = false;

                    }
                }
            }
        }
    }
}
