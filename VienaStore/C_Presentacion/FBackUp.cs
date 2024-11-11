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
using VienaStore.C_Presentacion.Administrador;
using static VienaStore.C_Negocio.BusinessBackUp;

namespace VienaStore.C_Presentacion
{
    public partial class FBackUp : Form
    {
        private static FBackUp instancia = null;

        private BusinessBackUp _businessBackUp;
        public static FBackUp Ventana_unica()
        {

            if (instancia == null)
            {
                instancia = new FBackUp();
                return instancia;
            }
            return instancia;
        }
        public FBackUp()
        {
            InitializeComponent();
            _businessBackUp = new BusinessBackUp();
        }

        private void FBackUp_Load(object sender, EventArgs e)
        {

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

        private void BtnBackUp_Click(object sender, EventArgs e)
        {
            
            try 
            {
                DialogResult ask = MessageBox.Show("¿Está seguro que quiere realizar un Back Up?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    _businessBackUp.BackUpDatabase();
                    MessageBox.Show("Respaldo de base de datos realizado exitosamente.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            } catch (Exception ex) { MessageBox.Show("Error al realizar el respaldo de la base de datos: " + ex.Message);

            }
        }
    }
}
