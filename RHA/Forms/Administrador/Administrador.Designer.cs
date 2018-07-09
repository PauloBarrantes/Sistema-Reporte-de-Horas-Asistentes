﻿namespace RHA.Forms.Administrador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnAsistentes = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblNombreAsistente = new System.Windows.Forms.Label();
            this.listaBalance2 = new RHA.Forms.Administrador.ListaBalance();
            this.listaProyectos1 = new RHA.Forms.Administrador.ListaProyectos();
            this.listaAsistentes1 = new RHA.Forms.Administrador.ListaAsistentes();
            this.inicioAdministrador1 = new RHA.Forms.Administrador.InicioAdministrador();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(126)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 41);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(842, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnProyectos);
            this.panel2.Controls.Add(this.btnBalance);
            this.panel2.Controls.Add(this.btnAsistentes);
            this.panel2.Controls.Add(this.btnInicio);
            this.panel2.Controls.Add(this.lblNombreAsistente);
            this.panel2.Location = new System.Drawing.Point(-1, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 586);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(0, 522);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(207, 60);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProyectos
            // 
            this.btnProyectos.FlatAppearance.BorderSize = 0;
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectos.ForeColor = System.Drawing.Color.White;
            this.btnProyectos.Image = ((System.Drawing.Image)(resources.GetObject("btnProyectos.Image")));
            this.btnProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProyectos.Location = new System.Drawing.Point(0, 327);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(207, 60);
            this.btnProyectos.TabIndex = 18;
            this.btnProyectos.Text = "Proyectos";
            this.btnProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBalance.Location = new System.Drawing.Point(0, 260);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(207, 60);
            this.btnBalance.TabIndex = 17;
            this.btnBalance.Text = "Balance";
            this.btnBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnAsistentes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsistentes.Location = new System.Drawing.Point(-2, 191);
            this.btnAsistentes.Name = "btnAsistentes";
            this.btnAsistentes.Size = new System.Drawing.Size(206, 60);
            this.btnAsistentes.TabIndex = 16;
            this.btnAsistentes.Text = "Asistentes";
            this.btnAsistentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistentes.UseVisualStyleBackColor = true;
            this.btnAsistentes.Click += new System.EventHandler(this.btnAsistentes_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInicio.Location = new System.Drawing.Point(0, 123);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(207, 60);
            this.btnInicio.TabIndex = 15;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblNombreAsistente
            // 
            this.lblNombreAsistente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAsistente.ForeColor = System.Drawing.Color.White;
            this.lblNombreAsistente.Location = new System.Drawing.Point(0, 34);
            this.lblNombreAsistente.Name = "lblNombreAsistente";
            this.lblNombreAsistente.Size = new System.Drawing.Size(207, 23);
            this.lblNombreAsistente.TabIndex = 14;
            this.lblNombreAsistente.Text = "Nombre";
            this.lblNombreAsistente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaBalance2
            // 
            this.listaBalance2.Location = new System.Drawing.Point(204, 40);
            this.listaBalance2.Name = "listaBalance2";
            this.listaBalance2.Size = new System.Drawing.Size(672, 586);
            this.listaBalance2.TabIndex = 5;
            // 
            // listaProyectos1
            // 
            this.listaProyectos1.Location = new System.Drawing.Point(204, 40);
            this.listaProyectos1.Name = "listaProyectos1";
            this.listaProyectos1.Size = new System.Drawing.Size(672, 586);
            this.listaProyectos1.TabIndex = 4;
            // 
            // listaAsistentes1
            // 
            this.listaAsistentes1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaAsistentes1.Location = new System.Drawing.Point(204, 40);
            this.listaAsistentes1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listaAsistentes1.Name = "listaAsistentes1";
            this.listaAsistentes1.Size = new System.Drawing.Size(672, 586);
            this.listaAsistentes1.TabIndex = 3;
            // 
            // inicioAdministrador1
            // 
            this.inicioAdministrador1.Location = new System.Drawing.Point(204, 40);
            this.inicioAdministrador1.Name = "inicioAdministrador1";
            this.inicioAdministrador1.Size = new System.Drawing.Size(672, 586);
            this.inicioAdministrador1.TabIndex = 2;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 625);
            this.Controls.Add(this.listaBalance2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listaProyectos1);
            this.Controls.Add(this.listaAsistentes1);
            this.Controls.Add(this.inicioAdministrador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProyectos;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnAsistentes;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblNombreAsistente;
        private System.Windows.Forms.Button btnLogout;

        private InicioAdministrador inicioAdministrador1;
        private ListaAsistentes listaAsistentes1;
        private ListaProyectos listaProyectos1;
        private ListaBalance listaBalance2;
    }
}