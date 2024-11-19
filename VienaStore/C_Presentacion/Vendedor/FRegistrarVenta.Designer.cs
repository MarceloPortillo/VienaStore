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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnConfirmarVenta = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GBEmpleado = new System.Windows.Forms.GroupBox();
            this.TxtEmpleado = new System.Windows.Forms.TextBox();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.GBCliente = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDNI = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.LblCliente = new System.Windows.Forms.Label();
            this.GBProducto = new System.Windows.Forms.GroupBox();
            this.LblNombreProducto = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.LblPrecioVenta = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.LblStock = new System.Windows.Forms.Label();
            this.TxtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.BtnBuscarProducto = new System.Windows.Forms.Button();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.TxtCodProd = new System.Windows.Forms.TextBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.LblFactura = new System.Windows.Forms.Label();
            this.CBFactura = new System.Windows.Forms.ComboBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Panel();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.CBFormaDePago = new System.Windows.Forms.ComboBox();
            this.LblTipoPago = new System.Windows.Forms.Label();
            this.DtaProductos = new System.Windows.Forms.DataGridView();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GBEmpleado.SuspendLayout();
            this.GBCliente.SuspendLayout();
            this.GBProducto.SuspendLayout();
            this.LblDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtaProductos)).BeginInit();
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
            this.LblCantidad.Location = new System.Drawing.Point(658, 108);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(81, 19);
            this.LblCantidad.TabIndex = 5;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = global::VienaStore.Properties.Resources.signoMas_48;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(1107, 87);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(218, 71);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnConfirmarVenta
            // 
            this.BtnConfirmarVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmarVenta.Image = global::VienaStore.Properties.Resources.Confirmar_48x48px;
            this.BtnConfirmarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmarVenta.Location = new System.Drawing.Point(1051, 852);
            this.BtnConfirmarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConfirmarVenta.Name = "BtnConfirmarVenta";
            this.BtnConfirmarVenta.Size = new System.Drawing.Size(285, 66);
            this.BtnConfirmarVenta.TabIndex = 9;
            this.BtnConfirmarVenta.Text = "Confirmar Venta";
            this.BtnConfirmarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmarVenta.UseVisualStyleBackColor = true;
            this.BtnConfirmarVenta.Click += new System.EventHandler(this.BtnConfirmarVenta_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::VienaStore.Properties.Resources.cancelar_48x48_px;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(1342, 852);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(165, 66);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // GBEmpleado
            // 
            this.GBEmpleado.Controls.Add(this.TxtEmpleado);
            this.GBEmpleado.Controls.Add(this.LblEmpleado);
            this.GBEmpleado.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBEmpleado.Location = new System.Drawing.Point(139, 52);
            this.GBEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBEmpleado.Name = "GBEmpleado";
            this.GBEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBEmpleado.Size = new System.Drawing.Size(617, 169);
            this.GBEmpleado.TabIndex = 12;
            this.GBEmpleado.TabStop = false;
            this.GBEmpleado.Text = "EMPLEADO";
            // 
            // TxtEmpleado
            // 
            this.TxtEmpleado.Location = new System.Drawing.Point(32, 83);
            this.TxtEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEmpleado.Name = "TxtEmpleado";
            this.TxtEmpleado.ReadOnly = true;
            this.TxtEmpleado.Size = new System.Drawing.Size(507, 32);
            this.TxtEmpleado.TabIndex = 4;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpleado.Location = new System.Drawing.Point(26, 45);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(89, 19);
            this.LblEmpleado.TabIndex = 0;
            this.LblEmpleado.Text = "Empleado:";
            // 
            // GBCliente
            // 
            this.GBCliente.Controls.Add(this.label2);
            this.GBCliente.Controls.Add(this.LblDNI);
            this.GBCliente.Controls.Add(this.TxtDireccion);
            this.GBCliente.Controls.Add(this.TxtDNI);
            this.GBCliente.Controls.Add(this.TxtNombre);
            this.GBCliente.Controls.Add(this.BtnBuscarCliente);
            this.GBCliente.Controls.Add(this.LblCliente);
            this.GBCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCliente.Location = new System.Drawing.Point(777, 52);
            this.GBCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBCliente.Name = "GBCliente";
            this.GBCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBCliente.Size = new System.Drawing.Size(730, 169);
            this.GBCliente.TabIndex = 13;
            this.GBCliente.TabStop = false;
            this.GBCliente.Text = "CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dirección:";
            // 
            // LblDNI
            // 
            this.LblDNI.AutoSize = true;
            this.LblDNI.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDNI.Location = new System.Drawing.Point(52, 80);
            this.LblDNI.Name = "LblDNI";
            this.LblDNI.Size = new System.Drawing.Size(52, 22);
            this.LblDNI.TabIndex = 6;
            this.LblDNI.Text = "DNI:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(138, 118);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.Size = new System.Drawing.Size(452, 32);
            this.TxtDireccion.TabIndex = 5;
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(138, 74);
            this.TxtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.ReadOnly = true;
            this.TxtDNI.Size = new System.Drawing.Size(452, 32);
            this.TxtDNI.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(138, 29);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(452, 32);
            this.TxtNombre.TabIndex = 3;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(603, 24);
            this.BtnBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(111, 37);
            this.BtnBuscarCliente.TabIndex = 1;
            this.BtnBuscarCliente.Text = "BUSCAR";
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(26, 35);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(78, 22);
            this.LblCliente.TabIndex = 0;
            this.LblCliente.Text = "Cliente:";
            // 
            // GBProducto
            // 
            this.GBProducto.Controls.Add(this.LblNombreProducto);
            this.GBProducto.Controls.Add(this.TxtCantidad);
            this.GBProducto.Controls.Add(this.TxtPrecioVenta);
            this.GBProducto.Controls.Add(this.LblPrecioVenta);
            this.GBProducto.Controls.Add(this.TxtStock);
            this.GBProducto.Controls.Add(this.LblStock);
            this.GBProducto.Controls.Add(this.TxtDescripcionProducto);
            this.GBProducto.Controls.Add(this.BtnBuscarProducto);
            this.GBProducto.Controls.Add(this.LblDescripcion);
            this.GBProducto.Controls.Add(this.BtnAgregar);
            this.GBProducto.Controls.Add(this.TxtNombreProducto);
            this.GBProducto.Controls.Add(this.TxtCodProd);
            this.GBProducto.Controls.Add(this.LblCantidad);
            this.GBProducto.Controls.Add(this.LblProducto);
            this.GBProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBProducto.Location = new System.Drawing.Point(142, 238);
            this.GBProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBProducto.Name = "GBProducto";
            this.GBProducto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBProducto.Size = new System.Drawing.Size(1365, 186);
            this.GBProducto.TabIndex = 14;
            this.GBProducto.TabStop = false;
            this.GBProducto.Text = "PRODUCTO";
            // 
            // LblNombreProducto
            // 
            this.LblNombreProducto.AutoSize = true;
            this.LblNombreProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreProducto.Location = new System.Drawing.Point(21, 87);
            this.LblNombreProducto.Name = "LblNombreProducto";
            this.LblNombreProducto.Size = new System.Drawing.Size(76, 19);
            this.LblNombreProducto.TabIndex = 11;
            this.LblNombreProducto.Text = "Nombre:";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(759, 99);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(136, 32);
            this.TxtCantidad.TabIndex = 10;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Location = new System.Drawing.Point(371, 126);
            this.TxtPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.ReadOnly = true;
            this.TxtPrecioVenta.Size = new System.Drawing.Size(161, 32);
            this.TxtPrecioVenta.TabIndex = 9;
            // 
            // LblPrecioVenta
            // 
            this.LblPrecioVenta.AutoSize = true;
            this.LblPrecioVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioVenta.Location = new System.Drawing.Point(256, 132);
            this.LblPrecioVenta.Name = "LblPrecioVenta";
            this.LblPrecioVenta.Size = new System.Drawing.Size(109, 19);
            this.LblPrecioVenta.TabIndex = 8;
            this.LblPrecioVenta.Text = "Precio Venta:";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(113, 124);
            this.TxtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.ReadOnly = true;
            this.TxtStock.Size = new System.Drawing.Size(125, 32);
            this.TxtStock.TabIndex = 7;
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.Location = new System.Drawing.Point(38, 132);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(59, 19);
            this.LblStock.TabIndex = 6;
            this.LblStock.Text = "Stock:";
            // 
            // TxtDescripcionProducto
            // 
            this.TxtDescripcionProducto.Location = new System.Drawing.Point(759, 38);
            this.TxtDescripcionProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDescripcionProducto.Name = "TxtDescripcionProducto";
            this.TxtDescripcionProducto.ReadOnly = true;
            this.TxtDescripcionProducto.Size = new System.Drawing.Size(466, 32);
            this.TxtDescripcionProducto.TabIndex = 5;
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProducto.Location = new System.Drawing.Point(1238, 29);
            this.BtnBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(111, 37);
            this.BtnBuscarProducto.TabIndex = 4;
            this.BtnBuscarProducto.Text = "BUSCAR";
            this.BtnBuscarProducto.UseVisualStyleBackColor = true;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(639, 47);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(100, 19);
            this.LblDescripcion.TabIndex = 3;
            this.LblDescripcion.Text = "Descripción:";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(113, 78);
            this.TxtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.ReadOnly = true;
            this.TxtNombreProducto.Size = new System.Drawing.Size(419, 32);
            this.TxtNombreProducto.TabIndex = 2;
            // 
            // TxtCodProd
            // 
            this.TxtCodProd.Location = new System.Drawing.Point(172, 38);
            this.TxtCodProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodProd.Name = "TxtCodProd";
            this.TxtCodProd.ReadOnly = true;
            this.TxtCodProd.Size = new System.Drawing.Size(360, 32);
            this.TxtCodProd.TabIndex = 1;
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(21, 47);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(140, 19);
            this.LblProducto.TabIndex = 0;
            this.LblProducto.Text = "Codigo Producto:";
            // 
            // LblFactura
            // 
            this.LblFactura.AutoSize = true;
            this.LblFactura.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFactura.Location = new System.Drawing.Point(171, 462);
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(72, 19);
            this.LblFactura.TabIndex = 15;
            this.LblFactura.Text = "Factura:";
            // 
            // CBFactura
            // 
            this.CBFactura.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFactura.FormattingEnabled = true;
            this.CBFactura.Location = new System.Drawing.Point(269, 457);
            this.CBFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBFactura.Name = "CBFactura";
            this.CBFactura.Size = new System.Drawing.Size(290, 34);
            this.CBFactura.TabIndex = 16;
            this.CBFactura.Text = "Seleccione la Factura";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(1227, 467);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(60, 19);
            this.LblFecha.TabIndex = 17;
            this.LblFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1311, 464);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 32);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1179, 795);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total a Pagar:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(1356, 790);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(151, 27);
            this.TxtTotal.TabIndex = 24;
            // 
            // LblDireccion
            // 
            this.LblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.BackColor = System.Drawing.Color.Coral;
            this.LblDireccion.Controls.Add(this.BtnImprimir);
            this.LblDireccion.Controls.Add(this.BtnConfirmarVenta);
            this.LblDireccion.Controls.Add(this.BtnSalir);
            this.LblDireccion.Controls.Add(this.CBFormaDePago);
            this.LblDireccion.Controls.Add(this.LblTipoPago);
            this.LblDireccion.Controls.Add(this.GBCliente);
            this.LblDireccion.Controls.Add(this.GBProducto);
            this.LblDireccion.Controls.Add(this.GBEmpleado);
            this.LblDireccion.Controls.Add(this.label1);
            this.LblDireccion.Controls.Add(this.TxtTotal);
            this.LblDireccion.Controls.Add(this.LblFecha);
            this.LblDireccion.Controls.Add(this.CBFactura);
            this.LblDireccion.Controls.Add(this.LblFactura);
            this.LblDireccion.Controls.Add(this.dateTimePicker1);
            this.LblDireccion.Controls.Add(this.DtaProductos);
            this.LblDireccion.Location = new System.Drawing.Point(84, 67);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(1576, 944);
            this.LblDireccion.TabIndex = 25;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Image = global::VienaStore.Properties.Resources.Descargar2_PDF_48x48px;
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.Location = new System.Drawing.Point(822, 853);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(215, 65);
            this.BtnImprimir.TabIndex = 27;
            this.BtnImprimir.Text = "Generar PDF";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // CBFormaDePago
            // 
            this.CBFormaDePago.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFormaDePago.FormattingEnabled = true;
            this.CBFormaDePago.Location = new System.Drawing.Point(794, 461);
            this.CBFormaDePago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBFormaDePago.Name = "CBFormaDePago";
            this.CBFormaDePago.Size = new System.Drawing.Size(363, 34);
            this.CBFormaDePago.TabIndex = 26;
            this.CBFormaDePago.Text = "Seleccione la Forma de Pago";
            // 
            // LblTipoPago
            // 
            this.LblTipoPago.AutoSize = true;
            this.LblTipoPago.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoPago.Location = new System.Drawing.Point(640, 464);
            this.LblTipoPago.Name = "LblTipoPago";
            this.LblTipoPago.Size = new System.Drawing.Size(130, 19);
            this.LblTipoPago.TabIndex = 25;
            this.LblTipoPago.Text = "Forma de Pago:";
            // 
            // DtaProductos
            // 
            this.DtaProductos.AllowUserToAddRows = false;
            this.DtaProductos.AllowUserToOrderColumns = true;
            this.DtaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaProductos.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DtaProductos.ColumnHeadersHeight = 29;
            this.DtaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProducto,
            this.NroProducto,
            this.Descripcion,
            this.Cantidad,
            this.PrecioUnitario,
            this.SubTotal,
            this.ELIMINAR});
            this.DtaProductos.EnableHeadersVisualStyles = false;
            this.DtaProductos.Location = new System.Drawing.Point(139, 529);
            this.DtaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtaProductos.Name = "DtaProductos";
            this.DtaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DtaProductos.RowHeadersVisible = false;
            this.DtaProductos.RowHeadersWidth = 51;
            this.DtaProductos.RowTemplate.Height = 24;
            this.DtaProductos.Size = new System.Drawing.Size(1368, 242);
            this.DtaProductos.TabIndex = 0;
            this.DtaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaProductos_CellContentClick);
            this.DtaProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtaProductos_CellFormatting);
            // 
            // CodProducto
            // 
            this.CodProducto.HeaderText = "CodProducto";
            this.CodProducto.MinimumWidth = 6;
            this.CodProducto.Name = "CodProducto";
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
            // FRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1692, 1051);
            this.Controls.Add(this.LblNuevaVenta);
            this.Controls.Add(this.LblDireccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRegistrarVenta";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRegistrarVenta1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRegistrarVenta_Load);
            this.GBEmpleado.ResumeLayout(false);
            this.GBEmpleado.PerformLayout();
            this.GBCliente.ResumeLayout(false);
            this.GBCliente.PerformLayout();
            this.GBProducto.ResumeLayout(false);
            this.GBProducto.PerformLayout();
            this.LblDireccion.ResumeLayout(false);
            this.LblDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblNuevaVenta;
        public System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnConfirmarVenta;
        public System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox GBEmpleado;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.GroupBox GBCliente;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.GroupBox GBProducto;
        private System.Windows.Forms.Button BtnBuscarProducto;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.TextBox TxtCodProd;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.TextBox TxtDescripcionProducto;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.Label LblPrecioVenta;
        private System.Windows.Forms.Label LblFactura;
        private System.Windows.Forms.ComboBox CBFactura;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Panel LblDireccion;
        private System.Windows.Forms.TextBox TxtEmpleado;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDNI;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.ComboBox CBFormaDePago;
        private System.Windows.Forms.Label LblTipoPago;
        private System.Windows.Forms.DataGridView DtaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ELIMINAR;
        private System.Windows.Forms.Label LblNombreProducto;
        private System.Windows.Forms.Button BtnImprimir;
    }
}