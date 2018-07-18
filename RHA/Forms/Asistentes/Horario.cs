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
        Panel[,] panels = new Panel[5, 10];
        public Horario()
        {
            empleado = new Empleado();
            asistenteDB = new Class.AsistenteDB();
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    panels[i, j] = new Panel();
                    panels[i, j].Width = 62;
                    panels[i, j].Height = 47;
                    panels[i, j].Text = "-";
                    panels[i, j].Top = i * 50;
                    panels[i, j].Left = j * 65;
                  

                    panels[i, j].BackColor = Color.FromArgb(255, 255, 255);
                    panelButton.Controls.Add(panels[i, j]);

                    if (j>=2 && j<8 && i >=1 && i <3) {
                        panels[i, j].BackColor = Color.FromArgb(255, 194, 23);

                    }
                }
            }
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
