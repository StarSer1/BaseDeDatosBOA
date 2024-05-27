using BOAEntidad;
using BOALogica;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BOALogica.CLogica;

namespace BaseDeDatosBOA
{
    public partial class Ventas : Form
    {
        private CLogica logica;
        List<Venta> ventas = null;
        public Ventas()
        {
            logica = new CLogica();
            InitializeComponent();

            logica.TurnOffLabels(label2, label3, label4, label5, label6, label7, label8);//agregado
            logica.TurnOffTxtB(txtIdEmpleado, txtIdComputadora, txtIdCliente, txtFechaCliente, txtPrecioFinal, txtPrecioBase, txtDescuento);//agregado

            ValidadorForm.AgregarValidacion(btnInsertar, txtIdVenta, txtIdEmpleado, txtIdComputadora, txtIdCliente, txtFechaCliente, txtPrecioFinal, txtPrecioBase, txtDescuento);
            ValidadorForm.AgregarValidacion(btnModificar, txtIdVenta, txtIdEmpleado, txtIdComputadora, txtIdCliente, txtFechaCliente, txtPrecioFinal, txtPrecioBase, txtDescuento);//agregado

        }

        public void LoadData()
        {
            try
            {
                ventas = logica.ObtenerVentas();
                ventas = logica.ObtenerVentas();//agregado(creo)
                dgvVentas.DataSource = ventas;
                dgvVentas.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvVentas_DataBindingComplete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dgvVentas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv != null)
            {
                dgv.Columns["idVenta"].Width = 55;
                dgv.Columns["idEmpleado"].Width = 95;
                dgv.Columns["idComputadora"].Width = 115;
                dgv.Columns["idCliente"].Width = 65;
                dgv.Columns["fechaVenta"].Width = 100;
                dgv.Columns["precioFinal"].Width = 90;
                dgv.Columns["precioBase"].Width = 90;
                dgv.Columns["Descuento"].Width = 80;
            }
        }



        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            List<Empleado> emple = logica.ObtenerEmpleado();
            List<Computadora> compu = logica.ObtenerComputadoras();
            List<Cliente> clien = logica.ObtenerClientes();

