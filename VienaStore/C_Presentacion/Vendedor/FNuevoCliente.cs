using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Datos;
using VienaStore.C_Negocio;



namespace VienaStore.C_Presentacion.Vendedor
{
    public partial class FNuevoCliente : Form
    {
        private Validaciones validacion;

        private  static FNuevoCliente instancia=null;
        public static FNuevoCliente Ventana_unica()
        {                    
            

                if (instancia == null)
                {
                    instancia = new FNuevoCliente();
                    return instancia;
            }                 
            
            
            return instancia;
        }

        public FNuevoCliente()
        {
            InitializeComponent();
            validacion = new Validaciones();

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            C_Negocio.Validaciones.SoloLetras(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Negocio.Validaciones.SoloLetras(e);
        }

        private void TxtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Negocio.Validaciones.SoloNumeros(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Negocio.Validaciones.SoloNumeros(e);
        }

        private void FNuevoCliente_Load(object sender, EventArgs e)
        {
            TxtNombre.Focus();
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtEmail.Text) && !C_Negocio.Validaciones.ValidarEmail(TxtEmail.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no es válida. El correo debe tener el formato: nombre@dominio.com",
                                "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtEmail.SelectAll();
                TxtEmail.Focus();
            }
        }
        public virtual void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                string.IsNullOrWhiteSpace(TxtDNI.Text) ||
                string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtDireccion.Text) ||
                (string.IsNullOrWhiteSpace(TxtTelefono.Text) || !TxtTelefono.MaskFull) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Clientes cliente = new Clientes();
            
            if (!decimal.TryParse(TxtDNI.Text, out decimal dni))
            {
                MessageBox.Show("El DNI ingresado no tiene un formato numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            cliente.dni = dni;
            cliente.nombre = TxtNombre.Text;
            cliente.apellido = TxtApellido.Text;
            cliente.direccion = TxtDireccion.Text;
            cliente.email = TxtEmail.Text;
            
            cliente.telefono = TxtTelefono.Text; 
            
            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                validacion.GuardarCliente(cliente);
                MessageBox.Show("El Cliente: " + this.TxtApellido.Text + " " + this.TxtDNI.Text + " se insertó Correctamente",
                                "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                this.TxtApellido.Clear();
                this.TxtNombre.Clear();
                this.TxtDNI.Clear();
                this.TxtDireccion.Clear();
                this.TxtEmail.Clear();
                this.TxtTelefono.Clear();
            }
            else
            {
                this.TxtApellido.Clear();
                this.TxtNombre.Clear();
                this.TxtDNI.Clear();
                this.TxtDireccion.Clear();
                this.TxtEmail.Clear();
                this.TxtTelefono.Clear();
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }

        public static void limpiar()
        {
            instancia = null;
        }
    }
}
