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
    public partial class Clientes : Form
    {
        private CLogica logica;
        List<Cliente> clientes = null;

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

                ValidadorForm.AgregarValidacion(btnInsertar, txtIdCliente, txtNombre, txtApellidoP, txtApellidoM, txtCorreo);
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
       
        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtApellidoP_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtApellidoM_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdCliente.Text, clientes, item => item.ToString());
            if (checkId == true)
            {
                txtApellidoM.Visible = true;
                txtApellidoP.Visible = true;
                txtCorreo.Visible = true;
                txtIdCliente.Visible = true;
                txtNombre.Visible = true;

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
            else
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    if (clientes[i].IdCliente.ToString() == txtIdCliente.Text)
                    {
                        txtApellidoM.Visible = true;
                        txtApellidoP.Visible = true;
                        txtCorreo.Visible = true;
                        txtIdCliente.Visible = true;
                        txtNombre.Visible = true;

                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;

                        txtApellidoM.Text = clientes[i].ApellidoM.ToString();
                        txtApellidoP.Text = clientes[i].ApellidoP.ToString();
                        txtCorreo.Text = clientes[i].Correo.ToString();
                        txtIdCliente.Text = clientes[i].IdCliente.ToString();
                        txtNombre.Text = clientes[i].Nombre.ToString();


                        txtIdCliente.Enabled = false;
                        btnInsertar.Enabled = false;
                    }
                }
            }
        }
    }
}
