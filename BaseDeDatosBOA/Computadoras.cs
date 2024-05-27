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
    public partial class Computadoras : Form
    {
        private CLogica logica;
        List<Computadora> computadoras = null;

        public Computadoras()
        {
            logica = new CLogica();
            InitializeComponent();

            ValidadorForm.AgregarValidacion(btnInsertar, txtIdComputadora, txtModelo, txtIdRam, txtIdProcesador, txtIdGrafica, txtIdAlmacenamiento, txtIdTarjetaMadre, txtIdFuentePoder);
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
            List<Almacenamiento> alma = logica.ObtenerAlmacenamientos();
            List<Ram> ram = logica.ObtenerRam();
            List<Procesador> proce = logica.ObtenerProcesadores();
            List<Grafica> graf = logica.ObtenerGraficas();
            List<TarjetaMadre> tarjMadre = logica.ObtenerTarjetaMadres();
            List<FuentePoder> fuentePod = logica.ObtenerFuentesDePoder();

            bool checkExistence = logica.CheckExistenciaComputadora(txtIdRam.Text, txtIdProcesador.Text, txtIdGrafica.Text, txtIdAlmacenamiento.Text, txtIdTarjetaMadre.Text, txtIdFuentePoder.Text, ram, proce, graf, alma, tarjMadre, fuentePod);
            if (checkExistence == true)
            {
                bool checkFormat = logica.CheckAllFormats(txtIdComputadora.Text, @"^COM\d+$");
                if (checkFormat == false)
                {
                    MessageBox.Show("error de formato en ID");
                }
                else
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

        
        private void textBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdComputadora_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdRam_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdProcesador_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdGrafica_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdAlmacenamiento_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdTarjetaMadre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdFuentePoder_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdComputadora.Text, computadoras, item => item.ToString());
            if (checkId == true)
            {
                txtIdComputadora.Visible = true;
                txtIdAlmacenamiento.Visible = true;
                txtIdFuentePoder.Visible = true;
                txtIdGrafica.Visible = true;
                txtIdProcesador.Visible = true;
                txtIdRam.Visible = true;
                txtIdTarjetaMadre.Visible = true;
                txtModelo.Visible = true;

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
            else
            {
                for (int i = 0; i < computadoras.Count; i++)
                {
                    if (computadoras[i].IdComputadora.ToString() == txtIdComputadora.Text)
                    {
                        txtIdComputadora.Visible = true;
                        txtIdAlmacenamiento.Visible = true;
                        txtIdFuentePoder.Visible = true;
                        txtIdGrafica.Visible = true;
                        txtIdProcesador.Visible = true;
                        txtIdRam.Visible = true;
                        txtIdTarjetaMadre.Visible = true;
                        txtModelo.Visible = true;

                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;

                        txtIdComputadora.Text = computadoras[i].IdComputadora.ToString();
                        txtIdAlmacenamiento.Text = computadoras[i].IdAlmacenamiento.ToString();
                        txtIdFuentePoder.Text = computadoras[i].IdFuentePoder.ToString();
                        txtIdGrafica.Text = computadoras[i].IdGrafica.ToString();
                        txtIdProcesador.Text = computadoras[i].IdProcesador.ToString();
                        txtIdRam.Text = computadoras[i].IdRam.ToString();
                        txtIdTarjetaMadre.Text = computadoras[i].IdTarjetaMadre.ToString();
                        txtModelo.Text = computadoras[i].Modelo.ToString();

                        txtIdComputadora.Enabled = false;
                        btnInsertar.Enabled = false;
                    }
                }
            }
        }
    }
}
