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
    public partial class Procesadores : Form
    {
        private CLogica logica;
        List<Procesador> procesadores = null;

        public Procesadores()
        {
            logica = new CLogica();
            InitializeComponent();

            ValidadorForm.AgregarValidacion(btnInsertar, txtIdProcesador, txtMarca, txtModelo);
        }
        public void LoadData()
        {
            try
            {
                List<Procesador> procesador = logica.ObtenerProcesadores();
                dgvProcesadores.DataSource = procesador;
                //dgvProcesadores.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvVentas_DataBindingComplete);
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
            bool checkFormat = logica.CheckAllFormats(txtIdProcesador.Text, @"^P\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
            {
                Procesador procesador = null;
                try
                {
                    procesador = new Procesador
                    {
                        IdProcesador = txtIdProcesador.Text,
                        Marca = txtMarca.Text,
                        Modelo = txtModelo.Text,
                    };
                    logica.RegistrarProcesador(procesador);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Procesador procesador = null;
            try
            {
                procesador = new Procesador
                {
                    IdProcesador = txtIdProcesador.Text,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                };
                logica.ModificarProcesadores(procesador);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Procesadores_Load(object sender, EventArgs e)
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
            AbrirEliminar("idProcesador");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta formConsulta = new Consulta();
            formConsulta.tablaDeDondeViene = "PROCESADOR";
            formConsulta.ShowDialog();
        }

        private void txtIdProcesador_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdProcesador.Text, procesadores, item => item.IdProcesador.ToString());
            if (checkId == true)
            {
                txtMarca.Visible = true;
                txtModelo.Visible = true;
                label2.Visible = true;
                label3.Visible = true;

            }
            else
            {
                for (int i = 0; i < procesadores.Count; i++)
                {
                    if (procesadores[i].IdProcesador.ToString() == txtIdProcesador.Text)
                    {
                        txtMarca.Visible = true;
                        txtModelo.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;

                        txtIdProcesador.Text = procesadores[i].IdProcesador.ToString();
                        txtMarca.Text = procesadores[i].Marca.ToString();
                        txtModelo.Text = procesadores[i].Modelo.ToString();


                        txtIdProcesador.Enabled = false;
                        btnInsertar.Enabled = false;

                    }
                }
            }
        }
    }
}