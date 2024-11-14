namespace VienaStore.C_Presentacion.Administrador
{
    partial class FAgregarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblAgregarProducto = new System.Windows.Forms.Label();
            this.LblNombreProducto = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblPrecioCompra = new System.Windows.Forms.Label();
            this.LblPrecioVenta = new System.Windows.Forms.Label();
            this.TBNombreProducto = new System.Windows.Forms.TextBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.TBPrecioCompra = new System.Windows.Forms.TextBox();
            this.TBPrecioVenta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CboProveedor = new System.Windows.Forms.ComboBox();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.TxtStockMin = new System.Windows.Forms.TextBox();
            this.LblStockMin = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.DataProducto = new System.Windows.Forms.DataGridView();
            this.productosProveedoresCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosProveedoresCategoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAgregarProducto
            // 
            this.LblAgregarProducto.AutoSize = true;
            this.LblAgregarProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.LblAgregarProducto.Location = new System.Drawing.Point(691, 45);
            this.LblAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAgregarProducto.Name = "LblAgregarProducto";
            this.LblAgregarProducto.Size = new System.Drawing.Size(534, 40);
            this.LblAgregarProducto.TabIndex = 34;
            this.LblAgregarProducto.Text = "AGREGAR NUEVO PRODUCTO";
            // 
            // LblNombreProducto
            // 
            this.LblNombreProducto.AutoSize = true;
            this.LblNombreProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreProducto.Location = new System.Drawing.Point(32, 38);
            this.LblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreProducto.Name = "LblNombreProducto";
            this.LblNombreProducto.Size = new System.Drawing.Size(86, 22);
            this.LblNombreProducto.TabIndex = 73;
            this.LblNombreProducto.Text = "Nombre:";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(32, 85);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(100, 22);
            this.LblCategoria.TabIndex = 74;
            this.LblCategoria.Text = "Categoría:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(608, 38);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(117, 22);
            this.LblDescripcion.TabIndex = 48;
            this.LblDescripcion.Text = "Descripción:";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.Location = new System.Drawing.Point(608, 143);
            this.LblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(66, 22);
            this.LblStock.TabIndex = 76;
            this.LblStock.Text = "Stock:";
            // 
            // LblPrecioCompra
            // 
            this.LblPrecioCompra.AutoSize = true;
            this.LblPrecioCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioCompra.Location = new System.Drawing.Point(32, 146);
            this.LblPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecioCompra.Name = "LblPrecioCompra";
            this.LblPrecioCompra.Size = new System.Drawing.Size(123, 22);
            this.LblPrecioCompra.TabIndex = 77;
            this.LblPrecioCompra.Text = "Precio Costo:";
            // 
            // LblPrecioVenta
            // 
            this.LblPrecioVenta.AutoSize = true;
            this.LblPrecioVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioVenta.Location = new System.Drawing.Point(32, 197);
            this.LblPrecioVenta.Name = "LblPrecioVenta";
            this.LblPrecioVenta.Size = new System.Drawing.Size(125, 22);
            this.LblPrecioVenta.TabIndex = 78;
            this.LblPrecioVenta.Text = "Precio Venta:";
            this.LblPrecioVenta.Click += new System.EventHandler(this.LblPrecioVenta_Click);
            // 
            // TBNombreProducto
            // 
            this.TBNombreProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreProducto.Location = new System.Drawing.Point(220, 38);
            this.TBNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBNombreProducto.Name = "TBNombreProducto";
            this.TBNombreProducto.Size = new System.Drawing.Size(335, 30);
            this.TBNombreProducto.TabIndex = 2;
            this.TBNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombreProducto_KeyPress);
            // 
            // CBCategoria
            // 
            this.CBCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Cartera"});
            this.CBCategoria.Location = new System.Drawing.Point(220, 85);
            this.CBCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(335, 32);
            this.CBCategoria.TabIndex = 3;
            this.CBCategoria.Text = "Seleccione la Categoría";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.Location = new System.Drawing.Point(796, 38);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(335, 30);
            this.TBDescripcion.TabIndex = 4;
            // 
            // TBStock
            // 
            this.TBStock.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStock.Location = new System.Drawing.Point(796, 143);
            this.TBStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(335, 30);
            this.TBStock.TabIndex = 6;
            this.TBStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBStock_KeyPress);
            // 
            // TBPrecioCompra
            // 
            this.TBPrecioCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioCompra.Location = new System.Drawing.Point(220, 146);
            this.TBPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBPrecioCompra.Name = "TBPrecioCompra";
            this.TBPrecioCompra.Size = new System.Drawing.Size(335, 30);
            this.TBPrecioCompra.TabIndex = 7;
            this.TBPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPrecioCompra_KeyPress);
            // 
            // TBPrecioVenta
            // 
            this.TBPrecioVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioVenta.Location = new System.Drawing.Point(220, 197);
            this.TBPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBPrecioVenta.Name = "TBPrecioVenta";
            this.TBPrecioVenta.Size = new System.Drawing.Size(335, 30);
            this.TBPrecioVenta.TabIndex = 8;
            this.TBPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPrecioVenta_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VienaStore.Properties.Resources.Agregar_Producto_240x240px;
            this.pictureBox1.Location = new System.Drawing.Point(43, 146);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 300);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Coral;
            this.BtnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::VienaStore.Properties.Resources.guardar_48x48_px;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(1460, 488);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(200, 82);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "AGREGAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Coral;
            this.BtnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::VienaStore.Properties.Resources.cancelar_48x48_px;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(1460, 976);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(200, 82);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.CboProveedor);
            this.panel1.Controls.Add(this.LblProveedor);
            this.panel1.Controls.Add(this.TxtStockMin);
            this.panel1.Controls.Add(this.LblStockMin);
            this.panel1.Controls.Add(this.TBPrecioVenta);
            this.panel1.Controls.Add(this.TBPrecioCompra);
            this.panel1.Controls.Add(this.TBStock);
            this.panel1.Controls.Add(this.TBDescripcion);
            this.panel1.Controls.Add(this.CBCategoria);
            this.panel1.Controls.Add(this.TBNombreProducto);
            this.panel1.Controls.Add(this.LblPrecioVenta);
            this.panel1.Controls.Add(this.LblPrecioCompra);
            this.panel1.Controls.Add(this.LblStock);
            this.panel1.Controls.Add(this.LblDescripcion);
            this.panel1.Controls.Add(this.LblCategoria);
            this.panel1.Controls.Add(this.LblNombreProducto);
            this.panel1.Location = new System.Drawing.Point(403, 146);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 303);
            this.panel1.TabIndex = 87;
            // 
            // CboProveedor
            // 
            this.CboProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboProveedor.FormattingEnabled = true;
            this.CboProveedor.Items.AddRange(new object[] {
            "Tommy"});
            this.CboProveedor.Location = new System.Drawing.Point(796, 201);
            this.CboProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboProveedor.Name = "CboProveedor";
            this.CboProveedor.Size = new System.Drawing.Size(335, 32);
            this.CboProveedor.TabIndex = 9;
            this.CboProveedor.Text = "Seleccione un Proveedor";
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.Location = new System.Drawing.Point(608, 204);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(103, 22);
            this.LblProveedor.TabIndex = 88;
            this.LblProveedor.Text = "Proveedor:";
            // 
            // TxtStockMin
            // 
            this.TxtStockMin.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockMin.Location = new System.Drawing.Point(796, 90);
            this.TxtStockMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtStockMin.Name = "TxtStockMin";
            this.TxtStockMin.Size = new System.Drawing.Size(335, 30);
            this.TxtStockMin.TabIndex = 5;
            this.TxtStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockMin_KeyPress);
            // 
            // LblStockMin
            // 
            this.LblStockMin.AutoSize = true;
            this.LblStockMin.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStockMin.Location = new System.Drawing.Point(608, 94);
            this.LblStockMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStockMin.Name = "LblStockMin";
            this.LblStockMin.Size = new System.Drawing.Size(102, 22);
            this.LblStockMin.TabIndex = 86;
            this.LblStockMin.Text = "Stock Min:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Coral;
            this.BtnLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Image = global::VienaStore.Properties.Resources.borrar;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(1217, 488);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(200, 82);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // DataProducto
            // 
            this.DataProducto.AllowUserToAddRows = false;
            this.DataProducto.AllowUserToResizeColumns = false;
            this.DataProducto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataProducto.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DataProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataProducto.ColumnHeadersHeight = 30;
            this.DataProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataProducto.EnableHeadersVisualStyles = false;
            this.DataProducto.Location = new System.Drawing.Point(43, 616);
            this.DataProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataProducto.MultiSelect = false;
            this.DataProducto.Name = "DataProducto";
            this.DataProducto.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataProducto.RowHeadersVisible = false;
            this.DataProducto.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DataProducto.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataProducto.RowTemplate.Height = 24;
            this.DataProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataProducto.Size = new System.Drawing.Size(1617, 318);
            this.DataProducto.TabIndex = 88;
            // 
            // productosProveedoresCategoriasBindingSource
            // 
            this.productosProveedoresCategoriasBindingSource.DataSource = typeof(VienaStore.C_Datos.Productos_Proveedores_Categorias);
            // 
            // FAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1805, 1108);
            this.Controls.Add(this.DataProducto);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblAgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAgregarProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FAgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosProveedoresCategoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAgregarProducto;
        private System.Windows.Forms.Label LblNombreProducto;
        private System.Windows.Forms.Label LblCategoria;
        public System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblPrecioCompra;
        private System.Windows.Forms.Label LblPrecioVenta;
        public System.Windows.Forms.TextBox TBNombreProducto;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.TextBox TBPrecioVenta;
        public System.Windows.Forms.Label LblStock;
        public System.Windows.Forms.TextBox TBDescripcion;
        public System.Windows.Forms.TextBox TBStock;
        public System.Windows.Forms.TextBox TBPrecioCompra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLimpiar;
        public System.Windows.Forms.TextBox TxtStockMin;
        public System.Windows.Forms.Label LblStockMin;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.ComboBox CboProveedor;
        private System.Windows.Forms.DataGridView DataProducto;
        private System.Windows.Forms.BindingSource productosProveedoresCategoriasBindingSource;
    }
}