﻿using System;
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

            string password1 = txtPassword.Text;
            string passwordConfi = txtPasswordConfirmarcion.Text;

            if (password1 == passwordConfi)
            {

            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Las contraseñas ingresadas no coinciden";
            }
        }

        
    }
}
