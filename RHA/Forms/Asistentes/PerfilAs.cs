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
    public partial class PerfilAs : UserControl
    {
        Asistente asistente;
        Administrador.Administrador admin;
        Empleado empleado;
        public PerfilAs()
        {
            empleado = new Empleado();
            InitializeComponent();
            
        }
        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;
        }
        public void llenarPerfil(string usuario)
        {
            Console.WriteLine(usuario);
            SqlDataReader datosAsistente = empleado.obtenerInfoAsistente(usuario);
            while (datosAsistente.Read())
            {
                lblNombre.Text = datosAsistente["NombreEmp"].ToString() + " " + datosAsistente["Apellido1"].ToString() + " " + datosAsistente["Apellido2"].ToString();
                lblCarrera.Text = lblCarrera.Text + " " + datosAsistente["Carrera"].ToString();
                lblHorasAcumuladas.Text = lblHorasAcumuladas.Text + " " + datosAsistente["HorasAcumuladas"].ToString();
                lblEmail.Text = lblEmail.Text + " " + datosAsistente["Email"].ToString();
                lblCedula.Text = lblCedula.Text + " " + datosAsistente["Cedula"].ToString();
                lblCarne.Text = lblCarne.Text + " " + datosAsistente["Carne"].ToString();
            }
            datosAsistente.Close();


        }

       
    }
}
