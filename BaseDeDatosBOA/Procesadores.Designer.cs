﻿namespace BaseDeDatosBOA
{
    partial class Procesadores
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnConsulta = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.txtModelo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdProcesador = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvProcesadores = new Guna.UI2.WinForms.Guna2DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesadores)).BeginInit();
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(785, 172);
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
            this.label2.Location = new System.Drawing.Point(793, 123);
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
            this.label1.Location = new System.Drawing.Point(746, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "IdProcesador";
            // 
            // btnInsertar
            // 
            this.btnInsertar.CheckedState.Parent = this.btnInsertar;
            this.btnInsertar.CustomImages.Parent = this.btnInsertar;
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
            // 
            // txtModelo
            // 
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
            this.txtModelo.Location = new System.Drawing.Point(849, 164);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.PlaceholderText = "";
            this.txtModelo.SelectedText = "";
            this.txtModelo.ShadowDecoration.Parent = this.txtModelo;
            this.txtModelo.Size = new System.Drawing.Size(149, 31);
            this.txtModelo.TabIndex = 33;
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
            this.txtMarca.Location = new System.Drawing.Point(849, 115);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.PlaceholderText = "";
            this.txtMarca.SelectedText = "";
            this.txtMarca.ShadowDecoration.Parent = this.txtMarca;
            this.txtMarca.Size = new System.Drawing.Size(149, 31);
            this.txtMarca.TabIndex = 32;
            // 
            // txtIdProcesador
            // 
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
            this.txtIdProcesador.Location = new System.Drawing.Point(849, 68);
            this.txtIdProcesador.Name = "txtIdProcesador";
            this.txtIdProcesador.PasswordChar = '\0';
            this.txtIdProcesador.PlaceholderText = "";
            this.txtIdProcesador.SelectedText = "";
            this.txtIdProcesador.ShadowDecoration.Parent = this.txtIdProcesador;
            this.txtIdProcesador.Size = new System.Drawing.Size(149, 31);
            this.txtIdProcesador.TabIndex = 31;
            // 
            // dgvProcesadores
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvProcesadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProcesadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcesadores.BackgroundColor = System.Drawing.Color.White;
            this.dgvProcesadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProcesadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProcesadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcesadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProcesadores.ColumnHeadersHeight = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcesadores.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProcesadores.EnableHeadersVisualStyles = false;
            this.dgvProcesadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProcesadores.Location = new System.Drawing.Point(27, 68);
            this.dgvProcesadores.Name = "dgvProcesadores";
            this.dgvProcesadores.RowHeadersVisible = false;
            this.dgvProcesadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcesadores.Size = new System.Drawing.Size(680, 501);
            this.dgvProcesadores.TabIndex = 30;
            this.dgvProcesadores.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvProcesadores.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProcesadores.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProcesadores.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProcesadores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProcesadores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProcesadores.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProcesadores.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProcesadores.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProcesadores.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProcesadores.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProcesadores.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProcesadores.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProcesadores.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvProcesadores.ThemeStyle.ReadOnly = false;
            this.dgvProcesadores.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProcesadores.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProcesadores.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProcesadores.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProcesadores.ThemeStyle.RowsStyle.Height = 22;
            this.dgvProcesadores.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProcesadores.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Procesadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(252)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1031, 575);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtIdProcesador);
            this.Controls.Add(this.dgvProcesadores);
            this.Name = "Procesadores";
            this.Text = "Procesadores";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnEliminar;
        private Guna.UI2.WinForms.Guna2ImageButton btnConsulta;
        private Guna.UI2.WinForms.Guna2ImageButton btnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnInsertar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2TextBox txtModelo;
        private Guna.UI2.WinForms.Guna2TextBox txtMarca;
        private Guna.UI2.WinForms.Guna2TextBox txtIdProcesador;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProcesadores;
    }
}