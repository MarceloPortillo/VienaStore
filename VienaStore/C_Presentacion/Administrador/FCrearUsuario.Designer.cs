namespace VienaStore.C_Presentacion.Administrador
{
    partial class FCrearUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CboRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.DtaUsuario = new System.Windows.Forms.DataGridView();
            this.ColLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(469, 9);
            this.label1.Size = new System.Drawing.Size(328, 34);
            this.label1.Text = "REGISTRAR USUARIO";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(503, 637);
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // LblDNI
            // 
            this.LblDNI.Location = new System.Drawing.Point(25, 29);
            // 
            // LblNombre
            // 
            this.LblNombre.Location = new System.Drawing.Point(25, 79);
            // 
            // LblApellido
            // 
            this.LblApellido.Location = new System.Drawing.Point(25, 138);
            // 
            // LblDireccion
            // 
            this.LblDireccion.Location = new System.Drawing.Point(25, 244);
            // 
            // LblTelefono
            // 
            this.LblTelefono.Location = new System.Drawing.Point(28, 294);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(143, 79);
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(143, 138);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(143, 29);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(143, 244);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(143, 190);
            // 
            // LblEmail
            // 
            this.LblEmail.Location = new System.Drawing.Point(25, 190);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(143, 294);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(707, 637);
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(815, 628);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(143, 346);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(334, 22);
            this.TxtUsuario.TabIndex = 21;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(143, 391);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(334, 22);
            this.TxtContraseña.TabIndex = 22;
            this.TxtContraseña.UseSystemPasswordChar = true;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(28, 346);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(62, 16);
            this.LblUsuario.TabIndex = 23;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.Location = new System.Drawing.Point(28, 397);
            this.LblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(91, 16);
            this.LblContraseña.TabIndex = 24;
            this.LblContraseña.Text = "Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.CboRol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblContraseña);
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.TxtContraseña);
            this.panel1.Controls.Add(this.TxtUsuario);
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
            this.panel1.Location = new System.Drawing.Point(23, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 523);
            this.panel1.TabIndex = 25;
            this.panel1.Controls.SetChildIndex(this.LblDNI, 0);
            this.panel1.Controls.SetChildIndex(this.LblNombre, 0);
            this.panel1.Controls.SetChildIndex(this.LblApellido, 0);
            this.panel1.Controls.SetChildIndex(this.LblDireccion, 0);
            this.panel1.Controls.SetChildIndex(this.LblTelefono, 0);
            this.panel1.Controls.SetChildIndex(this.TxtNombre, 0);
            this.panel1.Controls.SetChildIndex(this.TxtApellido, 0);
            this.panel1.Controls.SetChildIndex(this.TxtDNI, 0);
            this.panel1.Controls.SetChildIndex(this.TxtDireccion, 0);
            this.panel1.Controls.SetChildIndex(this.TxtEmail, 0);
            this.panel1.Controls.SetChildIndex(this.LblEmail, 0);
            this.panel1.Controls.SetChildIndex(this.TxtTelefono, 0);
            this.panel1.Controls.SetChildIndex(this.TxtUsuario, 0);
            this.panel1.Controls.SetChildIndex(this.TxtContraseña, 0);
            this.panel1.Controls.SetChildIndex(this.LblUsuario, 0);
            this.panel1.Controls.SetChildIndex(this.LblContraseña, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.CboRol, 0);
            // 
            // CboRol
            // 
            this.CboRol.FormattingEnabled = true;
            this.CboRol.Items.AddRange(new object[] {
            "Vendedor",
            "Encargado",
            "Administrador"});
            this.CboRol.Location = new System.Drawing.Point(313, 447);
            this.CboRol.Name = "CboRol";
            this.CboRol.Size = new System.Drawing.Size(153, 24);
            this.CboRol.TabIndex = 26;
            this.CboRol.Text = "Seleccione un Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Rol";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Coral;
            this.BtnLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Image = global::VienaStore.Properties.Resources.borrar;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(293, 637);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(162, 82);
            this.BtnLimpiar.TabIndex = 26;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // DtaUsuario
            // 
            this.DtaUsuario.AllowUserToAddRows = false;
            this.DtaUsuario.AllowUserToOrderColumns = true;
            this.DtaUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaUsuario.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DtaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.DtaUsuario.Location = new System.Drawing.Point(582, 203);
            this.DtaUsuario.Name = "DtaUsuario";
            this.DtaUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DtaUsuario.RowHeadersVisible = false;
            this.DtaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtaUsuario.Size = new System.Drawing.Size(646, 242);
            this.DtaUsuario.TabIndex = 0;
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
            // FCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 788);
            this.Controls.Add(this.DtaUsuario);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FCrearUsuario";
            this.Text = "FCrearUsuario";
            this.Load += new System.EventHandler(this.FCrearUsuario_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.BtnLimpiar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.BtnGuardar, 0);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.DtaUsuario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtUsuario;
        public System.Windows.Forms.TextBox TxtContraseña;
        public System.Windows.Forms.Label LblUsuario;
        public System.Windows.Forms.Label LblContraseña;
        public System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.ComboBox CboRol;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuario;
        public System.Windows.Forms.DataGridView DtaUsuario;
        public System.Windows.Forms.Panel panel1;
    }
}