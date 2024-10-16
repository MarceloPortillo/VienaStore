namespace VienaStore.C_Presentacion.Encargado
{
    partial class menu_encargado
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
            this.BtnInformes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRealizarBackUp
            // 
            this.BtnRealizarBackUp.Enabled = false;
            this.BtnRealizarBackUp.Location = new System.Drawing.Point(200, 610);
            this.BtnRealizarBackUp.Visible = false;
            // 
            // BtnBuescarUsuario
            // 
            this.BtnBuescarUsuario.Enabled = false;
            this.BtnBuescarUsuario.Location = new System.Drawing.Point(361, 610);
            this.BtnBuescarUsuario.Visible = false;
            // 
            // BtnCrearUsuario
            // 
            this.BtnCrearUsuario.Enabled = false;
            this.BtnCrearUsuario.Location = new System.Drawing.Point(28, 559);
            this.BtnCrearUsuario.Visible = false;
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.Enabled = false;
            this.BtnProveedores.Location = new System.Drawing.Point(28, 610);
            this.BtnProveedores.Visible = false;
            // 
            // BtnAgregarCat
            // 
            this.BtnAgregarCat.Enabled = false;
            this.BtnAgregarCat.Location = new System.Drawing.Point(25, 449);
            this.BtnAgregarCat.Visible = false;
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.Enabled = false;
            this.BtnModificarCliente.Location = new System.Drawing.Point(189, 559);
            this.BtnModificarCliente.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnInformes);
            this.panel1.Size = new System.Drawing.Size(204, 718);
            this.panel1.Controls.SetChildIndex(this.BtnAgregarCat, 0);
            this.panel1.Controls.SetChildIndex(this.BtnRegistrarVenta, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.Controls.SetChildIndex(this.BtnRegistrarCliente, 0);
            this.panel1.Controls.SetChildIndex(this.BtnBuscarCliente, 0);
            this.panel1.Controls.SetChildIndex(this.BtnListarCliente, 0);
            this.panel1.Controls.SetChildIndex(this.BtnBuscarProd, 0);
            this.panel1.Controls.SetChildIndex(this.BtnListarProd, 0);
            this.panel1.Controls.SetChildIndex(this.BtnAgregarProducto, 0);
            this.panel1.Controls.SetChildIndex(this.BtnInformes, 0);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.Size = new System.Drawing.Size(179, 20);
            this.LblBienvenido.Text = "MENÚ ENCARGADO";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnCrearUsuario);
            this.panel3.Controls.Add(this.BtnBuescarUsuario);
            this.panel3.Controls.Add(this.BtnRealizarBackUp);
            this.panel3.Controls.Add(this.BtnProveedores);
            this.panel3.Controls.Add(this.BtnModificarCliente);
            this.panel3.Size = new System.Drawing.Size(618, 667);
            // 
            // BtnRegistrarVenta
            // 
            this.BtnRegistrarVenta.Location = new System.Drawing.Point(25, 296);
            // 
            // BtnInformes
            // 
            this.BtnInformes.BackColor = System.Drawing.Color.Coral;
            this.BtnInformes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnInformes.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInformes.Image = global::VienaStore.Properties.Resources.informes_32px;
            this.BtnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInformes.Location = new System.Drawing.Point(25, 347);
            this.BtnInformes.Name = "BtnInformes";
            this.BtnInformes.Size = new System.Drawing.Size(155, 45);
            this.BtnInformes.TabIndex = 13;
            this.BtnInformes.TabStop = false;
            this.BtnInformes.Tag = "2";
            this.BtnInformes.Text = "    GENERAR\r\n   INFORMES";
            this.BtnInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInformes.UseCompatibleTextRendering = true;
            this.BtnInformes.UseVisualStyleBackColor = false;
            this.BtnInformes.Click += new System.EventHandler(this.BtnInformes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::VienaStore.Properties.Resources.anularVenta_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(25, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 14;
            this.button1.TabStop = false;
            this.button1.Tag = "2";
            this.button1.Text = "   ANULAR\r\n   VENTA";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu_encargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 718);
            this.Name = "menu_encargado";
            this.Text = "menu_encargado";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogotipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BtnInformes;
        public System.Windows.Forms.Button button1;
    }
}