namespace VienaStore.C_Presentacion.Administrador
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
            this.BtnVentaVendedor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnListarProd
            // 
            this.BtnListarProd.Image = global::VienaStore.Properties.Resources.lista_prod_32px;
            this.BtnListarProd.Location = new System.Drawing.Point(33, 302);
            this.BtnListarProd.Margin = new System.Windows.Forms.Padding(5);
            this.BtnListarProd.Size = new System.Drawing.Size(207, 55);
            this.BtnListarProd.Text = "   LISTAR \r\n   PRODUCTOS";
            // 
            // BtnBuscarProd
            // 
            this.BtnBuscarProd.Image = global::VienaStore.Properties.Resources.buscar_prod_32px;
            this.BtnBuscarProd.Location = new System.Drawing.Point(33, 239);
            this.BtnBuscarProd.Margin = new System.Windows.Forms.Padding(5);
            this.BtnBuscarProd.Size = new System.Drawing.Size(207, 55);
            this.BtnBuscarProd.Text = "    BUSCAR\r\n  PRODUCTO";
            // 
            // BtnListarCliente
            // 
            this.BtnListarCliente.Image = global::VienaStore.Properties.Resources.listar_clientes_32px;
            this.BtnListarCliente.Location = new System.Drawing.Point(33, 111);
            this.BtnListarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.BtnListarCliente.Size = new System.Drawing.Size(207, 55);
            this.BtnListarCliente.Text = "     LISTAR       CLIENTES";
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Enabled = false;
            this.BtnBuscarCliente.Image = global::VienaStore.Properties.Resources.buscar_cliente_32px;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(33, 111);
            this.BtnBuscarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.BtnBuscarCliente.Size = new System.Drawing.Size(207, 55);
            this.BtnBuscarCliente.Text = "    BUSCAR \r\n    CLIENTE";
            this.BtnBuscarCliente.Visible = false;
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.Enabled = true;
            this.BtnModificarCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCliente.Image = global::VienaStore.Properties.Resources.graficos_32px;
            this.BtnModificarCliente.Location = new System.Drawing.Point(33, 364);
            this.BtnModificarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.BtnModificarCliente.Size = new System.Drawing.Size(207, 55);
            this.BtnModificarCliente.Text = "    GENERAR \r\n   REPORTES";
            this.BtnModificarCliente.Visible = true;
            this.BtnModificarCliente.Click += new System.EventHandler(this.BtnModificarCliente_Click);
            // 
            // BtnRegistrarCliente
            // 
            this.BtnRegistrarCliente.Enabled = false;
            this.BtnRegistrarCliente.Image = global::VienaStore.Properties.Resources.agregar_usuario_32px;
            this.BtnRegistrarCliente.Location = new System.Drawing.Point(33, 111);
            this.BtnRegistrarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRegistrarCliente.Size = new System.Drawing.Size(207, 55);
            this.BtnRegistrarCliente.Text = "  REGISTRAR \r\n  CLIENTE";
            this.BtnRegistrarCliente.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnVentaVendedor);
            this.panel1.Controls.Add(this.BtnAgregarCat);
            this.panel1.Controls.Add(this.BtnCrearUsuario);
            this.panel1.Controls.Add(this.BtnBuescarUsuario);
            this.panel1.Controls.Add(this.BtnAgregarProducto);
            this.panel1.Controls.Add(this.BtnProveedores);
            this.panel1.Controls.Add(this.BtnRealizarBackUp);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(272, 922);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Controls.SetChildIndex(this.BtnMisVentas, 0);
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
            this.panel1.Controls.SetChildIndex(this.BtnVentaVendedor, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.Location = new System.Drawing.Point(428, 17);
            this.LblBienvenido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblBienvenido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblBienvenido.Size = new System.Drawing.Size(273, 26);
            this.LblBienvenido.Text = "MENÚ ADMINISTRADOR";
            this.LblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(1024, 859);
            // 
            // BtnRegistrarVenta
            // 
            this.BtnRegistrarVenta.Enabled = false;
            this.BtnRegistrarVenta.Location = new System.Drawing.Point(33, 429);
            this.BtnRegistrarVenta.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRegistrarVenta.Size = new System.Drawing.Size(207, 55);
            this.BtnRegistrarVenta.Visible = false;
            // 
            // BtnMisVentas
            // 
            this.BtnMisVentas.Location = new System.Drawing.Point(52, 620);
            this.BtnMisVentas.Size = new System.Drawing.Size(100, 50);
            // 
            // BtnRealizarBackUp
            // 
            this.BtnRealizarBackUp.BackColor = System.Drawing.Color.Coral;
            this.BtnRealizarBackUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRealizarBackUp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRealizarBackUp.Image = global::VienaStore.Properties.Resources.back_up_32px;
            this.BtnRealizarBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRealizarBackUp.Location = new System.Drawing.Point(33, 553);
            this.BtnRealizarBackUp.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRealizarBackUp.Name = "BtnRealizarBackUp";
            this.BtnRealizarBackUp.Size = new System.Drawing.Size(207, 55);
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
            this.BtnProveedores.Location = new System.Drawing.Point(33, 490);
            this.BtnProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(207, 55);
            this.BtnProveedores.TabIndex = 9;
            this.BtnProveedores.TabStop = false;
            this.BtnProveedores.Tag = "2";
            this.BtnProveedores.Text = "   PROVEEDORES";
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
            this.BtnAgregarProducto.Location = new System.Drawing.Point(33, 174);
            this.BtnAgregarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(207, 55);
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
            this.BtnBuescarUsuario.Location = new System.Drawing.Point(33, 678);
            this.BtnBuescarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuescarUsuario.Name = "BtnBuescarUsuario";
            this.BtnBuescarUsuario.Size = new System.Drawing.Size(207, 55);
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
            this.BtnCrearUsuario.Location = new System.Drawing.Point(33, 615);
            this.BtnCrearUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCrearUsuario.Name = "BtnCrearUsuario";
            this.BtnCrearUsuario.Size = new System.Drawing.Size(207, 55);
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
            this.BtnAgregarCat.Location = new System.Drawing.Point(33, 741);
            this.BtnAgregarCat.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregarCat.Name = "BtnAgregarCat";
            this.BtnAgregarCat.Size = new System.Drawing.Size(207, 55);
            this.BtnAgregarCat.TabIndex = 13;
            this.BtnAgregarCat.TabStop = false;
            this.BtnAgregarCat.Tag = "2";
            this.BtnAgregarCat.Text = "  GESTIONAR\r\n CATEGORIAS";
            this.BtnAgregarCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregarCat.UseCompatibleTextRendering = true;
            this.BtnAgregarCat.UseVisualStyleBackColor = false;
            this.BtnAgregarCat.Click += new System.EventHandler(this.BtnAgregarCat_Click);
            // 
            // BtnVentaVendedor
            // 
            this.BtnVentaVendedor.BackColor = System.Drawing.Color.Coral;
            this.BtnVentaVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnVentaVendedor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentaVendedor.Image = global::VienaStore.Properties.Resources.venta_nuevo32px;
            this.BtnVentaVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentaVendedor.Location = new System.Drawing.Point(33, 427);
            this.BtnVentaVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVentaVendedor.Name = "BtnVentaVendedor";
            this.BtnVentaVendedor.Size = new System.Drawing.Size(207, 55);
            this.BtnVentaVendedor.TabIndex = 14;
            this.BtnVentaVendedor.TabStop = false;
            this.BtnVentaVendedor.Tag = "2";
            this.BtnVentaVendedor.Text = "     GESTIONAR    VENTAS";
            this.BtnVentaVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentaVendedor.UseCompatibleTextRendering = true;
            this.BtnVentaVendedor.UseVisualStyleBackColor = false;
            this.BtnVentaVendedor.Click += new System.EventHandler(this.BtnVentaVendedor_Click);
            // 
            // menu_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 922);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
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
        public System.Windows.Forms.Button BtnVentaVendedor;
    }
}