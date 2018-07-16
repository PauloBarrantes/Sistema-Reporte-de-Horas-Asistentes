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
    public partial class ListaBalance : UserControl
    {
        public ListaBalance()
        {
            InitializeComponent();
        }
        Administrador admin;
        public void SetAdmin(Administrador admin)
        {
            this.admin = admin;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
