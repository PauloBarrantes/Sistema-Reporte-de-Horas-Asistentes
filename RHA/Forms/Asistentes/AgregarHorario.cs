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
    public partial class AgregarHorario : UserControl
    {
        Asistente asistente;
        Button[,] boton = new Button[5, 10];
        bool [,] horario = new bool[5, 10];

        public AgregarHorario()
        {
            InitializeComponent();
            int z = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    boton[i, j] = new Button();
                    boton[i, j].Width = 62;
                    boton[i, j].Height = 47;
                    boton[i, j].Text ="-"; 
                    boton[i, j].Top = i * 50;
                    boton[i, j].Left = j * 65;
                    boton[i, j].Click += new EventHandler(this.btnMatrix);
                    boton[i, j].FlatStyle = 0;
                    boton[i, j].FlatAppearance.BorderSize = 0;
                   
                //    boton[i, j].BackColor = Color.FromArgb(255, 242, 214);
                    panelButton.Controls.Add(boton[i, j]);

                    horario[i, j] = false;



                }
            }
        }
        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;

        }

        private void btnMatrix(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int iFila = 0;
            int jColumna = 0;
            for (int i = 0; i < 5; ++i)
            {
                for(int j = 0; j < 10; ++j){
                    if (boton[i, j] == clickedButton) {
                        iFila = i;
                        jColumna = j;
                    }
                }
            }
            if(clickedButton.BackColor == Color.FromArgb(255, 194, 23))
            {
                clickedButton.BackColor = Color.FromKnownColor(KnownColor.Control);
                horario[iFila, jColumna] = false;
            }
            else
            {
                clickedButton.BackColor = Color.FromArgb(255, 194, 23);
                horario[iFila, jColumna] = true;
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            asistente.TraerHorario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] dias = new string[5];
            dias[0] = "Lunes";
            dias[1] = "Martes";
            dias[2] = "Miércoles";
            dias[3] = "Jueves";
            dias[4] = "Viernes";

            TimeSpan[] times = new TimeSpan[10];
            times[0] = new TimeSpan(08, 0, 0);
            times[1] = new TimeSpan(09, 0, 0);
            times[2] = new TimeSpan(10, 0, 0);
            times[3] = new TimeSpan(11, 0, 0);
            times[4] = new TimeSpan(12, 0, 0);
            times[5] = new TimeSpan(13, 0, 0);
            times[6] = new TimeSpan(14, 0, 0);
            times[7] = new TimeSpan(15, 0, 0);
            times[8] = new TimeSpan(16, 0, 0);
            times[9] = new TimeSpan(17, 0, 0);
            Console.WriteLine(times[0].ToString());     // Displays "02:14:18".
            Console.WriteLine(times[1].ToString());     // Displays "02:14:18".

            bool bloque = false;
            string diaActual = "";
            TimeSpan horaInicio = times[0];
            TimeSpan horaFin = times[0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (horario[i, j] == true && bloque == false)
                    {
                        bloque = true;
                        horaInicio = times[j];

                    }
                    else if (horario[i, j] == true && bloque == true)
                    {
                        if (j == 9)
                        {
                            diaActual = dias[i];
                            horaFin = times[j];
                            //asistente.guardarBloqueHorario(this.asistente.usuarioActual,"I Semestre",2018,diaActual, horaInicio, horaFin);
                            Console.WriteLine("Hora Inicio" + horaInicio + "Hora Fin: " + horaFin + "Dia" + diaActual);

                            bloque = false;
                        }
                        // Se acabo
                    }
                    else if (horario[i, j] == false && bloque == true)
                    {

                        // Se acabo el bloque en el pasado
                        diaActual = dias[i];
                        horaFin = times[j-1];
                        Console.WriteLine("Hora Inicio"+horaInicio + "Hora Fin: " + horaFin + "Dia" + diaActual);
                        //asistente.guardarBloqueHorario(this.asistente.usuarioActual, "I Semestre", 2018, diaActual, horaInicio, horaFin);
                        bloque = false;
                        


                    } 
                }
            }

        }
    }
}
