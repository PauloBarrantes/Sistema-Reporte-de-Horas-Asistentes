namespace RHA
{
    partial class AgregarAsistente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.tabAsistentes = new System.Windows.Forms.TabPage();
            this.tabProyectos = new System.Windows.Forms.TabPage();
            this.tabBalance = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(877, 34);
            this.materialTabSelector1.TabIndex = 33;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabInicio);
            this.materialTabControl1.Controls.Add(this.tabAsistentes);
            this.materialTabControl1.Controls.Add(this.tabProyectos);
            this.materialTabControl1.Controls.Add(this.tabBalance);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 99);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(877, 489);
            this.materialTabControl1.TabIndex = 34;
            // 
            // tabInicio
            // 
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(869, 463);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // tabAsistentes
            // 
            this.tabAsistentes.Location = new System.Drawing.Point(4, 22);
            this.tabAsistentes.Name = "tabAsistentes";
            this.tabAsistentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsistentes.Size = new System.Drawing.Size(869, 463);
            this.tabAsistentes.TabIndex = 1;
            this.tabAsistentes.Text = "Lista de Asistentes";
            this.tabAsistentes.UseVisualStyleBackColor = true;
            // 
            // tabProyectos
            // 
            this.tabProyectos.Location = new System.Drawing.Point(4, 22);
            this.tabProyectos.Name = "tabProyectos";
            this.tabProyectos.Size = new System.Drawing.Size(869, 463);
            this.tabProyectos.TabIndex = 2;
            this.tabProyectos.Text = "Lista de Proyectos";
            this.tabProyectos.UseVisualStyleBackColor = true;
            // 
            // tabBalance
            // 
            this.tabBalance.Location = new System.Drawing.Point(4, 22);
            this.tabBalance.Name = "tabBalance";
            this.tabBalance.Size = new System.Drawing.Size(869, 463);
            this.tabBalance.TabIndex = 3;
            this.tabBalance.Text = "Balance";
            this.tabBalance.UseVisualStyleBackColor = true;
            // 
            // AgregarAsistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 585);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "AgregarAsistente";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.AgregarAsistente_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabAsistentes;
        private System.Windows.Forms.TabPage tabProyectos;
        private System.Windows.Forms.TabPage tabBalance;
    }
}