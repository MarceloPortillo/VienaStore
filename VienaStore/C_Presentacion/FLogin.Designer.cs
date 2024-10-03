namespace VienaStore.C_Presentacion
{
    partial class FLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TBContrasenia = new System.Windows.Forms.TextBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.LblContrasenia = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblIniciarSesion = new System.Windows.Forms.Label();
            this.LblHola = new System.Windows.Forms.Label();
            this.LblBuenDia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnIngresar);
            this.panel1.Controls.Add(this.TBContrasenia);
            this.panel1.Controls.Add(this.TBUsuario);
            this.panel1.Controls.Add(this.LblContrasenia);
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.LblIniciarSesion);
            this.panel1.Location = new System.Drawing.Point(74, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 328);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(27, 201);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(425, 1);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(28, 143);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(425, 1);
            this.panel2.TabIndex = 14;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(143, 237);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnIngresar.Size = new System.Drawing.Size(187, 39);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.BtnIngresar.Enter += new System.EventHandler(this.btnIngresar_Click);
            // 
            // TBContrasenia
            // 
            this.TBContrasenia.BackColor = System.Drawing.Color.Salmon;
            this.TBContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBContrasenia.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContrasenia.Location = new System.Drawing.Point(28, 176);
            this.TBContrasenia.Name = "TBContrasenia";
            this.TBContrasenia.Size = new System.Drawing.Size(424, 20);
            this.TBContrasenia.TabIndex = 2;
            this.TBContrasenia.UseSystemPasswordChar = true;
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.Color.Salmon;
            this.TBUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuario.Location = new System.Drawing.Point(28, 118);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(425, 19);
            this.TBUsuario.TabIndex = 1;
            // 
            // LblContrasenia
            // 
            this.LblContrasenia.AutoSize = true;
            this.LblContrasenia.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasenia.Location = new System.Drawing.Point(28, 155);
            this.LblContrasenia.Name = "LblContrasenia";
            this.LblContrasenia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblContrasenia.Size = new System.Drawing.Size(89, 18);
            this.LblContrasenia.TabIndex = 8;
            this.LblContrasenia.Text = "Contraseña";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(27, 98);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblUsuario.Size = new System.Drawing.Size(61, 18);
            this.LblUsuario.TabIndex = 7;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblIniciarSesion
            // 
            this.LblIniciarSesion.AutoEllipsis = true;
            this.LblIniciarSesion.AutoSize = true;
            this.LblIniciarSesion.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIniciarSesion.Location = new System.Drawing.Point(143, 32);
            this.LblIniciarSesion.Name = "LblIniciarSesion";
            this.LblIniciarSesion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblIniciarSesion.Size = new System.Drawing.Size(197, 34);
            this.LblIniciarSesion.TabIndex = 12;
            this.LblIniciarSesion.Text = "Iniciar Sesión";
            // 
            // LblHola
            // 
            this.LblHola.AutoSize = true;
            this.LblHola.BackColor = System.Drawing.Color.Transparent;
            this.LblHola.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHola.Location = new System.Drawing.Point(54, 64);
            this.LblHola.Name = "LblHola";
            this.LblHola.Size = new System.Drawing.Size(70, 28);
            this.LblHola.TabIndex = 13;
            this.LblHola.Text = "Hola!";
            // 
            // LblBuenDia
            // 
            this.LblBuenDia.AutoSize = true;
            this.LblBuenDia.BackColor = System.Drawing.Color.Transparent;
            this.LblBuenDia.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuenDia.Location = new System.Drawing.Point(52, 93);
            this.LblBuenDia.Name = "LblBuenDia";
            this.LblBuenDia.Size = new System.Drawing.Size(154, 34);
            this.LblBuenDia.TabIndex = 6;
            this.LblBuenDia.Text = "Buen día!";
            // 
            // FLogin
            // 
            this.AcceptButton = this.BtnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(605, 557);
            this.Controls.Add(this.LblBuenDia);
            this.Controls.Add(this.LblHola);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblHola;
        private System.Windows.Forms.Label LblIniciarSesion;
        private System.Windows.Forms.TextBox TBContrasenia;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Label LblContrasenia;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnIngresar;
        protected internal System.Windows.Forms.Label LblBuenDia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}