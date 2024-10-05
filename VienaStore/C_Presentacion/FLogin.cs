using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Presentacion.Administrador;
using VienaStore.C_Presentacion.Encargado;
using VienaStore.C_Presentacion.Vendedor;
using VienaStore.C_Negocio;

namespace VienaStore.C_Presentacion
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        // Evento click del botón Ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Login.registro(TBUsuario.Text, TBContrasenia.Text);   
            this.Hide();
        }
    }
}
