﻿namespace VienaStore.C_Presentacion.Vendedor
{
    partial class Menu_Vendedor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Vendedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnListarProd = new System.Windows.Forms.Button();
            this.BtnBuscarProd = new System.Windows.Forms.Button();
            this.BtnListarCliente = new System.Windows.Forms.Button();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.BtnModificarCliente = new System.Windows.Forms.Button();
            this.BtnRegistrarCliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.TxtFecha = new System.Windows.Forms.Label();
            this.LblBienvenido = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnListarProd);
            this.panel1.Controls.Add(this.BtnBuscarProd);
            this.panel1.Controls.Add(this.BtnListarCliente);
            this.panel1.Controls.Add(this.BtnBuscarCliente);
            this.panel1.Controls.Add(this.BtnModificarCliente);
            this.panel1.Controls.Add(this.BtnRegistrarCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 502);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VienaStore.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BtnListarProd
            // 
            this.BtnListarProd.BackColor = System.Drawing.Color.Coral;
            this.BtnListarProd.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListarProd.Image = global::VienaStore.Properties.Resources.listaProductos;
            this.BtnListarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListarProd.Location = new System.Drawing.Point(25, 433);
            this.BtnListarProd.Name = "BtnListarProd";
            this.BtnListarProd.Size = new System.Drawing.Size(155, 57);
            this.BtnListarProd.TabIndex = 5;
            this.BtnListarProd.Text = "LISTAR \r\nPRODUCTOS";
            this.BtnListarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnListarProd.UseVisualStyleBackColor = false;
            this.BtnListarProd.Click += new System.EventHandler(this.BtnListarProd_Click);
            // 
            // BtnBuscarProd
            // 
            this.BtnBuscarProd.BackColor = System.Drawing.Color.Coral;
            this.BtnBuscarProd.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProd.Image = global::VienaStore.Properties.Resources.buscarProducto;
            this.BtnBuscarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarProd.Location = new System.Drawing.Point(25, 368);
            this.BtnBuscarProd.Name = "BtnBuscarProd";
            this.BtnBuscarProd.Size = new System.Drawing.Size(155, 59);
            this.BtnBuscarProd.TabIndex = 4;
            this.BtnBuscarProd.Text = "BUSCAR\r\nPRODUCTOS";
            this.BtnBuscarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscarProd.UseVisualStyleBackColor = false;
            this.BtnBuscarProd.Click += new System.EventHandler(this.BtnBuscarProd_Click);
            // 
            // BtnListarCliente
            // 
            this.BtnListarCliente.BackColor = System.Drawing.Color.Coral;
            this.BtnListarCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListarCliente.Image = global::VienaStore.Properties.Resources.Listar;
            this.BtnListarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListarCliente.Location = new System.Drawing.Point(25, 299);
            this.BtnListarCliente.Name = "BtnListarCliente";
            this.BtnListarCliente.Size = new System.Drawing.Size(155, 59);
            this.BtnListarCliente.TabIndex = 3;
            this.BtnListarCliente.Text = "   LISTAR     CLIENTES";
            this.BtnListarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnListarCliente.UseVisualStyleBackColor = false;
            this.BtnListarCliente.Click += new System.EventHandler(this.BtnListarCliente_Click);
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.Coral;
            this.BtnBuscarCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCliente.Image = global::VienaStore.Properties.Resources.buscarCliente;
            this.BtnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(25, 238);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(155, 55);
            this.BtnBuscarCliente.TabIndex = 2;
            this.BtnBuscarCliente.Text = "  BUSCAR   CLIENTE";
            this.BtnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.BackColor = System.Drawing.Color.Coral;
            this.BtnModificarCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCliente.Image = global::VienaStore.Properties.Resources.editar;
            this.BtnModificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarCliente.Location = new System.Drawing.Point(25, 173);
            this.BtnModificarCliente.Name = "BtnModificarCliente";
            this.BtnModificarCliente.Size = new System.Drawing.Size(155, 59);
            this.BtnModificarCliente.TabIndex = 1;
            this.BtnModificarCliente.Text = "MODIFICAR \r\nCLIENTE";
            this.BtnModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModificarCliente.UseVisualStyleBackColor = false;
            this.BtnModificarCliente.Click += new System.EventHandler(this.BtnModificarCliente_Click);
            // 
            // BtnRegistrarCliente
            // 
            this.BtnRegistrarCliente.BackColor = System.Drawing.Color.Coral;
            this.BtnRegistrarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRegistrarCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarCliente.Image = global::VienaStore.Properties.Resources.nuevoUsuario;
            this.BtnRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarCliente.Location = new System.Drawing.Point(25, 111);
            this.BtnRegistrarCliente.Name = "BtnRegistrarCliente";
            this.BtnRegistrarCliente.Size = new System.Drawing.Size(155, 56);
            this.BtnRegistrarCliente.TabIndex = 0;
            this.BtnRegistrarCliente.TabStop = false;
            this.BtnRegistrarCliente.Tag = "2";
            this.BtnRegistrarCliente.Text = "REGISTRAR \r\nCLIENTE";
            this.BtnRegistrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistrarCliente.UseCompatibleTextRendering = true;
            this.BtnRegistrarCliente.UseVisualStyleBackColor = false;
            this.BtnRegistrarCliente.Click += new System.EventHandler(this.BtnRegistrarCliente_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.BtnCerrarSesion);
            this.panel2.Controls.Add(this.TxtFecha);
            this.panel2.Controls.Add(this.LblBienvenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(204, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 51);
            this.panel2.TabIndex = 1;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrarSesion.Image = global::VienaStore.Properties.Resources.CierreSesion;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(547, 0);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(49, 51);
            this.BtnCerrarSesion.TabIndex = 3;
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // TxtFecha
            // 
            this.TxtFecha.AutoSize = true;
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(3, 3);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(51, 20);
            this.TxtFecha.TabIndex = 2;
            this.TxtFecha.Text = "label2";
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.AutoSize = true;
            this.LblBienvenido.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenido.Location = new System.Drawing.Point(214, 31);
            this.LblBienvenido.Name = "LblBienvenido";
            this.LblBienvenido.Size = new System.Drawing.Size(130, 20);
            this.LblBienvenido.TabIndex = 0;
            this.LblBienvenido.Text = "Bienvenido...";
            // 
            // fecha
            // 
            this.fecha.Enabled = true;
            this.fecha.Tick += new System.EventHandler(this.fecha_Tick);
            // 
            // Menu_Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Menu_Vendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Vendedor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnListarProd;
        private System.Windows.Forms.Button BtnBuscarProd;
        private System.Windows.Forms.Button BtnListarCliente;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.Button BtnModificarCliente;
        private System.Windows.Forms.Button BtnRegistrarCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblBienvenido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TxtFecha;
        private System.Windows.Forms.Timer fecha;
        private System.Windows.Forms.Button BtnCerrarSesion;
    }
}