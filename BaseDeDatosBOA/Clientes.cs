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
    public partial class Clientes : Form
    {
        private CLogica logica;

        public Clientes()
        {
            logica = new CLogica();
            InitializeComponent();


        }
        public void LoadData()
        {
            try
            {
                List<Cliente> clientes = logica.ObtenerClientes();
                dgvClientes.DataSource = clientes;
                //dgvClientes.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvVentas_DataBindingComplete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            bool checkFormat = logica.CheckAllFormats(txtIdCliente.Text, @"^C\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
            {
                Cliente cliente = null;
                try
                {
                    cliente = new Cliente
                    {
                        IdCliente = txtIdCliente.Text,
                        Nombre = txtNombre.Text,
                        ApellidoP = txtApellidoP.Text,
                        ApellidoM = txtApellidoM.Text,
                        Correo = txtCorreo.Text,
                    };
                    logica.RegistrarCliente(cliente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente cliente = null;
            try
            {
                cliente = new Cliente
                {
                    IdCliente = txtIdCliente.Text,
                    Nombre = txtNombre.Text,
                    ApellidoP = txtApellidoP.Text,
                    ApellidoM = txtApellidoM.Text,
                    Correo = txtCorreo.Text,
                };
                logica.ModificarCliente(cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
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
            AbrirEliminar("idCliente");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta formConsulta = new Consulta();
            formConsulta.tablaDeDondeViene = "CLIENTES";
            formConsulta.ShowDialog();
        }
        private void ValidateTextBoxes()
        {
            if (!string.IsNullOrWhiteSpace(txtApellidoM.Text) &&
                !string.IsNullOrWhiteSpace(txtApellidoP.Text) &&
                !string.IsNullOrWhiteSpace(txtCorreo.Text) &&
                !string.IsNullOrWhiteSpace(txtIdCliente.Text) &&
                !string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                btnInsertar.Enabled = true;
            }
            else
            {
                btnInsertar.Enabled = false;
            }
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtApellidoP_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtApellidoM_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

        }
    }
}
