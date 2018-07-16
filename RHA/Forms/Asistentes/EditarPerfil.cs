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

        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido1.Text != "" && txtApellido2.Text != "" && txtEmail.Text != "" && txtTelefono.Text != "" && txtCarne.Text != ""&& txtCedula.Text != "")
            {

            }
            else
            {
                VentanasEmergentes.VentanaError ventanaError = new VentanasEmergentes.VentanaError("Hay espacios vacíos, por favor complételos");
                ventanaError.StartPosition = FormStartPosition.Manual;
                ventanaError.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
                ventanaError.Show();
               
            }
        }
    }
}
