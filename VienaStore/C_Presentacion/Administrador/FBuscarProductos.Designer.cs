namespace VienaStore.C_Presentacion.Administrador
{
    partial class FBuscarProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblProducto = new System.Windows.Forms.Label();
            this.DGProdcuto = new System.Windows.Forms.DataGridView();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.PBEditarProducto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TBPrecioCompra = new System.Windows.Forms.TextBox();
            this.TBPrecioVenta = new System.Windows.Forms.TextBox();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.TBCategoria = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LblPrecioCompra = new System.Windows.Forms.Label();
            this.LblPrecioVenta = new System.Windows.Forms.Label();
            this.LblStok = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEditar = new System.Windows.Forms.Label();
            this.LblEditarProducto = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CondProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGProdcuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEditarProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.ForeColor = System.Drawing.Color.Black;
            this.LblProducto.Location = new System.Drawing.Point(89, 44);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(236, 40);
            this.LblProducto.TabIndex = 0;
            this.LblProducto.Text = "PRODUCTOS";
            // 
            // DGProdcuto
            // 
            this.DGProdcuto.AllowUserToAddRows = false;
            this.DGProdcuto.AllowUserToResizeColumns = false;
            this.DGProdcuto.AllowUserToResizeRows = false;
            this.DGProdcuto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGProdcuto.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DGProdcuto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGProdcuto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGProdcuto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGProdcuto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGProdcuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProdcuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CondProducto,
            this.Nombre,
            this.Categoria,
            this.Descripcion,
            this.Stock,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Estado});
            this.DGProdcuto.EnableHeadersVisualStyles = false;
            this.DGProdcuto.GridColor = System.Drawing.Color.MistyRose;
            this.DGProdcuto.Location = new System.Drawing.Point(96, 89);
            this.DGProdcuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGProdcuto.Name = "DGProdcuto";
            this.DGProdcuto.ReadOnly = true;
            this.DGProdcuto.RowHeadersVisible = false;
            this.DGProdcuto.RowHeadersWidth = 51;
            this.DGProdcuto.RowTemplate.Height = 24;
            this.DGProdcuto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGProdcuto.Size = new System.Drawing.Size(997, 400);
            this.DGProdcuto.TabIndex = 1;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Coral;
            this.BtnEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Image = global::VienaStore.Properties.Resources.Editar_Cliente_48x48px;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(697, 502);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(195, 68);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Coral;
            this.BtnAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = global::VienaStore.Properties.Resources.buscarProveedor_48px;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(491, 502);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(195, 68);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "BUSCAR";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Coral;
            this.BtnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = global::VienaStore.Properties.Resources.Eliminar_48x48px;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(899, 502);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(195, 68);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // PBEditarProducto
            // 
            this.PBEditarProducto.BackColor = System.Drawing.Color.Salmon;
            this.PBEditarProducto.Location = new System.Drawing.Point(93, 615);
            this.PBEditarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBEditarProducto.Name = "PBEditarProducto";
            this.PBEditarProducto.Size = new System.Drawing.Size(323, 325);
            this.PBEditarProducto.TabIndex = 5;
            this.PBEditarProducto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.TBPrecioCompra);
            this.panel1.Controls.Add(this.TBPrecioVenta);
            this.panel1.Controls.Add(this.TBStock);
            this.panel1.Controls.Add(this.TBDescripcion);
            this.panel1.Controls.Add(this.TBCategoria);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.LblPrecioCompra);
            this.panel1.Controls.Add(this.LblPrecioVenta);
            this.panel1.Controls.Add(this.LblStok);
            this.panel1.Controls.Add(this.LblDescripcion);
            this.panel1.Controls.Add(this.LblCategoria);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Location = new System.Drawing.Point(469, 615);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 325);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::VienaStore.Properties.Resources.Confirmar_48x48px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(400, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 68);
            this.button1.TabIndex = 14;
            this.button1.Text = "CONFIRMAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Coral;
            this.BtnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::VienaStore.Properties.Resources.cancelar_48x48_px;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(169, 254);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(212, 68);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TBPrecioCompra
            // 
            this.TBPrecioCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioCompra.Location = new System.Drawing.Point(169, 203);
            this.TBPrecioCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPrecioCompra.Name = "TBPrecioCompra";
            this.TBPrecioCompra.Size = new System.Drawing.Size(443, 32);
            this.TBPrecioCompra.TabIndex = 12;
            // 
            // TBPrecioVenta
            // 
            this.TBPrecioVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioVenta.Location = new System.Drawing.Point(169, 162);
            this.TBPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPrecioVenta.Name = "TBPrecioVenta";
            this.TBPrecioVenta.Size = new System.Drawing.Size(443, 32);
            this.TBPrecioVenta.TabIndex = 11;
            // 
            // TBStock
            // 
            this.TBStock.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStock.Location = new System.Drawing.Point(169, 123);
            this.TBStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(443, 32);
            this.TBStock.TabIndex = 10;
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.Location = new System.Drawing.Point(169, 82);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(443, 32);
            this.TBDescripcion.TabIndex = 9;
            // 
            // TBCategoria
            // 
            this.TBCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCategoria.Location = new System.Drawing.Point(169, 43);
            this.TBCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBCategoria.Name = "TBCategoria";
            this.TBCategoria.Size = new System.Drawing.Size(443, 32);
            this.TBCategoria.TabIndex = 8;
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(169, 2);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(443, 32);
            this.TBNombre.TabIndex = 7;
            // 
            // LblPrecioCompra
            // 
            this.LblPrecioCompra.AutoSize = true;
            this.LblPrecioCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioCompra.Location = new System.Drawing.Point(21, 217);
            this.LblPrecioCompra.Name = "LblPrecioCompra";
            this.LblPrecioCompra.Size = new System.Drawing.Size(126, 19);
            this.LblPrecioCompra.TabIndex = 6;
            this.LblPrecioCompra.Text = "Precio Compra:";
            // 
            // LblPrecioVenta
            // 
            this.LblPrecioVenta.AutoSize = true;
            this.LblPrecioVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioVenta.Location = new System.Drawing.Point(21, 176);
            this.LblPrecioVenta.Name = "LblPrecioVenta";
            this.LblPrecioVenta.Size = new System.Drawing.Size(109, 19);
            this.LblPrecioVenta.TabIndex = 5;
            this.LblPrecioVenta.Text = "Precio Venta:";
            // 
            // LblStok
            // 
            this.LblStok.AutoSize = true;
            this.LblStok.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStok.Location = new System.Drawing.Point(21, 135);
            this.LblStok.Name = "LblStok";
            this.LblStok.Size = new System.Drawing.Size(59, 19);
            this.LblStok.TabIndex = 4;
            this.LblStok.Text = "Stock:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(21, 96);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(100, 19);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Descripción:";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(21, 57);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(88, 19);
            this.LblCategoria.TabIndex = 1;
            this.LblCategoria.Text = "Categoría:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(21, 16);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(76, 19);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblEditar
            // 
            this.LblEditar.AutoSize = true;
            this.LblEditar.BackColor = System.Drawing.Color.Salmon;
            this.LblEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditar.Location = new System.Drawing.Point(171, 699);
            this.LblEditar.Name = "LblEditar";
            this.LblEditar.Size = new System.Drawing.Size(156, 53);
            this.LblEditar.TabIndex = 7;
            this.LblEditar.Text = "Editar";
            // 
            // LblEditarProducto
            // 
            this.LblEditarProducto.AutoSize = true;
            this.LblEditarProducto.BackColor = System.Drawing.Color.Salmon;
            this.LblEditarProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditarProducto.Location = new System.Drawing.Point(137, 779);
            this.LblEditarProducto.Name = "LblEditarProducto";
            this.LblEditarProducto.Size = new System.Drawing.Size(220, 53);
            this.LblEditarProducto.TabIndex = 8;
            this.LblEditarProducto.Text = "Producto";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(96, 542);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(373, 28);
            this.TxtBuscar.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ingrese el nombre del producto";
            // 
            // CondProducto
            // 
            this.CondProducto.HeaderText = "Cod. Prod.";
            this.CondProducto.MinimumWidth = 6;
            this.CondProducto.Name = "CondProducto";
            this.CondProducto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Costo";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // FBuscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1101, 917);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblEditarProducto);
            this.Controls.Add(this.LblEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PBEditarProducto);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.DGProdcuto);
            this.Controls.Add(this.LblProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FBuscarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBuscarProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DGProdcuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEditarProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.DataGridView DGProdcuto;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblPrecioCompra;
        private System.Windows.Forms.Label LblPrecioVenta;
        private System.Windows.Forms.Label LblStok;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TBPrecioCompra;
        private System.Windows.Forms.TextBox TBPrecioVenta;
        private System.Windows.Forms.TextBox TBStock;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.TextBox TBCategoria;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BtnEditar;
        public System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        public System.Windows.Forms.PictureBox PBEditarProducto;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Label LblEditar;
        public System.Windows.Forms.Label LblEditarProducto;
    }
}