using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHA
{
    class Empleado
    {
        AccesoBaseDatos db;

        public Empleado()
        {
            db = new AccesoBaseDatos();
        }

        public bool agregarAsistentes(string email, string password, string nombre, string apellido1, string apellido2, string carne, string cedula, string carrera, string telefono, int horasAcumuladas, string sexo)
        {
            bool retorno = false;
            int resultado = db.agregarAsistente(email, password, nombre, apellido1, apellido2, carne, cedula, carrera, telefono, horasAcumuladas, sexo);

            if (resultado == 1)
            {
                retorno = true;
            }
            return retorno;
        }

        public SqlDataReader obtenerNombre(string usuarioActual)
        {
            SqlDataReader datos = null;
            try
            {
                datos = db.ejecutarConsulta("SELECT distinct NombreEmp FROM Empleado WHERE Email = \'" + usuarioActual + "\'");
            }
            catch
            (SqlException ex)
            {
                Console.WriteLine("GG ObtenerNombre");
            }
            return datos;
        }
        public SqlDataReader obtenerInfoUsuario(string usuarioActual)
        {
            SqlDataReader datos = null;
            try
            {
                datos = db.ejecutarConsulta("SELECT * FROM Empleado WHERE Email = \'" + usuarioActual + "\'");
            }
            catch
            (SqlException ex)
            {
                Console.WriteLine("GG ObtenerNombre");
            }
            return datos;
        }

        public SqlDataReader obtenerPeriodo() {

            SqlDataReader datos = null;
            try
            {
                datos = db.ejecutarConsulta("SELECT * FROM Periodo");
            }
            catch
            (SqlException ex)
            {
                Console.WriteLine("GG ObtenerNombre");
            }
            return datos;
        }
        public SqlDataReader obtenerInfoAsistente(string usuarioActual)
        {
            SqlDataReader datos = null;
            try
            {
                datos = db.ejecutarConsulta("SELECT * FROM Empleado JOIN Asistente  On Asistente.Email = \'" + usuarioActual + "\'" + " WHERE Empleado.Email = \'" + usuarioActual + "\'");
            }
            catch
            (SqlException ex)
            {
                Console.WriteLine("GG ObtenerNombre");
            }
            return datos;
        }
        public SqlDataReader obtenerNombramiento(string usuarioActual, string ciclo, string anno)
        {
            SqlDataReader datos = null;
            try
            {
                datos = db.ejecutarConsulta("SELECT * FROM Nombramiento "  + " WHERE Nombramiento.Email = \'" + usuarioActual + "\' and Nombramiento.Ciclo = \'"+ciclo+"\' and Nombramiento.Anno = \'"+anno+"\'");
            }
            catch
            (SqlException ex)
            {
                Console.WriteLine("GG ObtenerNombre");
            }
            return datos;
        }
        public bool login(string email, string password)
        {
            return db.login(email, password);
        }
        public bool eliminarAsistente(string email)
        {
            bool retorno = false;


            return retorno;
        }

        public bool agregarNombramiento(string email, string idNombramiento, string ciclo, int anno, int horas, string entNombradora, int tipoAsistente)
        {
            bool retorno = false;
            int resultado = db.agregarNombramiento(email, idNombramiento, ciclo, anno, horas, entNombradora, tipoAsistente);

            if (resultado == 1)
            {
                retorno = true;
            }
            return retorno;
        }
        public bool agregarBloqueHoras(string email, string nombreProyecto, string fecha, string horaI, string horaF)
        {
            return db.agregarBloqueHoras(email, nombreProyecto, fecha, horaI, horaF);
        }
        public bool editarPerfil(string nombre, string apellido1, string apellido2, string cedula, string emailNuevo, string emailViejo, string carrera, string carne, string telefono)
        {
            
            return db.editarPerfil(nombre, apellido1, apellido2, cedula, emailNuevo, emailViejo, carrera, carne, telefono);
        }
        public bool cambiarPassword(string email, string password) {
            return db.cambiarPassword(email, password);

        }

        public int rol(string email)
        {
            int rol = db.Rol(email);
            return rol;
        }
    }
}
