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
using VienaStore.C_Presentacion.Vendedor;

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class Proveedores : Form
    {
        private static Proveedores instancia = null;
        public static Proveedores Ventana_unica()
        {



            if (instancia == null)
            {
                instancia = new Proveedores();
                return instancia;
            }
            return instancia;
        }
        public Proveedores()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            instancia = null;
            this.Close();
        }

        private void TxtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void TxtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtEmpresa.Text) ||
                string.IsNullOrWhiteSpace(TxtCuit.Text) ||
                string.IsNullOrWhiteSpace(TxtCorreo.Text) ||
                string.IsNullOrWhiteSpace(TxtDireccion.Text) ||
                string.IsNullOrWhiteSpace(TxtTelefono.Text) )
                
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult ask = MessageBox.Show("¿Seguro que desea modificar el proveedor?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El Proveedor: " + this.TxtEmpresa.Text + "\n" + "CUIT N°" + " " + this.TxtCuit.Text + "" + " \nSe inserto Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtEmpresa.Clear();
                this.TxtCuit.Clear();
                this.TxtCorreo.Clear();
                this.TxtDireccion.Clear();
                this.TxtTelefono.Clear();
                return;
            }
            else
            {
                this.TxtEmpresa.Clear();
                this.TxtCuit.Clear();
                this.TxtCorreo.Clear();
                this.TxtDireccion.Clear();
                this.TxtTelefono.Clear();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.TxtEmpresa.Clear();
            this.TxtCuit.Clear();
            this.TxtCorreo.Clear();
            this.TxtDireccion.Clear();
            this.TxtTelefono.Clear();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtEmpresa.Text) ||
                string.IsNullOrWhiteSpace(TxtCuit.Text) ||
                string.IsNullOrWhiteSpace(TxtCorreo.Text) ||
                string.IsNullOrWhiteSpace(TxtDireccion.Text) ||
                string.IsNullOrWhiteSpace(TxtTelefono.Text))

            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult ask = MessageBox.Show("¿Seguro que desea agregar un nuevo proveedor?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El Proveedor: " + this.TxtEmpresa.Text + "\n" + "CUIT N°" + " " + this.TxtCuit.Text + "" + " \nSe agregó Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtEmpresa.Clear();
                this.TxtCuit.Clear();
                this.TxtCorreo.Clear();
                this.TxtDireccion.Clear();
                this.TxtTelefono.Clear();
                return;
            }
            else
            {
                this.TxtEmpresa.Clear();
                this.TxtCuit.Clear();
                this.TxtCorreo.Clear();
                this.TxtDireccion.Clear();
                this.TxtTelefono.Clear();
            }
        }
    }
}
