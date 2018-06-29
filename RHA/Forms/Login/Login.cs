using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHA.Forms.Login
{
    public partial class Login : Form
    {
        Empleado empleado;
        public Login()
        {
            InitializeComponent();
            empleado = new Empleado();
        }

        private void button1_Click(object sender, EventArgs e)
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
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtEmail.Text != "" && txtPassword.Text != "") {
            if (true)
            {
                //if (empleado.login(txtEmail.Text, txtPassword.Text) == true) {
                if (true)
                {
                    Asistentes.Asistente asistente = new Asistentes.Asistente();
                    asistente.Show();
                    this.Hide();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
