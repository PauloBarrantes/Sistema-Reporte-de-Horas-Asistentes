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
    public partial class EditarPerfil : UserControl
    {
        Asistente asistente;
        Administrador.Administrador admin;
        Empleado empleado;
        public EditarPerfil()
        {
            empleado = new Empleado();
            InitializeComponent();
        }
        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.asistente.traerPerfil();
        }


        public void llenar()
        {

        }


        public void limpiar()
        {
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtCarne.Clear();
            txtCedula.Clear();
            cbCarrera.SelectedIndex = -1;
          }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido1.Text != "" && txtApellido2.Text != "" && txtEmail.Text != "" && txtTelefono.Text != "" && txtCarne.Text != "" && txtCedula.Text != "" && cbCarrera.SelectedIndex != -1)
            {
                bool success = empleado.editarPerfil(txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtEmail.Text, this.asistente.usuarioActual, cbCarrera.Text, txtCarne.Text, txtCedula.Text, txtTelefono.Text);
                if (success)
                {
                    VentanasEmergentes.Satisfactorio satisfactorio = new VentanasEmergentes.Satisfactorio("El perfil se ha editado con éxito");
                    satisfactorio.Show();
                    this.asistente.usuarioActual = txtEmail.Text;
                    this.asistente.cargarInicio();
                    this.asistente.cargarPerfil();
                }
                else
                {
                    VentanasEmergentes.VentanaError error = new VentanasEmergentes.VentanaError("Ha ocurrido un problema");
                    error.Show();
                }
                limpiar();
            }
            else
            {
                VentanasEmergentes.VentanaError ventana = new VentanasEmergentes.VentanaError("Tiene que completar todos los espacios para poder editar el perfil.");
                ventana.Show();
            }
        }
    }
}
