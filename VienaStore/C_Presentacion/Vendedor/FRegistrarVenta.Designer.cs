namespace VienaStore.C_Presentacion.Vendedor
{
    partial class FRegistrarVenta
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
            this.LblNuevaVenta = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnConfirmarVenta = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.DataGridView();
            this.NroProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GBEmpleado = new System.Windows.Forms.GroupBox();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.GBCliente = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.LblCliente = new System.Windows.Forms.Label();
            this.GBProducto = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LblPrecioVenta = new System.Windows.Forms.Label();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.LblStock = new System.Windows.Forms.Label();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.BtnBuscarDescripcion = new System.Windows.Forms.Button();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.LblFactura = new System.Windows.Forms.Label();
            this.CBFactura = new System.Windows.Forms.ComboBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.LblIVA = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.PVenta = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LblTotal)).BeginInit();
            this.GBEmpleado.SuspendLayout();
            this.GBCliente.SuspendLayout();
            this.GBProducto.SuspendLayout();
            this.PVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNuevaVenta
            // 
            this.LblNuevaVenta.AutoSize = true;
            this.LblNuevaVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNuevaVenta.Location = new System.Drawing.Point(21, 9);
            this.LblNuevaVenta.Name = "LblNuevaVenta";
            this.LblNuevaVenta.Size = new System.Drawing.Size(237, 48);
            this.LblNuevaVenta.TabIndex = 0;
            this.LblNuevaVenta.Text = "Nueva Venta";
            this.LblNuevaVenta.UseCompatibleTextRendering = true;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(600, 133);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(74, 19);
            this.LblCantidad.TabIndex = 5;
            this.LblCantidad.Text = "Cantidad";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(680, 131);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(60, 27);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Text = "0";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(783, 131);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(291, 34);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmarVenta
            // 
            this.BtnConfirmarVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmarVenta.Location = new System.Drawing.Point(662, 786);
            this.BtnConfirmarVenta.Name = "BtnConfirmarVenta";
            this.BtnConfirmarVenta.Size = new System.Drawing.Size(410, 55);
            this.BtnConfirmarVenta.TabIndex = 9;
            this.BtnConfirmarVenta.Text = "Confirmar Venta";
            this.BtnConfirmarVenta.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::VienaStore.Properties.Resources.cancelar_48x48_px;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(1084, 786);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(165, 55);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AllowUserToAddRows = false;
            this.LblTotal.AllowUserToOrderColumns = true;
            this.LblTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LblTotal.BackgroundColor = System.Drawing.Color.MistyRose;
            this.LblTotal.ColumnHeadersHeight = 29;
            this.LblTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LblTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroProducto,
            this.Descripcion,
            this.Cantidad,
            this.PrecioUnitario,
            this.SubTotal,
            this.ELIMINAR});
            this.LblTotal.EnableHeadersVisualStyles = false;
            this.LblTotal.Location = new System.Drawing.Point(31, 490);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.LblTotal.RowHeadersVisible = false;
            this.LblTotal.RowHeadersWidth = 51;
            this.LblTotal.RowTemplate.Height = 24;
            this.LblTotal.Size = new System.Drawing.Size(1105, 150);
            this.LblTotal.TabIndex = 0;
            // 
            // NroProducto
            // 
            this.NroProducto.HeaderText = "NroProducto";
            this.NroProducto.MinimumWidth = 6;
            this.NroProducto.Name = "NroProducto";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.MinimumWidth = 6;
            this.ELIMINAR.Name = "ELIMINAR";
            // 
            // GBEmpleado
            // 
            this.GBEmpleado.Controls.Add(this.LblEmpleado);
            this.GBEmpleado.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBEmpleado.Location = new System.Drawing.Point(31, 21);
            this.GBEmpleado.Name = "GBEmpleado";
            this.GBEmpleado.Size = new System.Drawing.Size(544, 121);
            this.GBEmpleado.TabIndex = 12;
            this.GBEmpleado.TabStop = false;
            this.GBEmpleado.Text = "EMPLEADO";
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpleado.Location = new System.Drawing.Point(32, 36);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(89, 19);
            this.LblEmpleado.TabIndex = 0;
            this.LblEmpleado.Text = "Empleado:";
            // 
            // GBCliente
            // 
            this.GBCliente.Controls.Add(this.textBox2);
            this.GBCliente.Controls.Add(this.textBox1);
            this.GBCliente.Controls.Add(this.BtnBuscarCliente);
            this.GBCliente.Controls.Add(this.LblCliente);
            this.GBCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCliente.Location = new System.Drawing.Point(592, 21);
            this.GBCliente.Name = "GBCliente";
            this.GBCliente.Size = new System.Drawing.Size(544, 121);
            this.GBCliente.TabIndex = 13;
            this.GBCliente.TabStop = false;
            this.GBCliente.Text = "CLIENTE";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(507, 32);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 32);
            this.textBox1.TabIndex = 2;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(417, 27);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(111, 37);
            this.BtnBuscarCliente.TabIndex = 1;
            this.BtnBuscarCliente.Text = "BUSCAR";
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(17, 33);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(78, 22);
            this.LblCliente.TabIndex = 0;
            this.LblCliente.Text = "Cliente:";
            // 
            // GBProducto
            // 
            this.GBProducto.Controls.Add(this.textBox4);
            this.GBProducto.Controls.Add(this.LblPrecioVenta);
            this.GBProducto.Controls.Add(this.TBStock);
            this.GBProducto.Controls.Add(this.LblStock);
            this.GBProducto.Controls.Add(this.TBDescripcion);
            this.GBProducto.Controls.Add(this.BtnBuscarDescripcion);
            this.GBProducto.Controls.Add(this.LblDescripcion);
            this.GBProducto.Controls.Add(this.BtnAgregar);
            this.GBProducto.Controls.Add(this.TBProducto);
            this.GBProducto.Controls.Add(this.comboBox3);
            this.GBProducto.Controls.Add(this.textBox3);
            this.GBProducto.Controls.Add(this.LblCantidad);
            this.GBProducto.Controls.Add(this.LblProducto);
            this.GBProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBProducto.Location = new System.Drawing.Point(31, 190);
            this.GBProducto.Name = "GBProducto";
            this.GBProducto.Size = new System.Drawing.Size(1104, 186);
            this.GBProducto.TabIndex = 14;
            this.GBProducto.TabStop = false;
            this.GBProducto.Text = "PRODUCTO";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(373, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(162, 32);
            this.textBox4.TabIndex = 9;
            // 
            // LblPrecioVenta
            // 
            this.LblPrecioVenta.AutoSize = true;
            this.LblPrecioVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioVenta.Location = new System.Drawing.Point(249, 133);
            this.LblPrecioVenta.Name = "LblPrecioVenta";
            this.LblPrecioVenta.Size = new System.Drawing.Size(109, 19);
            this.LblPrecioVenta.TabIndex = 8;
            this.LblPrecioVenta.Text = "Precio Venta:";
            // 
            // TBStock
            // 
            this.TBStock.Location = new System.Drawing.Point(87, 124);
            this.TBStock.Name = "TBStock";
            this.TBStock.ReadOnly = true;
            this.TBStock.Size = new System.Drawing.Size(125, 32);
            this.TBStock.TabIndex = 7;
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.Location = new System.Drawing.Point(22, 132);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(59, 19);
            this.LblStock.TabIndex = 6;
            this.LblStock.Text = "Stock:";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(536, 78);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.ReadOnly = true;
            this.TBDescripcion.Size = new System.Drawing.Size(553, 32);
            this.TBDescripcion.TabIndex = 5;
            // 
            // BtnBuscarDescripcion
            // 
            this.BtnBuscarDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarDescripcion.Location = new System.Drawing.Point(978, 29);
            this.BtnBuscarDescripcion.Name = "BtnBuscarDescripcion";
            this.BtnBuscarDescripcion.Size = new System.Drawing.Size(111, 37);
            this.BtnBuscarDescripcion.TabIndex = 4;
            this.BtnBuscarDescripcion.Text = "BUSCAR";
            this.BtnBuscarDescripcion.UseVisualStyleBackColor = true;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(532, 43);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(93, 19);
            this.LblDescripcion.TabIndex = 3;
            this.LblDescripcion.Text = "Descripción";
            // 
            // TBProducto
            // 
            this.TBProducto.Location = new System.Drawing.Point(26, 78);
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.ReadOnly = true;
            this.TBProducto.Size = new System.Drawing.Size(399, 32);
            this.TBProducto.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(106, 32);
            this.textBox3.TabIndex = 1;
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(21, 47);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(76, 19);
            this.LblProducto.TabIndex = 0;
            this.LblProducto.Text = "Producto";
            // 
            // LblFactura
            // 
            this.LblFactura.AutoSize = true;
            this.LblFactura.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFactura.Location = new System.Drawing.Point(27, 413);
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(65, 19);
            this.LblFactura.TabIndex = 15;
            this.LblFactura.Text = "Factura";
            // 
            // CBFactura
            // 
            this.CBFactura.FormattingEnabled = true;
            this.CBFactura.Items.AddRange(new object[] {
            "FACTURA A",
            "FACTURA B",
            "REMITO"});
            this.CBFactura.Location = new System.Drawing.Point(118, 408);
            this.CBFactura.Name = "CBFactura";
            this.CBFactura.Size = new System.Drawing.Size(174, 24);
            this.CBFactura.TabIndex = 16;
            this.CBFactura.Text = "Seleccione la Factura";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(707, 413);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(60, 19);
            this.LblFecha.TabIndex = 17;
            this.LblFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(773, 413);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.Location = new System.Drawing.Point(435, 654);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(100, 22);
            this.LblSubTotal.TabIndex = 19;
            this.LblSubTotal.Text = "Sub Total:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(566, 654);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(83, 22);
            this.textBox5.TabIndex = 20;
            this.textBox5.Text = "0";
            // 
            // LblIVA
            // 
            this.LblIVA.AutoSize = true;
            this.LblIVA.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIVA.Location = new System.Drawing.Point(677, 652);
            this.LblIVA.Name = "LblIVA";
            this.LblIVA.Size = new System.Drawing.Size(50, 22);
            this.LblIVA.TabIndex = 21;
            this.LblIVA.Text = "IVA:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(748, 652);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(83, 22);
            this.textBox6.TabIndex = 22;
            this.textBox6.Text = "0,21";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(872, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(986, 650);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 22);
            this.textBox7.TabIndex = 24;
            // 
            // PVenta
            // 
            this.PVenta.BackColor = System.Drawing.Color.Coral;
            this.PVenta.Controls.Add(this.GBCliente);
            this.PVenta.Controls.Add(this.GBProducto);
            this.PVenta.Controls.Add(this.GBEmpleado);
            this.PVenta.Controls.Add(this.LblSubTotal);
            this.PVenta.Controls.Add(this.textBox5);
            this.PVenta.Controls.Add(this.LblIVA);
            this.PVenta.Controls.Add(this.textBox6);
            this.PVenta.Controls.Add(this.label1);
            this.PVenta.Controls.Add(this.textBox7);
            this.PVenta.Controls.Add(this.LblFecha);
            this.PVenta.Controls.Add(this.CBFactura);
            this.PVenta.Controls.Add(this.LblFactura);
            this.PVenta.Controls.Add(this.dateTimePicker1);
            this.PVenta.Controls.Add(this.LblTotal);
            this.PVenta.Location = new System.Drawing.Point(78, 60);
            this.PVenta.Name = "PVenta";
            this.PVenta.Size = new System.Drawing.Size(1171, 699);
            this.PVenta.TabIndex = 25;
            // 
            // FRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1284, 888);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnConfirmarVenta);
            this.Controls.Add(this.LblNuevaVenta);
            this.Controls.Add(this.PVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRegistrarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRegistrarVenta1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.LblTotal)).EndInit();
            this.GBEmpleado.ResumeLayout(false);
            this.GBEmpleado.PerformLayout();
            this.GBCliente.ResumeLayout(false);
            this.GBCliente.PerformLayout();
            this.GBProducto.ResumeLayout(false);
            this.GBProducto.PerformLayout();
            this.PVenta.ResumeLayout(false);
            this.PVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblNuevaVenta;
        public System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnConfirmarVenta;
        public System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView LblTotal;
        private System.Windows.Forms.GroupBox GBEmpleado;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.GroupBox GBCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox GBProducto;
        private System.Windows.Forms.Button BtnBuscarDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TBProducto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.TextBox TBStock;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LblPrecioVenta;
        private System.Windows.Forms.Label LblFactura;
        private System.Windows.Forms.ComboBox CBFactura;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label LblIVA;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel PVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ELIMINAR;
    }
}