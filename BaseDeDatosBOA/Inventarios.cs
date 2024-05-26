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
    public partial class Inventarios : Form
    {
        private CLogica logica;

        public Inventarios()
        {
            logica = new CLogica();
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                List<Inventario> inventarios= logica.ObtenerInventarios();
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
    }
}
