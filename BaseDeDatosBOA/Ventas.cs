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
    public partial class Ventas : Form
    {
        private CLogica logica;
        public Ventas()
        {
            logica = new CLogica();
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                List<Venta> ventas = logica.ObtenerVentas();
                dgvVentas.DataSource = ventas;
                dgvVentas.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvVentas_DataBindingComplete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            Venta venta = null;
            try
            {
                venta = new Venta
                {
                    IdVenta = txtIdVenta.Text,
                    IdEmpleado = txtIdEmp.Text,
                    IdComputadora = txtIdComp.Text,
                    IdCliente = txtIdCliente.Text,
                    FechaVenta = txtFecha.Text,
                    PrecioFinal = int.Parse(txtPrecioF.Text),
                    PrecioBase = int.Parse(txtPrecioB.Text),
                    Descuento = int.Parse(txtDesc.Text)
                };
                logica.RegistrarVenta(venta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Venta venta = null;
            try
            {
                venta = new Venta
                {
                    IdVenta = txtIdVenta.Text,
                    IdEmpleado = txtIdEmp.Text,
                    IdComputadora = txtIdComp.Text,
                    IdCliente = txtIdCliente.Text,
                    FechaVenta = txtFecha.Text,
                    PrecioFinal = int.Parse(txtPrecioF.Text),
                    PrecioBase = int.Parse(txtPrecioB.Text),
                    Descuento = int.Parse(txtDesc.Text)
                };
                logica.ModificarVenta(venta);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
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
    }
}
