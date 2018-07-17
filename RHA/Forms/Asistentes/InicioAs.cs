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
        DateTime Lunes;
        DateTime Domingo;
        DateTime[] Semana = new DateTime[7];
        public InicioAs()
        {
            empleado = new Empleado();
            InitializeComponent();
            sgProgreso.Uses360Mode = true;
            DateTime hoy = DateTime.Now;

            if (hoy.DayOfWeek == DayOfWeek.Monday)
            {

                Lunes = hoy;
                Domingo = hoy.AddDays(6);
                Console.WriteLine(Lunes + "" + Domingo);

            }
            else if (hoy.DayOfWeek == DayOfWeek.Tuesday)
            {
                Lunes = hoy.AddDays(-1);
                Domingo = hoy.AddDays(5);
                Console.WriteLine(Lunes + "" + Domingo);
            }
            else if (hoy.DayOfWeek == DayOfWeek.Wednesday)
            {
                Lunes = hoy.AddDays(-2);
                Domingo = hoy.AddDays(4);
                Console.WriteLine(Lunes + "" + Domingo);
            }
            else if (hoy.DayOfWeek == DayOfWeek.Thursday)
            {
                Lunes = hoy.AddDays(-3);
                Domingo = hoy.AddDays(3);
                Console.WriteLine(Lunes + "" + Domingo);
            }
            else if (hoy.DayOfWeek == DayOfWeek.Friday)
            {
                Lunes = hoy.AddDays(-4);
                Domingo = hoy.AddDays(2);
                Console.WriteLine(Lunes + "" + Domingo);
            }
            else if (hoy.DayOfWeek == DayOfWeek.Saturday)
            {
                Lunes = hoy.AddDays(-5);
                Domingo = hoy.AddDays(1);
                Console.WriteLine(Lunes + "" + Domingo);
            }
            else if (hoy.DayOfWeek == DayOfWeek.Sunday)
            {
                Lunes = hoy.AddDays(-6);
                Domingo = hoy.AddDays(0);
                Console.WriteLine(Lunes + "" + Domingo);
            }
            for (int i = 0; i < 7; ++i)
            {
                Semana[i] = Lunes.AddDays(i);
            }
            Console.WriteLine(hoy.DayOfWeek);

            lblSemanaActual.Text = lblSemanaActual.Text +" " +String.Format("{0:dd/MM/yy}", Lunes) + " - " + String.Format("{0:dd/MM/yy}", Domingo);
         }

        
        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;

        }

        public void llenarDatos()
        {

            SqlDataReader periodo = empleado.obtenerPeriodo();
            while (periodo.Read()) {
                lblperiodo.Text = lblperiodo.Text + " " + periodo["Ciclo"] + " - " + periodo["Anno"];
            }   
            sgProgreso.To = 100;
            sgProgreso.Value = 60;
            Console.WriteLine(this.asistente.usuarioActual);
            SqlDataReader datosAsistente = empleado.obtenerInfoAsistente(this.asistente.usuarioActual);
            
            while (datosAsistente.Read())
            {
                lblNombre.Text = datosAsistente["NombreEmp"].ToString() + " "+ datosAsistente["Apellido1"].ToString()+" "+ datosAsistente["Apellido2"].ToString(); 
                lblCarrera.Text = lblCarrera.Text + " "+datosAsistente["Carrera"].ToString();
                lblHorasAcumuladas.Text = lblHorasAcumuladas.Text + " " + datosAsistente["HorasAcumuladas"].ToString();
                string sexo = datosAsistente["Sexo"].ToString();
                if (sexo == "M")
                {
                    lblMen.BringToFront();
                }
                else {
                    lblGirl.BringToFront();
                }
            }
            datosAsistente.Close();

        }


    }
}
