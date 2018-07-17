namespace RHA.Forms.Secreataria
{
    partial class AgregarNombramiento
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnNombrar = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.cbAsistentes = new MetroFramework.Controls.MetroComboBox();
            this.cbEntidad = new MetroFramework.Controls.MetroComboBox();
            this.txtCantidadHoras = new MetroFramework.Controls.MetroTextBox();
            this.cbPeriodo = new MetroFramework.Controls.MetroComboBox();
            this.cbTipoAsistente = new MetroFramework.Controls.MetroComboBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblCarne = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(440, 172);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(201, 18);
            this.lblInfo.TabIndex = 56;
            this.lblInfo.Text = "Información del Asistente:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(108, 369);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(119, 17);
            this.lblTipo.TabIndex = 54;
            this.lblTipo.Text = "Tipo de Asistente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Período:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Cantidad de Horas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Entidad Nombradora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Asistente:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(178)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(44, 529);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(147, 43);
            this.btnVolver.TabIndex = 47;
            this.btnVolver.Text = "Cancelar";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnNombrar
            // 
            this.btnNombrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.btnNombrar.FlatAppearance.BorderSize = 0;
            this.btnNombrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNombrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombrar.ForeColor = System.Drawing.Color.White;
            this.btnNombrar.Location = new System.Drawing.Point(574, 529);
            this.btnNombrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNombrar.Name = "btnNombrar";
            this.btnNombrar.Size = new System.Drawing.Size(147, 43);
            this.btnNombrar.TabIndex = 45;
            this.btnNombrar.Text = "Nombrar";
            this.btnNombrar.UseVisualStyleBackColor = false;
            this.btnNombrar.Click += new System.EventHandler(this.btnNombrar_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(105, 15);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(331, 33);
            this.lblBienvenido.TabIndex = 37;
            this.lblBienvenido.Text = "Agregar Nombramiento";
            // 
            // cbAsistentes
            // 
            this.cbAsistentes.FormattingEnabled = true;
            this.cbAsistentes.ItemHeight = 23;
            this.cbAsistentes.Location = new System.Drawing.Point(443, 115);
            this.cbAsistentes.Name = "cbAsistentes";
            this.cbAsistentes.Size = new System.Drawing.Size(205, 29);
            this.cbAsistentes.TabIndex = 63;
            this.cbAsistentes.UseSelectable = true;
            // 
            // cbEntidad
            // 
            this.cbEntidad.FormattingEnabled = true;
            this.cbEntidad.ItemHeight = 23;
            this.cbEntidad.Location = new System.Drawing.Point(111, 193);
            this.cbEntidad.Name = "cbEntidad";
            this.cbEntidad.Size = new System.Drawing.Size(205, 29);
            this.cbEntidad.TabIndex = 64;
            this.cbEntidad.UseSelectable = true;
            // 
            // txtCantidadHoras
            // 
            // 
            // 
            // 
            this.txtCantidadHoras.CustomButton.Image = null;
            this.txtCantidadHoras.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtCantidadHoras.CustomButton.Name = "";
            this.txtCantidadHoras.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantidadHoras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidadHoras.CustomButton.TabIndex = 1;
            this.txtCantidadHoras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidadHoras.CustomButton.UseSelectable = true;
            this.txtCantidadHoras.CustomButton.Visible = false;
            this.txtCantidadHoras.Lines = new string[0];
            this.txtCantidadHoras.Location = new System.Drawing.Point(111, 256);
            this.txtCantidadHoras.MaxLength = 32767;
            this.txtCantidadHoras.Name = "txtCantidadHoras";
            this.txtCantidadHoras.PasswordChar = '\0';
            this.txtCantidadHoras.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidadHoras.SelectedText = "";
            this.txtCantidadHoras.SelectionLength = 0;
            this.txtCantidadHoras.SelectionStart = 0;
            this.txtCantidadHoras.ShortcutsEnabled = true;
            this.txtCantidadHoras.Size = new System.Drawing.Size(205, 23);
            this.txtCantidadHoras.TabIndex = 39;
            this.txtCantidadHoras.UseSelectable = true;
            this.txtCantidadHoras.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidadHoras.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.ItemHeight = 23;
            this.cbPeriodo.Location = new System.Drawing.Point(111, 321);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(205, 29);
            this.cbPeriodo.TabIndex = 65;
            this.cbPeriodo.UseSelectable = true;
            // 
            // cbTipoAsistente
            // 
            this.cbTipoAsistente.FormattingEnabled = true;
            this.cbTipoAsistente.ItemHeight = 23;
            this.cbTipoAsistente.Items.AddRange(new object[] {
            "Estudiante",
            "Asistente",
            "Asistente Graduado"});
            this.cbTipoAsistente.Location = new System.Drawing.Point(111, 399);
            this.cbTipoAsistente.Name = "cbTipoAsistente";
            this.cbTipoAsistente.Size = new System.Drawing.Size(205, 29);
            this.cbTipoAsistente.TabIndex = 66;
            this.cbTipoAsistente.UseSelectable = true;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(440, 256);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(60, 17);
            this.lblCedula.TabIndex = 67;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblCarne
            // 
            this.lblCarne.AutoSize = true;
            this.lblCarne.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarne.Location = new System.Drawing.Point(440, 298);
            this.lblCarne.Name = "lblCarne";
            this.lblCarne.Size = new System.Drawing.Size(52, 17);
            this.lblCarne.TabIndex = 68;
            this.lblCarne.Text = "Carné:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(440, 337);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(134, 17);
            this.lblEmail.TabIndex = 69;
            this.lblEmail.Text = "Correo electrónico:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(108, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 17);
            this.label11.TabIndex = 71;
            this.label11.Text = "Identificador (Máscara)";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(111, 115);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(205, 23);
            this.txtID.TabIndex = 70;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(440, 218);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 17);
            this.lblNombre.TabIndex = 72;
            this.lblNombre.Text = "Nombre:";
            // 
            // AgregarNombramiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCarne);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.cbTipoAsistente);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.cbEntidad);
            this.Controls.Add(this.cbAsistentes);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidadHoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnNombrar);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "AgregarNombramiento";
            this.Size = new System.Drawing.Size(764, 586);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnNombrar;
        private System.Windows.Forms.Label lblBienvenido;
        private MetroFramework.Controls.MetroComboBox cbAsistentes;
        private MetroFramework.Controls.MetroComboBox cbEntidad;
        private MetroFramework.Controls.MetroTextBox txtCantidadHoras;
        private MetroFramework.Controls.MetroComboBox cbPeriodo;
        private MetroFramework.Controls.MetroComboBox cbTipoAsistente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblCarne;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroTextBox txtID;
        private System.Windows.Forms.Label lblNombre;
    }
}
