using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Negocio;
using VienaStore.C_Datos;
using VienaStore.C_Presentacion;

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class FGestionCategorias : Form
    {
        private BusinessCategoria _businessCategoria;
        private static FGestionCategorias instancia = null;
        public static FGestionCategorias Ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FGestionCategorias();
                return instancia;
            }

            return instancia;
        }
        public FGestionCategorias()
        {
            InitializeComponent();
            _businessCategoria  = new BusinessCategoria();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }

        public static void limpiar()
        {
            instancia = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgreCat_Click(object sender, EventArgs e)
        {
            if (!CampoVacios.camposCategoria(TxtNombre, TxtDescripcion) || Validaciones.ValidarLength(TxtNombre.Text, 3))
            {
                return;
            }
            
            Categorias categoria = new Categorias();

            categoria.nombre = TxtNombre.Text;
            categoria.descripcion = TxtDescripcion.Text;            

            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea agregar una nueva categoría?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    _businessCategoria.guardar(categoria);
                    Dialogos.DialogoCategoria(TxtNombre.Text);
                    Limpiar.LimpiarCategoria(TxtNombre, TxtDescripcion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            Limpiar.LimpiarCategoria(TxtNombre, TxtDescripcion);
        }


        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar.LimpiarCategoria(TxtNombre, TxtDescripcion);
        }
    }
}
