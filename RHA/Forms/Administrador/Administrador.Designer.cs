namespace RHA
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnAsistentes = new System.Windows.Forms.Button();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.inicioAdministrador1 = new RHA.Forms.Administrador.InicioAdministrador();
            this.listaProyectos1 = new RHA.Forms.Administrador.ListaProyectos();
            this.listaAsistentes1 = new RHA.Forms.Administrador.ListaAsistentes();
            this.listaBalance1 = new RHA.Forms.Administrador.ListaBalance();
            this.pnSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSideBar
            // 
            this.pnSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.pnSideBar.Controls.Add(this.btnProyectos);
            this.pnSideBar.Controls.Add(this.btnBalance);
            this.pnSideBar.Controls.Add(this.btnAsistentes);
            this.pnSideBar.Controls.Add(this.btnCerrarSesión);
            this.pnSideBar.Controls.Add(this.btnInicio);
            this.pnSideBar.Location = new System.Drawing.Point(-1, 41);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(207, 546);
            this.pnSideBar.TabIndex = 0;
            // 
            // btnProyectos
            // 
            this.btnProyectos.FlatAppearance.BorderSize = 0;
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectos.ForeColor = System.Drawing.Color.White;
            this.btnProyectos.Image = ((System.Drawing.Image)(resources.GetObject("btnProyectos.Image")));
            this.btnProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyectos.Location = new System.Drawing.Point(0, 324);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(212, 60);
            this.btnProyectos.TabIndex = 7;
            this.btnProyectos.Text = "Proyectos";
            this.btnProyectos.UseVisualStyleBackColor = true;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.FlatAppearance.BorderSize = 0;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.ForeColor = System.Drawing.Color.White;
            this.btnBalance.Image = ((System.Drawing.Image)(resources.GetObject("btnBalance.Image")));
            this.btnBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalance.Location = new System.Drawing.Point(1, 258);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(211, 60);
            this.btnBalance.TabIndex = 6;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnAsistentes
            // 
            this.btnAsistentes.FlatAppearance.BorderSize = 0;
            this.btnAsistentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistentes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistentes.ForeColor = System.Drawing.Color.White;
            this.btnAsistentes.Image = ((System.Drawing.Image)(resources.GetObject("btnAsistentes.Image")));
            this.btnAsistentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistentes.Location = new System.Drawing.Point(0, 192);
            this.btnAsistentes.Name = "btnAsistentes";
            this.btnAsistentes.Size = new System.Drawing.Size(207, 60);
            this.btnAsistentes.TabIndex = 5;
            this.btnAsistentes.Text = "Asistentes";
            this.btnAsistentes.UseVisualStyleBackColor = true;
            this.btnAsistentes.Click += new System.EventHandler(this.btnAsistentes_Click);
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesión.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesión.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesión.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesión.Image")));
            this.btnCerrarSesión.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesión.Location = new System.Drawing.Point(3, 486);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(204, 46);
            this.btnCerrarSesión.TabIndex = 4;
            this.btnCerrarSesión.Text = "     Cerrar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 125);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(212, 60);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(126)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 41);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(831, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 41);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button6_Click);
            // 
            // inicioAdministrador1
            // 
            this.inicioAdministrador1.Location = new System.Drawing.Point(208, 41);
            this.inicioAdministrador1.Name = "inicioAdministrador1";
            this.inicioAdministrador1.Size = new System.Drawing.Size(666, 543);
            this.inicioAdministrador1.TabIndex = 2;
            this.inicioAdministrador1.Load += new System.EventHandler(this.inicioAdministrador1_Load);
            // 
            // listaProyectos1
            // 
            this.listaProyectos1.Location = new System.Drawing.Point(208, 41);
            this.listaProyectos1.Name = "listaProyectos1";
            this.listaProyectos1.Size = new System.Drawing.Size(672, 539);
            this.listaProyectos1.TabIndex = 5;
            // 
            // listaAsistentes1
            // 
            this.listaAsistentes1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaAsistentes1.Location = new System.Drawing.Point(208, 41);
            this.listaAsistentes1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listaAsistentes1.Name = "listaAsistentes1";
            this.listaAsistentes1.Size = new System.Drawing.Size(672, 539);
            this.listaAsistentes1.TabIndex = 4;
            // 
            // listaBalance1
            // 
            this.listaBalance1.Location = new System.Drawing.Point(208, 41);
            this.listaBalance1.Name = "listaBalance1";
            this.listaBalance1.Size = new System.Drawing.Size(672, 546);
            this.listaBalance1.TabIndex = 3;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSideBar);
            this.Controls.Add(this.inicioAdministrador1);
            this.Controls.Add(this.listaProyectos1);
            this.Controls.Add(this.listaAsistentes1);
            this.Controls.Add(this.listaBalance1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.pnSideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSideBar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Button btnProyectos;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnAsistentes;
        private System.Windows.Forms.Button btnExit;
        private Forms.Administrador.InicioAdministrador inicioAdministrador1;
        private Forms.Administrador.ListaBalance listaBalance1;
        private Forms.Administrador.ListaAsistentes listaAsistentes1;
        private Forms.Administrador.ListaProyectos listaProyectos1;
    }
}