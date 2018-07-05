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
        Class.AsistenteDB asistentes;
        public ListaAsistentes()
        {
            asistentes = new Class.AsistenteDB();
            InitializeComponent();
            agregarAsistente1.Visible = false;
            llenarTabla(dgvAsistentes);
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

        private void llenarTabla(DataGridView dataGridView)
        {
            DataTable tabla = asistentes.obtenerAsistentes();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.DataSource = bindingSource;

            for (int i = 0; i < dataGridView.ColumnCount; i++) {
                dataGridView.Columns[i].Width = 100;
            }
        }

      
    }
}
