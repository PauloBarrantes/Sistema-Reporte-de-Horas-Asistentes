﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHA.Forms.Secreataria
{
    public partial class Secretaria : Form
    {

        string usuarioActual;
        public Secretaria(string email)
        {
            this.usuarioActual = email;
            InitializeComponent();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login.Login login = new Login.Login();
            login.Show();
            this.Hide();
        }
    }
}
