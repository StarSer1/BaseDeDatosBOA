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
    public partial class Computadoras : Form
    {
        private CLogica logica;
        public Computadoras()
        {
            logica = new CLogica();
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                List<Computadora> computadora = logica.ObtenerComputadoras();
                dgvComputadora.DataSource = computadora;
                //dgvComputadora.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvVentas_DataBindingComplete);
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
            Computadora computadora = null;
            try
            {
                computadora = new Computadora
                {
                    IdComputadora = txtIdComputadora.Text,
                    Modelo = txtModelo.Text,
                    IdRam = txtIdRam.Text,
                    IdProcesador = txtIdProcesador.Text,
                    IdGrafica = txtIdGrafica.Text,
                    IdAlmacenamiento = txtIdAlmacenamiento.Text,
                    IdTarjetaMadre = txtIdTarjetaMadre.Text,
                    IdFuentePoder = txtIdFuentePoder.Text
                };
                logica.RegistrarComputadora(computadora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Computadora computadora = null;
            try
            {
                computadora = new Computadora
                {
                    IdComputadora = txtIdComputadora.Text,
                    Modelo = txtModelo.Text,
                    IdRam = txtIdRam.Text,
                    IdProcesador = txtIdProcesador.Text,
                    IdGrafica = txtIdGrafica.Text,
                    IdAlmacenamiento = txtIdAlmacenamiento.Text,
                    IdTarjetaMadre = txtIdTarjetaMadre.Text,
                    IdFuentePoder = txtIdFuentePoder.Text
                };
                logica.ModificarComputadora(computadora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Computadoras_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirEliminar("idComputadora");
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {
            Consulta formConsulta = new Consulta();
            formConsulta.tablaDeDondeViene = "COMPUTADORA";
            formConsulta.ShowDialog();
        }
    }
}
