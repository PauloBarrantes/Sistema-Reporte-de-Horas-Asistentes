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
    public partial class ReporteHorasAs : UserControl
    {
        Asistente asistente;
        DateTime Lunes;
        DateTime Domingo;
        DateTime[] Semana = new DateTime[7];
        Class.Proyecto proyecto;
        Empleado empleado;
        public ReporteHorasAs()
        {
            proyecto = new Class.Proyecto();
            empleado = new Empleado();
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
            llenarProyectos();
        }

        public void  llenarProyectos() {
            cbProyectoLunes.DisplayMember = "Text";
            cbProyectoLunes.ValueMember = "Value";
            cbProyectoMartes.DisplayMember = "Text";
            cbProyectoMartes.ValueMember = "Value";
            cbProyectoMierco.DisplayMember = "Text";
            cbProyectoMierco.ValueMember = "Value";
            cbProyectoJueves.DisplayMember = "Text";
            cbProyectoJueves.ValueMember = "Value";

            cbProyectoVier.DisplayMember = "Text";
            cbProyectoVier.ValueMember = "Value";
            cbProyectoSab.DisplayMember = "Text";
            cbProyectoSab.ValueMember = "Value";
            cbProyectoDomingo.DisplayMember = "Text";
            cbProyectoDomingo.ValueMember = "Value";
            SqlDataReader proyectos = proyecto.obtenerProyectos();
            while (proyectos.Read()) {
                cbProyectoLunes.Items.Add(new { Text = proyectos["Nombre"].ToString(), Value = proyectos["Nombre"].ToString() });
                cbProyectoMartes.Items.Add(new { Text = proyectos["Nombre"].ToString(), Value = proyectos["Nombre"].ToString() });
                cbProyectoMierco.Items.Add(new { Text = proyectos["Nombre"].ToString(), Value = proyectos["Nombre"].ToString() });
                cbProyectoJueves.Items.Add(new { Text = proyectos["Nombre"].ToString(), Value = proyectos["Nombre"].ToString() });
                cbProyectoVier.Items.Add(new { Text = proyectos["Nombre"].ToString(), Value = proyectos["Nombre"].ToString() });
                cbProyectoSab.Items.Add(new { Text = proyectos["Nombre"].ToString(), Value = proyectos["Nombre"].ToString() });
                cbProyectoDomingo.Items.Add(new { Text = proyectos["Nombre"].ToString(), Value = proyectos["Nombre"].ToString() });

            }

        }
        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;

        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            if (cbProyectoLunes.SelectedIndex != -1 && cbHoraILunes.SelectedIndex != -1 && cbHoraFLunes.SelectedIndex != -1) {

            }
            else if (cbProyectoMartes.SelectedIndex != -1 && cbHoraIMartes.SelectedIndex != -1 && cbHoraFMartes.SelectedIndex != -1)
            {

            }
            else if (cbProyectoMierco.SelectedIndex != -1 && cbHoraIMiercoles.SelectedIndex != -1 && cbHoraFMiercoles.SelectedIndex != -1)
            {

            }
            else if (cbProyectoJueves.SelectedIndex != -1 && cbHoraIJueves.SelectedIndex != -1 && cbHoraFJueves.SelectedIndex != -1)
            {

            }
            else if (cbProyectoVier.SelectedIndex != -1 && cbHoraIViernes.SelectedIndex != -1 && cbHoraFViernes.SelectedIndex != -1)
            {

            }
            else if (cbProyectoSab.SelectedIndex != -1 && cbHoraISabado.SelectedIndex != -1 && cbHoraFSabado.SelectedIndex != -1)
            {

            }
            else if (cbProyectoDomingo.SelectedIndex != -1 && cbHoraIDom.SelectedIndex != -1 && cbHoraFDomingo.SelectedIndex != -1)
            {

            }
        }
    }
}
