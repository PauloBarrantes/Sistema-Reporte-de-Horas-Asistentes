namespace RHA.Forms.Administrador
{
    partial class ListaAsistentes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnAgregarAsistentes = new System.Windows.Forms.Button();
            this.dgvAsistentes = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cédula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Horario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(21, 34);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(249, 33);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Lista de Asistentes";
            // 
            // btnAgregarAsistentes
            // 
            this.btnAgregarAsistentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.btnAgregarAsistentes.FlatAppearance.BorderSize = 0;
            this.btnAgregarAsistentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAsistentes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAsistentes.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAsistentes.Location = new System.Drawing.Point(594, 34);
            this.btnAgregarAsistentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarAsistentes.Name = "btnAgregarAsistentes";
            this.btnAgregarAsistentes.Size = new System.Drawing.Size(147, 43);
            this.btnAgregarAsistentes.TabIndex = 3;
            this.btnAgregarAsistentes.Text = "Agregar Asistente";
            this.btnAgregarAsistentes.UseVisualStyleBackColor = false;
            this.btnAgregarAsistentes.Click += new System.EventHandler(this.btnAgregarAsistentes_Click);
            // 
            // dgvAsistentes
            // 
            this.dgvAsistentes.AllowUserToAddRows = false;
            this.dgvAsistentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvAsistentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsistentes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAsistentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAsistentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvAsistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.Cédula,
            this.Nombre,
            this.Apellido,
            this.Carrera,
            this.Horas,
            this.Perfil,
            this.Horario,
            this.Eliminar});
            this.dgvAsistentes.Location = new System.Drawing.Point(59, 96);
            this.dgvAsistentes.Name = "dgvAsistentes";
            this.dgvAsistentes.ReadOnly = true;
            this.dgvAsistentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAsistentes.RowHeadersWidth = 50;
            this.dgvAsistentes.Size = new System.Drawing.Size(669, 474);
            this.dgvAsistentes.TabIndex = 8;
            this.dgvAsistentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistentes_CellContentClick);
            this.dgvAsistentes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvAsistentes_CellPainting);
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // Cédula
            // 
            this.Cédula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cédula.HeaderText = "Cédula";
            this.Cédula.Name = "Cédula";
            this.Cédula.ReadOnly = true;
            this.Cédula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cédula.Width = 74;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 76;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Apellido.Width = 76;
            // 
            // Carrera
            // 
            this.Carrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Carrera.Width = 74;
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            this.Horas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Perfil
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.Perfil.DefaultCellStyle = dataGridViewCellStyle2;
            this.Perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            this.Perfil.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Horario
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.Horario.DefaultCellStyle = dataGridViewCellStyle3;
            this.Horario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Horario.Text = "";
            // 
            // Eliminar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle4;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ListaAsistentes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dgvAsistentes);
            this.Controls.Add(this.btnAgregarAsistentes);
            this.Controls.Add(this.lblBienvenido);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListaAsistentes";
            this.Size = new System.Drawing.Size(764, 586);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnAgregarAsistentes;
        private System.Windows.Forms.DataGridView dgvAsistentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cédula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewButtonColumn Perfil;
        private System.Windows.Forms.DataGridViewButtonColumn Horario;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
