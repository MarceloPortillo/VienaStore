﻿namespace VienaStore.C_Presentacion.Administrador
{
    partial class reportes
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
            this.LblDesde = new System.Windows.Forms.Label();
            this.LblHasta = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DateDesde = new System.Windows.Forms.DateTimePicker();
            this.DateHasta = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnGererar = new System.Windows.Forms.Button();
            this.CboSeleccionar = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDesde
            // 
            this.LblDesde.AutoSize = true;
            this.LblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesde.Location = new System.Drawing.Point(361, 163);
            this.LblDesde.Name = "LblDesde";
            this.LblDesde.Size = new System.Drawing.Size(71, 20);
            this.LblDesde.TabIndex = 1;
            this.LblDesde.Text = "DESDE";
            // 
            // LblHasta
            // 
            this.LblHasta.AutoSize = true;
            this.LblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHasta.Location = new System.Drawing.Point(611, 163);
            this.LblHasta.Name = "LblHasta";
            this.LblHasta.Size = new System.Drawing.Size(68, 20);
            this.LblHasta.TabIndex = 2;
            this.LblHasta.Text = "HASTA";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(543, 15);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(152, 48);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "REPORTES";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DateDesde
            // 
            this.DateDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDesde.Location = new System.Drawing.Point(459, 163);
            this.DateDesde.Name = "DateDesde";
            this.DateDesde.Size = new System.Drawing.Size(110, 20);
            this.DateDesde.TabIndex = 4;
            // 
            // DateHasta
            // 
            this.DateHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateHasta.Location = new System.Drawing.Point(708, 162);
            this.DateHasta.Name = "DateHasta";
            this.DateHasta.Size = new System.Drawing.Size(107, 20);
            this.DateHasta.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 223);
            this.dataGridView1.TabIndex = 7;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Coral;
            this.BtnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::VienaStore.Properties.Resources.imprimir;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(329, 586);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(141, 69);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "IMPRIMIR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Coral;
            this.BtnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::VienaStore.Properties.Resources.cancelar_48x48_px;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(997, 586);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(141, 69);
            this.BtnCancelar.TabIndex = 21;
            this.BtnCancelar.Text = "SALIR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::VienaStore.Properties.Resources.borrar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(519, 586);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 69);
            this.button1.TabIndex = 22;
            this.button1.Text = "LIMPIAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(839, 245);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(358, 316);
            this.listBox1.TabIndex = 23;
            // 
            // BtnGererar
            // 
            this.BtnGererar.BackColor = System.Drawing.Color.Coral;
            this.BtnGererar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGererar.Image = global::VienaStore.Properties.Resources.graficos_32px1;
            this.BtnGererar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGererar.Location = new System.Drawing.Point(443, 245);
            this.BtnGererar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGererar.Name = "BtnGererar";
            this.BtnGererar.Size = new System.Drawing.Size(137, 69);
            this.BtnGererar.TabIndex = 24;
            this.BtnGererar.Text = "GENERAR";
            this.BtnGererar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGererar.UseVisualStyleBackColor = false;
            // 
            // CboSeleccionar
            // 
            this.CboSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSeleccionar.FormattingEnabled = true;
            this.CboSeleccionar.Items.AddRange(new object[] {
            "TODAS LAS VENTAS",
            "VENTAS POR PRODUCTOS",
            "VENTAS POR USUARIOS",
            "COMPRA PROVEEDORES"});
            this.CboSeleccionar.Location = new System.Drawing.Point(254, 79);
            this.CboSeleccionar.Name = "CboSeleccionar";
            this.CboSeleccionar.Size = new System.Drawing.Size(326, 28);
            this.CboSeleccionar.TabIndex = 6;
            this.CboSeleccionar.Text = "Seleccione el tipo de informe";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Carteras",
            "Mochilas",
            "Billeteras"});
            this.comboBox1.Location = new System.Drawing.Point(606, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 28);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Text = "Productos";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Todos",
            "Carteras S.A",
            "Mochilas Himawari",
            "Billeteras Lop"});
            this.comboBox2.Location = new System.Drawing.Point(793, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 28);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.Text = "Proveedores";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Todos",
            "Rodriguez Gaston",
            "Portillo Juan",
            "Becker Pablito"});
            this.comboBox3.Location = new System.Drawing.Point(983, 79);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 28);
            this.comboBox3.TabIndex = 27;
            this.comboBox3.Text = "Usuarios";
            // 
            // reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1189, 668);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnGererar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CboSeleccionar);
            this.Controls.Add(this.DateHasta);
            this.Controls.Add(this.DateDesde);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblHasta);
            this.Controls.Add(this.LblDesde);
            this.Name = "reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblDesde;
        private System.Windows.Forms.Label LblHasta;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DateTimePicker DateDesde;
        private System.Windows.Forms.DateTimePicker DateHasta;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button BtnGuardar;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Button BtnGererar;
        private System.Windows.Forms.ComboBox CboSeleccionar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}