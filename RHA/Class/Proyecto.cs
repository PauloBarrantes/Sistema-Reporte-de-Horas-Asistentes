using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHA.Class
{
    class Proyecto
    {
         AccesoBaseDatos db;
        public Proyecto()
        {
            db = new AccesoBaseDatos();
        }

        public bool agregarProyecto(string nombre, string estado)
        {
           return db.agregarProyecto(nombre, estado);

        
        }
        public SqlDataReader obtenerProyectos()
        {
            SqlDataReader dataReader = null;
            try
            {
                dataReader = db.ejecutarConsulta("SELECT * FROM Proyecto");
            }
            catch
            (SqlException ex)
            {
                Console.WriteLine("GG obtenerProyectos");
            }

            return dataReader;
        }

    }
}
