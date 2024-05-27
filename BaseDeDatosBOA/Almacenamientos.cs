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
    public partial class Almacenamientos : Form
    {
        private CLogica logica;
        List<Almacenamiento> almacenamiento = null;

        public Almacenamientos()
        {
            logica = new CLogica();
            InitializeComponent();
            logica.TurnOffLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
            logica.TurnOffTxtB(this.Controls.OfType<Guna2TextBox>().Where((button) => button.Name.ToString() != "txtIdAlmacenamiento").ToArray());

            ValidadorForm.AgregarValidacion(btnInsertar, txtCapacidad, txtFrecuencia, txtIdAlmacenamiento, txtMarca, txtTipo, txtVelocidadTrans);
            ValidadorForm.AgregarValidacion(btnModificar, txtCapacidad, txtFrecuencia, txtIdAlmacenamiento, txtMarca, txtTipo, txtVelocidadTrans);
        }
        public void LoadData()
        {
            try
            {
                almacenamiento = logica.ObtenerAlmacenamientos();
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
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
            {
                bool checkId = logica.VerifyID(txtIdAlmacenamiento.Text, almacenamiento, item => item.IdAlmacenamiento.ToString());
                if (checkId == true)
                {
                    try
                    {
                        Almacenamiento almacenamiento = null;
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
                    txtIdAlmacenamiento.Enabled = true;
                    logica.ClearTextBoxs(this.Controls.OfType<Guna2TextBox>().ToArray());
                    logica.TurnOffLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                    logica.TurnOffTxtB(this.Controls.OfType<Guna2TextBox>().Where((button) => button.Name.ToString() != "txtIdAlmacenamiento").ToArray());
                }
            }
        }

       
        private void textBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool checkFormat = logica.CheckAllFormats(txtIdAlmacenamiento.Text, @"^A\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
            {
                try
                {
                    Almacenamiento almacenamiento = null;
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
                txtIdAlmacenamiento.Enabled = true;
                btnInsertar.Enabled = true;
                logica.TurnOffLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                logica.TurnOffTxtB(this.Controls.OfType<Guna2TextBox>().Where((button) => button.Name.ToString() != "txtIdAlmacenamiento").ToArray());
                logica.ClearTextBoxs(this.Controls.OfType<Guna2TextBox>().ToArray());
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
            logica.CambioAMayusculas(sender, e);
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtCapacidad_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtFrecuencia_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtVelocidadTrans_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdAlmacenamiento.Text, almacenamiento, item => item.IdAlmacenamiento.ToString());
            if (checkId == true)
            {
                logica.TurnOnLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                logica.TurnOnTxtB(this.Controls.OfType<Guna2TextBox>().ToArray());
            }
            else
            {
                for (int i = 0; i < almacenamiento.Count; i++)
                {
                    if (almacenamiento[i].IdAlmacenamiento.ToString() == txtIdAlmacenamiento.Text)
                    {
                        logica.TurnOnLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                        logica.TurnOnTxtB(this.Controls.OfType<Guna2TextBox>().ToArray());

                        txtIdAlmacenamiento.Text = almacenamiento[i].IdAlmacenamiento.ToString();
                        txtMarca.Text = almacenamiento[i].Marca.ToString();
                        txtTipo.Text = almacenamiento[i].Tipo.ToString();
                        txtCapacidad.Text = almacenamiento[i].Capacidad.ToString();
                        txtFrecuencia.Text = almacenamiento[i].Frecuencia.ToString();
                        txtVelocidadTrans.Text = almacenamiento[i].VelocidadTransferencia.ToString();

                        txtIdAlmacenamiento.Enabled = false;
                        btnInsertar.Enabled = false;

                    }
                }
            }
        }
    }
}
