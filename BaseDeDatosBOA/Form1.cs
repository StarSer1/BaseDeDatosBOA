using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BaseDeDatosBOA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Obtener la cadena de conexión desde App.config
            string connectionString = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;

            // Definir la consulta SQL (modifica "NombreDeTuTabla" por el nombre de tu tabla real)
            string query = "SELECT * FROM COMPUTADORA";

            // Crear una conexión SQL
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    con.Open();

                    // Crear un SqlDataAdapter
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

                    // Crear un DataTable
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable como origen de datos del DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
