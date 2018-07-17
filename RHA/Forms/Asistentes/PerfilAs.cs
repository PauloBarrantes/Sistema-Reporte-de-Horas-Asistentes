using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RHA.Forms.Asistentes
{
    public partial class PerfilAs : UserControl
    {
        Asistente asistente;
        Administrador.Administrador admin;
        Empleado empleado;
        public PerfilAs()
        {
            empleado = new Empleado();
            InitializeComponent();
            
        }
        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;
        }
        public void llenarPerfil(string usuario)
        {
              string ciclo ="";
            string anno = "";
            SqlDataReader periodo = empleado.obtenerPeriodo();
            while (periodo.Read()) {
                ciclo = periodo["Ciclo"].ToString();
                anno = periodo["Anno"].ToString();
                lblPeriodo.Text = lblPeriodo.Text + " " + periodo["Ciclo"] + " - " + periodo["Anno"];

            }
            SqlDataReader nombramiento = empleado.obtenerNombramiento(this.asistente.usuarioActual, ciclo, anno);
            int cantidadHorasNombradas = 0;
            while (nombramiento.Read()) {
                if (Int32.Parse(nombramiento["TipoAsistente"].ToString()) == 0)
                {
                    lblTipoAsistente.Text = lblTipoAsistente.Text + "Estudiante";
                }
                else if (Int32.Parse(nombramiento["TipoAsistente"].ToString()) == 1)
                {

                    lblTipoAsistente.Text = lblTipoAsistente.Text + "Asistente";
                }
                else if (Int32.Parse(nombramiento["TipoAsistente"].ToString()) == 2)
                {

                    lblTipoAsistente.Text = lblTipoAsistente.Text + "Asistente Graduado";
                }
                else {
                    lblTipoAsistente.Text = lblTipoAsistente.Text + "Por Definir";

                }
                cantidadHorasNombradas = cantidadHorasNombradas + Int32.Parse(nombramiento["CantidadHoras"].ToString()); 
            }

            lblHorasAsignadas.Text = lblHorasAsignadas.Text+cantidadHorasNombradas;
            
            Console.WriteLine(usuario);
            SqlDataReader datosAsistente = empleado.obtenerInfoAsistente(usuario);
            while (datosAsistente.Read())
            {
                lblNombre.Text = datosAsistente["NombreEmp"].ToString() + " " + datosAsistente["Apellido1"].ToString() + " " + datosAsistente["Apellido2"].ToString();
                lblCarrera.Text = lblCarrera.Text + " " + datosAsistente["Carrera"].ToString();
                lblHorasAcumuladas.Text = lblHorasAcumuladas.Text + " " + datosAsistente["HorasAcumuladas"].ToString();
                lblEmail.Text = lblEmail.Text + " " + datosAsistente["Email"].ToString();
                lblCedula.Text = lblCedula.Text + " " + datosAsistente["Cedula"].ToString();
                lblCarne.Text = lblCarne.Text + " " + datosAsistente["Carne"].ToString();
                lblSexo.Text = lblSexo.Text + " " + datosAsistente["Sexo"].ToString();
                if (datosAsistente["Telefono"].ToString() != "00000000")
                {
                    lblTel.Text = lblTel.Text + datosAsistente["Telefono"].ToString();
                }
                else {
                    lblTel.Text = lblTel.Text + " Por definir";

                }
                string sexo = datosAsistente["Sexo"].ToString();
                if (sexo == "M")
                {
                    lblMen.BringToFront();
                }
                else
                {
                    lblGirl.BringToFront();
                }

            }
            datosAsistente.Close();


        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            this.asistente.traerEditarPerfil();
        }
       
        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            
            this.asistente.traerCambiarContraseña();
        }
    }
}
