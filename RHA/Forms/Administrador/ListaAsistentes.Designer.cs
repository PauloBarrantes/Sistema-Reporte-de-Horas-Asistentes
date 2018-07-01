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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnAgregarAsistentes = new System.Windows.Forms.Button();
            this.agregarAsistente1 = new RHA.Forms.Administrador.AgregarAsistente();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(43, 34);
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
            this.btnAgregarAsistentes.Location = new System.Drawing.Point(505, 34);
            this.btnAgregarAsistentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarAsistentes.Name = "btnAgregarAsistentes";
            this.btnAgregarAsistentes.Size = new System.Drawing.Size(147, 43);
            this.btnAgregarAsistentes.TabIndex = 3;
            this.btnAgregarAsistentes.Text = "Agregar Asistente";
            this.btnAgregarAsistentes.UseVisualStyleBackColor = false;
            this.btnAgregarAsistentes.Click += new System.EventHandler(this.btnAgregarAsistentes_Click);
            // 
            // agregarAsistente1
            // 
            this.agregarAsistente1.Location = new System.Drawing.Point(1, 2);
            this.agregarAsistente1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.agregarAsistente1.Name = "agregarAsistente1";
            this.agregarAsistente1.Size = new System.Drawing.Size(672, 586);
            this.agregarAsistente1.TabIndex = 0;
            // 
            // ListaAsistentes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.agregarAsistente1);
            this.Controls.Add(this.btnAgregarAsistentes);
            this.Controls.Add(this.lblBienvenido);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListaAsistentes";
            this.Size = new System.Drawing.Size(672, 586);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnAgregarAsistentes;
        private AgregarAsistente agregarAsistente1;
    }
}
