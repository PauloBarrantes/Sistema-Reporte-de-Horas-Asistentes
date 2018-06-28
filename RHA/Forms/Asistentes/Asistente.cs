using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHA.Forms.Asistentes
{
    public partial class Asistente : Form
    {
        public Asistente()
        {
            InitializeComponent();
        }

        private void Asistente_Load(object sender, EventArgs e)
        {
            btnInicioAs.BackColor = Color.FromArgb(12, 87, 153);
            inicioAs1.BringToFront();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            string message = "¿Está seguro que desea salir?";
            string caption = "Salir";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();

            }
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        Point lastLocation;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                 (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnInicioAs_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnInicioAs.BackColor = Color.FromArgb(12, 87, 153);
            inicioAs1.BringToFront();
        }

        private void btnReporteAs_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnReporteAs.BackColor = Color.FromArgb(12, 87, 153);
            reporteHorasAs1.BringToFront();
        }

        private void btnPerfilAs_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnPerfilAs.BackColor = Color.FromArgb(12, 87, 153);
            perfilAs1.BringToFront();
        }

        private void btnBalanceAs_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnBalanceAs.BackColor = Color.FromArgb(12, 87, 153);
            balanceHorasAs1.BringToFront();
        }

        private void btnHorarioAs_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnHorarioAs.BackColor = Color.FromArgb(12, 87, 153);
            horario2.BringToFront();
        }
        private void pintarBotones()
        {
            btnInicioAs.BackColor = Color.FromArgb(8, 51, 88);
            btnReporteAs.BackColor = Color.FromArgb(8, 51, 88);
            btnPerfilAs.BackColor = Color.FromArgb(8, 51, 88);

            btnBalanceAs.BackColor = Color.FromArgb(8, 51, 88);
            btnHorarioAs.BackColor = Color.FromArgb(8, 51, 88);


        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }


       

    }
}
