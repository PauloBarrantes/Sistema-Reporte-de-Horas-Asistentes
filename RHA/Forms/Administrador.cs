using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace RHA
{
    public partial class AgregarAsistente : MaterialForm
    {
        public AgregarAsistente()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
           // materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
           // materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
           
        }

        private void AgregarAsistente_Load(object sender, EventArgs e)
        {

        }


        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }
    }
}
