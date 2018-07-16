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
    public partial class AgregarHorario : UserControl
    {
        Asistente asistente;
        public AgregarHorario()
        {
            InitializeComponent();
        }
        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            asistente.TraerHorario();
        }
    }
}
