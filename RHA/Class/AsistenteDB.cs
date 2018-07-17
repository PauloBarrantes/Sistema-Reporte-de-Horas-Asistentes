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

        public bool guardarBloqueReporte(string email, string nombreProyecto, string fecha, string horaInicial, string horaFinal) {
           return  db.guardarBloqueReporte(email, nombreProyecto, fecha, horaInicial, horaFinal);
        }

        public bool guardarBloqueHorario(string email, string ciclo, string anno, string dia, string horaInicio, string horaFinal) {
            return db.guardarBloqueHorario(email, ciclo, anno, dia, horaInicio, horaFinal);
        }


        public SqlDataReader obtenerAsistentes() {
            SqlDataReader datos = null;
            try
            {
                datos = db.ejecutarConsulta("SELECT Asi.Email, Asi.Cedula, Emp.NombreEmp, Emp.Apellido1, Asi.Carrera, Asi.HorasAcumuladas FROM Asistente as Asi JOIN Empleado as Emp on Emp.Email = Asi.Email");
            }
            catch
            (SqlException ex)
            {
                Console.WriteLine("GG ObtenerNombre");
            }
            return datos;
            
        }
        public SqlDataReader obtenerHorario(string usuarioActual, string ciclo, string anno)
        {
            SqlDataReader datos = null;
            try
            {
                datos = db.ejecutarConsulta("SELECT Asi.Email, Asi.Cedula, Emp.NombreEmp, Emp.Apellido1, Asi.Carrera, Asi.HorasAcumuladas FROM Asistente as Asi JOIN Empleado as Emp on Emp.Email = Asi.Email");
            }
            catch
            (SqlException ex)
            {
                Console.WriteLine("GG ObtenerNombre");
            }
            return datos;

        }

        public SqlDataReader obtenerBalance()
        {
            SqlDataReader datos = null;
            try
            {
                datos = db.ejecutarConsulta("SELECT Asi.Email, Asi.Cedula, Emp.NombreEmp, Emp.Apellido1, Asi.HorasAcumuladas FROM Asistente as Asi JOIN Empleado as Emp on Emp.Email = Asi.Email");
            }
            catch
            (SqlException ex)
            {
                Console.WriteLine("GG ObtenerNombre");
            }
            return datos;
        }

    }
}
