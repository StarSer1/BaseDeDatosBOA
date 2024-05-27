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
    public partial class Almacenamientos : Form
    {
        private CLogica logica;
        List<Almacenamiento> almacenamientos = null;

        public Almacenamientos()
        {
            logica = new CLogica();
            InitializeComponent();
            ValidadorForm.AgregarValidacion(btnInsertar, txtCapacidad, txtFrecuencia, txtIdAlmacenamiento, txtMarca, txtTipo, txtVelocidadTrans);
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
            bool checkFormat = logica.CheckAllFormats(txtIdAlmacenamiento.Text, @"^A\d+$");
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

       
        private void textBox_TextChanged(object sender, EventArgs e)
        {
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

        private void txtIdAlmacenamiento_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCapacidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFrecuencia_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtVelocidadTrans_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdAlmacenamiento.Text, almacenamientos, item => item.IdAlmacenamiento.ToString());
            if (checkId == true)
            {
                txtMarca.Visible = true;
                txtTipo.Visible = true;
                txtCapacidad.Visible = true;
                txtFrecuencia.Visible = true;
                txtVelocidadTrans.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
            else
            {
                for (int i = 0; i < almacenamientos.Count; i++)
                {
                    if (almacenamientos[i].IdAlmacenamiento.ToString() == txtIdAlmacenamiento.Text)
                    {
                        txtMarca.Visible = true;
                        txtTipo.Visible = true;
                        txtCapacidad.Visible = true;
                        txtFrecuencia.Visible = true;
                        txtVelocidadTrans.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;

                        txtIdAlmacenamiento.Text = almacenamientos[i].IdAlmacenamiento.ToString();
                        txtMarca.Text = almacenamientos[i].Marca.ToString();
                        txtTipo.Text = almacenamientos[i].Tipo.ToString();
                        txtCapacidad.Text = almacenamientos[i].Capacidad.ToString();
                        txtFrecuencia.Text = almacenamientos[i].Frecuencia.ToString();
                        txtVelocidadTrans.Text = almacenamientos[i].VelocidadTransferencia.ToString();

                        txtIdAlmacenamiento.Enabled = false;
                        btnInsertar.Enabled = false;

                    }
                }
            }
        }
    }
}
