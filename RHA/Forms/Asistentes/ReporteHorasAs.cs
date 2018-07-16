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
    public partial class ReporteHorasAs : UserControl
    {
        Asistente asistente;
        public ReporteHorasAs()
        {
            InitializeComponent();
        }
        public void SetAsistente(Asistente asistente)
        {
            this.asistente = asistente;

        }
    }
}
