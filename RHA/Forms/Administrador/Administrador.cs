using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace RHA
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            btnInicio.BackColor = Color.FromArgb(12, 87, 153);

        }

        private void button6_Click(object sender, EventArgs e)
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
        /// Inician los eventos de los botones del SideBar
        private void btnInicio_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnInicio.BackColor = Color.FromArgb(12, 87, 153);
            inicioAdministrador1.BringToFront();
        }

        private void btnAsistentes_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnAsistentes.BackColor = Color.FromArgb(12, 87, 153);
            listaAsistentes1.BringToFront();
        }
        private void btnBalance_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnBalance.BackColor = Color.FromArgb(12, 87, 153);
            listaBalance1.BringToFront();

        }
        private void btnProyectos_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnProyectos.BackColor = Color.FromArgb(12, 87, 153);
            listaProyectos1.BringToFront();
        }
        private void pintarBotones() {
            btnInicio.BackColor = Color.FromArgb(8, 51, 88);
            btnAsistentes.BackColor = Color.FromArgb(8, 51, 88);
            btnBalance.BackColor = Color.FromArgb(8, 51, 88);
            btnProyectos.BackColor = Color.FromArgb(8, 51, 88);
           

        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        Point lastLocation;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) {
                this.Location = new Point(
                 (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

      

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
    }
}
