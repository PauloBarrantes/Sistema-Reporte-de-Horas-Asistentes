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
    public partial class ListaBalance : UserControl
    {
        Class.AsistenteDB asistentes;
        Administrador admin;

        public ListaBalance()
        {
            asistentes = new Class.AsistenteDB();
            InitializeComponent();
            llenarTabla();
        }
     
        public void SetAdmin(Administrador admin)
        {
            this.admin = admin;

        }
        public void llenarTabla()
        {
            SqlDataReader dataReader = asistentes.obtenerBalance();
            while (dataReader.Read())
            {
                string HorasAcumuladasStr = dataReader["HorasAcumuladas"].ToString();
                string estado = "";
                int horasAcumuladas = Int32.Parse(HorasAcumuladasStr);
                if (horasAcumuladas > 0)
                {
                    estado = "Tiene Horas Extra";
                }
                else if (horasAcumuladas == 0)
                {
                    estado = "OK";
                }
                else
                {
                    estado = "Debe Horas";
                }
                
                dgvProyectos.Rows.Add(
                    dataReader["Email"].ToString(),
                    dataReader["Cedula"].ToString(),
                    dataReader["NombreEmp"].ToString(),
                    dataReader["Apellido1"].ToString(),
                    dataReader["HorasAcumuladas"].ToString(),
                    estado
                    );

              
            }
        }

        private void ListaBalance_Load(object sender, EventArgs e)
        {

        }
    }
}
