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
using VienaStore.C_Presentacion.Vendedor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class FGestionProveedores : Form
    {
        private static FGestionProveedores instancia = null;

        private BusinessProveedores _businessProveedores;

        private bool esEdicion = false;

        private int idProveedorSeleccionado = -1; 


        public static FGestionProveedores Ventana_unica()
        {

            if (instancia == null)
            {
                instancia = new FGestionProveedores();
                return instancia;
            }
            return instancia;
        }
        public FGestionProveedores()
        {
            InitializeComponent();
            _businessProveedores = new BusinessProveedores();
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

        private void TxtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasYPuntos(e);
        }

        private void TxtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosYGuion(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.LimpiarProveedor(TxtEmpresa, TxtCuit, TxtCorreo, TxtDireccion, TxtTelefono);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AddProveedor();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validaciones.SoloNumeros(e);
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(TxtCorreo.Text) && !C_Negocio.Validaciones.ValidarEmail(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no es válida. El correo debe tener el formato: nombre@dominio.com",
                                "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCorreo.SelectAll();
                TxtCorreo.Focus();
            }
        }

        private void TxtBuscar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Clear();
        }

        private void FGestionProveedores_Load(object sender, EventArgs e)
        {
            ListarProveedores();
            DtaProveedores.ClearSelection();
        }

        private void ListarProveedores()
        {
            List<Proveedores> proveedores = _businessProveedores.GetProveedores();
            DtaProveedores.DataSource = proveedores;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BotonGuardarProveedor();
            esEdicion = false;
            DtaProveedores.ClearSelection();
        }

        private void GuardarProveedor()
        {
            Proveedores proveedor = new Proveedores();

            proveedor.nombreProveedor = TxtEmpresa.Text.ToUpper();
            proveedor.cuit = TxtCuit.Text;
            proveedor.email = TxtCorreo.Text.ToLower();
            proveedor.direccion = TxtDireccion.Text.ToUpper();
            proveedor.telefono = TxtTelefono.Text;
            proveedor.id_proveedor = Convert.ToInt32(DtaProveedores.CurrentRow.Cells["idproveedor"].Value);


            _businessProveedores.GuardarProveedor(proveedor);
        }

        private void DatagridEliminar(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DtaProveedores.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {                
                int id = int.Parse(DtaProveedores.Rows[e.RowIndex].Cells["idproveedor"].Value.ToString());
                string estado = DtaProveedores.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                if (estado == "ACTIVO")
                {
                    DialogResult preg = MessageBox.Show("¿Esta seguro que quiere eliminar este Proveedor?", "Confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (preg == DialogResult.Yes)
                    {
                        DtaProveedores.Rows[e.RowIndex].Cells["estado"].Value = "ELIMINADO";
                        EliminarProveedor(id);
                        Limpiar.LimpiarProveedor(TxtEmpresa, TxtCuit, TxtCorreo, TxtDireccion, TxtTelefono);
                        MessageBox.Show("Se ha eliminado correctamente", "Elminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        return;
                    }
                }
                else if (estado == "ELIMINADO")
                {
                    DialogResult preg = MessageBox.Show("¿Esta seguro que quiere dar el Alta del Proveedor?", "Confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (preg == DialogResult.Yes)
                    {
                        DtaProveedores.Rows[e.RowIndex].Cells["estado"].Value = "ACTIVO";
                        EliminarProveedor(id);
                        MessageBox.Show("El proveedor ha sido dado de alta correctamente", "Reestablecido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        return;
                    }
                }
            }

        }

        private void  BotonGuardarProveedor()
        {
            if (CampoVacios.camposProveedor(TxtEmpresa, TxtCuit, TxtDireccion, TxtTelefono, TxtCorreo))
            {
                if (esEdicion == true)
                {
                    DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas Modificar los datos del proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmacion == DialogResult.Yes)
                    {
                        GuardarProveedor();
                        Limpiar.LimpiarProveedor(TxtEmpresa, TxtDireccion, TxtCuit, TxtCorreo, TxtTelefono);
                        ListarProveedores();
                        MessageBox.Show("Modificación Exitosa", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else {
                    MessageBox.Show("Debes Presionar el Boton Agregar para Ingresar un nuevo Proveedor", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
            }
        }
        private void AddProveedor()
        {
            if (!CampoVacios.camposProveedor(TxtEmpresa, TxtCuit, TxtCorreo, TxtDireccion, TxtTelefono))
            {
                Limpiar.LimpiarProveedor(TxtEmpresa, TxtCuit, TxtCorreo, TxtDireccion, TxtTelefono);
                return;
            }

            Proveedores proveedor = new Proveedores();
            proveedor.nombreProveedor = TxtEmpresa.Text.ToUpper();
            proveedor.cuit = TxtCuit.Text.ToUpper();
            proveedor.direccion = TxtDireccion.Text.ToUpper();
            proveedor.telefono = TxtTelefono.Text;
            proveedor.email = TxtCorreo.Text.ToLower();

            DialogResult ask = MessageBox.Show("¿Seguro que desea agregar un nuevo proveedor?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {

                _businessProveedores.GuardarProveedor(proveedor);

                MessageBox.Show("El Proveedor: " + this.TxtEmpresa.Text + "\n" + "CUIT N°" + " " + this.TxtCuit.Text + "" + " \nSe agregó Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar.LimpiarProveedor(TxtEmpresa, TxtCuit, TxtCorreo, TxtDireccion, TxtTelefono);
                ListarProveedores();
                return;
            }
            else
            {
                Limpiar.LimpiarProveedor(TxtEmpresa, TxtCuit, TxtCorreo, TxtDireccion, TxtTelefono);
            }
        }
        private void Edit()
        {

            if (DtaProveedores.SelectedRows.Count > 0)
            {
                esEdicion = true;
                DataGridViewRow fila = DtaProveedores.SelectedRows[0];
                string estado = Convert.ToString(fila.Cells["estado"].Value);
                if (estado == "ELIMINADO")
                {
                    MessageBox.Show("El proveedor no existe", "Verificar!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                else
                {
                    int id_proveedor = Convert.ToInt32(fila.Cells["idproveedor"].Value);
                    TxtEmpresa.Text = Convert.ToString(fila.Cells["nombreProveedor"].Value);
                    TxtCuit.Text = Convert.ToString(fila.Cells["cuit"].Value);
                    TxtDireccion.Text = Convert.ToString(fila.Cells["direccion"].Value);
                    TxtTelefono.Text = Convert.ToString(fila.Cells["telefono"].Value);
                    TxtCorreo.Text = Convert.ToString(fila.Cells["email"].Value);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un proveedor para Modificar", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }          
            
        }


        private void EliminarProveedor(int id)
        {
            _businessProveedores.DeleteProveedor(id);
        }

        private void DtaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridEliminar(e);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscaText = TxtBuscar.Text;
            List<Proveedores> proveedoresEncontrados = _businessProveedores.GetProveedores(buscaText);
            DtaProveedores.DataSource = proveedoresEncontrados;
        }

       
    }
}
