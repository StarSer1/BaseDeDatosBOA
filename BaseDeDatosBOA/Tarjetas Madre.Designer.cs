namespace BaseDeDatosBOA
{
    partial class Tarjetas_Madre
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
            this.txtDimensiones = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnInsertar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.txtSocket = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRanurasDIMM = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdModelo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdTarjetaMadre = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvTarjetasMadre = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnVerificar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetasMadre)).BeginInit();
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
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(746, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 46;
            this.label6.Text = "Dimensiones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(786, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Socket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(737, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "RanurasDIMM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(783, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(791, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(735, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "IdTarjetaMadre";
            // 
            // txtDimensiones
            // 
            this.txtDimensiones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDimensiones.DefaultText = "";
            this.txtDimensiones.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDimensiones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDimensiones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDimensiones.DisabledState.Parent = this.txtDimensiones;
            this.txtDimensiones.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDimensiones.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDimensiones.FocusedState.Parent = this.txtDimensiones;
            this.txtDimensiones.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDimensiones.HoverState.Parent = this.txtDimensiones;
            this.txtDimensiones.Location = new System.Drawing.Point(847, 305);
            this.txtDimensiones.Name = "txtDimensiones";
            this.txtDimensiones.PasswordChar = '\0';
            this.txtDimensiones.PlaceholderText = "";
            this.txtDimensiones.SelectedText = "";
            this.txtDimensiones.ShadowDecoration.Parent = this.txtDimensiones;
            this.txtDimensiones.Size = new System.Drawing.Size(149, 31);
            this.txtDimensiones.TabIndex = 38;
            this.txtDimensiones.TextChanged += new System.EventHandler(this.txtDimensiones_TextChanged);
            // 
            // btnInsertar
            // 
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
            // txtSocket
            // 
            this.txtSocket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSocket.DefaultText = "";
            this.txtSocket.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSocket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSocket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSocket.DisabledState.Parent = this.txtSocket;
            this.txtSocket.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSocket.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSocket.FocusedState.Parent = this.txtSocket;
            this.txtSocket.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSocket.HoverState.Parent = this.txtSocket;
            this.txtSocket.Location = new System.Drawing.Point(847, 258);
            this.txtSocket.Name = "txtSocket";
            this.txtSocket.PasswordChar = '\0';
            this.txtSocket.PlaceholderText = "";
            this.txtSocket.SelectedText = "";
            this.txtSocket.ShadowDecoration.Parent = this.txtSocket;
            this.txtSocket.Size = new System.Drawing.Size(149, 31);
            this.txtSocket.TabIndex = 35;
            this.txtSocket.TextChanged += new System.EventHandler(this.txtSocket_TextChanged);
            // 
            // txtRanurasDIMM
            // 
            this.txtRanurasDIMM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRanurasDIMM.DefaultText = "";
            this.txtRanurasDIMM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRanurasDIMM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRanurasDIMM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRanurasDIMM.DisabledState.Parent = this.txtRanurasDIMM;
            this.txtRanurasDIMM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRanurasDIMM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRanurasDIMM.FocusedState.Parent = this.txtRanurasDIMM;
            this.txtRanurasDIMM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRanurasDIMM.HoverState.Parent = this.txtRanurasDIMM;
            this.txtRanurasDIMM.Location = new System.Drawing.Point(847, 210);
            this.txtRanurasDIMM.Name = "txtRanurasDIMM";
            this.txtRanurasDIMM.PasswordChar = '\0';
            this.txtRanurasDIMM.PlaceholderText = "";
            this.txtRanurasDIMM.SelectedText = "";
            this.txtRanurasDIMM.ShadowDecoration.Parent = this.txtRanurasDIMM;
            this.txtRanurasDIMM.Size = new System.Drawing.Size(149, 31);
            this.txtRanurasDIMM.TabIndex = 34;
            this.txtRanurasDIMM.TextChanged += new System.EventHandler(this.txtRanurasDIMM_TextChanged);
            this.txtRanurasDIMM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRanurasDIMM_KeyPress);
            // 
            // txtIdModelo
            // 
            this.txtIdModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdModelo.DefaultText = "";
            this.txtIdModelo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdModelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdModelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdModelo.DisabledState.Parent = this.txtIdModelo;
            this.txtIdModelo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdModelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdModelo.FocusedState.Parent = this.txtIdModelo;
            this.txtIdModelo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdModelo.HoverState.Parent = this.txtIdModelo;
            this.txtIdModelo.Location = new System.Drawing.Point(847, 164);
            this.txtIdModelo.Name = "txtIdModelo";
            this.txtIdModelo.PasswordChar = '\0';
            this.txtIdModelo.PlaceholderText = "";
            this.txtIdModelo.SelectedText = "";
            this.txtIdModelo.ShadowDecoration.Parent = this.txtIdModelo;
            this.txtIdModelo.Size = new System.Drawing.Size(149, 31);
            this.txtIdModelo.TabIndex = 33;
            this.txtIdModelo.TextChanged += new System.EventHandler(this.txtIdModelo_TextChanged);
            // 
            // txtMarca
            // 
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
            this.txtMarca.Location = new System.Drawing.Point(847, 115);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.PlaceholderText = "";
            this.txtMarca.SelectedText = "";
            this.txtMarca.ShadowDecoration.Parent = this.txtMarca;
            this.txtMarca.Size = new System.Drawing.Size(149, 31);
            this.txtMarca.TabIndex = 32;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtIdTarjetaMadre
            // 
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
            this.txtIdTarjetaMadre.Location = new System.Drawing.Point(847, 68);
            this.txtIdTarjetaMadre.Name = "txtIdTarjetaMadre";
            this.txtIdTarjetaMadre.PasswordChar = '\0';
            this.txtIdTarjetaMadre.PlaceholderText = "";
            this.txtIdTarjetaMadre.SelectedText = "";
            this.txtIdTarjetaMadre.ShadowDecoration.Parent = this.txtIdTarjetaMadre;
            this.txtIdTarjetaMadre.Size = new System.Drawing.Size(113, 31);
            this.txtIdTarjetaMadre.TabIndex = 31;
            this.txtIdTarjetaMadre.TextChanged += new System.EventHandler(this.txtIdTarjetaMadre_TextChanged);
            // 
            // dgvTarjetasMadre
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTarjetasMadre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTarjetasMadre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarjetasMadre.BackgroundColor = System.Drawing.Color.White;
            this.dgvTarjetasMadre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTarjetasMadre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTarjetasMadre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarjetasMadre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTarjetasMadre.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarjetasMadre.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTarjetasMadre.EnableHeadersVisualStyles = false;
            this.dgvTarjetasMadre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTarjetasMadre.Location = new System.Drawing.Point(27, 68);
            this.dgvTarjetasMadre.Name = "dgvTarjetasMadre";
            this.dgvTarjetasMadre.RowHeadersVisible = false;
            this.dgvTarjetasMadre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarjetasMadre.Size = new System.Drawing.Size(680, 501);
            this.dgvTarjetasMadre.TabIndex = 30;
            this.dgvTarjetasMadre.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvTarjetasMadre.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTarjetasMadre.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTarjetasMadre.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTarjetasMadre.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTarjetasMadre.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTarjetasMadre.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTarjetasMadre.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTarjetasMadre.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTarjetasMadre.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTarjetasMadre.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTarjetasMadre.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTarjetasMadre.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTarjetasMadre.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvTarjetasMadre.ThemeStyle.ReadOnly = false;
            this.dgvTarjetasMadre.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTarjetasMadre.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTarjetasMadre.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTarjetasMadre.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTarjetasMadre.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTarjetasMadre.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTarjetasMadre.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // Tarjetas_Madre
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
            this.Controls.Add(this.txtDimensiones);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtSocket);
            this.Controls.Add(this.txtRanurasDIMM);
            this.Controls.Add(this.txtIdModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtIdTarjetaMadre);
            this.Controls.Add(this.dgvTarjetasMadre);
            this.Name = "Tarjetas_Madre";
            this.Text = "Tarjetas_Madre";
            this.Load += new System.EventHandler(this.Tarjetas_Madre_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetasMadre)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox txtDimensiones;
        private Guna.UI2.WinForms.Guna2Button btnInsertar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2TextBox txtSocket;
        private Guna.UI2.WinForms.Guna2TextBox txtRanurasDIMM;
        private Guna.UI2.WinForms.Guna2TextBox txtIdModelo;
        private Guna.UI2.WinForms.Guna2TextBox txtMarca;
        private Guna.UI2.WinForms.Guna2TextBox txtIdTarjetaMadre;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTarjetasMadre;
        private Guna.UI2.WinForms.Guna2ImageButton btnVerificar;
    }
}