namespace RHA.Forms.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkOlvide = new MetroFramework.Controls.MetroLink();
            this.lblCorreoInválido = new System.Windows.Forms.Label();
            this.lblNoCorreo = new System.Windows.Forms.Label();
            this.lblFaltaCorreo = new System.Windows.Forms.Label();
            this.lblFaltanCampos = new System.Windows.Forms.Label();
            this.lblLogoProdus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 38);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(362, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 33);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Bienvenido!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo Electrónico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleDescription = "d";
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(88, 224);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(209, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(88, 332);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(209, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(88, 415);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(209, 43);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkOlvide
            // 
            this.linkOlvide.Location = new System.Drawing.Point(88, 485);
            this.linkOlvide.Name = "linkOlvide";
            this.linkOlvide.Size = new System.Drawing.Size(209, 23);
            this.linkOlvide.TabIndex = 7;
            this.linkOlvide.Text = "Olvide la contraseña";
            this.linkOlvide.UseSelectable = true;
            this.linkOlvide.Visible = false;
            this.linkOlvide.Click += new System.EventHandler(this.linkOlvide_Click);
            // 
            // lblCorreoInválido
            // 
            this.lblCorreoInválido.AutoSize = true;
            this.lblCorreoInválido.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoInválido.ForeColor = System.Drawing.Color.Brown;
            this.lblCorreoInválido.Location = new System.Drawing.Point(73, 274);
            this.lblCorreoInválido.Name = "lblCorreoInválido";
            this.lblCorreoInválido.Size = new System.Drawing.Size(251, 15);
            this.lblCorreoInválido.TabIndex = 9;
            this.lblCorreoInválido.Text = "Correo Electrónico o Contraseña Incorrecto";
            // 
            // lblNoCorreo
            // 
            this.lblNoCorreo.AutoSize = true;
            this.lblNoCorreo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCorreo.ForeColor = System.Drawing.Color.Brown;
            this.lblNoCorreo.Location = new System.Drawing.Point(108, 250);
            this.lblNoCorreo.Name = "lblNoCorreo";
            this.lblNoCorreo.Size = new System.Drawing.Size(184, 15);
            this.lblNoCorreo.TabIndex = 10;
            this.lblNoCorreo.Text = "Esto no es un correo electrónico";
            // 
            // lblFaltaCorreo
            // 
            this.lblFaltaCorreo.AutoSize = true;
            this.lblFaltaCorreo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaCorreo.ForeColor = System.Drawing.Color.Brown;
            this.lblFaltaCorreo.Location = new System.Drawing.Point(92, 250);
            this.lblFaltaCorreo.Name = "lblFaltaCorreo";
            this.lblFaltaCorreo.Size = new System.Drawing.Size(218, 15);
            this.lblFaltaCorreo.TabIndex = 11;
            this.lblFaltaCorreo.Text = "Por favor escriba el correo electrónico";
            // 
            // lblFaltanCampos
            // 
            this.lblFaltanCampos.AutoSize = true;
            this.lblFaltanCampos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltanCampos.ForeColor = System.Drawing.Color.Brown;
            this.lblFaltanCampos.Location = new System.Drawing.Point(108, 358);
            this.lblFaltanCampos.Name = "lblFaltanCampos";
            this.lblFaltanCampos.Size = new System.Drawing.Size(182, 15);
            this.lblFaltanCampos.TabIndex = 12;
            this.lblFaltanCampos.Text = "Por favor escriba la contraseña";
            // 
            // lblLogoProdus
            // 
            this.lblLogoProdus.Image = ((System.Drawing.Image)(resources.GetObject("lblLogoProdus.Image")));
            this.lblLogoProdus.Location = new System.Drawing.Point(88, 30);
            this.lblLogoProdus.Name = "lblLogoProdus";
            this.lblLogoProdus.Size = new System.Drawing.Size(228, 127);
            this.lblLogoProdus.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFaltanCampos);
            this.Controls.Add(this.lblCorreoInválido);
            this.Controls.Add(this.linkOlvide);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFaltaCorreo);
            this.Controls.Add(this.lblNoCorreo);
            this.Controls.Add(this.lblLogoProdus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private MetroFramework.Controls.MetroLink linkOlvide;
        private System.Windows.Forms.Label lblCorreoInválido;
        private System.Windows.Forms.Label lblNoCorreo;
        private System.Windows.Forms.Label lblFaltaCorreo;
        private System.Windows.Forms.Label lblFaltanCampos;
        private System.Windows.Forms.Label lblLogoProdus;
    }
}
