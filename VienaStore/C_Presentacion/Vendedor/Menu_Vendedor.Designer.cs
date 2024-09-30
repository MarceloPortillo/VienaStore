namespace VienaStore.C_Presentacion.Vendedor
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
            this.BtnModificarCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnListarProd = new System.Windows.Forms.Button();
            this.BtnBuscarProd = new System.Windows.Forms.Button();
            this.BtnListarCliente = new System.Windows.Forms.Button();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.BtnRegistrarCliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.LblBienvenido = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblEstrellas = new System.Windows.Forms.Label();
            this.PBoxLogotipo = new System.Windows.Forms.PictureBox();
            this.LblHora = new System.Windows.Forms.Label();
            this.THora = new System.Windows.Forms.Timer(this.components);
            this.BtnRegistrarVenta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.BtnRegistrarVenta);
            this.panel1.Controls.Add(this.BtnModificarCliente);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnListarProd);
            this.panel1.Controls.Add(this.BtnBuscarProd);
            this.panel1.Controls.Add(this.BtnListarCliente);
            this.panel1.Controls.Add(this.BtnBuscarCliente);
            this.panel1.Controls.Add(this.BtnRegistrarCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 615);
            this.panel1.TabIndex = 0;
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.BackColor = System.Drawing.Color.Coral;
            this.BtnModificarCliente.Enabled = false;
            this.BtnModificarCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarCliente.Image")));
            this.BtnModificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarCliente.Location = new System.Drawing.Point(25, 427);
            this.BtnModificarCliente.Name = "BtnModificarCliente";
            this.BtnModificarCliente.Size = new System.Drawing.Size(155, 59);
            this.BtnModificarCliente.TabIndex = 1;
            this.BtnModificarCliente.Text = "MODIFICAR \r\nCLIENTE";
            this.BtnModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModificarCliente.UseVisualStyleBackColor = false;
            this.BtnModificarCliente.Visible = false;
            this.BtnModificarCliente.Click += new System.EventHandler(this.BtnModificarCliente_Click);
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
            this.BtnListarProd.Image = ((System.Drawing.Image)(resources.GetObject("BtnListarProd.Image")));
            this.BtnListarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListarProd.Location = new System.Drawing.Point(25, 364);
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
            this.BtnBuscarProd.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarProd.Image")));
            this.BtnBuscarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarProd.Location = new System.Drawing.Point(25, 299);
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
            this.BtnListarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnListarCliente.Image")));
            this.BtnListarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListarCliente.Location = new System.Drawing.Point(25, 234);
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
            this.BtnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarCliente.Image")));
            this.BtnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(25, 173);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(155, 55);
            this.BtnBuscarCliente.TabIndex = 2;
            this.BtnBuscarCliente.Text = "  BUSCAR   CLIENTE";
            this.BtnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // BtnRegistrarCliente
            // 
            this.BtnRegistrarCliente.BackColor = System.Drawing.Color.Coral;
            this.BtnRegistrarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRegistrarCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarCliente.Image")));
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.BtnCerrarSesion);
            this.panel2.Controls.Add(this.LblBienvenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(204, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 51);
            this.panel2.TabIndex = 1;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrarSesion.Image")));
            this.BtnCerrarSesion.Location = new System.Drawing.Point(717, 0);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(49, 51);
            this.BtnCerrarSesion.TabIndex = 3;
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.AutoSize = true;
            this.LblBienvenido.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenido.Location = new System.Drawing.Point(350, 14);
            this.LblBienvenido.Name = "LblBienvenido";
            this.LblBienvenido.Size = new System.Drawing.Size(166, 20);
            this.LblBienvenido.TabIndex = 0;
            this.LblBienvenido.Text = "MENÚ VENDEDOR";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(315, 272);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(126, 46);
            this.LblFecha.TabIndex = 2;
            this.LblFecha.Text = "label2";
            // 
            // fecha
            // 
            this.fecha.Enabled = true;
            this.fecha.Tick += new System.EventHandler(this.fecha_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSalmon;
            this.panel3.Controls.Add(this.LblEstrellas);
            this.panel3.Controls.Add(this.PBoxLogotipo);
            this.panel3.Controls.Add(this.LblHora);
            this.panel3.Controls.Add(this.LblFecha);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(204, 51);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(766, 564);
            this.panel3.TabIndex = 3;
            // 
            // LblEstrellas
            // 
            this.LblEstrellas.AutoSize = true;
            this.LblEstrellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstrellas.Location = new System.Drawing.Point(514, 487);
            this.LblEstrellas.Name = "LblEstrellas";
            this.LblEstrellas.Size = new System.Drawing.Size(114, 31);
            this.LblEstrellas.TabIndex = 8;
            this.LblEstrellas.Text = "⭐⭐⭐⭐⭐";
            // 
            // PBoxLogotipo
            // 
            this.PBoxLogotipo.Image = global::VienaStore.Properties.Resources.logotipo;
            this.PBoxLogotipo.Location = new System.Drawing.Point(470, 391);
            this.PBoxLogotipo.Name = "PBoxLogotipo";
            this.PBoxLogotipo.Size = new System.Drawing.Size(195, 93);
            this.PBoxLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBoxLogotipo.TabIndex = 7;
            this.PBoxLogotipo.TabStop = false;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(391, 143);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(249, 91);
            this.LblHora.TabIndex = 3;
            this.LblHora.Text = "label1";
            // 
            // THora
            // 
            this.THora.Enabled = true;
            this.THora.Tick += new System.EventHandler(this.THora_Tick);
            // 
            // BtnRegistrarVenta
            // 
            this.BtnRegistrarVenta.BackColor = System.Drawing.Color.Coral;
            this.BtnRegistrarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRegistrarVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarVenta.Image = global::VienaStore.Properties.Resources.compras_32px;
            this.BtnRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarVenta.Location = new System.Drawing.Point(25, 427);
            this.BtnRegistrarVenta.Name = "BtnRegistrarVenta";
            this.BtnRegistrarVenta.Size = new System.Drawing.Size(155, 59);
            this.BtnRegistrarVenta.TabIndex = 8;
            this.BtnRegistrarVenta.TabStop = false;
            this.BtnRegistrarVenta.Tag = "2";
            this.BtnRegistrarVenta.Text = "   REGISTRAR\r\n    VENTA";
            this.BtnRegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistrarVenta.UseCompatibleTextRendering = true;
            this.BtnRegistrarVenta.UseVisualStyleBackColor = false;
            this.BtnRegistrarVenta.Click += new System.EventHandler(this.BtnRegistrarVenta_Click);
            // 
            // Menu_Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(970, 615);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Menu_Vendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Vendedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogotipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Timer fecha;
        private System.Windows.Forms.Button BtnCerrarSesion;
        public System.Windows.Forms.Button BtnListarProd;
        public System.Windows.Forms.Button BtnBuscarProd;
        public System.Windows.Forms.Button BtnListarCliente;
        public System.Windows.Forms.Button BtnBuscarCliente;
        public System.Windows.Forms.Button BtnModificarCliente;
        public System.Windows.Forms.Button BtnRegistrarCliente;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label LblBienvenido;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer THora;
        public System.Windows.Forms.PictureBox PBoxLogotipo;
        private System.Windows.Forms.Label LblEstrellas;
        public System.Windows.Forms.Button BtnRegistrarVenta;
    }
}