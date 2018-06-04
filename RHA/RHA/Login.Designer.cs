namespace RHA
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
            this.btn_login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_emailUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblForgot = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.divider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Depth = 0;
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(147, 347);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.Primary = true;
            this.btn_login.Size = new System.Drawing.Size(120, 36);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Iniciar Sesión";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_emailUser
            // 
            this.txt_emailUser.Depth = 0;
            this.txt_emailUser.Hint = "";
            this.txt_emailUser.Location = new System.Drawing.Point(68, 182);
            this.txt_emailUser.MaxLength = 32767;
            this.txt_emailUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_emailUser.Name = "txt_emailUser";
            this.txt_emailUser.PasswordChar = '\0';
            this.txt_emailUser.SelectedText = "";
            this.txt_emailUser.SelectionLength = 0;
            this.txt_emailUser.SelectionStart = 0;
            this.txt_emailUser.Size = new System.Drawing.Size(273, 23);
            this.txt_emailUser.TabIndex = 2;
            this.txt_emailUser.TabStop = false;
            this.txt_emailUser.UseSystemPasswordChar = false;
            // 
            // txt_password
            // 
            this.txt_password.Depth = 0;
            this.txt_password.Hint = "";
            this.txt_password.Location = new System.Drawing.Point(68, 273);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(273, 23);
            this.txt_password.TabIndex = 3;
            this.txt_password.TabStop = false;
            this.txt_password.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.White;
            this.materialLabel1.Location = new System.Drawing.Point(182, 34);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 19);
            this.materialLabel1.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(161, 242);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Contraseña";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(137, 149);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(136, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Correo Electrónico";
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.Depth = 0;
            this.lblForgot.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblForgot.Location = new System.Drawing.Point(137, 411);
            this.lblForgot.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(150, 19);
            this.lblForgot.TabIndex = 8;
            this.lblForgot.Text = "Olvide mi contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "¡Bienvenido!";
            // 
            // divider1
            // 
            this.divider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.divider1.Depth = 0;
            this.divider1.Location = new System.Drawing.Point(37, 119);
            this.divider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(351, 10);
            this.divider1.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 454);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblForgot);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_emailUser);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btn_login;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_emailUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblForgot;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialDivider divider1;
    }
}

