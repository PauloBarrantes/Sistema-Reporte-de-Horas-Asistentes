namespace RHA.Forms.Administrador
{
    partial class AgregarAsistente
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
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.rbEstudiante = new MetroFramework.Controls.MetroRadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido1 = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido2 = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCarne = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbAsistente = new MetroFramework.Controls.MetroRadioButton();
            this.rbGraduado = new MetroFramework.Controls.MetroRadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword2 = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPassword1 = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHorasAcumuladas = new MetroFramework.Controls.MetroTextBox();
            this.cbCarrera = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(105, 16);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(246, 33);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Agregar Asistente";
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(111, 120);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(205, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbEstudiante
            // 
            this.rbEstudiante.AutoSize = true;
            this.rbEstudiante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbEstudiante.Location = new System.Drawing.Point(550, 206);
            this.rbEstudiante.Name = "rbEstudiante";
            this.rbEstudiante.Size = new System.Drawing.Size(78, 15);
            this.rbEstudiante.TabIndex = 6;
            this.rbEstudiante.Text = "Estudiante";
            this.rbEstudiante.UseSelectable = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(574, 530);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 43);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar Asistente";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(178)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(44, 530);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(147, 43);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Primer Apellido:";
            // 
            // txtApellido1
            // 
            // 
            // 
            // 
            this.txtApellido1.CustomButton.Image = null;
            this.txtApellido1.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtApellido1.CustomButton.Name = "";
            this.txtApellido1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellido1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido1.CustomButton.TabIndex = 1;
            this.txtApellido1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido1.CustomButton.UseSelectable = true;
            this.txtApellido1.CustomButton.Visible = false;
            this.txtApellido1.Lines = new string[0];
            this.txtApellido1.Location = new System.Drawing.Point(111, 190);
            this.txtApellido1.MaxLength = 32767;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.PasswordChar = '\0';
            this.txtApellido1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido1.SelectedText = "";
            this.txtApellido1.SelectionLength = 0;
            this.txtApellido1.SelectionStart = 0;
            this.txtApellido1.ShortcutsEnabled = true;
            this.txtApellido1.Size = new System.Drawing.Size(205, 23);
            this.txtApellido1.TabIndex = 2;
            this.txtApellido1.UseSelectable = true;
            this.txtApellido1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellido1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Segundo Apellido:";
            // 
            // txtApellido2
            // 
            // 
            // 
            // 
            this.txtApellido2.CustomButton.Image = null;
            this.txtApellido2.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtApellido2.CustomButton.Name = "";
            this.txtApellido2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellido2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido2.CustomButton.TabIndex = 1;
            this.txtApellido2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido2.CustomButton.UseSelectable = true;
            this.txtApellido2.CustomButton.Visible = false;
            this.txtApellido2.Lines = new string[0];
            this.txtApellido2.Location = new System.Drawing.Point(111, 257);
            this.txtApellido2.MaxLength = 32767;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.PasswordChar = '\0';
            this.txtApellido2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido2.SelectedText = "";
            this.txtApellido2.SelectionLength = 0;
            this.txtApellido2.SelectionStart = 0;
            this.txtApellido2.ShortcutsEnabled = true;
            this.txtApellido2.Size = new System.Drawing.Size(205, 23);
            this.txtApellido2.TabIndex = 3;
            this.txtApellido2.UseSelectable = true;
            this.txtApellido2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellido2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cédula:";
            // 
            // txtCedula
            // 
            // 
            // 
            // 
            this.txtCedula.CustomButton.Image = null;
            this.txtCedula.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtCedula.CustomButton.Name = "";
            this.txtCedula.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCedula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCedula.CustomButton.TabIndex = 1;
            this.txtCedula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCedula.CustomButton.UseSelectable = true;
            this.txtCedula.CustomButton.Visible = false;
            this.txtCedula.Lines = new string[0];
            this.txtCedula.Location = new System.Drawing.Point(111, 323);
            this.txtCedula.MaxLength = 32767;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCedula.SelectedText = "";
            this.txtCedula.SelectionLength = 0;
            this.txtCedula.SelectionStart = 0;
            this.txtCedula.ShortcutsEnabled = true;
            this.txtCedula.Size = new System.Drawing.Size(205, 23);
            this.txtCedula.TabIndex = 4;
            this.txtCedula.UseSelectable = true;
            this.txtCedula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCedula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Correo Institucional:";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(111, 397);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(258, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Carrera:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Carné:";
            // 
            // txtCarne
            // 
            // 
            // 
            // 
            this.txtCarne.CustomButton.Image = null;
            this.txtCarne.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.txtCarne.CustomButton.Name = "";
            this.txtCarne.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCarne.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCarne.CustomButton.TabIndex = 1;
            this.txtCarne.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCarne.CustomButton.UseSelectable = true;
            this.txtCarne.CustomButton.Visible = false;
            this.txtCarne.Lines = new string[0];
            this.txtCarne.Location = new System.Drawing.Point(560, 167);
            this.txtCarne.MaxLength = 32767;
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.PasswordChar = '\0';
            this.txtCarne.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCarne.SelectedText = "";
            this.txtCarne.SelectionLength = 0;
            this.txtCarne.SelectionStart = 0;
            this.txtCarne.ShortcutsEnabled = true;
            this.txtCarne.Size = new System.Drawing.Size(88, 23);
            this.txtCarne.TabIndex = 8;
            this.txtCarne.UseSelectable = true;
            this.txtCarne.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCarne.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(440, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tipo Asistente:";
            // 
            // rbAsistente
            // 
            this.rbAsistente.AutoSize = true;
            this.rbAsistente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbAsistente.Location = new System.Drawing.Point(550, 238);
            this.rbAsistente.Name = "rbAsistente";
            this.rbAsistente.Size = new System.Drawing.Size(71, 15);
            this.rbAsistente.TabIndex = 27;
            this.rbAsistente.Text = "Asistente";
            this.rbAsistente.UseSelectable = true;
            // 
            // rbGraduado
            // 
            this.rbGraduado.AutoSize = true;
            this.rbGraduado.Location = new System.Drawing.Point(550, 275);
            this.rbGraduado.Name = "rbGraduado";
            this.rbGraduado.Size = new System.Drawing.Size(75, 15);
            this.rbGraduado.TabIndex = 28;
            this.rbGraduado.Text = "Graduado";
            this.rbGraduado.UseSelectable = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(440, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Confirmar Contraseña:";
            // 
            // txtPassword2
            // 
            // 
            // 
            // 
            this.txtPassword2.CustomButton.Image = null;
            this.txtPassword2.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtPassword2.CustomButton.Name = "";
            this.txtPassword2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword2.CustomButton.TabIndex = 1;
            this.txtPassword2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword2.CustomButton.UseSelectable = true;
            this.txtPassword2.CustomButton.Visible = false;
            this.txtPassword2.Lines = new string[0];
            this.txtPassword2.Location = new System.Drawing.Point(443, 388);
            this.txtPassword2.MaxLength = 32767;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword2.SelectedText = "";
            this.txtPassword2.SelectionLength = 0;
            this.txtPassword2.SelectionStart = 0;
            this.txtPassword2.ShortcutsEnabled = true;
            this.txtPassword2.Size = new System.Drawing.Size(205, 23);
            this.txtPassword2.TabIndex = 10;
            this.txtPassword2.UseSelectable = true;
            this.txtPassword2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(440, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Contraseña:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword1
            // 
            // 
            // 
            // 
            this.txtPassword1.CustomButton.Image = null;
            this.txtPassword1.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtPassword1.CustomButton.Name = "";
            this.txtPassword1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword1.CustomButton.TabIndex = 1;
            this.txtPassword1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword1.CustomButton.UseSelectable = true;
            this.txtPassword1.CustomButton.Visible = false;
            this.txtPassword1.Lines = new string[0];
            this.txtPassword1.Location = new System.Drawing.Point(443, 322);
            this.txtPassword1.MaxLength = 32767;
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '*';
            this.txtPassword1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword1.SelectedText = "";
            this.txtPassword1.SelectionLength = 0;
            this.txtPassword1.SelectionStart = 0;
            this.txtPassword1.ShortcutsEnabled = true;
            this.txtPassword1.Size = new System.Drawing.Size(205, 23);
            this.txtPassword1.TabIndex = 9;
            this.txtPassword1.UseSelectable = true;
            this.txtPassword1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(108, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Horas Acumuladas:";
            // 
            // txtHorasAcumuladas
            // 
            // 
            // 
            // 
            this.txtHorasAcumuladas.CustomButton.Image = null;
            this.txtHorasAcumuladas.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.txtHorasAcumuladas.CustomButton.Name = "";
            this.txtHorasAcumuladas.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHorasAcumuladas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHorasAcumuladas.CustomButton.TabIndex = 1;
            this.txtHorasAcumuladas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHorasAcumuladas.CustomButton.UseSelectable = true;
            this.txtHorasAcumuladas.CustomButton.Visible = false;
            this.txtHorasAcumuladas.Lines = new string[0];
            this.txtHorasAcumuladas.Location = new System.Drawing.Point(258, 448);
            this.txtHorasAcumuladas.MaxLength = 32767;
            this.txtHorasAcumuladas.Name = "txtHorasAcumuladas";
            this.txtHorasAcumuladas.PasswordChar = '\0';
            this.txtHorasAcumuladas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHorasAcumuladas.SelectedText = "";
            this.txtHorasAcumuladas.SelectionLength = 0;
            this.txtHorasAcumuladas.SelectionStart = 0;
            this.txtHorasAcumuladas.ShortcutsEnabled = true;
            this.txtHorasAcumuladas.Size = new System.Drawing.Size(58, 23);
            this.txtHorasAcumuladas.TabIndex = 6;
            this.txtHorasAcumuladas.UseSelectable = true;
            this.txtHorasAcumuladas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHorasAcumuladas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbCarrera
            // 
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.ItemHeight = 23;
            this.cbCarrera.Items.AddRange(new object[] {
            "Computación",
            "Ingeniería Cívil"});
            this.cbCarrera.Location = new System.Drawing.Point(443, 120);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(205, 29);
            this.cbCarrera.TabIndex = 7;
            this.cbCarrera.UseSelectable = true;
            // 
            // AgregarAsistente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cbCarrera);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHorasAcumuladas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.rbGraduado);
            this.Controls.Add(this.rbAsistente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbEstudiante);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "AgregarAsistente";
            this.Size = new System.Drawing.Size(764, 586);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroRadioButton rbEstudiante;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtApellido1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtApellido2;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtCedula;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtCarne;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroRadioButton rbAsistente;
        private MetroFramework.Controls.MetroRadioButton rbGraduado;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroTextBox txtPassword2;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroTextBox txtPassword1;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTextBox txtHorasAcumuladas;
        private MetroFramework.Controls.MetroComboBox cbCarrera;
    }
}
