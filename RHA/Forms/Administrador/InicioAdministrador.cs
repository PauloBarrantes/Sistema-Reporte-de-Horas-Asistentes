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
    public partial class InicioAdministrador : UserControl
    {
        Administrador admin;
        public void SetAdmin(Administrador admin)
        {
            this.admin = admin;

        }
        public InicioAdministrador()
        {
            InitializeComponent();
        }

        private void InicioAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
