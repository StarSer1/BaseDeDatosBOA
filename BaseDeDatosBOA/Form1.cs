using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BOALogica;
using BOAEntidad;
using FontAwesome.Sharp;
using Guna.UI2.WinForms.Suite;
using Color = System.Drawing.Color;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Documents;

namespace BaseDeDatosBOA
{
    public partial class Form1 : Form
    {
        private CLogica logica;
        private IconButton currentbtn;
        private Guna.UI2.WinForms.Suite.Panel bordeIzquierdobtn;
        private Form formHijo;


        public Form1()
        {
            InitializeComponent();
            logica = new CLogica();
            bordeIzquierdobtn = new Guna.UI2.WinForms.Suite.Panel();
            bordeIzquierdobtn.Size = new Size(10, 45);
            Gunapanelizquierdo.Controls.Add(bordeIzquierdobtn);
            //Quitar Borde Superior Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        private void formularioHijo(Form hijo)
        {
            if (formHijo != null)
            {
                //Al abrir un formulario cerramos el formulario anterior
                formHijo.Close();
            }
            formHijo = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            gunaPanelFondo.Controls.Add(hijo);
            gunaPanelFondo.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
            lblTitulo.Text = hijo.Text;
        }

        //AlmacenarColoresRgb
        private struct almacenarRGB
        {
            public static Color color1 = Color.FromArgb(0, 0, 0, 0);
        }

        //Metodo
        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                resaltarBoton();
                //Boton
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(61, 89, 97);
                currentbtn.ForeColor = Color.White;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = Color.FromArgb(4, 35, 55);
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                //bordeIzquierdobtn
                bordeIzquierdobtn.BackColor = Color.FromArgb(4, 35, 55);
                bordeIzquierdobtn.Location = new Point(0, currentbtn.Location.Y);
                bordeIzquierdobtn.Visible = true;
                bordeIzquierdobtn.BringToFront();
                //Icono titulo hijo form
                iconTitulo.IconChar = currentbtn.IconChar;
                iconTitulo.IconColor = Color.FromArgb(4, 35, 55);
            }
        }
        private void resaltarBoton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(61, 89, 97);
                currentbtn.ForeColor = Color.White;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.FromArgb(4, 35, 55);
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            if (formHijo != null)
            {
                //Al abrir un formulario cerramos el formulario anterior
                formHijo.Close();
                Reset();
            }
        }
        private void Reset()
        {
            resaltarBoton();
            bordeIzquierdobtn.Visible = false;
            iconTitulo.IconChar = IconChar.Home;
            iconTitulo.IconColor = Color.FromArgb(4, 35, 55);
            lblTitulo.Text = "Inicio";
        }
        //Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Computadora> computadoras = logica.ObtenerComputadoras();
                //dataGridView1.DataSource = computadoras;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, almacenarRGB.color1);
            formularioHijo(new Ventas());
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, almacenarRGB.color1);
            formularioHijo(new Inventario());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, almacenarRGB.color1);
            formularioHijo(new Clientes());
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, almacenarRGB.color1);
            formularioHijo(new Empleados());
        }

        private void BtnComputadoras_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, almacenarRGB.color1);
            formularioHijo(new Computadoras());
        }

        private void BtnTarjetaMadre_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, almacenarRGB.color1);
            formularioHijo(new Tarjetas_Madre());
        }

        private void BtnProcesadores_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, almacenarRGB.color1);
            formularioHijo(new Procesadores());
        }

        private void BtnGrafica_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, almacenarRGB.color1);
            formularioHijo(new Graficas());
        }

        private void BtnRam_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, almacenarRGB.color1);
            formularioHijo(new RAM());

        }

        private void BtnAlmacenamiento_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, almacenarRGB.color1);
            formularioHijo(new Almacenamiento());
        }

        private void BtnFuenteDePoder_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, almacenarRGB.color1);
            formularioHijo(new Fuentes_De_Poder());
        }

        private void BtnInicio_Click_1(object sender, EventArgs e)
        {
            if (formHijo != null)
            {
                //Al abrir un formulario cerramos el formulario anterior
                formHijo.Close();
                Reset();
            }
        }

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
