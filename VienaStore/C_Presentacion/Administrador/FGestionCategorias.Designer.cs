namespace VienaStore.C_Presentacion.Administrador
{
    partial class FGestionCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGestionCategorias));
            this.LblTituloCategorias = new System.Windows.Forms.Label();
            this.LblDNI = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.DtaUsuario = new System.Windows.Forms.DataGridView();
            this.ColNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAgreCat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTituloCategorias
            // 
            this.LblTituloCategorias.AutoSize = true;
            this.LblTituloCategorias.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCategorias.ForeColor = System.Drawing.Color.Black;
            this.LblTituloCategorias.Location = new System.Drawing.Point(386, 20);
            this.LblTituloCategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTituloCategorias.Name = "LblTituloCategorias";
            this.LblTituloCategorias.Size = new System.Drawing.Size(386, 34);
            this.LblTituloCategorias.TabIndex = 24;
            this.LblTituloCategorias.Text = "GESTIONAR CATEGORIAS\r\n";
            // 
            // LblDNI
            // 
            this.LblDNI.AutoSize = true;
            this.LblDNI.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDNI.Location = new System.Drawing.Point(174, 132);
            this.LblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDNI.Name = "LblDNI";
            this.LblDNI.Size = new System.Drawing.Size(62, 16);
            this.LblDNI.TabIndex = 25;
            this.LblDNI.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.CausesValidation = false;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(288, 132);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(171, 20);
            this.TxtNombre.TabIndex = 26;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Descripción";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.CausesValidation = false;
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(288, 174);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(334, 50);
            this.TxtDescripcion.TabIndex = 28;
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
            this.ColNom,
            this.ColDescrip,
            this.ColEstado});
            this.DtaUsuario.EnableHeadersVisualStyles = false;
            this.DtaUsuario.Location = new System.Drawing.Point(262, 314);
            this.DtaUsuario.Name = "DtaUsuario";
            this.DtaUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DtaUsuario.RowHeadersVisible = false;
            this.DtaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtaUsuario.Size = new System.Drawing.Size(694, 187);
            this.DtaUsuario.TabIndex = 31;
            // 
            // ColNom
            // 
            this.ColNom.FillWeight = 58.32961F;
            this.ColNom.HeaderText = "NOMBRE";
            this.ColNom.Name = "ColNom";
            // 
            // ColDescrip
            // 
            this.ColDescrip.FillWeight = 165.5283F;
            this.ColDescrip.HeaderText = "DESCRIPCIÓN";
            this.ColDescrip.Name = "ColDescrip";
            // 
            // ColEstado
            // 
            this.ColEstado.FillWeight = 76.14214F;
            this.ColEstado.HeaderText = "ESTADO";
            this.ColEstado.Name = "ColEstado";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Coral;
            this.BtnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::VienaStore.Properties.Resources.modificar_48px;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(634, 520);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(161, 60);
            this.BtnGuardar.TabIndex = 32;
            this.BtnGuardar.Text = "MODIFICAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(443, 520);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 60);
            this.button1.TabIndex = 33;
            this.button1.Text = "LIMPIAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(833, 520);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 60);
            this.button2.TabIndex = 34;
            this.button2.Text = "CANCELAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnAgreCat
            // 
            this.BtnAgreCat.BackColor = System.Drawing.Color.Coral;
            this.BtnAgreCat.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgreCat.Image = global::VienaStore.Properties.Resources.signoMas_48;
            this.BtnAgreCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgreCat.Location = new System.Drawing.Point(262, 520);
            this.BtnAgreCat.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgreCat.Name = "BtnAgreCat";
            this.BtnAgreCat.Size = new System.Drawing.Size(152, 60);
            this.BtnAgreCat.TabIndex = 35;
            this.BtnAgreCat.Text = "AGREGAR";
            this.BtnAgreCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgreCat.UseVisualStyleBackColor = false;
            this.BtnAgreCat.Click += new System.EventHandler(this.BtnAgreCat_Click);
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(556, 267);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Buscar";
            // 
            // FGestionCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1240, 625);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnAgreCat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DtaUsuario);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblDNI);
            this.Controls.Add(this.LblTituloCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FGestionCategorias";
            this.Text = "Categorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DtaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblTituloCategorias;
        public System.Windows.Forms.Label LblDNI;
        public System.Windows.Forms.TextBox TxtNombre;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtDescripcion;
        public System.Windows.Forms.DataGridView DtaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        public System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAgregarCat;
        public System.Windows.Forms.Button BtnGuardar;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button BtnAgreCat;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label2;
    }
}