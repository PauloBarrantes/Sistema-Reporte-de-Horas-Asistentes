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
    public partial class Horario : UserControl
    {
        Empleado empleado;
        Class.AsistenteDB asistenteDB;
        Asistente asistente;

        public Horario()
        {
            empleado = new Empleado();
            asistenteDB = new Class.AsistenteDB();
            InitializeComponent();
        }

        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;
        }
        public void llenarHorario(string usuario)
        {
            SqlDataReader nombre = empleado.obtenerNombre(usuario);
            while (nombre.Read()) {
                lblName.Text = nombre["NombreEmp"].ToString();
            }
            SqlDataReader periodo = empleado.obtenerPeriodo();
            while (periodo.Read()) {
                SqlDataReader horario = asistenteDB.obtenerHorario(usuario, periodo["Ciclo"].ToString(), periodo["Anno"].ToString());

                while (horario.Read()) {


                }
            }
                                   
        }
        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            this.asistente.TraeragregarHorario();
        }
    }
}
