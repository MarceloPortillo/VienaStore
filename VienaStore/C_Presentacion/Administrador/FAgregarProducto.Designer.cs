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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBCodigoProducto = new System.Windows.Forms.TextBox();
            this.LblCodigoProducto = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGProductos = new System.Windows.Forms.DataGridView();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAgregarProducto
            // 
            this.LblAgregarProducto.AutoSize = true;
            this.LblAgregarProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgregarProducto.ForeColor = System.Drawing.Color.Teal;
            this.LblAgregarProducto.Location = new System.Drawing.Point(65, 44);
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
            this.LblNombreProducto.Location = new System.Drawing.Point(19, 60);
            this.LblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreProducto.Name = "LblNombreProducto";
            this.LblNombreProducto.Size = new System.Drawing.Size(86, 22);
            this.LblNombreProducto.TabIndex = 73;
            this.LblNombreProducto.Text = "Nombre:";
            this.LblNombreProducto.Click += new System.EventHandler(this.LblNombreProducto_Click);
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(18, 96);
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
            this.LblDescripcion.Location = new System.Drawing.Point(18, 132);
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
            this.LblStock.Location = new System.Drawing.Point(19, 168);
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
            this.LblPrecioCompra.Location = new System.Drawing.Point(18, 204);
            this.LblPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecioCompra.Name = "LblPrecioCompra";
            this.LblPrecioCompra.Size = new System.Drawing.Size(142, 22);
            this.LblPrecioCompra.TabIndex = 77;
            this.LblPrecioCompra.Text = "Precio Compra:";
            // 
            // LblPrecioVenta
            // 
            this.LblPrecioVenta.AutoSize = true;
            this.LblPrecioVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioVenta.Location = new System.Drawing.Point(19, 240);
            this.LblPrecioVenta.Name = "LblPrecioVenta";
            this.LblPrecioVenta.Size = new System.Drawing.Size(125, 22);
            this.LblPrecioVenta.TabIndex = 78;
            this.LblPrecioVenta.Text = "Precio Venta:";
            this.LblPrecioVenta.Click += new System.EventHandler(this.LblPrecioVenta_Click);
            // 
            // TBNombreProducto
            // 
            this.TBNombreProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreProducto.Location = new System.Drawing.Point(246, 54);
            this.TBNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.TBNombreProducto.Name = "TBNombreProducto";
            this.TBNombreProducto.Size = new System.Drawing.Size(334, 28);
            this.TBNombreProducto.TabIndex = 2;
            this.TBNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombreProducto_KeyPress);
            // 
            // CBCategoria
            // 
            this.CBCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Casual",
            "Formal ",
            "Deportivo"});
            this.CBCategoria.Location = new System.Drawing.Point(246, 90);
            this.CBCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(334, 28);
            this.CBCategoria.TabIndex = 3;
            this.CBCategoria.Text = "Seleccione la Categoría";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.Location = new System.Drawing.Point(246, 126);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(334, 28);
            this.TBDescripcion.TabIndex = 49;
            // 
            // TBStock
            // 
            this.TBStock.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStock.Location = new System.Drawing.Point(246, 162);
            this.TBStock.Margin = new System.Windows.Forms.Padding(4);
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(334, 28);
            this.TBStock.TabIndex = 81;
            this.TBStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBStock_KeyPress);
            // 
            // TBPrecioCompra
            // 
            this.TBPrecioCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioCompra.Location = new System.Drawing.Point(246, 198);
            this.TBPrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.TBPrecioCompra.Name = "TBPrecioCompra";
            this.TBPrecioCompra.Size = new System.Drawing.Size(334, 28);
            this.TBPrecioCompra.TabIndex = 82;
            // 
            // TBPrecioVenta
            // 
            this.TBPrecioVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioVenta.Location = new System.Drawing.Point(246, 234);
            this.TBPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.TBPrecioVenta.Name = "TBPrecioVenta";
            this.TBPrecioVenta.Size = new System.Drawing.Size(334, 28);
            this.TBPrecioVenta.TabIndex = 83;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Coral;
            this.BtnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::VienaStore.Properties.Resources.guardar_48x48_px;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(673, 851);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(200, 82);
            this.BtnGuardar.TabIndex = 8;
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
            this.BtnCancelar.Location = new System.Drawing.Point(888, 851);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(200, 82);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.TBCodigoProducto);
            this.panel1.Controls.Add(this.LblCodigoProducto);
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
            this.panel1.Location = new System.Drawing.Point(455, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 280);
            this.panel1.TabIndex = 87;
            // 
            // TBCodigoProducto
            // 
            this.TBCodigoProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigoProducto.Location = new System.Drawing.Point(246, 18);
            this.TBCodigoProducto.Name = "TBCodigoProducto";
            this.TBCodigoProducto.Size = new System.Drawing.Size(334, 28);
            this.TBCodigoProducto.TabIndex = 1;
            this.TBCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigoProducto_KeyPress);
            // 
            // LblCodigoProducto
            // 
            this.LblCodigoProducto.AutoSize = true;
            this.LblCodigoProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoProducto.Location = new System.Drawing.Point(18, 24);
            this.LblCodigoProducto.Name = "LblCodigoProducto";
            this.LblCodigoProducto.Size = new System.Drawing.Size(158, 22);
            this.LblCodigoProducto.TabIndex = 84;
            this.LblCodigoProducto.Text = "Código Producto:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Coral;
            this.BtnLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Image = global::VienaStore.Properties.Resources.borrar;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(455, 851);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(200, 82);
            this.BtnLimpiar.TabIndex = 88;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VienaStore.Properties.Resources.Agregar_Producto_240x240px;
            this.pictureBox1.Location = new System.Drawing.Point(84, 542);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 343);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // DGProductos
            // 
            this.DGProductos.AllowUserToAddRows = false;
            this.DGProductos.AllowUserToResizeColumns = false;
            this.DGProductos.AllowUserToResizeRows = false;
            this.DGProductos.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DGProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGProductos.ColumnHeadersHeight = 30;
            this.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProd,
            this.Nombre,
            this.Categoria,
            this.Descripción,
            this.Stock,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Estado});
            this.DGProductos.EnableHeadersVisualStyles = false;
            this.DGProductos.Location = new System.Drawing.Point(72, 107);
            this.DGProductos.Name = "DGProductos";
            this.DGProductos.ReadOnly = true;
            this.DGProductos.RowHeadersVisible = false;
            this.DGProductos.RowHeadersWidth = 51;
            this.DGProductos.RowTemplate.Height = 24;
            this.DGProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGProductos.Size = new System.Drawing.Size(1016, 411);
            this.DGProductos.TabIndex = 11;
            // 
            // CodProd
            // 
            this.CodProd.HeaderText = "Cod. Prod.";
            this.CodProd.MinimumWidth = 6;
            this.CodProd.Name = "CodProd";
            this.CodProd.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripcion";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 125;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 90;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 125;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 125;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // FAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1129, 945);
            this.Controls.Add(this.DGProductos);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblAgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAgregarProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).EndInit();
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
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBCodigoProducto;
        private System.Windows.Forms.Label LblCodigoProducto;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView DGProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
    }
}