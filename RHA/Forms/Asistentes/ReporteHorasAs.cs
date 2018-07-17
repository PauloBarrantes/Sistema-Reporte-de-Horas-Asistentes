using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHA.Forms.Asistentes
{
    public partial class ReporteHorasAs : UserControl
    {
        Asistente asistente;
        DateTime Lunes;
        DateTime Domingo;
        DateTime[] Semana = new DateTime[7];
        public ReporteHorasAs()
        {
            InitializeComponent();

            DateTime hoy = DateTime.Now;

            if (hoy.DayOfWeek == DayOfWeek.Monday)
            {

                Lunes = hoy ;
                Domingo = hoy.AddDays(6) ;
                Console.WriteLine(Lunes + "" + Domingo);

            }
            else if (hoy.DayOfWeek == DayOfWeek.Tuesday) {
                Lunes = hoy.AddDays(-1) ;
                Domingo = hoy.AddDays(5) ;
                Console.WriteLine(Lunes + "" + Domingo);
            }
            else if (hoy.DayOfWeek == DayOfWeek.Wednesday) {
                Lunes = hoy.AddDays(-2) ;
                Domingo = hoy.AddDays(4) ;
                Console.WriteLine(Lunes + "" + Domingo);
            }
            else if (hoy.DayOfWeek == DayOfWeek.Thursday) {
                Lunes = hoy.AddDays(-3) ;
                Domingo = hoy.AddDays(3) ;
                Console.WriteLine(Lunes + "" + Domingo);
            }
            else if (hoy.DayOfWeek == DayOfWeek.Friday)
            {
                Lunes = hoy.AddDays(-4) ;
                Domingo = hoy.AddDays(2) ;
                Console.WriteLine(Lunes + "" + Domingo);
            }
            else if (hoy.DayOfWeek == DayOfWeek.Saturday)
            {
                Lunes = hoy.AddDays(-5) ;
                Domingo = hoy.AddDays(1) ;
                Console.WriteLine(Lunes + "" + Domingo);
            }
            else if (hoy.DayOfWeek == DayOfWeek.Sunday)
            {
                Lunes = hoy.AddDays(-6) ;
                Domingo = hoy.AddDays(0) ;
                Console.WriteLine(Lunes + "" + Domingo);
            }
            for (int i =0; i<7;++i)
            {
                Semana[i] = Lunes.AddDays(i);
            }
            Console.WriteLine(hoy.DayOfWeek);

            lblSemana.Text = String.Format("{0:dd/MM/yy}", Lunes) +" - " +String.Format("{0:dd/MM/yy}", Domingo);  
        }
        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;

        }
    }
}
