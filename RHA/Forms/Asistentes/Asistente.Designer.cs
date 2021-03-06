﻿namespace RHA.Forms.Asistentes
{
    partial class Asistente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.btnInicioAs = new System.Windows.Forms.Button();
            this.lblNombreAsistente = new System.Windows.Forms.Label();
            this.btnHorarioAs = new System.Windows.Forms.Button();
            this.btnBalanceAs = new System.Windows.Forms.Button();
            this.btnReporteAs = new System.Windows.Forms.Button();
            this.btnPerfilAs = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cambiarContraseña1 = new RHA.Forms.Asistentes.CambiarContraseña();
            this.editarPerfil1 = new RHA.Forms.Asistentes.EditarPerfil();
            this.agregarHorario1 = new RHA.Forms.Asistentes.AgregarHorario();
            this.reporteHorasAs1 = new RHA.Forms.Asistentes.ReporteHorasAs();
            this.perfilAs1 = new RHA.Forms.Asistentes.PerfilAs();
            this.horario2 = new RHA.Forms.Asistentes.Horario();
            this.balanceHorasAs1 = new RHA.Forms.Asistentes.BalanceHorasAs();
            this.inicioAs1 = new RHA.Forms.Asistentes.InicioAs();
            this.panel1.SuspendLayout();
            this.pnSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 34);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnHide
            // 
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.Location = new System.Drawing.Point(855, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(56, 35);
            this.btnHide.TabIndex = 12;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(913, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnSideBar
            // 
            this.pnSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(122)))));
            this.pnSideBar.Controls.Add(this.btnInicioAs);
            this.pnSideBar.Controls.Add(this.lblNombreAsistente);
            this.pnSideBar.Controls.Add(this.btnHorarioAs);
            this.pnSideBar.Controls.Add(this.btnBalanceAs);
            this.pnSideBar.Controls.Add(this.btnReporteAs);
            this.pnSideBar.Controls.Add(this.btnPerfilAs);
            this.pnSideBar.Controls.Add(this.btnCerrar);
            this.pnSideBar.Location = new System.Drawing.Point(0, 33);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(207, 593);
            this.pnSideBar.TabIndex = 2;
            // 
            // btnInicioAs
            // 
            this.btnInicioAs.FlatAppearance.BorderSize = 0;
            this.btnInicioAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioAs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioAs.ForeColor = System.Drawing.Color.White;
            this.btnInicioAs.Image = ((System.Drawing.Image)(resources.GetObject("btnInicioAs.Image")));
            this.btnInicioAs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInicioAs.Location = new System.Drawing.Point(1, 114);
            this.btnInicioAs.Name = "btnInicioAs";
            this.btnInicioAs.Size = new System.Drawing.Size(206, 60);
            this.btnInicioAs.TabIndex = 8;
            this.btnInicioAs.Text = "Inicio";
            this.btnInicioAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicioAs.UseVisualStyleBackColor = true;
            this.btnInicioAs.Click += new System.EventHandler(this.btnInicioAs_Click);
            // 
            // lblNombreAsistente
            // 
            this.lblNombreAsistente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAsistente.ForeColor = System.Drawing.Color.White;
            this.lblNombreAsistente.Location = new System.Drawing.Point(0, 45);
            this.lblNombreAsistente.Name = "lblNombreAsistente";
            this.lblNombreAsistente.Size = new System.Drawing.Size(207, 23);
            this.lblNombreAsistente.TabIndex = 13;
            this.lblNombreAsistente.Text = "Nombre";
            this.lblNombreAsistente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHorarioAs
            // 
            this.btnHorarioAs.FlatAppearance.BorderSize = 0;
            this.btnHorarioAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarioAs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarioAs.ForeColor = System.Drawing.Color.White;
            this.btnHorarioAs.Image = ((System.Drawing.Image)(resources.GetObject("btnHorarioAs.Image")));
            this.btnHorarioAs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHorarioAs.Location = new System.Drawing.Point(-2, 373);
            this.btnHorarioAs.Name = "btnHorarioAs";
            this.btnHorarioAs.Size = new System.Drawing.Size(207, 60);
            this.btnHorarioAs.TabIndex = 12;
            this.btnHorarioAs.Text = "Horario";
            this.btnHorarioAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarioAs.UseVisualStyleBackColor = true;
            this.btnHorarioAs.Click += new System.EventHandler(this.btnHorarioAs_Click);
            // 
            // btnBalanceAs
            // 
            this.btnBalanceAs.FlatAppearance.BorderSize = 0;
            this.btnBalanceAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalanceAs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceAs.ForeColor = System.Drawing.Color.White;
            this.btnBalanceAs.Image = ((System.Drawing.Image)(resources.GetObject("btnBalanceAs.Image")));
            this.btnBalanceAs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBalanceAs.Location = new System.Drawing.Point(0, 309);
            this.btnBalanceAs.Name = "btnBalanceAs";
            this.btnBalanceAs.Size = new System.Drawing.Size(207, 60);
            this.btnBalanceAs.TabIndex = 11;
            this.btnBalanceAs.Text = "Balance Horas";
            this.btnBalanceAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalanceAs.UseVisualStyleBackColor = true;
            this.btnBalanceAs.Click += new System.EventHandler(this.btnBalanceAs_Click);
            // 
            // btnReporteAs
            // 
            this.btnReporteAs.FlatAppearance.BorderSize = 0;
            this.btnReporteAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteAs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteAs.ForeColor = System.Drawing.Color.White;
            this.btnReporteAs.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteAs.Image")));
            this.btnReporteAs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteAs.Location = new System.Drawing.Point(0, 243);
            this.btnReporteAs.Name = "btnReporteAs";
            this.btnReporteAs.Size = new System.Drawing.Size(207, 60);
            this.btnReporteAs.TabIndex = 10;
            this.btnReporteAs.Text = "Reportar Horas";
            this.btnReporteAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteAs.UseVisualStyleBackColor = true;
            this.btnReporteAs.Click += new System.EventHandler(this.btnReporteAs_Click);
            // 
            // btnPerfilAs
            // 
            this.btnPerfilAs.FlatAppearance.BorderSize = 0;
            this.btnPerfilAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfilAs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfilAs.ForeColor = System.Drawing.Color.White;
            this.btnPerfilAs.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfilAs.Image")));
            this.btnPerfilAs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerfilAs.Location = new System.Drawing.Point(0, 180);
            this.btnPerfilAs.Name = "btnPerfilAs";
            this.btnPerfilAs.Size = new System.Drawing.Size(207, 60);
            this.btnPerfilAs.TabIndex = 9;
            this.btnPerfilAs.Text = "Perfil";
            this.btnPerfilAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfilAs.UseVisualStyleBackColor = true;
            this.btnPerfilAs.Click += new System.EventHandler(this.btnPerfilAs_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(2, 532);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(204, 61);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cambiarContraseña1
            // 
            this.cambiarContraseña1.Location = new System.Drawing.Point(205, 35);
            this.cambiarContraseña1.Name = "cambiarContraseña1";
            this.cambiarContraseña1.Size = new System.Drawing.Size(764, 586);
            this.cambiarContraseña1.TabIndex = 11;
            // 
            // editarPerfil1
            // 
            this.editarPerfil1.Location = new System.Drawing.Point(205, 34);
            this.editarPerfil1.Name = "editarPerfil1";
            this.editarPerfil1.Size = new System.Drawing.Size(764, 592);
            this.editarPerfil1.TabIndex = 10;
            // 
            // agregarHorario1
            // 
            this.agregarHorario1.Location = new System.Drawing.Point(205, 33);
            this.agregarHorario1.Name = "agregarHorario1";
            this.agregarHorario1.Size = new System.Drawing.Size(764, 593);
            this.agregarHorario1.TabIndex = 9;
            // 
            // reporteHorasAs1
            // 
            this.reporteHorasAs1.Location = new System.Drawing.Point(205, 33);
            this.reporteHorasAs1.Name = "reporteHorasAs1";
            this.reporteHorasAs1.Size = new System.Drawing.Size(764, 586);
            this.reporteHorasAs1.TabIndex = 8;
            // 
            // perfilAs1
            // 
            this.perfilAs1.AutoSize = true;
            this.perfilAs1.Location = new System.Drawing.Point(207, 33);
            this.perfilAs1.Name = "perfilAs1";
            this.perfilAs1.Size = new System.Drawing.Size(764, 586);
            this.perfilAs1.TabIndex = 7;
            // 
            // horario2
            // 
            this.horario2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horario2.Location = new System.Drawing.Point(205, 35);
            this.horario2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.horario2.Name = "horario2";
            this.horario2.Size = new System.Drawing.Size(764, 586);
            this.horario2.TabIndex = 6;
            // 
            // balanceHorasAs1
            // 
            this.balanceHorasAs1.Location = new System.Drawing.Point(205, 33);
            this.balanceHorasAs1.Name = "balanceHorasAs1";
            this.balanceHorasAs1.Size = new System.Drawing.Size(764, 586);
            this.balanceHorasAs1.TabIndex = 5;
            // 
            // inicioAs1
            // 
            this.inicioAs1.Location = new System.Drawing.Point(205, 33);
            this.inicioAs1.Name = "inicioAs1";
            this.inicioAs1.Size = new System.Drawing.Size(764, 593);
            this.inicioAs1.TabIndex = 4;
            // 
            // Asistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 625);
            this.Controls.Add(this.cambiarContraseña1);
            this.Controls.Add(this.editarPerfil1);
            this.Controls.Add(this.agregarHorario1);
            this.Controls.Add(this.reporteHorasAs1);
            this.Controls.Add(this.perfilAs1);
            this.Controls.Add(this.horario2);
            this.Controls.Add(this.balanceHorasAs1);
            this.Controls.Add(this.inicioAs1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asistente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Asistente_Load);
            this.panel1.ResumeLayout(false);
            this.pnSideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnSideBar;
        private System.Windows.Forms.Button btnInicioAs;
        private System.Windows.Forms.Button btnBalanceAs;
        private System.Windows.Forms.Button btnReporteAs;
        private System.Windows.Forms.Button btnPerfilAs;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnHorarioAs;
        private System.Windows.Forms.Label lblNombreAsistente;
        private System.Windows.Forms.Button btnExit;
        private InicioAs inicioAs1;
        private BalanceHorasAs balanceHorasAs1;
        private Horario horario2;
        private PerfilAs perfilAs1;
        private ReporteHorasAs reporteHorasAs1;
        private AgregarHorario agregarHorario1;
        private EditarPerfil editarPerfil1;
        private CambiarContraseña cambiarContraseña1;
        private System.Windows.Forms.Button btnHide;
    }
}