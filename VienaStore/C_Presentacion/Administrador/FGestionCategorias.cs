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
using System.Media;

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class FGestionCategorias : Form
    {
        private BusinessCategoria _businessCategoria;
        private Categorias _categoria;
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
            _businessCategoria = new BusinessCategoria();
            TxtBuscarCategoria.TextChanged += TxtBuscarCategoria_TextChanged;
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
            agregar();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar.LimpiarCategoria(TxtNombre, TxtDescripcion);
        }

        public void saveCategoria()
        {
            GuardarCategoria();
        }

        private void FGestionCategorias_Load(object sender, EventArgs e)
        {
            ListarCategorias();            
            DtaCategoria.ClearSelection();
        }

        public void ListarCategorias(string buscarText = null)
        {
            List<Categorias> lista = _businessCategoria.GetCategorias(buscarText);
            DtaCategoria.DataSource = lista;
        }

        private void TxtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            string buscarTex = TxtBuscarCategoria.Text;
            List<Categorias> categoriasEncontradas = _businessCategoria.GetCategorias(buscarTex);
            DtaCategoria.DataSource = categoriasEncontradas;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            BotonGuardar();
            DtaCategoria.ClearSelection();
        }

        private void DtaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridEliminar(e);
        }

        private void EliminarCategoria(int id)
        {
            _businessCategoria.DeleteCategoria(id);
        }

        private void edit()
        {
            if (DtaCategoria.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = DtaCategoria.SelectedRows[0];
                int id_Categoria = Convert.ToInt32(fila.Cells["id_categoria"].Value);
                TxtNombre.Text = Convert.ToString(fila.Cells["nombre"].Value);
                TxtDescripcion.Text = Convert.ToString(fila.Cells["descripcion"].Value);
                string estado = Convert.ToString(fila.Cells["BtnActivarDesactivar"].Value);
                if (estado == "Inactivo")
                {
                    MessageBox.Show("No puedes Modificar una Categoria Inactiva", "Inactiva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar.LimpiarCategoria(TxtNombre, TxtDescripcion);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonGuardar() 
        {
            if (CampoVacios.camposCategoria(TxtNombre, TxtDescripcion))
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas Modificar esta categoria?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    saveCategoria();
                    ListarCategorias();
                    Limpiar.LimpiarCategoria(TxtNombre, TxtDescripcion);
                    MessageBox.Show("Modificación Exitosa", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No puede guardar sin haber modificado antes", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DatagridEliminar(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DtaCategoria.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int id = int.Parse(DtaCategoria.Rows[e.RowIndex].Cells["id_Categoria"].Value.ToString());
                string estado = DtaCategoria.Rows[e.RowIndex].Cells["estadoDataGridViewTextBoxColumn"].Value.ToString();
                if (estado == "Activo")
                {
                    DialogResult preg = MessageBox.Show("¿Esta seguro que quiere eliminar esta Categoria?", "Confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (preg == DialogResult.Yes)
                    {
                        DtaCategoria.Rows[e.RowIndex].Cells["estadoDataGridViewTextBoxColumn"].Value = "Inactivo";
                        EliminarCategoria(id);
                        MessageBox.Show("Se ha eliminado correctamente", "Elminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        return;
                    }
                }
                else if (estado == "Inactivo")
                {
                    DialogResult preg = MessageBox.Show("¿Esta seguro que quiere Activar esta Categoría?", "Confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (preg == DialogResult.Yes)
                    {
                        DtaCategoria.Rows[e.RowIndex].Cells["estadoDataGridViewTextBoxColumn"].Value = "Activo";
                        EliminarCategoria(id);
                        MessageBox.Show("Se ha Activado correctamente", "Reestablecido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void agregar()
        {
            if (!CampoVacios.camposCategoria(TxtNombre, TxtDescripcion) || Validaciones.ValidarLength(TxtNombre.Text, 3))
            {
                Limpiar.LimpiarCategoria(TxtNombre, TxtDescripcion);
                return;
            }
            Categorias categoria = new Categorias();
            categoria.nombre = TxtNombre.Text.ToUpper();
            categoria.descripcion = TxtDescripcion.Text.ToUpper();
            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea agregar una nueva categoría?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    _businessCategoria.guardar(categoria);
                    Dialogos.DialogoCategoria(TxtNombre.Text);
                    Limpiar.LimpiarCategoria(TxtNombre, TxtDescripcion);
                    ListarCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void GuardarCategoria()
        {
            if (CampoVacios.camposCategoria(TxtNombre, TxtDescripcion))
            {
                Categorias categoria = new Categorias();
                categoria.id_Categoria = Convert.ToInt32(DtaCategoria.CurrentRow.Cells["id_Categoria"].Value);
                categoria.nombre = TxtNombre.Text.ToUpper();
                categoria.descripcion = TxtDescripcion.Text.ToUpper();
                categoria.estado = Convert.ToString(DtaCategoria.CurrentRow.Cells["estadoDataGridViewTextBoxColumn"].Value);

                _businessCategoria.guardar(categoria);
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }
    }

}
