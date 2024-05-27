namespace BaseDeDatosBOA
{
    partial class Fuentes_De_Poder
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.txtCertificacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTipo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPotencia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdFuentePoder = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvFuentesDePoder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtModelo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVerificar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuentesDePoder)).BeginInit();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(734, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Certificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(802, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(765, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Potencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(786, 121);
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
            this.label1.Location = new System.Drawing.Point(717, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "IdFuentePoder";
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
            // txtCertificacion
            // 
            this.txtCertificacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtCertificacion.BorderThickness = 3;
            this.txtCertificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCertificacion.DefaultText = "";
            this.txtCertificacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCertificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCertificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCertificacion.DisabledState.Parent = this.txtCertificacion;
            this.txtCertificacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCertificacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCertificacion.FocusedState.Parent = this.txtCertificacion;
            this.txtCertificacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCertificacion.HoverState.Parent = this.txtCertificacion;
            this.txtCertificacion.Location = new System.Drawing.Point(848, 307);
            this.txtCertificacion.Name = "txtCertificacion";
            this.txtCertificacion.PasswordChar = '\0';
            this.txtCertificacion.PlaceholderText = "";
            this.txtCertificacion.SelectedText = "";
            this.txtCertificacion.ShadowDecoration.Parent = this.txtCertificacion;
            this.txtCertificacion.Size = new System.Drawing.Size(149, 31);
            this.txtCertificacion.TabIndex = 35;
            this.txtCertificacion.TextChanged += new System.EventHandler(this.txtCertificacion_TextChanged);
            // 
            // txtTipo
            // 
            this.txtTipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtTipo.BorderThickness = 3;
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.DefaultText = "";
            this.txtTipo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTipo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTipo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTipo.DisabledState.Parent = this.txtTipo;
            this.txtTipo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipo.FocusedState.Parent = this.txtTipo;
            this.txtTipo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipo.HoverState.Parent = this.txtTipo;
            this.txtTipo.Location = new System.Drawing.Point(848, 259);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.PasswordChar = '\0';
            this.txtTipo.PlaceholderText = "";
            this.txtTipo.SelectedText = "";
            this.txtTipo.ShadowDecoration.Parent = this.txtTipo;
            this.txtTipo.Size = new System.Drawing.Size(149, 31);
            this.txtTipo.TabIndex = 34;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // txtPotencia
            // 
            this.txtPotencia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.txtPotencia.BorderThickness = 3;
            this.txtPotencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPotencia.DefaultText = "";
            this.txtPotencia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPotencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPotencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPotencia.DisabledState.Parent = this.txtPotencia;
            this.txtPotencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPotencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPotencia.FocusedState.Parent = this.txtPotencia;
            this.txtPotencia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPotencia.HoverState.Parent = this.txtPotencia;
            this.txtPotencia.Location = new System.Drawing.Point(848, 213);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.PasswordChar = '\0';
            this.txtPotencia.PlaceholderText = "";
            this.txtPotencia.SelectedText = "";
            this.txtPotencia.ShadowDecoration.Parent = this.txtPotencia;
            this.txtPotencia.Size = new System.Drawing.Size(149, 31);
            this.txtPotencia.TabIndex = 33;
            this.txtPotencia.TextChanged += new System.EventHandler(this.txtPotencia_TextChanged);
            this.txtPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPotencia_KeyPress);
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
            this.txtMarca.Location = new System.Drawing.Point(848, 115);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.PlaceholderText = "";
            this.txtMarca.SelectedText = "";
            this.txtMarca.ShadowDecoration.Parent = this.txtMarca;
            this.txtMarca.Size = new System.Drawing.Size(149, 31);
            this.txtMarca.TabIndex = 32;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
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
            this.txtIdFuentePoder.Location = new System.Drawing.Point(848, 68);
            this.txtIdFuentePoder.Name = "txtIdFuentePoder";
            this.txtIdFuentePoder.PasswordChar = '\0';
            this.txtIdFuentePoder.PlaceholderText = "";
            this.txtIdFuentePoder.SelectedText = "";
            this.txtIdFuentePoder.ShadowDecoration.Parent = this.txtIdFuentePoder;
            this.txtIdFuentePoder.Size = new System.Drawing.Size(113, 31);
            this.txtIdFuentePoder.TabIndex = 31;
            this.txtIdFuentePoder.TextChanged += new System.EventHandler(this.txtIdFuentePoder_TextChanged);
            // 
            // dgvFuentesDePoder
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFuentesDePoder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuentesDePoder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuentesDePoder.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuentesDePoder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFuentesDePoder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFuentesDePoder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuentesDePoder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFuentesDePoder.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuentesDePoder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFuentesDePoder.EnableHeadersVisualStyles = false;
            this.dgvFuentesDePoder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFuentesDePoder.Location = new System.Drawing.Point(27, 68);
            this.dgvFuentesDePoder.Name = "dgvFuentesDePoder";
            this.dgvFuentesDePoder.RowHeadersVisible = false;
            this.dgvFuentesDePoder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuentesDePoder.Size = new System.Drawing.Size(680, 501);
            this.dgvFuentesDePoder.TabIndex = 30;
            this.dgvFuentesDePoder.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvFuentesDePoder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFuentesDePoder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFuentesDePoder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFuentesDePoder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFuentesDePoder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFuentesDePoder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFuentesDePoder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFuentesDePoder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvFuentesDePoder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFuentesDePoder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFuentesDePoder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFuentesDePoder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFuentesDePoder.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvFuentesDePoder.ThemeStyle.ReadOnly = false;
            this.dgvFuentesDePoder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFuentesDePoder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFuentesDePoder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFuentesDePoder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFuentesDePoder.ThemeStyle.RowsStyle.Height = 22;
            this.dgvFuentesDePoder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFuentesDePoder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.txtModelo.Location = new System.Drawing.Point(848, 163);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.PlaceholderText = "";
            this.txtModelo.SelectedText = "";
            this.txtModelo.ShadowDecoration.Parent = this.txtModelo;
            this.txtModelo.Size = new System.Drawing.Size(149, 31);
            this.txtModelo.TabIndex = 33;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(779, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Modelo";
            // 
            // btnVerificar
            // 
            this.btnVerificar.CheckedState.Parent = this.btnVerificar;
            this.btnVerificar.HoverState.Parent = this.btnVerificar;
            this.btnVerificar.Image = global::BaseDeDatosBOA.Properties.Resources.cheque;
            this.btnVerificar.ImageSize = new System.Drawing.Size(25, 25);
            this.btnVerificar.Location = new System.Drawing.Point(967, 68);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.PressedState.Parent = this.btnVerificar;
            this.btnVerificar.Size = new System.Drawing.Size(30, 29);
            this.btnVerificar.TabIndex = 50;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Fuentes_De_Poder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(252)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1031, 575);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtCertificacion);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtIdFuentePoder);
            this.Controls.Add(this.dgvFuentesDePoder);
            this.Name = "Fuentes_De_Poder";
            this.Text = "Fuentes_De_Poder";
            this.Load += new System.EventHandler(this.Fuentes_De_Poder_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuentesDePoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnEliminar;
        private Guna.UI2.WinForms.Guna2ImageButton btnConsulta;
        private Guna.UI2.WinForms.Guna2ImageButton btnActualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnInsertar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2TextBox txtCertificacion;
        private Guna.UI2.WinForms.Guna2TextBox txtTipo;
        private Guna.UI2.WinForms.Guna2TextBox txtPotencia;
        private Guna.UI2.WinForms.Guna2TextBox txtMarca;
        private Guna.UI2.WinForms.Guna2TextBox txtIdFuentePoder;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFuentesDePoder;
        private Guna.UI2.WinForms.Guna2TextBox txtModelo;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ImageButton btnVerificar;
    }
}