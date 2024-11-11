using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using VienaStore.C_Datos;

namespace VienaStore.C_Negocio
{
    public class BusinessBackUp
    {
        private DataAccesBackUp _dataAccess;
        
            public BusinessBackUp()
            {
                _dataAccess = new DataAccesBackUp();
            }

        public void BackUpDatabase()
        {            
            string nombre = $"{DateTime.Today.Day}-{DateTime.Today.Month}-{DateTime.Today.Year}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}";

            
            string rutaBackup = $@"C:\BackUpVienaStore\VienaStore-{nombre}.bak";

            
            string consulta = $"BACKUP DATABASE [VienaStore] TO DISK = N'{rutaBackup}' WITH NOFORMAT, NOINIT, NAME = N'VienaStore - Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";

            
            _dataAccess.BackUpDatabase(consulta);
        }


    }

}

