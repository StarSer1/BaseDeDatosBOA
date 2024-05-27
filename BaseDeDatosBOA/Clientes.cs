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
            logica.TurnOffLabels(label2, label3, label4, label5);//agregado
            logica.TurnOffTxtB(txtNombre, txtApellidoP, txtApellidoM, txtCorreo);//agregado

            ValidadorForm.AgregarValidacion(btnInsertar, txtIdCliente, txtNombre, txtApellidoP, txtApellidoM, txtCorreo);
            ValidadorForm.AgregarValidacion(btnModificar, txtIdCliente, txtNombre, txtApellidoP, txtApellidoM, txtCorreo);//agregado

        }
        public void LoadData()
        {
            try
            {
                clientes = logica.ObtenerClientes();
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
                bool checkId = logica.VerifyID(txtIdCliente.Text, clientes, item => item.IdCliente.ToString());
                if (checkId == true)
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
                logica.ClearTextBoxs(txtIdCliente, txtNombre, txtApellidoP, txtApellidoM, txtCorreo);
                txtIdCliente.Enabled = true;
                logica.TurnOffLabels(label2, label3, label4, label5);
                logica.TurnOffTxtB(txtNombre, txtApellidoP, txtApellidoM, txtCorreo);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
                    logica.ModificarCliente(cliente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtIdCliente.Enabled = true;
                btnInsertar.Enabled = true;
                logica.TurnOffLabels(label2, label3, label4, label5);
                logica.TurnOffTxtB(txtNombre, txtApellidoP, txtApellidoM, txtCorreo);
                logica.ClearTextBoxs(txtIdCliente, txtNombre, txtApellidoP, txtApellidoM, txtCorreo);
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
            logica.CambioAMayusculas(sender, e);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtApellidoP_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtApellidoM_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdCliente.Text, clientes, item => item.IdCliente.ToString());
            if (checkId == true)
            {
                logica.TurnOnLabels(label2, label3, label4, label5);
                logica.TurnOnTxtB(txtIdCliente, txtNombre, txtApellidoP, txtApellidoM, txtCorreo);
            }
            else
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    if (clientes[i].IdCliente.ToString() == txtIdCliente.Text)
                    {
                        logica.TurnOnLabels(label2, label3, label4, label5);
                        logica.TurnOnTxtB(txtIdCliente, txtNombre, txtApellidoP, txtApellidoM, txtCorreo);

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