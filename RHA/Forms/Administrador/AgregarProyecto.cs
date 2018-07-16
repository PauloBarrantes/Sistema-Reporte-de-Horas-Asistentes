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
    public partial class AgregarProyecto : UserControl
    {
        Administrador admin;
        public void SetAdmin(Administrador admin)
        {
            this.admin = admin;

        }
        public AgregarProyecto()
        {
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
    }
}
