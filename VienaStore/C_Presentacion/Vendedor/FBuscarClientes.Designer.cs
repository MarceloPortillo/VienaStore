namespace VienaStore.C_Presentacion.Vendedor
{
    partial class FBuscarClientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CBBuscar = new System.Windows.Forms.ComboBox();
            this.LblCLientes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Controls.Add(this.CBBuscar);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(66, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR CLIENTE";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(220, 52);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(508, 32);
            this.TxtBuscar.TabIndex = 2;
            // 
            // CBBuscar
            // 
            this.CBBuscar.BackColor = System.Drawing.Color.LightSalmon;
            this.CBBuscar.FormattingEnabled = true;
            this.CBBuscar.Location = new System.Drawing.Point(33, 52);
            this.CBBuscar.Name = "CBBuscar";
            this.CBBuscar.Size = new System.Drawing.Size(121, 34);
            this.CBBuscar.TabIndex = 1;
            this.CBBuscar.Text = "DNI";
            // 
            // LblCLientes
            // 
            this.LblCLientes.AutoSize = true;
            this.LblCLientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCLientes.ForeColor = System.Drawing.Color.Teal;
            this.LblCLientes.Location = new System.Drawing.Point(59, 250);
            this.LblCLientes.Name = "LblCLientes";
            this.LblCLientes.Size = new System.Drawing.Size(167, 38);
            this.LblCLientes.TabIndex = 1;
            this.LblCLientes.Text = "CLIENTES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 351);
            this.dataGridView1.TabIndex = 2;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = global::VienaStore.Properties.Resources.Eliminar_48x48px;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(238, 714);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(195, 68);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Image = global::VienaStore.Properties.Resources.Editar_Cliente_48x48px;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(456, 714);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(195, 68);
            this.BtnEditar.TabIndex = 4;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Image = global::VienaStore.Properties.Resources.borrar;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(670, 714);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(195, 68);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::VienaStore.Properties.Resources.cancelar_48x48_px;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(879, 714);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(195, 68);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1200, 813);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblCLientes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBuscarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBuscarClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox CBBuscar;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TxtBuscar;
        public System.Windows.Forms.Label LblCLientes;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button BtnEliminar;
        public System.Windows.Forms.Button BtnEditar;
        public System.Windows.Forms.Button BtnLimpiar;
        public System.Windows.Forms.Button BtnCancelar;
    }
}