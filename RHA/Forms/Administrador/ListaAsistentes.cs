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
            dgvAsistentes.RowTemplate.Height = 35;

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
                       
            
        }

        private void dgvAsistentes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.user__2_.Width;
                var h = Properties.Resources.user__2_.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.user__2_, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.calendar__1_.Width;
                var h = Properties.Resources.calendar__1_.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.calendar__1_, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.remove_user.Width;
                var h = Properties.Resources.remove_user.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.remove_user, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvAsistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAsistentes.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                MessageBox.Show(dgvAsistentes.Columns[e.ColumnIndex+1].Name);
                
            }
            else
            {
                if (dgvAsistentes.Columns[e.ColumnIndex].Name == "Perfil")
                {
                    MessageBox.Show("Perfil");
                }
                else
                {
                    MessageBox.Show("Horario");
                }

            }
        }
    }
}

