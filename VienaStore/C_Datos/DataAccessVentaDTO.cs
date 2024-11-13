using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienaStore.C_Datos
{
    public class DataAccessVentaDTO
    {
        public int idVenta { get; set; }              
        public float total { get; set; }               
        public DateTime fecha { get; set; }            
        public string estadoFactura { get; set; }      
        public string nombreUsuario { get; set; }      
        public string descripcionFactura { get; set; } 
        public string nombreCliente { get; set; }       
        public string tipoPago { get; set; }  
    }
}

