using System;
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
    public partial class ListaAsistentes : UserControl
    {
        public ListaAsistentes()
        {
            InitializeComponent();
            agregarAsistente1.Visible = false;
        }

        private void btnAgregarAsistentes_Click(object sender, EventArgs e)
        {
            agregarAsistente1.Visible = true;
            agregarAsistente1.BringToFront();
        }

        public void reiniciar()
        {
            agregarAsistente1.Visible = false;
            this.BringToFront();
        }
    }
}
