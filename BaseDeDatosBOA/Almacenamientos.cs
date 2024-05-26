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
    public partial class Almacenamientos : Form
    {
        private CLogica logica;
        public Almacenamientos()
        {
            logica = new CLogica();
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                List<Almacenamiento> almacenamiento = logica.ObtenerAlmacenamientos();
                dgvAlmacenamiento.DataSource = almacenamiento;
                //dgvAlmacenamiento.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvVentas_DataBindingComplete);
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
            Almacenamiento almacenamiento = null;
            try
            {
                almacenamiento = new Almacenamiento
                {
                    IdAlmacenamiento = txtIdAlmacenamiento.Text,
                    Marca = txtMarca.Text,
                    Tipo = txtTipo.Text,
                    Capacidad = int.Parse(txtCapacidad.Text),
                    Frecuencia = int.Parse(txtFrecuencia.Text),
                    VelocidadTransferencia = int.Parse(txtVelocidadTrans.Text)
                };
                logica.RegistrarAlmacenamiento(almacenamiento);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Almacenamiento almacenamiento = null;
            try
            {
                almacenamiento = new Almacenamiento
                {
                    IdAlmacenamiento = txtIdAlmacenamiento.Text,
                    Marca = txtMarca.Text,
                    Tipo = txtTipo.Text,
                    Capacidad = int.Parse(txtCapacidad.Text),
                    Frecuencia = int.Parse(txtFrecuencia.Text),
                    VelocidadTransferencia = int.Parse(txtVelocidadTrans.Text)
                };
                logica.ModificarAlmacenamientos(almacenamiento);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Almacenamientos_Load(object sender, EventArgs e)
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
            AbrirEliminar("idAlmacenamiento");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta formConsulta = new Consulta();
            formConsulta.tablaDeDondeViene = "ALMACENAMIENTO";
            formConsulta.ShowDialog();
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.SoloNumeros(sender, e);
        }
    }
}
