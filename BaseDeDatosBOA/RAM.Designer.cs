namespace BaseDeDatosBOA
{
    partial class RAM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnConsulta = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVelocidadTrans = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnInsertar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.txtTamaño = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFrecuencia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTipoRam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdRam = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvRam = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnVerificar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRam)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Controls.Add(this.btnConsulta);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1031, 35);
            this.flowLayoutPanel1.TabIndex = 49;
            // 
            // btnEliminar
            // 
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Image = global::BaseDeDatosBOA.Properties.Resources.eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(3, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.PressedState.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(41, 30);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.CheckedState.Parent = this.btnConsulta;
            this.btnConsulta.HoverState.Parent = this.btnConsulta;
            this.btnConsulta.Image = global::BaseDeDatosBOA.Properties.Resources.lupa;
            this.btnConsulta.Location = new System.Drawing.Point(50, 3);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.PressedState.Parent = this.btnConsulta;
            this.btnConsulta.Size = new System.Drawing.Size(41, 30);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.CheckedState.Parent = this.btnActualizar;
            this.btnActualizar.HoverState.Parent = this.btnActualizar;
            this.btnActualizar.Image = global::BaseDeDatosBOA.Properties.Resources.recargar;
            this.btnActualizar.Location = new System.Drawing.Point(97, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.PressedState.Parent = this.btnActualizar;
            this.btnActualizar.Size = new System.Drawing.Size(41, 30);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(708, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 18);
            this.label6.TabIndex = 46;
            this.label6.Text = "VelocidadTransferencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(809, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tamaño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(782, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Frecuencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(803, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "TipoRam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(823, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(822, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "IdRam";
            // 
            // txtVelocidadTrans
            // 
            this.txtVelocidadTrans.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtVelocidadTrans.BorderThickness = 3;
            this.txtVelocidadTrans.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVelocidadTrans.DefaultText = "";
            this.txtVelocidadTrans.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVelocidadTrans.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVelocidadTrans.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVelocidadTrans.DisabledState.Parent = this.txtVelocidadTrans;
            this.txtVelocidadTrans.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVelocidadTrans.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVelocidadTrans.FocusedState.Parent = this.txtVelocidadTrans;
            this.txtVelocidadTrans.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVelocidadTrans.HoverState.Parent = this.txtVelocidadTrans;
            this.txtVelocidadTrans.Location = new System.Drawing.Point(910, 305);
            this.txtVelocidadTrans.Name = "txtVelocidadTrans";
            this.txtVelocidadTrans.PasswordChar = '\0';
            this.txtVelocidadTrans.PlaceholderText = "";
            this.txtVelocidadTrans.SelectedText = "";
            this.txtVelocidadTrans.ShadowDecoration.Parent = this.txtVelocidadTrans;
            this.txtVelocidadTrans.Size = new System.Drawing.Size(86, 31);
            this.txtVelocidadTrans.TabIndex = 38;
            this.txtVelocidadTrans.TextChanged += new System.EventHandler(this.txtVelocidadTrans_TextChanged);
            this.txtVelocidadTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrecuencia_KeyPress);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.btnInsertar.BorderRadius = 15;
            this.btnInsertar.BorderThickness = 3;
            this.btnInsertar.CheckedState.Parent = this.btnInsertar;
            this.btnInsertar.CustomImages.Parent = this.btnInsertar;
            this.btnInsertar.Enabled = false;
            this.btnInsertar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(89)))), ((int)(((byte)(97)))));
            this.btnInsertar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.HoverState.Parent = this.btnInsertar;
            this.btnInsertar.Location = new System.Drawing.Point(713, 481);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.ShadowDecoration.Parent = this.btnInsertar;
            this.btnInsertar.Size = new System.Drawing.Size(149, 44);
            this.btnInsertar.TabIndex = 37;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.btnModificar.BorderRadius = 15;
            this.btnModificar.BorderThickness = 3;
            this.btnModificar.CheckedState.Parent = this.btnModificar;
            this.btnModificar.CustomImages.Parent = this.btnModificar;
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(89)))), ((int)(((byte)(97)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.HoverState.Parent = this.btnModificar;
            this.btnModificar.Location = new System.Drawing.Point(870, 481);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(149, 44);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtTamaño
            // 
            this.txtTamaño.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtTamaño.BorderThickness = 3;
            this.txtTamaño.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTamaño.DefaultText = "";
            this.txtTamaño.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTamaño.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTamaño.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTamaño.DisabledState.Parent = this.txtTamaño;
            this.txtTamaño.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTamaño.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTamaño.FocusedState.Parent = this.txtTamaño;
            this.txtTamaño.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTamaño.HoverState.Parent = this.txtTamaño;
            this.txtTamaño.Location = new System.Drawing.Point(886, 258);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.PasswordChar = '\0';
            this.txtTamaño.PlaceholderText = "";
            this.txtTamaño.SelectedText = "";
            this.txtTamaño.ShadowDecoration.Parent = this.txtTamaño;
            this.txtTamaño.Size = new System.Drawing.Size(110, 31);
            this.txtTamaño.TabIndex = 35;
            this.txtTamaño.TextChanged += new System.EventHandler(this.txtTamaño_TextChanged);
            this.txtTamaño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrecuencia_KeyPress);
            // 
            // txtFrecuencia
            // 
            this.txtFrecuencia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtFrecuencia.BorderThickness = 3;
            this.txtFrecuencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrecuencia.DefaultText = "";
            this.txtFrecuencia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrecuencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrecuencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrecuencia.DisabledState.Parent = this.txtFrecuencia;
            this.txtFrecuencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrecuencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrecuencia.FocusedState.Parent = this.txtFrecuencia;
            this.txtFrecuencia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrecuencia.HoverState.Parent = this.txtFrecuencia;
            this.txtFrecuencia.Location = new System.Drawing.Point(886, 210);
            this.txtFrecuencia.Name = "txtFrecuencia";
            this.txtFrecuencia.PasswordChar = '\0';
            this.txtFrecuencia.PlaceholderText = "";
            this.txtFrecuencia.SelectedText = "";
            this.txtFrecuencia.ShadowDecoration.Parent = this.txtFrecuencia;
            this.txtFrecuencia.Size = new System.Drawing.Size(110, 31);
            this.txtFrecuencia.TabIndex = 34;
            this.txtFrecuencia.TextChanged += new System.EventHandler(this.txtFrecuencia_TextChanged);
            this.txtFrecuencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrecuencia_KeyPress);
            // 
            // txtTipoRam
            // 
            this.txtTipoRam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtTipoRam.BorderThickness = 3;
            this.txtTipoRam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoRam.DefaultText = "";
            this.txtTipoRam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTipoRam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTipoRam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTipoRam.DisabledState.Parent = this.txtTipoRam;
            this.txtTipoRam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTipoRam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipoRam.FocusedState.Parent = this.txtTipoRam;
            this.txtTipoRam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipoRam.HoverState.Parent = this.txtTipoRam;
            this.txtTipoRam.Location = new System.Drawing.Point(886, 164);
            this.txtTipoRam.Name = "txtTipoRam";
            this.txtTipoRam.PasswordChar = '\0';
            this.txtTipoRam.PlaceholderText = "";
            this.txtTipoRam.SelectedText = "";
            this.txtTipoRam.ShadowDecoration.Parent = this.txtTipoRam;
            this.txtTipoRam.Size = new System.Drawing.Size(110, 31);
            this.txtTipoRam.TabIndex = 33;
            this.txtTipoRam.TextChanged += new System.EventHandler(this.txtTipoRam_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtMarca.BorderThickness = 3;
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.DefaultText = "";
            this.txtMarca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarca.DisabledState.Parent = this.txtMarca;
            this.txtMarca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarca.FocusedState.Parent = this.txtMarca;
            this.txtMarca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarca.HoverState.Parent = this.txtMarca;
            this.txtMarca.Location = new System.Drawing.Point(886, 115);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.PlaceholderText = "";
            this.txtMarca.SelectedText = "";
            this.txtMarca.ShadowDecoration.Parent = this.txtMarca;
            this.txtMarca.Size = new System.Drawing.Size(110, 31);
            this.txtMarca.TabIndex = 32;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtIdRam
            // 
            this.txtIdRam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtIdRam.BorderThickness = 3;
            this.txtIdRam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdRam.DefaultText = "";
            this.txtIdRam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdRam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdRam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdRam.DisabledState.Parent = this.txtIdRam;
            this.txtIdRam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdRam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdRam.FocusedState.Parent = this.txtIdRam;
            this.txtIdRam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdRam.HoverState.Parent = this.txtIdRam;
            this.txtIdRam.Location = new System.Drawing.Point(886, 68);
            this.txtIdRam.Name = "txtIdRam";
            this.txtIdRam.PasswordChar = '\0';
            this.txtIdRam.PlaceholderText = "";
            this.txtIdRam.SelectedText = "";
            this.txtIdRam.ShadowDecoration.Parent = this.txtIdRam;
            this.txtIdRam.Size = new System.Drawing.Size(74, 31);
            this.txtIdRam.TabIndex = 31;
            this.txtIdRam.TextChanged += new System.EventHandler(this.txtIdRam_TextChanged);
            // 
            // dgvRam
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRam.BackgroundColor = System.Drawing.Color.White;
            this.dgvRam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRam.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRam.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRam.EnableHeadersVisualStyles = false;
            this.dgvRam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRam.Location = new System.Drawing.Point(27, 68);
            this.dgvRam.Name = "dgvRam";
            this.dgvRam.RowHeadersVisible = false;
            this.dgvRam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRam.Size = new System.Drawing.Size(680, 501);
            this.dgvRam.TabIndex = 30;
            this.dgvRam.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvRam.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRam.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRam.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRam.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRam.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRam.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRam.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRam.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRam.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRam.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRam.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRam.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRam.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvRam.ThemeStyle.ReadOnly = false;
            this.dgvRam.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRam.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRam.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRam.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRam.ThemeStyle.RowsStyle.Height = 22;
            this.dgvRam.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRam.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnVerificar
            // 
            this.btnVerificar.CheckedState.Parent = this.btnVerificar;
            this.btnVerificar.HoverState.Parent = this.btnVerificar;
            this.btnVerificar.Image = global::BaseDeDatosBOA.Properties.Resources.cheque;
            this.btnVerificar.ImageSize = new System.Drawing.Size(25, 25);
            this.btnVerificar.Location = new System.Drawing.Point(966, 68);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.PressedState.Parent = this.btnVerificar;
            this.btnVerificar.Size = new System.Drawing.Size(30, 29);
            this.btnVerificar.TabIndex = 50;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // RAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(252)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1031, 575);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVelocidadTrans);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.txtFrecuencia);
            this.Controls.Add(this.txtTipoRam);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtIdRam);
            this.Controls.Add(this.dgvRam);
            this.Name = "RAM";
            this.Text = "RAM";
            this.Load += new System.EventHandler(this.RAM_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnEliminar;
        private Guna.UI2.WinForms.Guna2ImageButton btnConsulta;
        private Guna.UI2.WinForms.Guna2ImageButton btnActualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtVelocidadTrans;
        private Guna.UI2.WinForms.Guna2Button btnInsertar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2TextBox txtTamaño;
        private Guna.UI2.WinForms.Guna2TextBox txtFrecuencia;
        private Guna.UI2.WinForms.Guna2TextBox txtTipoRam;
        private Guna.UI2.WinForms.Guna2TextBox txtMarca;
        private Guna.UI2.WinForms.Guna2TextBox txtIdRam;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRam;
        private Guna.UI2.WinForms.Guna2ImageButton btnVerificar;
    }
}