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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblProducto = new System.Windows.Forms.Label();
            this.DtaProdcuto = new System.Windows.Forms.DataGridView();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboCategoria = new System.Windows.Forms.ComboBox();
            this.ComboProveedor = new System.Windows.Forms.ComboBox();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.TxtStockMIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TBPrecioCompra = new System.Windows.Forms.TextBox();
            this.TBPrecioVenta = new System.Windows.Forms.TextBox();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LblPrecioCompra = new System.Windows.Forms.Label();
            this.LblPrecioVenta = new System.Windows.Forms.Label();
            this.LblStokMin = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEditarProducto = new System.Windows.Forms.Label();
            this.LblEditar = new System.Windows.Forms.Label();
            this.PBEditarProducto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtaProdcuto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBEditarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.ForeColor = System.Drawing.Color.Black;
            this.LblProducto.Location = new System.Drawing.Point(499, 27);
            this.LblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(196, 34);
            this.LblProducto.TabIndex = 0;
            this.LblProducto.Text = "PRODUCTOS";
            // 
            // DtaProdcuto
            // 
            this.DtaProdcuto.AllowUserToAddRows = false;
            this.DtaProdcuto.AllowUserToResizeColumns = false;
            this.DtaProdcuto.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtaProdcuto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtaProdcuto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaProdcuto.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DtaProdcuto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaProdcuto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DtaProdcuto.ColumnHeadersHeight = 30;
            this.DtaProdcuto.EnableHeadersVisualStyles = false;
            this.DtaProdcuto.GridColor = System.Drawing.Color.MistyRose;
            this.DtaProdcuto.Location = new System.Drawing.Point(92, 115);
            this.DtaProdcuto.Margin = new System.Windows.Forms.Padding(2);
            this.DtaProdcuto.MultiSelect = false;
            this.DtaProdcuto.Name = "DtaProdcuto";
            this.DtaProdcuto.ReadOnly = true;
            this.DtaProdcuto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaProdcuto.RowHeadersVisible = false;
            this.DtaProdcuto.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSalmon;
            this.DtaProdcuto.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DtaProdcuto.RowTemplate.Height = 24;
            this.DtaProdcuto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtaProdcuto.Size = new System.Drawing.Size(1086, 273);
            this.DtaProdcuto.TabIndex = 1;
            this.DtaProdcuto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaProdcuto_CellContentClick);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Coral;
            this.BtnEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Image = global::VienaStore.Properties.Resources.Editar_Cliente_48x48px;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(1032, 410);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(146, 55);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ComboCategoria);
            this.panel1.Controls.Add(this.ComboProveedor);
            this.panel1.Controls.Add(this.LblProveedor);
            this.panel1.Controls.Add(this.TxtStockMIn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.TBPrecioCompra);
            this.panel1.Controls.Add(this.TBPrecioVenta);
            this.panel1.Controls.Add(this.TBStock);
            this.panel1.Controls.Add(this.TBDescripcion);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.LblPrecioCompra);
            this.panel1.Controls.Add(this.LblPrecioVenta);
            this.panel1.Controls.Add(this.LblStokMin);
            this.panel1.Controls.Add(this.LblDescripcion);
            this.panel1.Controls.Add(this.LblCategoria);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Location = new System.Drawing.Point(468, 486);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 224);
            this.panel1.TabIndex = 6;
            // 
            // ComboCategoria
            // 
            this.ComboCategoria.FormattingEnabled = true;
            this.ComboCategoria.Location = new System.Drawing.Point(538, 8);
            this.ComboCategoria.Name = "ComboCategoria";
            this.ComboCategoria.Size = new System.Drawing.Size(147, 21);
            this.ComboCategoria.TabIndex = 20;
            // 
            // ComboProveedor
            // 
            this.ComboProveedor.FormattingEnabled = true;
            this.ComboProveedor.Location = new System.Drawing.Point(538, 49);
            this.ComboProveedor.Name = "ComboProveedor";
            this.ComboProveedor.Size = new System.Drawing.Size(147, 21);
            this.ComboProveedor.TabIndex = 19;
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.Location = new System.Drawing.Point(456, 50);
            this.LblProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(77, 16);
            this.LblProveedor.TabIndex = 18;
            this.LblProveedor.Text = "Proveedor:";
            this.LblProveedor.Click += new System.EventHandler(this.LblProveedor_Click);
            // 
            // TxtStockMIn
            // 
            this.TxtStockMIn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockMIn.Location = new System.Drawing.Point(301, 107);
            this.TxtStockMIn.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStockMIn.Name = "TxtStockMIn";
            this.TxtStockMIn.Size = new System.Drawing.Size(55, 27);
            this.TxtStockMIn.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Stock:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::VienaStore.Properties.Resources.Confirmar_48x48px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(192, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "CONFIRMAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Coral;
            this.BtnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::VienaStore.Properties.Resources.cancelar_48x48_px;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(390, 164);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(159, 55);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TBPrecioCompra
            // 
            this.TBPrecioCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioCompra.Location = new System.Drawing.Point(301, 56);
            this.TBPrecioCompra.Margin = new System.Windows.Forms.Padding(2);
            this.TBPrecioCompra.Name = "TBPrecioCompra";
            this.TBPrecioCompra.Size = new System.Drawing.Size(113, 27);
            this.TBPrecioCompra.TabIndex = 12;
            // 
            // TBPrecioVenta
            // 
            this.TBPrecioVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioVenta.Location = new System.Drawing.Point(97, 54);
            this.TBPrecioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.TBPrecioVenta.Name = "TBPrecioVenta";
            this.TBPrecioVenta.Size = new System.Drawing.Size(93, 27);
            this.TBPrecioVenta.TabIndex = 11;
            // 
            // TBStock
            // 
            this.TBStock.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStock.Location = new System.Drawing.Point(101, 107);
            this.TBStock.Margin = new System.Windows.Forms.Padding(2);
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(55, 27);
            this.TBStock.TabIndex = 10;
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.Location = new System.Drawing.Point(301, 7);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(147, 27);
            this.TBDescripcion.TabIndex = 9;
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(97, 10);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(113, 27);
            this.TBNombre.TabIndex = 7;
            // 
            // LblPrecioCompra
            // 
            this.LblPrecioCompra.AutoSize = true;
            this.LblPrecioCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioCompra.Location = new System.Drawing.Point(2, 60);
            this.LblPrecioCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrecioCompra.Name = "LblPrecioCompra";
            this.LblPrecioCompra.Size = new System.Drawing.Size(91, 16);
            this.LblPrecioCompra.TabIndex = 6;
            this.LblPrecioCompra.Text = "Precio Costo:";
            // 
            // LblPrecioVenta
            // 
            this.LblPrecioVenta.AutoSize = true;
            this.LblPrecioVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioVenta.Location = new System.Drawing.Point(206, 60);
            this.LblPrecioVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrecioVenta.Name = "LblPrecioVenta";
            this.LblPrecioVenta.Size = new System.Drawing.Size(91, 16);
            this.LblPrecioVenta.TabIndex = 5;
            this.LblPrecioVenta.Text = "Precio Venta:";
            // 
            // LblStokMin
            // 
            this.LblStokMin.AutoSize = true;
            this.LblStokMin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStokMin.Location = new System.Drawing.Point(2, 113);
            this.LblStokMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStokMin.Name = "LblStokMin";
            this.LblStokMin.Size = new System.Drawing.Size(95, 16);
            this.LblStokMin.TabIndex = 4;
            this.LblStokMin.Text = "Stock MInimo:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(214, 13);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(83, 16);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Descripción:";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(456, 10);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(74, 16);
            this.LblCategoria.TabIndex = 1;
            this.LblCategoria.Text = "Categoría:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(2, 13);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(61, 16);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(897, 86);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(281, 24);
            this.TxtBuscar.TabIndex = 39;
            this.TxtBuscar.Click += new System.EventHandler(this.TxtBuscar_Click);
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(813, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "BUSCAR";
            // 
            // LblEditarProducto
            // 
            this.LblEditarProducto.AutoSize = true;
            this.LblEditarProducto.BackColor = System.Drawing.Color.Salmon;
            this.LblEditarProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditarProducto.Location = new System.Drawing.Point(145, 590);
            this.LblEditarProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEditarProducto.Name = "LblEditarProducto";
            this.LblEditarProducto.Size = new System.Drawing.Size(227, 44);
            this.LblEditarProducto.TabIndex = 8;
            this.LblEditarProducto.Text = "PRODUCTO";
            // 
            // LblEditar
            // 
            this.LblEditar.AutoSize = true;
            this.LblEditar.BackColor = System.Drawing.Color.Salmon;
            this.LblEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditar.Location = new System.Drawing.Point(178, 525);
            this.LblEditar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEditar.Name = "LblEditar";
            this.LblEditar.Size = new System.Drawing.Size(159, 44);
            this.LblEditar.TabIndex = 7;
            this.LblEditar.Text = "EDITAR";
            // 
            // PBEditarProducto
            // 
            this.PBEditarProducto.BackColor = System.Drawing.Color.Salmon;
            this.PBEditarProducto.Location = new System.Drawing.Point(139, 486);
            this.PBEditarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.PBEditarProducto.Name = "PBEditarProducto";
            this.PBEditarProducto.Size = new System.Drawing.Size(242, 219);
            this.PBEditarProducto.TabIndex = 5;
            this.PBEditarProducto.TabStop = false;
            // 
            // FBuscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1224, 788);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblEditarProducto);
            this.Controls.Add(this.LblEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PBEditarProducto);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.DtaProdcuto);
            this.Controls.Add(this.LblProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FBuscarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBuscarProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FBuscarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtaProdcuto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBEditarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.DataGridView DtaProdcuto;
        private System.Windows.Forms.Label LblPrecioCompra;
        private System.Windows.Forms.Label LblPrecioVenta;
        private System.Windows.Forms.Label LblStokMin;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TBPrecioCompra;
        private System.Windows.Forms.TextBox TBPrecioVenta;
        private System.Windows.Forms.TextBox TBStock;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BtnEditar;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtStockMIn;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LblEditarProducto;
        public System.Windows.Forms.Label LblEditar;
        public System.Windows.Forms.PictureBox PBEditarProducto;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.ComboBox ComboProveedor;
        private System.Windows.Forms.ComboBox ComboCategoria;
    }
}