﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class reportes : Form
    {
        private static reportes instancia = null;
        public static reportes Ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new reportes();
                return instancia;
            }
            return instancia;
        }
        public reportes()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            instancia = null;
            this.Close();
        }
    }
}
