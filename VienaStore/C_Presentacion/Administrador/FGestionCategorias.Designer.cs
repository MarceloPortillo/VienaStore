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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGestionCategorias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTituloCategorias = new System.Windows.Forms.Label();
            this.LblDNI = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.DtaUsuario = new System.Windows.Forms.DataGridView();
            this.id_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnActivarDesactivar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAgreCat = new System.Windows.Forms.Button();
            this.TxtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DtaUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
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
            this.LblDNI.Location = new System.Drawing.Point(253, 128);
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
            this.TxtNombre.Location = new System.Drawing.Point(359, 128);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(171, 20);
            this.TxtNombre.TabIndex = 26;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 175);
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
            this.TxtDescripcion.Location = new System.Drawing.Point(359, 174);
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
            this.DtaUsuario.AllowUserToResizeColumns = false;
            this.DtaUsuario.AllowUserToResizeRows = false;
            this.DtaUsuario.AutoGenerateColumns = false;
            this.DtaUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaUsuario.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DtaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Categoria,
            this.nombre,
            this.descripcion,
            this.estadoDataGridViewTextBoxColumn,
            this.BtnActivarDesactivar});
            this.DtaUsuario.DataSource = this.categoriasBindingSource;
            this.DtaUsuario.EnableHeadersVisualStyles = false;
            this.DtaUsuario.Location = new System.Drawing.Point(194, 312);
            this.DtaUsuario.MultiSelect = false;
            this.DtaUsuario.Name = "DtaUsuario";
            this.DtaUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DtaUsuario.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DtaUsuario.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DtaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtaUsuario.Size = new System.Drawing.Size(694, 187);
            this.DtaUsuario.TabIndex = 31;
            this.DtaUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaUsuario_CellContentClick);
            // 
            // id_Categoria
            // 
            this.id_Categoria.DataPropertyName = "id_Categoria";
            this.id_Categoria.FillWeight = 35.55792F;
            this.id_Categoria.HeaderText = "COD. CAT";
            this.id_Categoria.Name = "id_Categoria";
            this.id_Categoria.ReadOnly = true;
            this.id_Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BtnActivarDesactivar
            // 
            this.BtnActivarDesactivar.DataPropertyName = "estado";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.BtnActivarDesactivar.DefaultCellStyle = dataGridViewCellStyle5;
            this.BtnActivarDesactivar.FillWeight = 78.67189F;
            this.BtnActivarDesactivar.HeaderText = "ESTADO";
            this.BtnActivarDesactivar.Name = "BtnActivarDesactivar";
            this.BtnActivarDesactivar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnActivarDesactivar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnActivarDesactivar.Text = "ELIMINAR";
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Coral;
            this.BtnModificar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = global::VienaStore.Properties.Resources.modificar_48px;
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(472, 520);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(161, 60);
            this.BtnModificar.TabIndex = 32;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(276, 520);
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
            this.BtnAgreCat.Location = new System.Drawing.Point(84, 520);
            this.BtnAgreCat.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgreCat.Name = "BtnAgreCat";
            this.BtnAgreCat.Size = new System.Drawing.Size(152, 60);
            this.BtnAgreCat.TabIndex = 35;
            this.BtnAgreCat.Text = "AGREGAR";
            this.BtnAgreCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgreCat.UseVisualStyleBackColor = false;
            this.BtnAgreCat.Click += new System.EventHandler(this.BtnAgreCat_Click);
            // 
            // TxtBuscarCategoria
            // 
            this.TxtBuscarCategoria.CausesValidation = false;
            this.TxtBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarCategoria.Location = new System.Drawing.Point(359, 270);
            this.TxtBuscarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscarCategoria.Name = "TxtBuscarCategoria";
            this.TxtBuscarCategoria.Size = new System.Drawing.Size(171, 20);
            this.TxtBuscarCategoria.TabIndex = 36;
            this.TxtBuscarCategoria.TextChanged += new System.EventHandler(this.TxtBuscarCategoria_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Buscar";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Coral;
            this.BtnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = global::VienaStore.Properties.Resources.guardar_48x48_px;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(654, 520);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(161, 60);
            this.BtnSave.TabIndex = 38;
            this.BtnSave.Text = "GUARDAR";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombre.FillWeight = 78.67189F;
            this.nombre.HeaderText = "CATEGORIA";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.descripcion.FillWeight = 228.4264F;
            this.descripcion.HeaderText = "DESCRIPCIÓN";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.estadoDataGridViewTextBoxColumn.FillWeight = 78.67189F;
            this.estadoDataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(VienaStore.C_Datos.Categorias);
            // 
            // FGestionCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1240, 625);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBuscarCategoria);
            this.Controls.Add(this.BtnAgreCat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnModificar);
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
            this.Load += new System.EventHandler(this.FGestionCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtaUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
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
        public System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAgregarCat;
        public System.Windows.Forms.Button BtnModificar;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button BtnAgreCat;
        public System.Windows.Forms.TextBox TxtBuscarCategoria;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        public System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BtnActivarDesactivar;
    }
}