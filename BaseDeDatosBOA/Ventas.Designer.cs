namespace BaseDeDatosBOA
{
    partial class Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVentas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtIdVenta = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdEmp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdComp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFecha = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnInsertar = new Guna.UI2.WinForms.Guna2Button();
            this.txtPrecioF = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecioB = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEliminarVenta = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentas.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVentas.Location = new System.Drawing.Point(12, 61);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(680, 457);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvVentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVentas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVentas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVentas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVentas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVentas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVentas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvVentas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvVentas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVentas.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvVentas.ThemeStyle.ReadOnly = false;
            this.dgvVentas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVentas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvVentas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVentas.ThemeStyle.RowsStyle.Height = 22;
            this.dgvVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVentas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdVenta.DefaultText = "";
            this.txtIdVenta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdVenta.DisabledState.Parent = this.txtIdVenta;
            this.txtIdVenta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdVenta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdVenta.FocusedState.Parent = this.txtIdVenta;
            this.txtIdVenta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdVenta.HoverState.Parent = this.txtIdVenta;
            this.txtIdVenta.Location = new System.Drawing.Point(832, 77);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.PasswordChar = '\0';
            this.txtIdVenta.PlaceholderText = "";
            this.txtIdVenta.SelectedText = "";
            this.txtIdVenta.ShadowDecoration.Parent = this.txtIdVenta;
            this.txtIdVenta.Size = new System.Drawing.Size(160, 31);
            this.txtIdVenta.TabIndex = 1;
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdEmp.DefaultText = "";
            this.txtIdEmp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdEmp.DisabledState.Parent = this.txtIdEmp;
            this.txtIdEmp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdEmp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdEmp.FocusedState.Parent = this.txtIdEmp;
            this.txtIdEmp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdEmp.HoverState.Parent = this.txtIdEmp;
            this.txtIdEmp.Location = new System.Drawing.Point(832, 124);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.PasswordChar = '\0';
            this.txtIdEmp.PlaceholderText = "";
            this.txtIdEmp.SelectedText = "";
            this.txtIdEmp.ShadowDecoration.Parent = this.txtIdEmp;
            this.txtIdEmp.Size = new System.Drawing.Size(160, 31);
            this.txtIdEmp.TabIndex = 2;
            // 
            // txtIdComp
            // 
            this.txtIdComp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdComp.DefaultText = "";
            this.txtIdComp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdComp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdComp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdComp.DisabledState.Parent = this.txtIdComp;
            this.txtIdComp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdComp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdComp.FocusedState.Parent = this.txtIdComp;
            this.txtIdComp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdComp.HoverState.Parent = this.txtIdComp;
            this.txtIdComp.Location = new System.Drawing.Point(832, 173);
            this.txtIdComp.Name = "txtIdComp";
            this.txtIdComp.PasswordChar = '\0';
            this.txtIdComp.PlaceholderText = "";
            this.txtIdComp.SelectedText = "";
            this.txtIdComp.ShadowDecoration.Parent = this.txtIdComp;
            this.txtIdComp.Size = new System.Drawing.Size(160, 31);
            this.txtIdComp.TabIndex = 3;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCliente.DefaultText = "";
            this.txtIdCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCliente.DisabledState.Parent = this.txtIdCliente;
            this.txtIdCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCliente.FocusedState.Parent = this.txtIdCliente;
            this.txtIdCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCliente.HoverState.Parent = this.txtIdCliente;
            this.txtIdCliente.Location = new System.Drawing.Point(832, 219);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.PasswordChar = '\0';
            this.txtIdCliente.PlaceholderText = "";
            this.txtIdCliente.SelectedText = "";
            this.txtIdCliente.ShadowDecoration.Parent = this.txtIdCliente;
            this.txtIdCliente.Size = new System.Drawing.Size(160, 31);
            this.txtIdCliente.TabIndex = 4;
            // 
            // txtFecha
            // 
            this.txtFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFecha.DefaultText = "";
            this.txtFecha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFecha.DisabledState.Parent = this.txtFecha;
            this.txtFecha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFecha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFecha.FocusedState.Parent = this.txtFecha;
            this.txtFecha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFecha.HoverState.Parent = this.txtFecha;
            this.txtFecha.Location = new System.Drawing.Point(832, 267);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.PasswordChar = '\0';
            this.txtFecha.PlaceholderText = "";
            this.txtFecha.SelectedText = "";
            this.txtFecha.ShadowDecoration.Parent = this.txtFecha;
            this.txtFecha.Size = new System.Drawing.Size(160, 31);
            this.txtFecha.TabIndex = 5;
            // 
            // BtnModificar
            // 
            this.BtnModificar.CheckedState.Parent = this.BtnModificar;
            this.BtnModificar.CustomImages.Parent = this.BtnModificar;
            this.BtnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.HoverState.Parent = this.BtnModificar;
            this.BtnModificar.Location = new System.Drawing.Point(859, 474);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.ShadowDecoration.Parent = this.BtnModificar;
            this.BtnModificar.Size = new System.Drawing.Size(149, 44);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.CheckedState.Parent = this.BtnInsertar;
            this.BtnInsertar.CustomImages.Parent = this.BtnInsertar;
            this.BtnInsertar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnInsertar.ForeColor = System.Drawing.Color.White;
            this.BtnInsertar.HoverState.Parent = this.BtnInsertar;
            this.BtnInsertar.Location = new System.Drawing.Point(704, 474);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.ShadowDecoration.Parent = this.BtnInsertar;
            this.BtnInsertar.Size = new System.Drawing.Size(149, 44);
            this.BtnInsertar.TabIndex = 8;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // txtPrecioF
            // 
            this.txtPrecioF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioF.DefaultText = "";
            this.txtPrecioF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioF.DisabledState.Parent = this.txtPrecioF;
            this.txtPrecioF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioF.FocusedState.Parent = this.txtPrecioF;
            this.txtPrecioF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioF.HoverState.Parent = this.txtPrecioF;
            this.txtPrecioF.Location = new System.Drawing.Point(832, 314);
            this.txtPrecioF.Name = "txtPrecioF";
            this.txtPrecioF.PasswordChar = '\0';
            this.txtPrecioF.PlaceholderText = "";
            this.txtPrecioF.SelectedText = "";
            this.txtPrecioF.ShadowDecoration.Parent = this.txtPrecioF;
            this.txtPrecioF.Size = new System.Drawing.Size(160, 31);
            this.txtPrecioF.TabIndex = 9;
            // 
            // txtPrecioB
            // 
            this.txtPrecioB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioB.DefaultText = "";
            this.txtPrecioB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioB.DisabledState.Parent = this.txtPrecioB;
            this.txtPrecioB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioB.FocusedState.Parent = this.txtPrecioB;
            this.txtPrecioB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioB.HoverState.Parent = this.txtPrecioB;
            this.txtPrecioB.Location = new System.Drawing.Point(832, 362);
            this.txtPrecioB.Name = "txtPrecioB";
            this.txtPrecioB.PasswordChar = '\0';
            this.txtPrecioB.PlaceholderText = "";
            this.txtPrecioB.SelectedText = "";
            this.txtPrecioB.ShadowDecoration.Parent = this.txtPrecioB;
            this.txtPrecioB.Size = new System.Drawing.Size(160, 31);
            this.txtPrecioB.TabIndex = 10;
            // 
            // txtDesc
            // 
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.DefaultText = "";
            this.txtDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesc.DisabledState.Parent = this.txtDesc;
            this.txtDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesc.FocusedState.Parent = this.txtDesc;
            this.txtDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesc.HoverState.Parent = this.txtDesc;
            this.txtDesc.Location = new System.Drawing.Point(832, 408);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.PlaceholderText = "";
            this.txtDesc.SelectedText = "";
            this.txtDesc.ShadowDecoration.Parent = this.txtDesc;
            this.txtDesc.Size = new System.Drawing.Size(160, 31);
            this.txtDesc.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(766, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "IdVenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(736, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "IdEmpleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(712, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "IdComputadora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(758, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "IdCliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(736, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "FechaVenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(740, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "PrecioFinal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(737, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "PrecioBase";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(742, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Descuento";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.CheckedState.Parent = this.BtnActualizar;
            this.BtnActualizar.CustomImages.Parent = this.BtnActualizar;
            this.BtnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.HoverState.Parent = this.BtnActualizar;
            this.BtnActualizar.Location = new System.Drawing.Point(12, 524);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.ShadowDecoration.Parent = this.BtnActualizar;
            this.BtnActualizar.Size = new System.Drawing.Size(149, 39);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnEliminarVenta
            // 
            this.BtnEliminarVenta.CheckedState.Parent = this.BtnEliminarVenta;
            this.BtnEliminarVenta.CustomImages.Parent = this.BtnEliminarVenta;
            this.BtnEliminarVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEliminarVenta.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarVenta.HoverState.Parent = this.BtnEliminarVenta;
            this.BtnEliminarVenta.Location = new System.Drawing.Point(194, 524);
            this.BtnEliminarVenta.Name = "BtnEliminarVenta";
            this.BtnEliminarVenta.ShadowDecoration.Parent = this.BtnEliminarVenta;
            this.BtnEliminarVenta.Size = new System.Drawing.Size(149, 39);
            this.BtnEliminarVenta.TabIndex = 8;
            this.BtnEliminarVenta.Text = "Eliminar (prov)";
            this.BtnEliminarVenta.Click += new System.EventHandler(this.BtnEliminarVenta_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(252)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1031, 575);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtPrecioB);
            this.Controls.Add(this.txtPrecioF);
            this.Controls.Add(this.BtnEliminarVenta);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtIdComp);
            this.Controls.Add(this.txtIdEmp);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.dgvVentas);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvVentas;
        private Guna.UI2.WinForms.Guna2TextBox txtIdVenta;
        private Guna.UI2.WinForms.Guna2TextBox txtIdEmp;
        private Guna.UI2.WinForms.Guna2TextBox txtIdComp;
        private Guna.UI2.WinForms.Guna2TextBox txtIdCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtFecha;
        private Guna.UI2.WinForms.Guna2Button BtnModificar;
        private Guna.UI2.WinForms.Guna2Button BtnInsertar;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioF;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioB;
        private Guna.UI2.WinForms.Guna2TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button BtnActualizar;
        private Guna.UI2.WinForms.Guna2Button BtnEliminarVenta;
    }
}