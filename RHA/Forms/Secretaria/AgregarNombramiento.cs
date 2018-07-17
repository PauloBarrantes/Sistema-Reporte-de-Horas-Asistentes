using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHA.Forms.Secreataria
{
    public partial class AgregarNombramiento : UserControl
    {
        Empleado empleado;
        Secretaria secretaria;
        public AgregarNombramiento()
        {
            empleado = new Empleado();
            InitializeComponent();
        }
        public void SetSecretaria(Secretaria secretaria)
        {
            this.secretaria = secretaria;
        }

        private void btnNombrar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(cbEntidad.Text);

            if (txtID.Text != "" && cbEntidad.SelectedIndex != -1 && cbAsistentes.SelectedIndex != -1 && cbEntidad.SelectedIndex != -1 && txtCantidadHoras.Text != "" && cbPeriodo.SelectedIndex != -1){
                string[] periodo = cbPeriodo.Text.Split(' ');
                string ciclo = periodo[0];
                int anno = Int32.Parse(periodo[1]);
                empleado.agregarNombramiento(cbAsistentes.Text, txtID.Text, ciclo, anno, Int32.Parse(txtCantidadHoras.Text), cbEntidad.Text, Int32.Parse(cbTipoAsistente.Text));
            }
        }

        private void cbEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
