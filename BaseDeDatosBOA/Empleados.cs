using BOAEntidad;
using BOALogica;
using Guna.UI2.WinForms;
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
    public partial class Empleados : Form
    {
        private CLogica logica;
        List<Empleado> empleados = null;

        public Empleados()
        {
            logica = new CLogica();
            InitializeComponent();

            logica.TurnOffLabels(label2, label3, label4, label5, label6);
            logica.TurnOffTxtB(txtNombre, txtApellidoP, txtApellidoM, txtRFC, txtSueldo);

            ValidadorForm.AgregarValidacion(btnModificar, txtIdEmp, txtNombre, txtApellidoP, txtApellidoM, txtRFC, txtSueldo);
        }
        public void LoadData()
        {
            try
            {
                empleados = logica.ObtenerEmpleado();
                empleados = logica.ObtenerEmpleado();
                dgvEmpleado.DataSource = empleados;
                dgvEmpleado.Tag = "empleado";
                dgvEmpleado.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(logica.dgvVentasChangeSize);

                ValidadorForm.AgregarValidacion(btnInsertar, txtIdEmp, txtNombre, txtApellidoP, txtApellidoM, txtRFC, txtSueldo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            bool checkFormat = logica.CheckAllFormats(txtIdEmp.Text, @"^E\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
            {
                bool checkId = logica.VerifyID(txtIdEmp.Text, empleados, item => item.IdEmpleado.ToString());
                if (checkId == true)
                {
                    Empleado empleado = null;
                    try
                    {
                        empleado = new Empleado
                        {
                            IdEmpleado = txtIdEmp.Text,
                            Nombre = txtNombre.Text,
                            ApellidoP = txtApellidoP.Text,
                            ApellidoM = txtApellidoM.Text,
                            RFC = txtRFC.Text,
                            Sueldo = int.Parse(txtSueldo.Text),
                        };
                        logica.RegistrarEmpleado(empleado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
                logica.ClearTextBoxs(this.Controls.OfType<Guna2TextBox>().ToArray());
                txtIdEmp.Enabled = true;
                logica.TurnOffLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                logica.TurnOffTxtB(this.Controls.OfType<Guna2TextBox>().Where((button) => button.Name.ToString() != "txtIdEmp").ToArray());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool checkFormat = logica.CheckAllFormats(txtIdEmp.Text, @"^E\d+$");
            if (checkFormat == false)
            {
                MessageBox.Show("error de formato en ID");
            }
            else
            {
                Empleado empleado = null;
                try
                {
                    empleado = new Empleado
                    {
                        IdEmpleado = txtIdEmp.Text,
                        Nombre = txtNombre.Text,
                        ApellidoP = txtApellidoP.Text,
                        ApellidoM = txtApellidoM.Text,
                        RFC = txtRFC.Text,
                        Sueldo = int.Parse(txtSueldo.Text),
                    };
                    logica.ModificarEmpleado(empleado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtIdEmp.Enabled = true;
                btnInsertar.Enabled = true;
                logica.TurnOffLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                logica.TurnOffTxtB(this.Controls.OfType<Guna2TextBox>().Where((button) => button.Name.ToString() != "txtIdEmp").ToArray());
                logica.ClearTextBoxs(this.Controls.OfType<Guna2TextBox>().ToArray());
            }
        }

        private void Empleados_Load(object sender, EventArgs e)
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
            AbrirEliminar("idEmpleado");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta formConsulta = new Consulta();
            formConsulta.tablaDeDondeViene = "EMPLEADO";
            formConsulta.ShowDialog();
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.SoloNumeros(sender, e);
        }

        private void txtIdEmp_TextChanged(object sender, EventArgs e)
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

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool checkId = logica.VerifyID(txtIdEmp.Text, empleados, item => item.IdEmpleado.ToString());
            if (checkId == true)
            {
                logica.TurnOnLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                logica.TurnOnTxtB(this.Controls.OfType<Guna2TextBox>().ToArray());
            }
            else
            {
                for (int i = 0; i < empleados.Count; i++)
                {
                    if (empleados[i].IdEmpleado.ToString() == txtIdEmp.Text)
                    {
                        logica.TurnOnLabels(this.Controls.OfType<Label>().Where((label) => label.Name.ToString() != "label1").ToArray());
                        logica.TurnOnTxtB(this.Controls.OfType<Guna2TextBox>().ToArray());



                        txtApellidoM.Text = empleados[i].ApellidoM.ToString();
                        txtApellidoP.Text = empleados[i].ApellidoP.ToString();
                        txtIdEmp.Text = empleados[i].IdEmpleado.ToString();
                        txtNombre.Text = empleados[i].Nombre.ToString();
                        txtRFC.Text = empleados[i].RFC.ToString();
                        txtSueldo.Text = empleados[i].Sueldo.ToString();

                        txtIdEmp.Enabled = false;
                        btnInsertar.Enabled = false;
                    }
                }
            }
        }
    }
}