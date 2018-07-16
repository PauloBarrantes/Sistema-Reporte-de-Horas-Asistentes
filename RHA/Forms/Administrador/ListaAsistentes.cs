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
    public partial class ListaAsistentes : UserControl
    {
        Class.AsistenteDB asistentes;
        Administrador admin;
        public void SetAdmin(Administrador admin)
        {
            this.admin = admin;

        }
        public ListaAsistentes()
        {
            asistentes = new Class.AsistenteDB();
            InitializeComponent();
            
            dgvAsistentes.RowTemplate.Height = 35;

            llenarTabla(dgvAsistentes);
        }

        private void btnAgregarAsistentes_Click(object sender, EventArgs e)
        {
            this.admin.traerAgregarAsistente();
        }

        
        private void llenarTabla(DataGridView dataGridView)
        {
            
            SqlDataReader dataReader = asistentes.obtenerAsistentes();


            
                                    
            while (dataReader.Read())
            {
                         
                dgvAsistentes.Rows.Add(
                    dataReader["Email"].ToString(),
                    dataReader["Cedula"].ToString(),
                    dataReader["NombreEmp"].ToString(),
                    dataReader["Apellido1"].ToString(),
                    dataReader["Carrera"].ToString(),
                    "1"
                    );
            }
            
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
                MessageBox.Show("GG");
                
            }
            else
            {
                if (dgvAsistentes.Columns[e.ColumnIndex].Name == "Perfil")
                {
                    MessageBox.Show("Perfil");
                }
                else
                {
                    if(dgvAsistentes.Columns[e.ColumnIndex].Name == "Horario")
                    {
                        MessageBox.Show("Horario");
                    }
                    
                }

            }
        }
    }
}

