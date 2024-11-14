using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Datos;

namespace VienaStore.C_Negocio
{
    internal class BusinessReportes
    {
        private DataAccessReportes _dataAccessReportes;

        public BusinessReportes()
        {

            _dataAccessReportes = new DataAccessReportes();
        }


        public List<usuarios_ventas> GetreportesUsuarios(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _dataAccessReportes.reportesUsuarioVentas(fechaDesde, fechaHasta);
        }       
    }
}
