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
        public Ventas()
        {
            logica = new CLogica();
            InitializeComponent();
            ValidadorForm.AgregarValidacion(btnInsertar, txtIdVenta, txtIdEmpleado, txtIdComputadora, txtIdCliente, txtFechaCliente, txtPrecioFinal, txtPrecioBase, txtDescuento);
        }

        public void LoadData()
        {
            try
            {
                List<Venta> ventas = logica.ObtenerVentas();
                dgvVentas.DataSource = ventas;
                //dgvVentas.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvVentas_DataBindingComplete);
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
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
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
        }

        private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdComputadora_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFechaCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrecioFinal_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrecioBase_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
