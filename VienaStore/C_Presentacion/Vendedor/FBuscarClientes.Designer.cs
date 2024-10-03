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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDNI = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Controls.Add(this.CBBuscar);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(67, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(772, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR CLIENTE";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(220, 52);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(508, 32);
            this.TxtBuscar.TabIndex = 2;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // CBBuscar
            // 
            this.CBBuscar.BackColor = System.Drawing.Color.LightSalmon;
            this.CBBuscar.FormattingEnabled = true;
            this.CBBuscar.Location = new System.Drawing.Point(33, 52);
            this.CBBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBBuscar.Name = "CBBuscar";
            this.CBBuscar.Size = new System.Drawing.Size(121, 34);
            this.CBBuscar.TabIndex = 1;
            this.CBBuscar.Text = "DNI";
            // 
            // LblCLientes
            // 
            this.LblCLientes.AutoSize = true;
            this.LblCLientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCLientes.ForeColor = System.Drawing.Color.Black;
            this.LblCLientes.Location = new System.Drawing.Point(59, 250);
            this.LblCLientes.Name = "LblCLientes";
            this.LblCLientes.Size = new System.Drawing.Size(146, 38);
            this.LblCLientes.TabIndex = 1;
            this.LblCLientes.Text = "CLIENTE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 321);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 351);
            this.dataGridView1.TabIndex = 2;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = global::VienaStore.Properties.Resources.Eliminar_48x48px;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(679, 714);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.BtnEditar.Location = new System.Drawing.Point(15, 714);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(467, 714);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(195, 68);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::VienaStore.Properties.Resources.cancelar_48x48_px;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(879, 714);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(195, 68);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::VienaStore.Properties.Resources.guardaCliente_48px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(243, 714);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "GUARDAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.TxtTelefono);
            this.panel1.Controls.Add(this.LblEmail);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.TxtDireccion);
            this.panel1.Controls.Add(this.TxtDNI);
            this.panel1.Controls.Add(this.TxtApellido);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.LblTelefono);
            this.panel1.Controls.Add(this.LblDireccion);
            this.panel1.Controls.Add(this.LblApellido);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Controls.Add(this.LblDNI);
            this.panel1.Location = new System.Drawing.Point(915, 154);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 529);
            this.panel1.TabIndex = 22;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(199, 459);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtTelefono.Mask = "(999)-0000000";
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(292, 23);
            this.TxtTelefono.TabIndex = 18;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(37, 379);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(61, 19);
            this.LblEmail.TabIndex = 17;
            this.LblEmail.Text = "E-mail";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(199, 375);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(292, 23);
            this.TxtEmail.TabIndex = 16;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(199, 293);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(292, 23);
            this.TxtDireccion.TabIndex = 11;
            // 
            // TxtDNI
            // 
            this.TxtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDNI.Location = new System.Drawing.Point(199, 209);
            this.TxtDNI.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(292, 23);
            this.TxtDNI.TabIndex = 10;
            this.TxtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDNI_KeyPress);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(199, 126);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(292, 23);
            this.TxtApellido.TabIndex = 9;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.CausesValidation = false;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(199, 41);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(292, 23);
            this.TxtNombre.TabIndex = 8;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(37, 457);
            this.LblTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(81, 19);
            this.LblTelefono.TabIndex = 6;
            this.LblTelefono.Text = "Teléfono";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(37, 288);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(85, 19);
            this.LblDireccion.TabIndex = 5;
            this.LblDireccion.Text = "Dirección";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(37, 208);
            this.LblApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(39, 19);
            this.LblApellido.TabIndex = 4;
            this.LblApellido.Text = "DNI";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(37, 123);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(73, 19);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Apellido";
            // 
            // LblDNI
            // 
            this.LblDNI.AutoSize = true;
            this.LblDNI.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDNI.Location = new System.Drawing.Point(37, 41);
            this.LblDNI.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDNI.Name = "LblDNI";
            this.LblDNI.Size = new System.Drawing.Size(75, 19);
            this.LblDNI.TabIndex = 2;
            this.LblDNI.Text = "Nombre";
            // 
            // FBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1548, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblCLientes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FBuscarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBuscarClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.MaskedTextBox TxtTelefono;
        public System.Windows.Forms.Label LblEmail;
        public System.Windows.Forms.TextBox TxtEmail;
        public System.Windows.Forms.TextBox TxtDireccion;
        public System.Windows.Forms.TextBox TxtDNI;
        public System.Windows.Forms.TextBox TxtApellido;
        public System.Windows.Forms.TextBox TxtNombre;
        public System.Windows.Forms.Label LblTelefono;
        public System.Windows.Forms.Label LblDireccion;
        public System.Windows.Forms.Label LblApellido;
        public System.Windows.Forms.Label LblNombre;
        public System.Windows.Forms.Label LblDNI;
    }
}