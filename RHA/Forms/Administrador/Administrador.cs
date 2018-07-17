using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHA.Forms.Administrador
{
    public partial class Administrador : Form
    {
        Empleado empleado;
        string usuarioActual;
        public Administrador(string emailUsuarioActual)
        {
         
            empleado = new Empleado();
            usuarioActual = emailUsuarioActual;
            InitializeComponent();

            SqlDataReader sql = empleado.obtenerNombre(usuarioActual);
            string nombreEmpleado = "";
            while (sql.Read())
            {
                nombreEmpleado = sql["NombreEmp"].ToString();

            }
            sql.Close();

            lblNombre.Text = nombreEmpleado;
            btnInicio.BackColor = Color.FromArgb(28, 129, 158);
            inicioAdministrador1.BringToFront();

            inicioAdministrador1.SetAdmin(this);
            listaAsistentes1.SetAdmin(this);
            listaProyectos1.SetAdmin(this);
            listaBalance2.SetAdmin(this);
            agregarAsistente1.SetAdmin(this);
            agregarProyecto1.SetAdmin(this);

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


        private void pintarBotones()
        {
            btnInicio.BackColor = Color.FromArgb(0, 81, 122);
            btnAsistentes.BackColor = Color.FromArgb(0, 81, 122);
            btnProyectos.BackColor = Color.FromArgb(0, 81, 122);
            btnBalance.BackColor = Color.FromArgb(0, 81, 122);
            btnSettings.BackColor = Color.FromArgb(0, 81, 122);



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

                Application.Exit();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnInicio.BackColor = Color.FromArgb(28, 129, 158);
            inicioAdministrador1.BringToFront();
        }

        private void btnAsistentes_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnAsistentes.BackColor = Color.FromArgb(28, 129, 158);
            listaAsistentes1.BringToFront();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnBalance.BackColor = Color.FromArgb(28, 129, 158);
            listaBalance2.BringToFront();
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            pintarBotones();
            btnProyectos.BackColor = Color.FromArgb(28, 129, 158);
            listaProyectos1.BringToFront();
       
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.Login login = new Login.Login();
            login.Show();
            this.Hide();
        }


        public void traerListaProyectos()
        {
            this.listaProyectos1.BringToFront();
        }
        public void traerListaAsistentes()
        {
            this.listaAsistentes1.BringToFront();
        }
        public void traerListaBalance()
        {
            this.listaBalance2.BringToFront();
        }
        public void traerAgregarAsistente()
        {
            this.agregarAsistente1.limpiar();
            this.agregarAsistente1.BringToFront();
            
        }
        public void traerAgregarProyecto()
        {
            this.agregarProyecto1.limpiar();
            this.agregarProyecto1.BringToFront();
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
