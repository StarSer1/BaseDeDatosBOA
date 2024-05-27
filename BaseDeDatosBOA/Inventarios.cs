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
            logica.TurnOffLabels(label2, label3, label4, label5);
            logica.TurnOffTxtB(txtIdComputadora, txtFechaLlegada, txtPrecioLLegada, txtStock);

            ValidadorForm.AgregarValidacion(btnInsertar, txtFechaLlegada, txtIdComputadora, txtIdInventario, txtPrecioLLegada, txtStock);
            ValidadorForm.AgregarValidacion(btnModificar, txtFechaLlegada, txtIdComputadora, txtIdInventario, txtPrecioLLegada, txtStock);//agregado
        }
        public void LoadData()
        {
            try
            {
                inventarios = logica.ObtenerInventarios();
                dgvVentas.DataSource = inventarios;
                dgvVentas.Tag = "inventario";
                dgvVentas.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(logica.dgvVentasChangeSize);
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
                    bool checkId = logica.VerifyID(txtIdInventario.Text, inventarios, item => item.IdInventario.ToString());
                    if (checkId == true)
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
                    logica.ClearTextBoxs(txtIdInventario, txtPrecioLLegada, txtStock, txtFechaLlegada, txtIdComputadora);
                    txtIdInventario.Enabled = true;
                    logica.TurnOffLabels(label2, label3, label4, label5);
                    logica.TurnOffTxtB(txtIdComputadora, txtFechaLlegada, txtPrecioLLegada, txtStock);
                }
            }
        }

        private void Inventarios_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
                        logica.ModificarInventario(inventario);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    txtIdInventario.Enabled = true;
                    btnInsertar.Enabled = true;
                    logica.TurnOffLabels(label2, label3, label4, label5);
                    logica.TurnOffTxtB(txtIdComputadora, txtFechaLlegada, txtPrecioLLegada, txtStock);
                    logica.ClearTextBoxs(txtIdInventario, txtPrecioLLegada, txtStock, txtFechaLlegada, txtIdComputadora);
                }
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
            logica.CambioAMayusculas(sender, e);
        }

        private void txtIdComputadora_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtFechaLlegada_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtPrecioLLegada_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdInventario.Text, inventarios, item => item.IdInventario.ToString());
            if (checkId == true)
            {
                logica.TurnOnLabels(label2, label3, label4, label5);
                logica.TurnOnTxtB(txtIdInventario, txtIdComputadora, txtFechaLlegada, txtPrecioLLegada, txtStock);

            }
            else
            {
                for (int i = 0; i < inventarios.Count; i++)
                {
                    if (inventarios[i].IdInventario.ToString() == txtIdInventario.Text)
                    {
                        logica.TurnOnLabels(label2, label3, label4, label5);
                        logica.TurnOnTxtB(txtIdInventario, txtIdComputadora, txtFechaLlegada, txtPrecioLLegada, txtStock);

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
