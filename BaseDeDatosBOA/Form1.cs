using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BOALogica;
using BOAEntidad;

namespace BaseDeDatosBOA
{
    public partial class Form1 : Form
    {
        private CLogica logica;

        public Form1()
        {
            InitializeComponent();
            logica = new CLogica();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Computadora> computadoras = logica.ObtenerComputadoras();
                dataGridView1.DataSource = computadoras;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
