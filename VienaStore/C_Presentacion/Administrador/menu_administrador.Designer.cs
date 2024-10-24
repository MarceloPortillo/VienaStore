﻿namespace VienaStore.C_Presentacion.Administrador
{
    partial class menu_administrador
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
            this.BtnRealizarBackUp = new System.Windows.Forms.Button();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnBuescarUsuario = new System.Windows.Forms.Button();
            this.BtnCrearUsuario = new System.Windows.Forms.Button();
            this.BtnAgregarCat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnListarProd
            // 
            this.BtnListarProd.Image = global::VienaStore.Properties.Resources.lista_prod_32px;
            this.BtnListarProd.Location = new System.Drawing.Point(25, 245);
            this.BtnListarProd.Size = new System.Drawing.Size(155, 45);
            this.BtnListarProd.Text = "   LISTAR \r\n   PRODUCTOS";
            // 
            // BtnBuscarProd
            // 
            this.BtnBuscarProd.Image = global::VienaStore.Properties.Resources.buscar_prod_32px;
            this.BtnBuscarProd.Location = new System.Drawing.Point(25, 194);
            this.BtnBuscarProd.Size = new System.Drawing.Size(155, 45);
            this.BtnBuscarProd.Text = "    BUSCAR\r\n  PRODUCTO";
            // 
            // BtnListarCliente
            // 
            this.BtnListarCliente.Image = global::VienaStore.Properties.Resources.listar_clientes_32px;
            this.BtnListarCliente.Location = new System.Drawing.Point(25, 90);
            this.BtnListarCliente.Size = new System.Drawing.Size(155, 45);
            this.BtnListarCliente.Text = "     LISTAR       CLIENTES";
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Enabled = false;
            this.BtnBuscarCliente.Image = global::VienaStore.Properties.Resources.buscar_cliente_32px;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(25, 90);
            this.BtnBuscarCliente.Size = new System.Drawing.Size(155, 45);
            this.BtnBuscarCliente.Text = "    BUSCAR \r\n    CLIENTE";
            this.BtnBuscarCliente.Visible = false;
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.Enabled = true;
            this.BtnModificarCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCliente.Image = global::VienaStore.Properties.Resources.graficos_32px;
            this.BtnModificarCliente.Location = new System.Drawing.Point(25, 296);
            this.BtnModificarCliente.Size = new System.Drawing.Size(155, 45);
            this.BtnModificarCliente.Text = "    GENERAR \r\n   REPORTES";
            this.BtnModificarCliente.Visible = true;
            this.BtnModificarCliente.Click += new System.EventHandler(this.BtnModificarCliente_Click);
            // 
            // BtnRegistrarCliente
            // 
            this.BtnRegistrarCliente.Enabled = false;
            this.BtnRegistrarCliente.Image = global::VienaStore.Properties.Resources.agregar_usuario_32px;
            this.BtnRegistrarCliente.Location = new System.Drawing.Point(25, 90);
            this.BtnRegistrarCliente.Size = new System.Drawing.Size(155, 45);
            this.BtnRegistrarCliente.Text = "  REGISTRAR \r\n  CLIENTE";
            this.BtnRegistrarCliente.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnAgregarCat);
            this.panel1.Controls.Add(this.BtnCrearUsuario);
            this.panel1.Controls.Add(this.BtnBuescarUsuario);
            this.panel1.Controls.Add(this.BtnAgregarProducto);
            this.panel1.Controls.Add(this.BtnProveedores);
            this.panel1.Controls.Add(this.BtnRealizarBackUp);
            this.panel1.Size = new System.Drawing.Size(204, 749);
            this.panel1.Controls.SetChildIndex(this.BtnRegistrarVenta, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.Controls.SetChildIndex(this.BtnRegistrarCliente, 0);
            this.panel1.Controls.SetChildIndex(this.BtnModificarCliente, 0);
            this.panel1.Controls.SetChildIndex(this.BtnBuscarCliente, 0);
            this.panel1.Controls.SetChildIndex(this.BtnListarCliente, 0);
            this.panel1.Controls.SetChildIndex(this.BtnBuscarProd, 0);
            this.panel1.Controls.SetChildIndex(this.BtnListarProd, 0);
            this.panel1.Controls.SetChildIndex(this.BtnRealizarBackUp, 0);
            this.panel1.Controls.SetChildIndex(this.BtnProveedores, 0);
            this.panel1.Controls.SetChildIndex(this.BtnAgregarProducto, 0);
            this.panel1.Controls.SetChildIndex(this.BtnBuescarUsuario, 0);
            this.panel1.Controls.SetChildIndex(this.BtnCrearUsuario, 0);
            this.panel1.Controls.SetChildIndex(this.BtnAgregarCat, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.Location = new System.Drawing.Point(321, 14);
            this.LblBienvenido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblBienvenido.Size = new System.Drawing.Size(220, 20);
            this.LblBienvenido.Text = "MENÚ ADMINISTRADOR";
            this.LblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(768, 698);
            // 
            // BtnRegistrarVenta
            // 
            this.BtnRegistrarVenta.Location = new System.Drawing.Point(25, 347);
            this.BtnRegistrarVenta.Size = new System.Drawing.Size(155, 45);
            // 
            // BtnRealizarBackUp
            // 
            this.BtnRealizarBackUp.BackColor = System.Drawing.Color.Coral;
            this.BtnRealizarBackUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRealizarBackUp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRealizarBackUp.Image = global::VienaStore.Properties.Resources.back_up_32px;
            this.BtnRealizarBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRealizarBackUp.Location = new System.Drawing.Point(25, 449);
            this.BtnRealizarBackUp.Name = "BtnRealizarBackUp";
            this.BtnRealizarBackUp.Size = new System.Drawing.Size(155, 45);
            this.BtnRealizarBackUp.TabIndex = 8;
            this.BtnRealizarBackUp.TabStop = false;
            this.BtnRealizarBackUp.Tag = "2";
            this.BtnRealizarBackUp.Text = "     REALIZAR     \r\n      BACKUP";
            this.BtnRealizarBackUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRealizarBackUp.UseCompatibleTextRendering = true;
            this.BtnRealizarBackUp.UseVisualStyleBackColor = false;
            this.BtnRealizarBackUp.Click += new System.EventHandler(this.BtnRealizarBackUp_Click);
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.BackColor = System.Drawing.Color.Coral;
            this.BtnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnProveedores.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedores.Image = global::VienaStore.Properties.Resources.proveedor_32px;
            this.BtnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedores.Location = new System.Drawing.Point(25, 398);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(155, 45);
            this.BtnProveedores.TabIndex = 9;
            this.BtnProveedores.TabStop = false;
            this.BtnProveedores.Tag = "2";
            this.BtnProveedores.Text = " PROVEEDORES";
            this.BtnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProveedores.UseCompatibleTextRendering = true;
            this.BtnProveedores.UseVisualStyleBackColor = false;
            this.BtnProveedores.Click += new System.EventHandler(this.BtnProveedores_Click);
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.Coral;
            this.BtnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProducto.Image = global::VienaStore.Properties.Resources.agregar_prod_32px;
            this.BtnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(25, 141);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(155, 45);
            this.BtnAgregarProducto.TabIndex = 10;
            this.BtnAgregarProducto.TabStop = false;
            this.BtnAgregarProducto.Tag = "2";
            this.BtnAgregarProducto.Text = "     AGREGAR\r\n    PRODUCTO";
            this.BtnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregarProducto.UseCompatibleTextRendering = true;
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnBuescarUsuario
            // 
            this.BtnBuescarUsuario.BackColor = System.Drawing.Color.Coral;
            this.BtnBuescarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuescarUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuescarUsuario.Image = global::VienaStore.Properties.Resources.buscar_usu_32px;
            this.BtnBuescarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuescarUsuario.Location = new System.Drawing.Point(25, 551);
            this.BtnBuescarUsuario.Name = "BtnBuescarUsuario";
            this.BtnBuescarUsuario.Size = new System.Drawing.Size(155, 45);
            this.BtnBuescarUsuario.TabIndex = 11;
            this.BtnBuescarUsuario.TabStop = false;
            this.BtnBuescarUsuario.Tag = "2";
            this.BtnBuescarUsuario.Text = "        BUSCAR \r\n       USUARIO";
            this.BtnBuescarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuescarUsuario.UseCompatibleTextRendering = true;
            this.BtnBuescarUsuario.UseVisualStyleBackColor = false;
            this.BtnBuescarUsuario.Click += new System.EventHandler(this.BtnBuescarUsuario_Click);
            // 
            // BtnCrearUsuario
            // 
            this.BtnCrearUsuario.BackColor = System.Drawing.Color.Coral;
            this.BtnCrearUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCrearUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearUsuario.Image = global::VienaStore.Properties.Resources.agregar_usuario_32px__2_;
            this.BtnCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearUsuario.Location = new System.Drawing.Point(25, 500);
            this.BtnCrearUsuario.Name = "BtnCrearUsuario";
            this.BtnCrearUsuario.Size = new System.Drawing.Size(155, 45);
            this.BtnCrearUsuario.TabIndex = 12;
            this.BtnCrearUsuario.TabStop = false;
            this.BtnCrearUsuario.Tag = "2";
            this.BtnCrearUsuario.Text = "      CREAR\r\n      USUARIO";
            this.BtnCrearUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCrearUsuario.UseCompatibleTextRendering = true;
            this.BtnCrearUsuario.UseVisualStyleBackColor = false;
            this.BtnCrearUsuario.Click += new System.EventHandler(this.BtnCrearUsuario_Click);
            // 
            // BtnAgregarCat
            // 
            this.BtnAgregarCat.BackColor = System.Drawing.Color.Coral;
            this.BtnAgregarCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAgregarCat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCat.Image = global::VienaStore.Properties.Resources.categories_32PX;
            this.BtnAgregarCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarCat.Location = new System.Drawing.Point(25, 602);
            this.BtnAgregarCat.Name = "BtnAgregarCat";
            this.BtnAgregarCat.Size = new System.Drawing.Size(155, 45);
            this.BtnAgregarCat.TabIndex = 13;
            this.BtnAgregarCat.TabStop = false;
            this.BtnAgregarCat.Tag = "2";
            this.BtnAgregarCat.Text = "  GESTIONAR\r\n CATEGORIAS";
            this.BtnAgregarCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregarCat.UseCompatibleTextRendering = true;
            this.BtnAgregarCat.UseVisualStyleBackColor = false;
            this.BtnAgregarCat.Click += new System.EventHandler(this.BtnAgregarCat_Click);
            // 
            // menu_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 749);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "menu_administrador";
            this.Text = "MENÚ ADMINISTRADOR";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogotipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button BtnRealizarBackUp;
        public System.Windows.Forms.Button BtnAgregarProducto;
        public System.Windows.Forms.Button BtnBuescarUsuario;
        public System.Windows.Forms.Button BtnCrearUsuario;
        public System.Windows.Forms.Button BtnProveedores;
        public System.Windows.Forms.Button BtnAgregarCat;
    }
}