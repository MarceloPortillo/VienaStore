namespace VienaStore.C_Presentacion.Administrador
{
    partial class FGestionProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGestionProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblCuit = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEmpresa = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtCuit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.DtaProveedores = new System.Windows.Forms.DataGridView();
            this.LblProveedoresRegistrados = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.proveedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idproveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtaProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(748, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDORES";
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(1226, 106);
            this.LblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(93, 29);
            this.LblBuscar.TabIndex = 1;
            this.LblBuscar.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(1359, 106);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(309, 30);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.Click += new System.EventHandler(this.TxtBuscar_Click);
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpresa.Location = new System.Drawing.Point(153, 108);
            this.LblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(93, 24);
            this.LblEmpresa.TabIndex = 4;
            this.LblEmpresa.Text = "Empresa";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(901, 108);
            this.LblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(93, 24);
            this.LblTelefono.TabIndex = 5;
            this.LblTelefono.Text = "Telefono";
            // 
            // LblCuit
            // 
            this.LblCuit.AutoSize = true;
            this.LblCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCuit.Location = new System.Drawing.Point(153, 149);
            this.LblCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCuit.Name = "LblCuit";
            this.LblCuit.Size = new System.Drawing.Size(56, 24);
            this.LblCuit.TabIndex = 6;
            this.LblCuit.Text = "CUIT";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(153, 202);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(160, 24);
            this.LblDireccion.TabIndex = 7;
            this.LblDireccion.Text = "Direccion Fiscal";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.Location = new System.Drawing.Point(901, 151);
            this.LblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(69, 24);
            this.LblCorreo.TabIndex = 8;
            this.LblCorreo.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 302);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 9;
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpresa.Location = new System.Drawing.Point(357, 106);
            this.TxtEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Size = new System.Drawing.Size(438, 29);
            this.TxtEmpresa.TabIndex = 2;
            this.TxtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpresa_KeyPress);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(1105, 151);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(438, 29);
            this.TxtCorreo.TabIndex = 6;
            this.TxtCorreo.Leave += new System.EventHandler(this.TxtCorreo_Leave);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(1105, 108);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(438, 29);
            this.TxtTelefono.TabIndex = 5;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(357, 202);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(438, 29);
            this.TxtDireccion.TabIndex = 4;
            // 
            // TxtCuit
            // 
            this.TxtCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuit.Location = new System.Drawing.Point(357, 150);
            this.TxtCuit.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(438, 29);
            this.TxtCuit.TabIndex = 3;
            this.TxtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCuit_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.TxtCuit);
            this.panel1.Controls.Add(this.TxtDireccion);
            this.panel1.Controls.Add(this.TxtTelefono);
            this.panel1.Controls.Add(this.TxtCorreo);
            this.panel1.Controls.Add(this.BtnLimpiar);
            this.panel1.Controls.Add(this.TxtEmpresa);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LblCorreo);
            this.panel1.Controls.Add(this.LblDireccion);
            this.panel1.Controls.Add(this.LblCuit);
            this.panel1.Controls.Add(this.LblTelefono);
            this.panel1.Controls.Add(this.LblEmpresa);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 698);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1738, 352);
            this.panel1.TabIndex = 16;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Coral;
            this.BtnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(1513, 250);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(193, 74);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Coral;
            this.BtnAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = global::VienaStore.Properties.Resources.proveedor_32px;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(1113, 251);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(193, 74);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "  AGREGAR";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Coral;
            this.BtnLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(1314, 250);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(193, 74);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Coral;
            this.BtnEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Image = global::VienaStore.Properties.Resources.Editar_Cliente_48x48px;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(1348, 586);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(196, 85);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // DtaProveedores
            // 
            this.DtaProveedores.AllowUserToAddRows = false;
            this.DtaProveedores.AllowUserToResizeColumns = false;
            this.DtaProveedores.AllowUserToResizeRows = false;
            this.DtaProveedores.AutoGenerateColumns = false;
            this.DtaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaProveedores.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DtaProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtaProveedores.ColumnHeadersHeight = 50;
            this.DtaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empresa,
            this.cuit,
            this.direccion,
            this.telefono,
            this.email,
            this.estado,
            this.idproveedor});
            this.DtaProveedores.DataSource = this.proveedoresBindingSource1;
            this.DtaProveedores.EnableHeadersVisualStyles = false;
            this.DtaProveedores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DtaProveedores.Location = new System.Drawing.Point(13, 181);
            this.DtaProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.DtaProveedores.MultiSelect = false;
            this.DtaProveedores.Name = "DtaProveedores";
            this.DtaProveedores.ReadOnly = true;
            this.DtaProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DtaProveedores.RowHeadersVisible = false;
            this.DtaProveedores.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.DtaProveedores.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DtaProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtaProveedores.Size = new System.Drawing.Size(1738, 377);
            this.DtaProveedores.TabIndex = 20;
            this.DtaProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaProveedores_CellContentClick);
            // 
            // LblProveedoresRegistrados
            // 
            this.LblProveedoresRegistrados.AutoSize = true;
            this.LblProveedoresRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedoresRegistrados.Location = new System.Drawing.Point(46, 106);
            this.LblProveedoresRegistrados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProveedoresRegistrados.Name = "LblProveedoresRegistrados";
            this.LblProveedoresRegistrados.Size = new System.Drawing.Size(311, 29);
            this.LblProveedoresRegistrados.TabIndex = 18;
            this.LblProveedoresRegistrados.Text = "Proveedores Registrados";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Coral;
            this.BtnSalir.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(1563, 585);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(188, 85);
            this.BtnSalir.TabIndex = 12;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // proveedoresBindingSource1
            // 
            this.proveedoresBindingSource1.DataSource = typeof(VienaStore.C_Datos.Proveedores);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(VienaStore.C_Datos.Proveedores);
            // 
            // empresa
            // 
            this.empresa.DataPropertyName = "nombre";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.empresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.empresa.FillWeight = 126.1426F;
            this.empresa.HeaderText = "EMPRESA";
            this.empresa.MinimumWidth = 6;
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "cuit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cuit.DefaultCellStyle = dataGridViewCellStyle3;
            this.cuit.FillWeight = 80.21391F;
            this.cuit.HeaderText = "CUIT";
            this.cuit.MinimumWidth = 6;
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.FillWeight = 126.1426F;
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.telefono.DefaultCellStyle = dataGridViewCellStyle4;
            this.telefono.FillWeight = 86.35411F;
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.FillWeight = 126.1426F;
            this.email.HeaderText = "E-MAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.estado.DefaultCellStyle = dataGridViewCellStyle5;
            this.estado.FillWeight = 55.00405F;
            this.estado.HeaderText = "ESTADO";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idproveedor
            // 
            this.idproveedor.DataPropertyName = "id_proveedor";
            this.idproveedor.HeaderText = "id_proveedor";
            this.idproveedor.MinimumWidth = 6;
            this.idproveedor.Name = "idproveedor";
            this.idproveedor.ReadOnly = true;
            this.idproveedor.Visible = false;
            // 
            // FGestionProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1848, 1107);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblProveedoresRegistrados);
            this.Controls.Add(this.DtaProveedores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FGestionProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FGestionProveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtaProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblEmpresa;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblCuit;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmpresa;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtCuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblProveedoresRegistrados;
        public System.Windows.Forms.Button BtnLimpiar;
        public System.Windows.Forms.Button BtnSalir;
        public System.Windows.Forms.Button BtnEditar;
        public System.Windows.Forms.Button BtnAgregar;
        public System.Windows.Forms.Button BtnGuardar;
        public System.Windows.Forms.DataGridView DtaProveedores;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private System.Windows.Forms.BindingSource proveedoresBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewButtonColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedor;
    }
}