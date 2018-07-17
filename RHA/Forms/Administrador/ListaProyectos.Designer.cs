namespace RHA.Forms.Administrador
{
    partial class ListaProyectos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnAgregarAsistentes = new System.Windows.Forms.Button();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualizar = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnEliminarProyecto = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lblBienvenido.Location = new System.Drawing.Point(37, 28);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(145, 33);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Proyectos";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarAsistentes
            // 
            this.btnAgregarAsistentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.btnAgregarAsistentes.FlatAppearance.BorderSize = 0;
            this.btnAgregarAsistentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAsistentes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAsistentes.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAsistentes.Location = new System.Drawing.Point(553, 29);
            this.btnAgregarAsistentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarAsistentes.Name = "btnAgregarAsistentes";
            this.btnAgregarAsistentes.Size = new System.Drawing.Size(161, 43);
            this.btnAgregarAsistentes.TabIndex = 4;
            this.btnAgregarAsistentes.Text = "Agregar Proyecto";
            this.btnAgregarAsistentes.UseVisualStyleBackColor = false;
            this.btnAgregarAsistentes.Click += new System.EventHandler(this.btnAgregarAsistentes_Click);
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.AllowUserToAddRows = false;
            this.dgvProyectos.AllowUserToDeleteRows = false;
            this.dgvProyectos.AllowUserToResizeColumns = false;
            this.dgvProyectos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvProyectos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProyectos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProyectos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProyectos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.estado,
            this.actualizar,
            this.btnEliminarProyecto});
            this.dgvProyectos.Location = new System.Drawing.Point(45, 97);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.ReadOnly = true;
            this.dgvProyectos.RowHeadersWidth = 50;
            this.dgvProyectos.Size = new System.Drawing.Size(669, 474);
            this.dgvProyectos.TabIndex = 9;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombre.HeaderText = "Nombre del Proyecto:";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.estado.DefaultCellStyle = dataGridViewCellStyle3;
            this.estado.HeaderText = "Estado del Proyecto:";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // actualizar
            // 
            this.actualizar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.actualizar.DefaultCellStyle = dataGridViewCellStyle4;
            this.actualizar.HeaderText = "Actualizar el estado:";
            this.actualizar.Name = "actualizar";
            this.actualizar.ReadOnly = true;
            this.actualizar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.actualizar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnEliminarProyecto.DefaultCellStyle = dataGridViewCellStyle5;
            this.btnEliminarProyecto.HeaderText = "Eliminar Proyecto";
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.ReadOnly = true;
            this.btnEliminarProyecto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminarProyecto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEliminarProyecto.Text = "Eliminar";
            // 
            // ListaProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProyectos);
            this.Controls.Add(this.btnAgregarAsistentes);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "ListaProyectos";
            this.Size = new System.Drawing.Size(764, 586);
            this.Load += new System.EventHandler(this.ListaProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnAgregarAsistentes;
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewComboBoxColumn actualizar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarProyecto;
    }
}
