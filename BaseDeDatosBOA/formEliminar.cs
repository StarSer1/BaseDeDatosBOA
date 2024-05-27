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
            //Añadir logica para que no intente eliminar de otra tabla
            logica.Eliminar(txtId.Text, tablaDeDondeViene);
            MessageBox.Show("Eliminado");
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            logica.CambioAMayusculas(sender, e);
        }
    }
}
