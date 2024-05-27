namespace BaseDeDatosBOA
{
    partial class Computadoras
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdFuentePoder = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdTarjetaMadre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnInsertar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdAlmacenamiento = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdProcesador = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdRam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtModelo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdComputadora = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvComputadora = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtIdGrafica = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVerificar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputadora)).BeginInit();
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
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click_1);
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
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(727, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "IdFuentePoder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(723, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "IdTarjetaMadre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(713, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Almacenamiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(735, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "IdProcesador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(788, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "IdRam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(783, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(722, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "IdComputadora";
            // 
            // txtIdFuentePoder
            // 
            this.txtIdFuentePoder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtIdFuentePoder.BorderThickness = 3;
            this.txtIdFuentePoder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdFuentePoder.DefaultText = "";
            this.txtIdFuentePoder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdFuentePoder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdFuentePoder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdFuentePoder.DisabledState.Parent = this.txtIdFuentePoder;
            this.txtIdFuentePoder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdFuentePoder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdFuentePoder.FocusedState.Parent = this.txtIdFuentePoder;
            this.txtIdFuentePoder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdFuentePoder.HoverState.Parent = this.txtIdFuentePoder;
            this.txtIdFuentePoder.Location = new System.Drawing.Point(847, 404);
            this.txtIdFuentePoder.Name = "txtIdFuentePoder";
            this.txtIdFuentePoder.PasswordChar = '\0';
            this.txtIdFuentePoder.PlaceholderText = "";
            this.txtIdFuentePoder.SelectedText = "";
            this.txtIdFuentePoder.ShadowDecoration.Parent = this.txtIdFuentePoder;
            this.txtIdFuentePoder.Size = new System.Drawing.Size(149, 31);
            this.txtIdFuentePoder.TabIndex = 39;
            this.txtIdFuentePoder.TextChanged += new System.EventHandler(this.txtIdFuentePoder_TextChanged);
            // 
            // txtIdTarjetaMadre
            // 
            this.txtIdTarjetaMadre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtIdTarjetaMadre.BorderThickness = 3;
            this.txtIdTarjetaMadre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdTarjetaMadre.DefaultText = "";
            this.txtIdTarjetaMadre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdTarjetaMadre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdTarjetaMadre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdTarjetaMadre.DisabledState.Parent = this.txtIdTarjetaMadre;
            this.txtIdTarjetaMadre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdTarjetaMadre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdTarjetaMadre.FocusedState.Parent = this.txtIdTarjetaMadre;
            this.txtIdTarjetaMadre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdTarjetaMadre.HoverState.Parent = this.txtIdTarjetaMadre;
            this.txtIdTarjetaMadre.Location = new System.Drawing.Point(847, 350);
            this.txtIdTarjetaMadre.Name = "txtIdTarjetaMadre";
            this.txtIdTarjetaMadre.PasswordChar = '\0';
            this.txtIdTarjetaMadre.PlaceholderText = "";
            this.txtIdTarjetaMadre.SelectedText = "";
            this.txtIdTarjetaMadre.ShadowDecoration.Parent = this.txtIdTarjetaMadre;
            this.txtIdTarjetaMadre.Size = new System.Drawing.Size(149, 31);
            this.txtIdTarjetaMadre.TabIndex = 38;
            this.txtIdTarjetaMadre.TextChanged += new System.EventHandler(this.txtIdTarjetaMadre_TextChanged);
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
            // txtIdAlmacenamiento
            // 
            this.txtIdAlmacenamiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtIdAlmacenamiento.BorderThickness = 3;
            this.txtIdAlmacenamiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdAlmacenamiento.DefaultText = "";
            this.txtIdAlmacenamiento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdAlmacenamiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdAlmacenamiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdAlmacenamiento.DisabledState.Parent = this.txtIdAlmacenamiento;
            this.txtIdAlmacenamiento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdAlmacenamiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdAlmacenamiento.FocusedState.Parent = this.txtIdAlmacenamiento;
            this.txtIdAlmacenamiento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdAlmacenamiento.HoverState.Parent = this.txtIdAlmacenamiento;
            this.txtIdAlmacenamiento.Location = new System.Drawing.Point(847, 303);
            this.txtIdAlmacenamiento.Name = "txtIdAlmacenamiento";
            this.txtIdAlmacenamiento.PasswordChar = '\0';
            this.txtIdAlmacenamiento.PlaceholderText = "";
            this.txtIdAlmacenamiento.SelectedText = "";
            this.txtIdAlmacenamiento.ShadowDecoration.Parent = this.txtIdAlmacenamiento;
            this.txtIdAlmacenamiento.Size = new System.Drawing.Size(149, 31);
            this.txtIdAlmacenamiento.TabIndex = 35;
            this.txtIdAlmacenamiento.TextChanged += new System.EventHandler(this.txtIdAlmacenamiento_TextChanged);
            // 
            // txtIdProcesador
            // 
            this.txtIdProcesador.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtIdProcesador.BorderThickness = 3;
            this.txtIdProcesador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdProcesador.DefaultText = "";
            this.txtIdProcesador.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdProcesador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdProcesador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdProcesador.DisabledState.Parent = this.txtIdProcesador;
            this.txtIdProcesador.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdProcesador.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdProcesador.FocusedState.Parent = this.txtIdProcesador;
            this.txtIdProcesador.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdProcesador.HoverState.Parent = this.txtIdProcesador;
            this.txtIdProcesador.Location = new System.Drawing.Point(847, 210);
            this.txtIdProcesador.Name = "txtIdProcesador";
            this.txtIdProcesador.PasswordChar = '\0';
            this.txtIdProcesador.PlaceholderText = "";
            this.txtIdProcesador.SelectedText = "";
            this.txtIdProcesador.ShadowDecoration.Parent = this.txtIdProcesador;
            this.txtIdProcesador.Size = new System.Drawing.Size(149, 31);
            this.txtIdProcesador.TabIndex = 34;
            this.txtIdProcesador.TextChanged += new System.EventHandler(this.txtIdProcesador_TextChanged);
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
            this.txtIdRam.Location = new System.Drawing.Point(847, 164);
            this.txtIdRam.Name = "txtIdRam";
            this.txtIdRam.PasswordChar = '\0';
            this.txtIdRam.PlaceholderText = "";
            this.txtIdRam.SelectedText = "";
            this.txtIdRam.ShadowDecoration.Parent = this.txtIdRam;
            this.txtIdRam.Size = new System.Drawing.Size(149, 31);
            this.txtIdRam.TabIndex = 33;
            this.txtIdRam.TextChanged += new System.EventHandler(this.txtIdRam_TextChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtModelo.BorderThickness = 3;
            this.txtModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelo.DefaultText = "";
            this.txtModelo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtModelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtModelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModelo.DisabledState.Parent = this.txtModelo;
            this.txtModelo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModelo.FocusedState.Parent = this.txtModelo;
            this.txtModelo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModelo.HoverState.Parent = this.txtModelo;
            this.txtModelo.Location = new System.Drawing.Point(847, 115);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.PlaceholderText = "";
            this.txtModelo.SelectedText = "";
            this.txtModelo.ShadowDecoration.Parent = this.txtModelo;
            this.txtModelo.Size = new System.Drawing.Size(149, 31);
            this.txtModelo.TabIndex = 32;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // txtIdComputadora
            // 
            this.txtIdComputadora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtIdComputadora.BorderThickness = 3;
            this.txtIdComputadora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdComputadora.DefaultText = "";
            this.txtIdComputadora.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdComputadora.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdComputadora.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdComputadora.DisabledState.Parent = this.txtIdComputadora;
            this.txtIdComputadora.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdComputadora.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdComputadora.FocusedState.Parent = this.txtIdComputadora;
            this.txtIdComputadora.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdComputadora.HoverState.Parent = this.txtIdComputadora;
            this.txtIdComputadora.Location = new System.Drawing.Point(847, 68);
            this.txtIdComputadora.Name = "txtIdComputadora";
            this.txtIdComputadora.PasswordChar = '\0';
            this.txtIdComputadora.PlaceholderText = "";
            this.txtIdComputadora.SelectedText = "";
            this.txtIdComputadora.ShadowDecoration.Parent = this.txtIdComputadora;
            this.txtIdComputadora.Size = new System.Drawing.Size(117, 31);
            this.txtIdComputadora.TabIndex = 31;
            this.txtIdComputadora.TextChanged += new System.EventHandler(this.txtIdComputadora_TextChanged);
            // 
            // dgvComputadora
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvComputadora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComputadora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComputadora.BackgroundColor = System.Drawing.Color.White;
            this.dgvComputadora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComputadora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvComputadora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComputadora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComputadora.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComputadora.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComputadora.EnableHeadersVisualStyles = false;
            this.dgvComputadora.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvComputadora.Location = new System.Drawing.Point(27, 68);
            this.dgvComputadora.Name = "dgvComputadora";
            this.dgvComputadora.RowHeadersVisible = false;
            this.dgvComputadora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComputadora.Size = new System.Drawing.Size(680, 501);
            this.dgvComputadora.TabIndex = 30;
            this.dgvComputadora.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvComputadora.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvComputadora.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvComputadora.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvComputadora.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvComputadora.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvComputadora.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvComputadora.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvComputadora.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvComputadora.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvComputadora.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvComputadora.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvComputadora.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvComputadora.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvComputadora.ThemeStyle.ReadOnly = false;
            this.dgvComputadora.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvComputadora.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvComputadora.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvComputadora.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvComputadora.ThemeStyle.RowsStyle.Height = 22;
            this.dgvComputadora.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvComputadora.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtIdGrafica
            // 
            this.txtIdGrafica.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtIdGrafica.BorderThickness = 3;
            this.txtIdGrafica.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdGrafica.DefaultText = "";
            this.txtIdGrafica.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdGrafica.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdGrafica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdGrafica.DisabledState.Parent = this.txtIdGrafica;
            this.txtIdGrafica.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdGrafica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdGrafica.FocusedState.Parent = this.txtIdGrafica;
            this.txtIdGrafica.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdGrafica.HoverState.Parent = this.txtIdGrafica;
            this.txtIdGrafica.Location = new System.Drawing.Point(847, 256);
            this.txtIdGrafica.Name = "txtIdGrafica";
            this.txtIdGrafica.PasswordChar = '\0';
            this.txtIdGrafica.PlaceholderText = "";
            this.txtIdGrafica.SelectedText = "";
            this.txtIdGrafica.ShadowDecoration.Parent = this.txtIdGrafica;
            this.txtIdGrafica.Size = new System.Drawing.Size(149, 31);
            this.txtIdGrafica.TabIndex = 35;
            this.txtIdGrafica.TextChanged += new System.EventHandler(this.txtIdGrafica_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(766, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "IdGrafica";
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
            // Computadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(252)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1031, 575);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdFuentePoder);
            this.Controls.Add(this.txtIdTarjetaMadre);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtIdGrafica);
            this.Controls.Add(this.txtIdAlmacenamiento);
            this.Controls.Add(this.txtIdProcesador);
            this.Controls.Add(this.txtIdRam);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtIdComputadora);
            this.Controls.Add(this.dgvComputadora);
            this.Name = "Computadoras";
            this.Text = "Computadoras";
            this.Load += new System.EventHandler(this.Computadoras_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnEliminar;
        private Guna.UI2.WinForms.Guna2ImageButton btnConsulta;
        private Guna.UI2.WinForms.Guna2ImageButton btnActualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtIdFuentePoder;
        private Guna.UI2.WinForms.Guna2TextBox txtIdTarjetaMadre;
        private Guna.UI2.WinForms.Guna2Button btnInsertar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2TextBox txtIdAlmacenamiento;
        private Guna.UI2.WinForms.Guna2TextBox txtIdProcesador;
        private Guna.UI2.WinForms.Guna2TextBox txtIdRam;
        private Guna.UI2.WinForms.Guna2TextBox txtModelo;
        private Guna.UI2.WinForms.Guna2TextBox txtIdComputadora;
        private Guna.UI2.WinForms.Guna2DataGridView dgvComputadora;
        private Guna.UI2.WinForms.Guna2TextBox txtIdGrafica;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ImageButton btnVerificar;
    }
}