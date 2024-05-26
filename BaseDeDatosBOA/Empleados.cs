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
    public partial class Empleados : Form
    {
        private CLogica logica;
        public Empleados()
        {
            logica = new CLogica();
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                List<Empleado> empleados = logica.ObtenerEmpleado();
                dgvEmpleado.DataSource = empleados;
                //dgvEmpleado.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvVentas_DataBindingComplete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
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
    }
}
