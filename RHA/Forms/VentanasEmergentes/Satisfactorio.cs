using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHA.Forms.VentanasEmergentes
{
    public partial class Satisfactorio : Form
    {
        public Satisfactorio(string mensaje)
        {
            lblMensaje.Text = mensaje;
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
