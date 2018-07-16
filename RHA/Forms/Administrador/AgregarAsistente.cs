using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHA.Forms.Administrador
{
    public partial class AgregarAsistente : UserControl
    {
        Empleado empleado;
        public AgregarAsistente()
        {
            empleado = new Empleado();
            InitializeComponent();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido1 = txtApellido1.Text;
            string apellido2 = txtApellido2.Text;
            string cedula = txtCedula.Text;
            string carne = txtCarne.Text;
            string email = txtEmail.Text;
            string horasAcumuladas = txtHorasAcumuladas.Text;
            int horasAcumuladas1 = Int32.Parse(horasAcumuladas);
            string carrera = cbCarrera.Text;
            string password1 = txtPassword1.Text;
            string password2 = txtPassword2.Text;
            bool agregado;
            if(password1 == password2)
            {
                agregado =   empleado.agregarAsistentes(email,password1,nombre,apellido1, apellido2, carne,cedula,carrera,"83096579", horasAcumuladas1);
                Console.WriteLine("GG");
                Console.WriteLine(agregado);
                VentanasEmergentes.Satisfactorio mensaje = new VentanasEmergentes.Satisfactorio("El asistente fue agregado satisfactoriamente");
                
                mensaje.Show();
            }


            cleanTextFields();
        }

        private void validateTextFields()
        {

        }
        Administrador admin;
        public void SetAdmin(Administrador admin)
        {
            this.admin = admin;

        }

        private void cleanTextFields()
        {
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtCedula.Clear();
            txtCarne.Clear();
            txtEmail.Clear();
            txtHorasAcumuladas.Clear();
            cbCarrera.ResetText();
            txtPassword1.Clear();
            txtPassword2.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.admin.traerListaAsistentes();
        }
        public void limpiar()
        {
            txtEmail.Clear();
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtCarne.Clear();
            txtCedula.Clear();
            txtPassword1.Clear();
            txtPassword2.Clear();
            txtHorasAcumuladas.Clear();
            cbCarrera.SelectedIndex = -1;

            rbEstudiante.Select();
        }
    }
}
