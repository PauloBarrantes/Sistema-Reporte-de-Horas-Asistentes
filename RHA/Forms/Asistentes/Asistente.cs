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

namespace RHA.Forms.Asistentes
{
    public partial class Asistente : Form
    {
        public string usuarioActual;
        Empleado empleado;
        Class.AsistenteDB asistenteDB;
        public Asistente(string emailUsuario)
        {
            usuarioActual = emailUsuario;
            empleado = new Empleado();
            asistenteDB = new Class.AsistenteDB();
            InitializeComponent();
            inicioAs1.BringToFront();


            // Hay que pasar un controlador de la ventana del Asistente a cada Control de Usuario

            horario2.SetAsistente(this);
            balanceHorasAs1.SetAsistente(this);
            agregarHorario1.SetAsistente(this);
            perfilAs1.SetAsistente(this);
            inicioAs1.SetAsistente(this);
            reporteHorasAs1.SetAsistente(this);
            editarPerfil1.SetAsistente(this);
            cambiarContraseña1.SetAsistente(this);

            SqlDataReader sql = empleado.obtenerNombre(usuarioActual);
            
            while (sql.Read())
            {
                lblNombreAsistente.Text = sql["NombreEmp"].ToString();

            }

            sql.Close();

            inicioAs1.llenarDatos();
            perfilAs1.llenarPerfil(usuarioActual);
            

        }

        private void Asistente_Load(object sender, EventArgs e)
        {
            btnInicioAs.BackColor = Color.FromArgb(12, 87, 153);
            //inicioAs1.BringToFront();

        }
        public void TraeragregarHorario() {
            agregarHorario1.BringToFront();

        }
        public void TraerHorario()
        {
            horario2.BringToFront();
        }
        public void traerPerfil()
        {
            this.perfilAs1.BringToFront();
        }
        public void traerCambiarContraseña()
        {
            this.cambiarContraseña1.limpiar();
            this.cambiarContraseña1.BringToFront();

        }
        public void traerEditarPerfil()
        {
            this.editarPerfil1.llenar();
            this.editarPerfil1.BringToFront();
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
            btnInicioAs.BackColor = Color.FromArgb(0, 81, 122);
            btnReporteAs.BackColor = Color.FromArgb(0, 81, 122);
            btnPerfilAs.BackColor = Color.FromArgb(0, 81, 122);

            btnBalanceAs.BackColor = Color.FromArgb(0, 81, 122);
            btnHorarioAs.BackColor = Color.FromArgb(0, 81, 122);


        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
