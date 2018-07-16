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
    public partial class ListaProyectos : UserControl
    {
        Administrador admin;
        Class.Proyecto proyecto;
        public ListaProyectos()
        {
            proyecto = new Class.Proyecto();
            InitializeComponent();
        }


        public void SetAdmin(Administrador admin)
        {
            this.admin = admin;
        }
        private void btnAgregarAsistentes_Click(object sender, EventArgs e)
        {
            this.admin.traerAgregarProyecto();
            
        }
    }
  

}
