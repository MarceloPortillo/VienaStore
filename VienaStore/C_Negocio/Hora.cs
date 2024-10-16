using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VienaStore.C_Negocio
{
    internal class Hora
    {
        public static void saludo(Label LblHora)
        {
            DateTime ahora = DateTime.Now;
            int hora = ahora.Hour;            
            if (hora > 6 && hora <= 13)
            {
                LblHora.Text = "Buenos Días";
            }
            else if (hora > 13 && hora <= 18)
            {
                LblHora.Text = "Buenas Tardes";
            }
            else
            {
                LblHora.Text = "Buenas Noches";
            }
        }
    }
}

