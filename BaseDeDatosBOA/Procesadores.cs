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
    public partial class Procesadores : Form
    {
        private CLogica logica;

        public Procesadores()
        {
            logica = new CLogica();
            InitializeComponent();
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

        //Validaciones para rellenar txtbox
        private void ValidateTextBoxes()
        {
            if (!string.IsNullOrWhiteSpace(txtIdProcesador.Text) &&
                !string.IsNullOrWhiteSpace(txtMarca.Text) &&
                !string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                btnInsertar.Enabled = true;
            }
            else
            {
                btnInsertar.Enabled = false;
            }
        }

        private void txtIdProcesador_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }
    }
}