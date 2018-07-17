using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

            llenarTabla();
        }


        public void SetAdmin(Administrador admin)
        {
            this.admin = admin;
        }

        public void llenarTabla()
        {
            SqlDataReader dataReader = proyecto.obtenerProyectos();
            while (dataReader.Read())
            {

                dgvProyectos.Rows.Add(
                    dataReader["Nombre"].ToString(),
                    dataReader["Estado"].ToString()
                    
                    );
            }
        }
        private void btnAgregarAsistentes_Click(object sender, EventArgs e)
        {
            this.admin.traerAgregarProyecto();
            
        }

        private void ListaProyectos_Load(object sender, EventArgs e)
        {
            dgvProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
  

}
