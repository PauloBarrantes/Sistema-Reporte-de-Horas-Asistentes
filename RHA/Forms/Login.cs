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
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            AgregarAsistente agregarAsistente = new AgregarAsistente();
            this.Hide();
            agregarAsistente.ShowDialog();
            
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {

        }
    }
}
