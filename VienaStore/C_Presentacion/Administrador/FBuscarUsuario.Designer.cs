namespace VienaStore.C_Presentacion.Administrador
{
    partial class FBuscarUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtaUsuario = new System.Windows.Forms.DataGridView();
            this.ColLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.CboRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // DtaUsuario
            // 
            this.DtaUsuario.AllowUserToAddRows = false;
            this.DtaUsuario.AllowUserToOrderColumns = true;
            this.DtaUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaUsuario.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DtaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLegajo,
            this.ColNombre,
            this.ColApellido,
            this.ColDni,
            this.ColEmail,
            this.ColDireccion,
            this.ColTel,
            this.ColUsuario});
            this.DtaUsuario.EnableHeadersVisualStyles = false;
            this.DtaUsuario.Location = new System.Drawing.Point(531, 133);
            this.DtaUsuario.Name = "DtaUsuario";
            this.DtaUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DtaUsuario.RowHeadersVisible = false;
            this.DtaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtaUsuario.Size = new System.Drawing.Size(646, 242);
            this.DtaUsuario.TabIndex = 1;
            // 
            // ColLegajo
            // 
            this.ColLegajo.HeaderText = "Legajo";
            this.ColLegajo.Name = "ColLegajo";
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            // 
            // ColApellido
            // 
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.Name = "ColApellido";
            // 
            // ColDni
            // 
            this.ColDni.HeaderText = "Dni";
            this.ColDni.Name = "ColDni";
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "E-mail";
            this.ColEmail.Name = "ColEmail";
            // 
            // ColDireccion
            // 
            this.ColDireccion.HeaderText = "Dirección";
            this.ColDireccion.Name = "ColDireccion";
            // 
            // ColTel
            // 
            this.ColTel.HeaderText = "Teléfono";
            this.ColTel.Name = "ColTel";
            // 
            // ColUsuario
            // 
            this.ColUsuario.HeaderText = "Usuario";
            this.ColUsuario.Name = "ColUsuario";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(142, 424);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTelefono.Mask = "(999)-0000000";
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(334, 20);
            this.TxtTelefono.TabIndex = 30;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(35, 366);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(51, 16);
            this.LblEmail.TabIndex = 29;
            this.LblEmail.Text = "E-mail";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(142, 366);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(334, 20);
            this.TxtEmail.TabIndex = 28;
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(142, 308);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(334, 20);
            this.TxtDireccion.TabIndex = 27;
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(142, 250);
            this.TxtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(334, 20);
            this.TxtDNI.TabIndex = 26;
            this.TxtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDNI_KeyPress);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(142, 192);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(334, 20);
            this.TxtApellido.TabIndex = 25;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.CausesValidation = false;
            this.TxtNombre.Location = new System.Drawing.Point(142, 134);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(334, 20);
            this.TxtNombre.TabIndex = 24;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(35, 424);
            this.LblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(69, 16);
            this.LblTelefono.TabIndex = 23;
            this.LblTelefono.Text = "Teléfono";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(35, 308);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(72, 16);
            this.LblDireccion.TabIndex = 22;
            this.LblDireccion.Text = "Dirección";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(35, 250);
            this.LblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(33, 16);
            this.LblApellido.TabIndex = 21;
            this.LblApellido.Text = "DNI";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(35, 185);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(64, 16);
            this.LblNombre.TabIndex = 20;
            this.LblNombre.Text = "Apellido";
            // 
            // LblDNI
            // 
            this.LblDNI.AutoSize = true;
            this.LblDNI.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDNI.Location = new System.Drawing.Point(35, 134);
            this.LblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDNI.Name = "LblDNI";
            this.LblDNI.Size = new System.Drawing.Size(62, 16);
            this.LblDNI.TabIndex = 19;
            this.LblDNI.Text = "Nombre";
            // 
            // CboRol
            // 
            this.CboRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboRol.FormattingEnabled = true;
            this.CboRol.Items.AddRange(new object[] {
            "Vendedor",
            "Encargado",
            "Administrador"});
            this.CboRol.Location = new System.Drawing.Point(298, 588);
            this.CboRol.Name = "CboRol";
            this.CboRol.Size = new System.Drawing.Size(153, 21);
            this.CboRol.TabIndex = 36;
            this.CboRol.Text = "Seleccione un Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 588);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Rol";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.Location = new System.Drawing.Point(35, 540);
            this.LblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(91, 16);
            this.LblContraseña.TabIndex = 34;
            this.LblContraseña.Text = "Contraseña";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(35, 482);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(62, 16);
            this.LblUsuario.TabIndex = 33;
            this.LblUsuario.Text = "Usuario";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(142, 540);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(334, 20);
            this.TxtContraseña.TabIndex = 32;
            this.TxtContraseña.UseSystemPasswordChar = true;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(140, 482);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(334, 20);
            this.TxtUsuario.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 48);
            this.label1.TabIndex = 37;
            this.label1.Text = "BUSCAR USUARIO";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(184, 91);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(233, 20);
            this.TxtBuscar.TabIndex = 38;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(136, 54);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(340, 24);
            this.LblBuscar.TabIndex = 39;
            this.LblBuscar.Text = "Ingrese el DNI o el Nro de LEGAJO";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Coral;
            this.BtnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::VienaStore.Properties.Resources.guardar_48x48_px;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(679, 576);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(152, 69);
            this.BtnGuardar.TabIndex = 40;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Coral;
            this.BtnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::VienaStore.Properties.Resources.cancelar_48x48_px;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(1015, 576);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(152, 69);
            this.BtnCancelar.TabIndex = 41;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Coral;
            this.BtnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = global::VienaStore.Properties.Resources.Eliminar_48x48px;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(847, 576);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(152, 69);
            this.BtnEliminar.TabIndex = 42;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Coral;
            this.BtnEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Image = global::VienaStore.Properties.Resources.Editar_Cliente_48x48px;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(511, 576);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(152, 69);
            this.BtnEditar.TabIndex = 43;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = global::VienaStore.Properties.Resources.lupaBuscar_32px;
            this.BtnBuscar.Location = new System.Drawing.Point(423, 82);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 37);
            this.BtnBuscar.TabIndex = 44;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // FBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1236, 728);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtDNI);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblDNI);
            this.Controls.Add(this.DtaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBuscarUsuario";
            this.Text = "FBuscarUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DtaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DtaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuario;
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
        private System.Windows.Forms.ComboBox CboRol;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LblContraseña;
        public System.Windows.Forms.Label LblUsuario;
        public System.Windows.Forms.TextBox TxtContraseña;
        public System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblBuscar;
        public System.Windows.Forms.Button BtnGuardar;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button BtnEliminar;
        public System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnBuscar;
    }
}