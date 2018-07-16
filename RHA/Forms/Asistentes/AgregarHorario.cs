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
            if(clickedButton.BackColor == Color.FromArgb(255, 194, 23))
            {
                clickedButton.BackColor = Color.FromKnownColor(KnownColor.Control);
                
            }
            else
            {
                clickedButton.BackColor = Color.FromArgb(255, 194, 23);

            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            asistente.TraerHorario();
        }
    }
}
