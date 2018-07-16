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
    public partial class Horario : UserControl
    {
        Empleado empleado;
        
        Asistente asistente;

        public Horario()
        {
            empleado = new Empleado();
            InitializeComponent();
        }

        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;
        }

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            this.asistente.TraeragregarHorario();
        }
    }
}
