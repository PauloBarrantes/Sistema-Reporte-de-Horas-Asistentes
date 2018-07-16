using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RHA.Forms.Asistentes
{
    public partial class InicioAs : UserControl
    {
        Asistente asistente;
        Empleado empleado;
        public InicioAs()
        {
            empleado = new Empleado();
            InitializeComponent();
        }
        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;

        }

        public void llenarDatos()
        {
            Console.WriteLine(this.asistente.usuarioActual);
            SqlDataReader datosAsistente = empleado.obtenerInfoAsistente(this.asistente.usuarioActual);
            while (datosAsistente.Read())
            {
                lblNombre.Text = datosAsistente["NombreEmp"].ToString() + " "+ datosAsistente["Apellido1"].ToString()+" "+ datosAsistente["Apellido2"].ToString(); 
                lblCarrera.Text = lblCarrera.Text + " "+datosAsistente["Carrera"].ToString();
                lblHorasAcumuladas.Text = lblHorasAcumuladas.Text + " " + datosAsistente["HorasAcumuladas"].ToString();
            }
            datosAsistente.Close();

        }


    }
}
