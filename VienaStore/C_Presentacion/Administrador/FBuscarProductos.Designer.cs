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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblProducto = new System.Windows.Forms.Label();
            this.DGProdcuto = new System.Windows.Forms.DataGridView();
            this.CondProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGProdcuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEditarProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.ForeColor = System.Drawing.Color.Teal;
            this.LblProducto.Location = new System.Drawing.Point(89, 44);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(189, 40);
            this.LblProducto.TabIndex = 0;
            this.LblProducto.Text = "Productos";
            // 
            // DGProdcuto
            // 
            this.DGProdcuto.AllowUserToAddRows = false;
            this.DGProdcuto.AllowUserToResizeColumns = false;
            this.DGProdcuto.AllowUserToResizeRows = false;
            this.DGProdcuto.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DGProdcuto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGProdcuto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGProdcuto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGProdcuto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGProdcuto.ColumnHeadersHeight = 30;
            this.DGProdcuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGProdcuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CondProducto,
            this.Nombre,
            this.Categoria,
            this.Descripcion,
            this.Stock,
            this.PrecioVenta,
            this.PrecioCompra,
            this.Estado});
            this.DGProdcuto.EnableHeadersVisualStyles = false;
            this.DGProdcuto.GridColor = System.Drawing.Color.MistyRose;
            this.DGProdcuto.Location = new System.Drawing.Point(96, 89);
            this.DGProdcuto.Name = "DGProdcuto";
            this.DGProdcuto.ReadOnly = true;
            this.DGProdcuto.RowHeadersVisible = false;
            this.DGProdcuto.RowHeadersWidth = 51;
            this.DGProdcuto.RowTemplate.Height = 24;
            this.DGProdcuto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGProdcuto.Size = new System.Drawing.Size(997, 400);
            this.DGProdcuto.TabIndex = 1;
            // 
            // CondProducto
            // 
            this.CondProducto.HeaderText = "Cod. Prod.";
            this.CondProducto.MinimumWidth = 6;
            this.CondProducto.Name = "CondProducto";
            this.CondProducto.ReadOnly = true;
            this.CondProducto.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.Stock.Width = 125;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 125;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Coral;
            this.BtnEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Image = global::VienaStore.Properties.Resources.Editar_Cliente_48x48px;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(466, 502);
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
            this.BtnAgregar.Image = global::VienaStore.Properties.Resources.Agregar_Producto_48x48px;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(895, 502);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(195, 68);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Coral;
            this.BtnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = global::VienaStore.Properties.Resources.Eliminar_48x48px;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(680, 502);
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
            this.PBEditarProducto.Location = new System.Drawing.Point(93, 616);
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
            this.panel1.Location = new System.Drawing.Point(466, 616);
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
            this.TBPrecioCompra.Name = "TBPrecioCompra";
            this.TBPrecioCompra.Size = new System.Drawing.Size(443, 32);
            this.TBPrecioCompra.TabIndex = 12;
            // 
            // TBPrecioVenta
            // 
            this.TBPrecioVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioVenta.Location = new System.Drawing.Point(169, 163);
            this.TBPrecioVenta.Name = "TBPrecioVenta";
            this.TBPrecioVenta.Size = new System.Drawing.Size(443, 32);
            this.TBPrecioVenta.TabIndex = 11;
            // 
            // TBStock
            // 
            this.TBStock.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStock.Location = new System.Drawing.Point(169, 123);
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(443, 32);
            this.TBStock.TabIndex = 10;
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.Location = new System.Drawing.Point(169, 83);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(443, 32);
            this.TBDescripcion.TabIndex = 9;
            // 
            // TBCategoria
            // 
            this.TBCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCategoria.Location = new System.Drawing.Point(169, 43);
            this.TBCategoria.Name = "TBCategoria";
            this.TBCategoria.Size = new System.Drawing.Size(443, 32);
            this.TBCategoria.TabIndex = 8;
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(169, 3);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(443, 32);
            this.TBNombre.TabIndex = 7;
            // 
            // LblPrecioCompra
            // 
            this.LblPrecioCompra.AutoSize = true;
            this.LblPrecioCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioCompra.Location = new System.Drawing.Point(21, 216);
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
            this.LblStok.Location = new System.Drawing.Point(21, 136);
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
            this.LblCategoria.Location = new System.Drawing.Point(21, 56);
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
            this.LblEditar.Location = new System.Drawing.Point(170, 699);
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
            // FBuscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1102, 995);
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
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.PictureBox PBEditarProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblEditar;
        private System.Windows.Forms.Label LblEditarProducto;
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
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
    }
}