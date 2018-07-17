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
    public partial class CambiarContraseña : UserControl
    {
        Asistente asistente;
        Empleado empleado;
        public CambiarContraseña()
        {
            empleado = new Empleado();
            InitializeComponent();
            lblError.Visible = false;
        }
        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;

        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            if (txtPassword.Text != "" && txtPasswordConfirmarcion.Text != "") {
                string password1 = txtPassword.Text;
                string passwordConfi = txtPasswordConfirmarcion.Text;

                if (password1 == passwordConfi)
                {
                   bool retorno =  empleado.cambiarPassword(this.asistente.usuarioActual, password1);
                    if (retorno == true) {
                        VentanasEmergentes.Satisfactorio mensaje = new VentanasEmergentes.Satisfactorio("La contraseña ha sido cambiada con éxito");
                        mensaje.Show();
                        txtPassword.Clear();
                        txtPasswordConfirmarcion.Clear();
                    }
                    else
                    {
                        VentanasEmergentes.VentanaError mensaje = new VentanasEmergentes.VentanaError("La contraseña no ha sido cambiada");
                        mensaje.Show();
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Las contraseñas ingresadas no coinciden";
                }
            }
            else
            {
                VentanasEmergentes.VentanaError ventanaError = new VentanasEmergentes.VentanaError("Hay espacios vacíos, por favor complételos");
                ventanaError.StartPosition = FormStartPosition.Manual;
                ventanaError.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
                ventanaError.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.asistente.traerPerfil();
        }

        public void limpiar()
        {

        }
    }
}
