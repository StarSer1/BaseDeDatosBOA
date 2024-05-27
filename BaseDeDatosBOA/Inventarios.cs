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
    public partial class Inventarios : Form
    {
        private CLogica logica;
        List<Inventario> inventarios = null;

        public Inventarios()
        {
            logica = new CLogica();
            InitializeComponent();
            txtIdComputadora.Visible = false;
            txtFechaLlegada.Visible = false;
            txtPrecioLLegada.Visible = false;
            txtStock.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            ValidadorForm.AgregarValidacion(btnInsertar, txtFechaLlegada, txtIdComputadora, txtIdInventario, txtPrecioLLegada, txtStock);
        }
        public void LoadData()
        {
            try
            {
                inventarios = logica.ObtenerInventarios();
                dgvVentas.DataSource = inventarios;
                //dgvVentas.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvVentas_DataBindingComplete);
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
            List<Computadora> comp = logica.ObtenerComputadoras();
            bool checkExistence = logica.CheckExistenciaInventario(txtIdComputadora.Text, comp);
            if (checkExistence == true)
            {
                bool checkFormat = logica.CheckAllFormats(txtIdInventario.Text, @"^I\d+$");
                if (checkFormat == false)
                {
                    MessageBox.Show("error de formato en ID");
                }
                else
                {
                    Inventario inventario = null;
                    try
                    {
                        inventario = new Inventario
                        {
                            IdInventario = txtIdInventario.Text,
                            IdComputadora = txtIdComputadora.Text,
                            FechaLlegada = txtFechaLlegada.Text,
                            PrecioLlegada = int.Parse(txtPrecioLLegada.Text),
                            Stock = int.Parse(txtStock.Text)
                        };
                        logica.RegistrarInventario(inventario);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Inventarios_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Inventario inventario = null;
            try
            {
                inventario = new Inventario
                {
                    IdInventario = txtIdInventario.Text,
                    IdComputadora = txtIdComputadora.Text,
                    FechaLlegada = txtFechaLlegada.Text,
                    PrecioLlegada = int.Parse(txtPrecioLLegada.Text),
                    Stock = int.Parse(txtStock.Text)
                };
                logica.ModificarInventario(inventario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirEliminar("idInventario");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta formConsulta = new Consulta();
            formConsulta.tablaDeDondeViene = "INVENTARIO";
            formConsulta.ShowDialog();
        }

        private void txtPrecioLLegada_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.SoloNumeros(sender, e);
        }

       
        private void txtIdInventario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdComputadora_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFechaLlegada_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrecioLLegada_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdInventario.Text, inventarios, item => item.ToString());
            if (checkId == true)
            {
                txtIdComputadora.Visible = true;
                txtFechaLlegada.Visible = true;
                txtIdInventario.Visible = true;
                txtPrecioLLegada.Visible = true;
                txtStock.Visible = true;

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;

            }
            else
            {
                for (int i = 0; i < inventarios.Count; i++)
                {
                    if (inventarios[i].IdInventario.ToString() == txtIdInventario.Text)
                    {
                        txtIdComputadora.Visible = true;
                        txtFechaLlegada.Visible = true;
                        txtIdInventario.Visible = true;
                        txtPrecioLLegada.Visible = true;
                        txtStock.Visible = true;

                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;

                        txtIdComputadora.Text = inventarios[i].IdComputadora.ToString();
                        txtFechaLlegada.Text = inventarios[i].FechaLlegada.ToString();
                        txtIdInventario.Text = inventarios[i].IdInventario.ToString();
                        txtPrecioLLegada.Text = inventarios[i].PrecioLlegada.ToString();
                        txtStock.Text = inventarios[i].Stock.ToString();

                        txtIdInventario.Enabled = false;
                        btnInsertar.Enabled = false;
                    }
                }
            }
        }
    }
}
