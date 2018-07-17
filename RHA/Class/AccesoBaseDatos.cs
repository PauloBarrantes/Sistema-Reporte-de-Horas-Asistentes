using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RHA
{
    class AccesoBaseDatos
    {
        /*En Initial Catalog se agrega la base de datos propia. Intregated Security es para utilizar Windows Authentication*/
        //String conexion = "Data Source=10.1.4.55; Initial Catalog=gaudyblanco; Integrated Security=SSPI";

        /*En Initial Catalog se agrega la base de datos propia. Intregated Security = false es para utilizar SQL SERVER Authentication*/
        String conexion = "Data Source=10.1.4.55;User ID=b60369;Password=Folotopo11; Initial Catalog=DB_BYTEME; Integrated Security=false";

        /**
         * Constructor de la clase
         */
        public AccesoBaseDatos()
        {
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un SqlDataReader
         * Recibe: La consulta sql a ejecutar
         * Modifica: Obtiene las tuplas que corresponden a la consulta recibida
         * Retorna: El datareader con los resultados de la ejecución de la consulta
         */
        public SqlDataReader ejecutarConsulta(String consulta)
        {
            Console.WriteLine("GG");
            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlDataReader datos = null;
            SqlCommand comando = null;

            try
            {
                //Ejecuta la consulta sql recibida por parámetro y la carga en un datareader
                comando = new SqlCommand(consulta, sqlConnection);
                datos = comando.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            return datos;
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un DataTable
         * * Recibe: La consulta sql a ejecutar
         * Modifica: Obtiene las tuplas que corresponden a la consulta recibida
         * Retorna: El datatable con los resultados de la ejecución de la consulta
         */
        public DataTable ejecutarConsultaTabla(String consulta)
        {
            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand comando = new SqlCommand(consulta, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            return table;
        }

        /*Método para ejecutar un insert, update o delete 
         Recibe: la sentencia sql a ejecutar
         Modifica: realiza el cambio en la base de datos de acuerdo al tipo de sentencia sql
         Retorna: el tipo de error que generó la consulta o cero si la ejecución fue exitosa*/
        public int actualizarDatos(String consulta)
        {
            int error = 0;

            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand cons = new SqlCommand(consulta, sqlConnection);

            try
            {
                //Ejecuta la consulta sql recibida por parámetro
                cons.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                error = e.Number;
                Debug.WriteLine("Error: " + error);
            }

            finally
            {
                sqlConnection.Close();
            }

            return error;
        }

        /*Método para llamar al procedimiento almacenado de eliminarEstudiante 
         Recibe: el nombre del o los estudiantes que se va a eliminar
         Modifica: Elimina las tuplas que coincidan con el nombre recibido por parámetro
         Retorna: el tipo de error que generó la consulta o cero si la ejecución fue exitosa*/
        public int eliminarEmpleado(string nombre)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("eliminarEstudiante", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;

                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return error;
                    }
                    catch (SqlException ex)
                    {

                        error = ex.Number;
                        return error;
                    }
                }
            }

        }

        /*Método para llamar al procedimiento almacenado que permite agregar un nuevo usuario 
         Recibe: el usuario y la contraseña del nuevo usuario así como la cédula del estudiante a quién se asocia ese usuario
         Modifica: Agrega en la base de datos un nuevo usuario
         Retorna: 1 si se pudo guardar el nuevo usuario, un número diferente a cero que corresponde al número de error
         si no se pudo insertar*/
        public int agregarAsistente(string email, string password, string nombre, string apellido1, string apellido2, string carne, string cedula, string carrera, string telefono, int horasAcumuladas)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("AgregarAsistente", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                        cmd.Parameters.Add("@contrasena", SqlDbType.VarChar).Value = password;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@apellido1", SqlDbType.VarChar).Value = apellido1;
                        cmd.Parameters.Add("@apellido2", SqlDbType.VarChar).Value = apellido2;
                        cmd.Parameters.Add("@carne", SqlDbType.VarChar).Value = carne;
                        cmd.Parameters.Add("@cedula", SqlDbType.VarChar).Value = cedula;
                        cmd.Parameters.Add("@carrera", SqlDbType.VarChar).Value = carrera;
                        cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = telefono;
                        cmd.Parameters.Add("@horasAcumuladas", SqlDbType.Int).Value = horasAcumuladas;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@estado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        return Convert.ToInt32(cmd.Parameters["@estado"].Value);

                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }

        }

        /*Método para llamar al procedimiento almacenado que permite agregar un nuevo usuario 
         Recibe: el usuario y la contraseña del nuevo usuario así como la cédula del estudiante a quién se asocia ese usuario
         Modifica: Agrega en la base de datos un nuevo usuario
         Retorna: 1 si se pudo guardar el nuevo usuario, un número diferente a cero que corresponde al número de error
         si no se pudo insertar*/
        public int agregarNombramiento(string email, string idNombramiento, string ciclo, int anno, int horas, string entNombradora, int tipoAsistente)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("AgregarNombramiento", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = idNombramiento;
                        cmd.Parameters.Add("@ciclo", SqlDbType.VarChar).Value = ciclo;
                        cmd.Parameters.Add("@anno", SqlDbType.Int).Value = anno;
                        cmd.Parameters.Add("@cantidadHoras", SqlDbType.Int).Value = horas;
                        cmd.Parameters.Add("@entidadNombradora", SqlDbType.VarChar).Value = entNombradora;
                        cmd.Parameters.Add("@tipoAsistente", SqlDbType.Int).Value = tipoAsistente;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@estado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        return Convert.ToInt32(cmd.Parameters["@estado"].Value);

                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }

        }
        public bool agregarProyecto(string nombre, string estado)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("AgregarProyecto", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@salida", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        int value = Convert.ToInt32(cmd.Parameters["@salida"].Value);
                        if (value == 1)
                        {
                            return true;
                        }

                        /*Si devuelve 0 es que no se encuentra en la BD*/
                        else
                        {
                            return false;
                        }
                    }
                    catch (SqlException ex)
                    {
                        return false;
                    }
                }
            }
        }
        /*Método para llamar al procedimiento almacenado para comprobar que un usuario está en la base de datos
         Recibe: El usuario y contraseña que se desea verificar que está en la base de datos
         Modifica: Busca el usuario con esa contraseña en la base de datos
         Retorna: true si está en la base de datos, false sino*/
        public bool login(string email, string password)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("Login", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@loginEmail", SqlDbType.VarChar).Value = email;
                        cmd.Parameters.Add("@loginPassword", SqlDbType.VarChar).Value = password;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@isInDB", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        int value = Convert.ToInt32(cmd.Parameters["@isInDB"].Value);

                        /*Si el procedimiento devuelve 1 es que si se encuentra en la BD*/
                        if (value == 1)
                        {
                            return true;
                        }

                        /*Si devuelve 0 es que no se encuentra en la BD*/
                        else
                        {
                            return false;
                        }

                    }
                    catch (SqlException ex)
                    {
                        return false;
                    }
                }
            }

        }


    } 
}
