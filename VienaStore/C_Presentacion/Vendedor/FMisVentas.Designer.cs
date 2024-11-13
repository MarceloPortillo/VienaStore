namespace VienaStore.C_Presentacion.Vendedor
{
    partial class FMisVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtEmpleado = new System.Windows.Forms.TextBox();
            this.TxtBuscarFactura = new System.Windows.Forms.TextBox();
            this.LblVentas = new System.Windows.Forms.Label();
            this.dataGridViewMisVentas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMisVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtEmpleado);
            this.groupBox1.Controls.Add(this.TxtBuscarFactura);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR VENTA REALIZADA";
            // 
            // TxtEmpleado
            // 
            this.TxtEmpleado.Location = new System.Drawing.Point(16, 97);
            this.TxtEmpleado.Name = "TxtEmpleado";
            this.TxtEmpleado.Size = new System.Drawing.Size(415, 32);
            this.TxtEmpleado.TabIndex = 2;
            // 
            // TxtBuscarFactura
            // 
            this.TxtBuscarFactura.Location = new System.Drawing.Point(16, 42);
            this.TxtBuscarFactura.Name = "TxtBuscarFactura";
            this.TxtBuscarFactura.Size = new System.Drawing.Size(787, 32);
            this.TxtBuscarFactura.TabIndex = 1;
            // 
            // LblVentas
            // 
            this.LblVentas.AutoSize = true;
            this.LblVentas.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVentas.Location = new System.Drawing.Point(74, 249);
            this.LblVentas.Name = "LblVentas";
            this.LblVentas.Size = new System.Drawing.Size(137, 40);
            this.LblVentas.TabIndex = 2;
            this.LblVentas.Text = "Ventas";
            // 
            // dataGridViewMisVentas
            // 
            this.dataGridViewMisVentas.AllowUserToAddRows = false;
            this.dataGridViewMisVentas.AllowUserToResizeColumns = false;
            this.dataGridViewMisVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewMisVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMisVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMisVentas.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewMisVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMisVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMisVentas.ColumnHeadersHeight = 30;
            this.dataGridViewMisVentas.EnableHeadersVisualStyles = false;
            this.dataGridViewMisVentas.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridViewMisVentas.Location = new System.Drawing.Point(32, 313);
            this.dataGridViewMisVentas.MultiSelect = false;
            this.dataGridViewMisVentas.Name = "dataGridViewMisVentas";
            this.dataGridViewMisVentas.ReadOnly = true;
            this.dataGridViewMisVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMisVentas.RowHeadersVisible = false;
            this.dataGridViewMisVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSalmon;
            this.dataGridViewMisVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMisVentas.RowTemplate.Height = 24;
            this.dataGridViewMisVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMisVentas.Size = new System.Drawing.Size(1672, 686);
            this.dataGridViewMisVentas.TabIndex = 3;
            // 
            // FMisVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1707, 1032);
            this.Controls.Add(this.dataGridViewMisVentas);
            this.Controls.Add(this.LblVentas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMisVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FMisVentas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMisVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMisVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBuscarFactura;
        private System.Windows.Forms.Label LblVentas;
        private System.Windows.Forms.DataGridView dataGridViewMisVentas;
        private System.Windows.Forms.TextBox TxtEmpleado;
    }
}