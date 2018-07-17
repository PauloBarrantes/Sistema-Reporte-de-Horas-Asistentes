using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RHA.Forms.Login
{
    public partial class Login : Form
    {
        Empleado empleado;
        public Login()
        {
            InitializeComponent();
            empleado = new Empleado();
            invisiblesLabels();
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
                
                Application.Exit();
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
            invisiblesLabels();
            if (txtEmail.Text != "" && txtPassword.Text != "")

            {
                string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase );

                if (regex.IsMatch(txtEmail.Text)) { 
                    if (empleado.login(txtEmail.Text, txtPassword.Text) == true)
                    
                    {
                        int tipo = empleado.rol(txtEmail.Text);
                        if (tipo == 0)
                        {
                            Asistentes.Asistente asistente = new Asistentes.Asistente(txtEmail.Text);
                            asistente.Show();
                            this.Hide();
                        }

                        else if (tipo == 1)
                        {
                            Administrador.Administrador admin = new Administrador.Administrador(txtEmail.Text);
                            admin.Show();
                            this.Hide();
                        }
                        else if (tipo == 2)
                        {
                            Secreataria.Secretaria secretaria = new Secreataria.Secretaria(txtEmail.Text);
                            secretaria.Show();
                            this.Hide();
                        }
                        
                    
                        
                    }
                    else
                    {
                        lblCorreoInválido.Visible = true;
                    }
                }
                else
                {
                    lblNoCorreo.Visible = true;
                }
            }
            else
            {
                lblFaltaCorreo.Visible = true;
                lblFaltanCampos.Visible = true;
            }

        }

        private void invisiblesLabels()
        {
            lblCorreoInválido.Visible = false;
            lblFaltaCorreo.Visible = false;
            lblFaltanCampos.Visible = false;
            lblNoCorreo.Visible = false;

        }

        private void linkOlvide_Click(object sender, EventArgs e)
        {
            OlvideContrasena olvideContrasena = new OlvideContrasena();
            olvideContrasena.Show();
            this.Hide();
        }
    }
}
