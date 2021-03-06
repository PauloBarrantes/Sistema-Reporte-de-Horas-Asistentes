﻿using System;
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
    public partial class AgregarProyecto : UserControl
    {
        Administrador admin;
        Class.Proyecto proyecto;
        public void SetAdmin(Administrador admin)
        {
            
            this.admin = admin;

        }
        public AgregarProyecto()
        {
            proyecto = new Class.Proyecto();
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.admin.traerListaProyectos();
        }

        public void limpiar()
        {
            txtNombre.Clear();
            cbCarrera.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && cbCarrera.SelectedIndex != -1)
            {

                string estado = "";
                if (cbCarrera.SelectedIndex == 0)
                {
                    estado = "Activo";
                }
                else
                {
                    if (cbCarrera.SelectedIndex == 1)
                    {
                        estado = "Inactivo";
                    }

                }
                bool success = proyecto.agregarProyecto(txtNombre.Text, estado);
                if (success)
                {
                    VentanasEmergentes.Satisfactorio satisfactorio = new VentanasEmergentes.Satisfactorio("El proyecto ha sido guardado con éxito");
                    satisfactorio.Show();
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
                VentanasEmergentes.VentanaError ventana = new VentanasEmergentes.VentanaError("Tiene que completar todos los espacios para poder agregar el proyecto");
                ventana.Show();
            }
        }
    }
}
