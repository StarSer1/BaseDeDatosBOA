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
    public partial class Eliminar : Form
    {

        private CLogica logica;
        public string tablaDeDondeViene { get; set; }

        public Eliminar()
        {
            logica = new CLogica();
            InitializeComponent();
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            logica.Eliminar(txtId.Text, tablaDeDondeViene);
            MessageBox.Show("Eliminado");
        }
    }
}
