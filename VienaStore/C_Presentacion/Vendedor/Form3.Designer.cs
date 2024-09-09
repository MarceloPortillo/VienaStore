namespace VienaStore.C_Presentacion.Vendedor
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnRegistrarCliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
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
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Coral;
            this.button6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::VienaStore.Properties.Resources.listaProductos;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(25, 433);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 57);
            this.button6.TabIndex = 5;
            this.button6.Text = "LISTAR \r\nPRODUCTOS";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Coral;
            this.button5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::VienaStore.Properties.Resources.buscarProducto;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(25, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 59);
            this.button5.TabIndex = 4;
            this.button5.Text = "BUSCAR\r\nPRODUCTOS";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Coral;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::VienaStore.Properties.Resources.Listar;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(25, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "   LISTAR     CLIENTES";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Coral;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::VienaStore.Properties.Resources.buscarCliente;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(25, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "  BUSCAR   CLIENTE";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::VienaStore.Properties.Resources.editar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(25, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "MODIFICAR \r\nCLIENTE";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
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
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.TxtFecha);
            this.panel2.Controls.Add(this.LblBienvenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(204, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 51);
            this.panel2.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.Image = global::VienaStore.Properties.Resources.CierreSesion;
            this.button7.Location = new System.Drawing.Point(547, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 51);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = true;
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
            // Form3
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
            this.Name = "Form3";
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnRegistrarCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblBienvenido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TxtFecha;
        private System.Windows.Forms.Timer fecha;
        private System.Windows.Forms.Button button7;
    }
}