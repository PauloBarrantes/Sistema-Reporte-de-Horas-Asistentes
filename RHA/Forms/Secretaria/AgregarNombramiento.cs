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
        Secretaria secretaria;
        public AgregarNombramiento()
        {

            InitializeComponent();
        }
        public void SetSecretaria(Secretaria secretaria)
        {
            this.secretaria = secretaria;
        }

        private void btnNombrar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
