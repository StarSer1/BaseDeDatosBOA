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

            logica.TurnOffLabels(label2, label3, label4, label5);
            logica.TurnOffTxtB(txtMarca, txtModelo, txtTipo, txtVram);

            ValidadorForm.AgregarValidacion(btnInsertar, txtIdGrafica, txtMarca, txtModelo, txtTipo, txtVram);
            ValidadorForm.AgregarValidacion(btnModificar, txtIdGrafica, txtMarca, txtModelo, txtTipo, txtVram);
        }
        public void LoadData()
        {
            try
            {
                graficas = logica.ObtenerGraficas();
                dgvGraficas.DataSource = graficas;
                dgvGraficas.Tag = "grafica";
                dgvGraficas.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(logica.dgvVentasChangeSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AbrirEliminar(string tablaDondeViene)
        {
            Eliminar formEliminar = new Eliminar();
            formEliminar.tablaDeDondeViene = tablaDondeViene;
            formEliminar.ShowDialog();
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            bool checkFormat = logica.CheckAllFormats(txtIdGrafica.Text, @"^G\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
            {
                bool checkId = logica.VerifyID(txtIdGrafica.Text, graficas, item => item.IdGrafica.ToString());
                if (checkId == true)
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
                        logica.RegistrarGrafica(grafica);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                logica.ClearTextBoxs(txtIdGrafica, txtMarca, txtModelo, txtTipo, txtVram);
                txtIdGrafica.Enabled = true;
                logica.TurnOffLabels(label2, label3, label4, label5);
                logica.TurnOffTxtB(txtMarca, txtModelo, txtTipo, txtVram);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool checkFormat = logica.CheckAllFormats(txtIdGrafica.Text, @"^G\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
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
                txtIdGrafica.Enabled = true;
                btnInsertar.Enabled = true;
                logica.TurnOffLabels(label2, label3, label4, label5);
                logica.TurnOffTxtB(txtMarca, txtModelo, txtTipo, txtVram);
                logica.ClearTextBoxs(txtIdGrafica, txtMarca, txtModelo, txtTipo, txtVram);
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

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtVram_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdGrafica.Text, graficas, item => item.IdGrafica.ToString());
            if (checkId == true)
            {
                logica.TurnOnLabels(label2, label3, label4, label5);
                logica.TurnOnTxtB(txtIdGrafica, txtMarca, txtModelo, txtTipo, txtVram);
            }
            else
            {
                for (int i = 0; i < graficas.Count; i++)
                {
                    if (graficas[i].IdGrafica.ToString() == txtIdGrafica.Text)
                    {
                        logica.TurnOnLabels(label2, label3, label4, label5);
                        logica.TurnOnTxtB(txtIdGrafica, txtMarca, txtModelo, txtTipo, txtVram);

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