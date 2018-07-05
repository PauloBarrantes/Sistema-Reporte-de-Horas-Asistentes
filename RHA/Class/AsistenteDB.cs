using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHA.Class
{
    class AsistenteDB
    {
        AccesoBaseDatos db;

        public AsistenteDB()
        {
            db = new AccesoBaseDatos();
        }

        public DataTable obtenerAsistentes() {
            DataTable tabla = null;
            try
            {
                tabla = db.ejecutarConsultaTabla("SELECT Asi.Cedula, Emp.NombreEmp, Emp.Apellido1, Asi.Carrera, Asi.HorasAcumuladas FROM Asistente as Asi JOIN Empleado as Emp on Emp.Email = Asi.Email");
            }
            catch(SqlException ex) {
                Console.WriteLine(ex);
            }

            return tabla;
        }

    }
}