            bool checkExistence = logica.CheckExistenciaVenta(txtIdEmpleado.Text, txtIdComputadora.Text, txtIdCliente.Text, emple, compu, clien);
            if (checkExistence == true)
            {
                bool checkFormat = logica.CheckAllFormats(txtIdVenta.Text, @"^V\d+$");
                if (checkFormat == false)
                {
                    MessageBox.Show("error de formato en ID");
                }
                else
                {
                    bool checkId = logica.VerifyID(txtIdVenta.Text, ventas, item => item.IdVenta.ToString());
                    if (checkId == true)
                    {
                        Venta venta = null;
                        try
                        {
                            venta = new Venta
                            {
                                IdVenta = txtIdVenta.Text,
                                IdEmpleado = txtIdEmpleado.Text,
                                IdComputadora = txtIdComputadora.Text,
                                IdCliente = txtIdCliente.Text,
                                FechaVenta = txtFechaCliente.Text,
                                PrecioFinal = int.Parse(txtPrecioFinal.Text),
                                PrecioBase = int.Parse(txtPrecioBase.Text),
                                Descuento = int.Parse(txtDescuento.Text)
                            };
                            logica.RegistrarVenta(venta);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    logica.ClearTextBoxs(txtIdVenta, txtIdEmpleado, txtIdComputadora, txtIdCliente, txtFechaCliente, txtPrecioFinal, txtPrecioBase, txtDescuento);
                    txtIdVenta.Enabled = true;
                    logica.TurnOffLabels(label2, label3, label4, label5, label6, label7, label8);
                    logica.TurnOffTxtB(txtIdVenta, txtIdEmpleado, txtIdComputadora, txtIdCliente, txtFechaCliente, txtPrecioFinal, txtPrecioBase, txtDescuento);
                }
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            List<Computadora> comp = logica.ObtenerComputadoras();
            bool checkExistence = logica.CheckExistenciaInventario(txtIdComputadora.Text, comp);
            if (checkExistence == true)
            {
                bool checkFormat = logica.CheckAllFormats(txtIdVenta.Text, @"^V\d+$");
                if (checkFormat == false)
                {
                    MessageBox.Show("error de formato en ID");
                }
                else
                {
                    Venta venta = null;
                    try
                    {
                        venta = new Venta
                        {
                            IdVenta = txtIdVenta.Text,
                            IdEmpleado = txtIdEmpleado.Text,
                            IdComputadora = txtIdComputadora.Text,
                            IdCliente = txtIdCliente.Text,
                            FechaVenta = txtFechaCliente.Text,
                            PrecioFinal = int.Parse(txtPrecioFinal.Text),
                            PrecioBase = int.Parse(txtPrecioBase.Text),
                            Descuento = int.Parse(txtDescuento.Text)
                        };
                        logica.ModificarVenta(venta);
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show(exe.Message);
                    }
                    txtIdVenta.Enabled = true;
                    btnInsertar.Enabled = true;
                    logica.TurnOffLabels(label2, label3, label4, label5, label6, label7, label8);
                    logica.TurnOffTxtB(txtIdVenta, txtIdEmpleado, txtIdComputadora, txtIdCliente, txtFechaCliente, txtPrecioFinal, txtPrecioBase, txtDescuento);
                    logica.ClearTextBoxs(txtIdVenta, txtIdEmpleado, txtIdComputadora, txtIdCliente, txtFechaCliente, txtPrecioFinal, txtPrecioBase, txtDescuento);
                }
            }
        }

        private void Ventas_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AbrirEliminar(string tablaDondeViene)
        {
            Eliminar formEliminar = new Eliminar();
            formEliminar.tablaDeDondeViene = tablaDondeViene;
            formEliminar.ShowDialog();
        }
        private void BtnEliminarVenta_Click(object sender, EventArgs e)
        {
            AbrirEliminar("idVenta");
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta formConsulta = new Consulta();
            formConsulta.tablaDeDondeViene = "VENTA";
            formConsulta.ShowDialog();
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.SoloNumeros(sender, e);
        }


        private void txtIdVenta_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtIdComputadora_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtFechaCliente_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtPrecioFinal_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtPrecioBase_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdVenta.Text, ventas, item => item.IdVenta.ToString());
            if (checkId == true)
            {
                logica.TurnOnLabels(label2, label3, label4, label5, label6, label7, label8);
                logica.TurnOnTxtB(txtIdVenta, txtIdEmpleado, txtIdComputadora, txtIdCliente, txtFechaCliente, txtPrecioFinal, txtPrecioBase, txtDescuento);


            }
            else
            {
                for (int i = 0; i < ventas.Count; i++)
                {
                    if (ventas[i].IdVenta.ToString() == txtIdVenta.Text)
                    {
                        logica.TurnOnLabels(label2, label3, label4, label5, label6, label7, label8);
                        logica.TurnOnTxtB(txtIdVenta, txtIdEmpleado, txtIdComputadora, txtIdCliente, txtFechaCliente, txtPrecioFinal, txtPrecioBase, txtDescuento);


                        txtIdComputadora.Text = ventas[i].IdComputadora.ToString();
                        txtDescuento.Text = ventas[i].Descuento.ToString();
                        txtFechaCliente.Text = ventas[i].FechaVenta.ToString();
                        txtIdCliente.Text = ventas[i].IdCliente.ToString();
                        txtIdEmpleado.Text = ventas[i].IdEmpleado.ToString();
                        txtIdVenta.Text = ventas[i].IdVenta.ToString();
                        txtPrecioBase.Text = ventas[i].PrecioBase.ToString();
                        txtPrecioFinal.Text = ventas[i].PrecioFinal.ToString();

                        txtIdVenta.Enabled = false;
                        btnInsertar.Enabled = false;
                    }
                }
            }
        }
    }
}