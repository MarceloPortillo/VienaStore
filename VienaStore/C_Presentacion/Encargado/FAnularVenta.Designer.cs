namespace VienaStore.C_Presentacion.Encargado
{
    partial class FAnularVenta
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
            this.BtnSalirAnularVenta = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtaUsuario = new System.Windows.Forms.DataGridView();
            this.BtnAnular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalirAnularVenta
            // 
            this.BtnSalirAnularVenta.BackColor = System.Drawing.Color.Coral;
            this.BtnSalirAnularVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirAnularVenta.Image = global::VienaStore.Properties.Resources.cancelar_48x48_px;
            this.BtnSalirAnularVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalirAnularVenta.Location = new System.Drawing.Point(634, 354);
            this.BtnSalirAnularVenta.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalirAnularVenta.Name = "BtnSalirAnularVenta";
            this.BtnSalirAnularVenta.Size = new System.Drawing.Size(128, 52);
            this.BtnSalirAnularVenta.TabIndex = 7;
            this.BtnSalirAnularVenta.Text = "Salir";
            this.BtnSalirAnularVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalirAnularVenta.UseVisualStyleBackColor = false;
            this.BtnSalirAnularVenta.Click += new System.EventHandler(this.BtnSalirAnularVenta_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(190, 61);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(233, 20);
            this.TxtBuscar.TabIndex = 39;
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(177, 22);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(260, 24);
            this.LblBuscar.TabIndex = 40;
            this.LblBuscar.Text = "Ingrese el NRO de Factura";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = global::VienaStore.Properties.Resources.lupaBuscar_32px;
            this.BtnBuscar.Location = new System.Drawing.Point(440, 52);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 37);
            this.BtnBuscar.TabIndex = 45;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // ColApellido
            // 
            this.ColApellido.HeaderText = "Precio Total";
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Producto";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColLegajo
            // 
            this.ColLegajo.HeaderText = "Factura N°";
            this.ColLegajo.Name = "ColLegajo";
            this.ColLegajo.ReadOnly = true;
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
            this.ColLegajo,
            this.ColNombre,
            this.ColCantidad,
            this.ColApellido,
            this.ColEstado});
            this.DtaUsuario.EnableHeadersVisualStyles = false;
            this.DtaUsuario.Location = new System.Drawing.Point(110, 136);
            this.DtaUsuario.Name = "DtaUsuario";
            this.DtaUsuario.ReadOnly = true;
            this.DtaUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DtaUsuario.RowHeadersVisible = false;
            this.DtaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtaUsuario.Size = new System.Drawing.Size(634, 169);
            this.DtaUsuario.TabIndex = 46;
            // 
            // BtnAnular
            // 
            this.BtnAnular.BackColor = System.Drawing.Color.Coral;
            this.BtnAnular.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnular.Image = global::VienaStore.Properties.Resources.Eliminar_48x48px;
            this.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnular.Location = new System.Drawing.Point(486, 354);
            this.BtnAnular.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(125, 52);
            this.BtnAnular.TabIndex = 47;
            this.BtnAnular.Text = "ANULAR";
            this.BtnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnular.UseVisualStyleBackColor = false;
            // 
            // FAnularVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(879, 514);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.DtaUsuario);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnSalirAnularVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAnularVenta";
            this.Text = "FAnularVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DtaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalirAnularVenta;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLegajo;
        public System.Windows.Forms.DataGridView DtaUsuario;
        public System.Windows.Forms.TextBox TxtBuscar;
        public System.Windows.Forms.Label LblBuscar;
        public System.Windows.Forms.Button BtnAnular;
    }
}