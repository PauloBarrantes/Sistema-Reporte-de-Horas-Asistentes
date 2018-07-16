namespace RHA.Forms.Asistentes
{
    partial class CambiarContraseña
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordConfirmarcion = new MetroFramework.Controls.MetroTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(178)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(141, 366);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(176, 54);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.btnCambiarContraseña.FlatAppearance.BorderSize = 0;
            this.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseña.ForeColor = System.Drawing.Color.White;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(427, 366);
            this.btnCambiarContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(176, 54);
            this.btnCambiarContraseña.TabIndex = 48;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(231, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(292, 33);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "Cambiar Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(257, 177);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(246, 23);
            this.txtPassword.TabIndex = 51;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Confirmar Contraseña";
            // 
            // txtPasswordConfirmarcion
            // 
            // 
            // 
            // 
            this.txtPasswordConfirmarcion.CustomButton.Image = null;
            this.txtPasswordConfirmarcion.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.txtPasswordConfirmarcion.CustomButton.Name = "";
            this.txtPasswordConfirmarcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordConfirmarcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordConfirmarcion.CustomButton.TabIndex = 1;
            this.txtPasswordConfirmarcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordConfirmarcion.CustomButton.UseSelectable = true;
            this.txtPasswordConfirmarcion.CustomButton.Visible = false;
            this.txtPasswordConfirmarcion.Lines = new string[0];
            this.txtPasswordConfirmarcion.Location = new System.Drawing.Point(257, 256);
            this.txtPasswordConfirmarcion.MaxLength = 32767;
            this.txtPasswordConfirmarcion.Name = "txtPasswordConfirmarcion";
            this.txtPasswordConfirmarcion.PasswordChar = '*';
            this.txtPasswordConfirmarcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordConfirmarcion.SelectedText = "";
            this.txtPasswordConfirmarcion.SelectionLength = 0;
            this.txtPasswordConfirmarcion.SelectionStart = 0;
            this.txtPasswordConfirmarcion.ShortcutsEnabled = true;
            this.txtPasswordConfirmarcion.Size = new System.Drawing.Size(246, 23);
            this.txtPasswordConfirmarcion.TabIndex = 53;
            this.txtPasswordConfirmarcion.UseSelectable = true;
            this.txtPasswordConfirmarcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordConfirmarcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(257, 297);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(246, 42);
            this.lblError.TabIndex = 55;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPasswordConfirmarcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Name = "CambiarContraseña";
            this.Size = new System.Drawing.Size(764, 586);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtPasswordConfirmarcion;
        private System.Windows.Forms.Label lblError;
    }
}
