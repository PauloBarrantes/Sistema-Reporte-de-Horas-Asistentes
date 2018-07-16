namespace RHA.Forms.Asistentes
{
    partial class InicioAs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioAs));
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblHorasAcumuladas = new System.Windows.Forms.Label();
            this.sgProgreso = new LiveCharts.WinForms.SolidGauge();
            this.lblGirl = new System.Windows.Forms.Label();
            this.lblMen = new System.Windows.Forms.Label();
            this.lblperiodo = new System.Windows.Forms.Label();
            this.lblSemanaActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(46, 34);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(183, 33);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "¡Bienvenido!";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNombre.Location = new System.Drawing.Point(48, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 23);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblCarrera.Location = new System.Drawing.Point(48, 131);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(96, 23);
            this.lblCarrera.TabIndex = 5;
            this.lblCarrera.Text = "Carrera: ";
            // 
            // lblHorasAcumuladas
            // 
            this.lblHorasAcumuladas.AutoSize = true;
            this.lblHorasAcumuladas.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblHorasAcumuladas.Location = new System.Drawing.Point(48, 175);
            this.lblHorasAcumuladas.Name = "lblHorasAcumuladas";
            this.lblHorasAcumuladas.Size = new System.Drawing.Size(202, 23);
            this.lblHorasAcumuladas.TabIndex = 7;
            this.lblHorasAcumuladas.Text = "Horas Acumuladas:";
            // 
            // sgProgreso
            // 
            this.sgProgreso.Location = new System.Drawing.Point(439, 313);
            this.sgProgreso.Name = "sgProgreso";
            this.sgProgreso.Size = new System.Drawing.Size(297, 226);
            this.sgProgreso.TabIndex = 12;
            this.sgProgreso.Text = "GG";
            // 
            // lblGirl
            // 
            this.lblGirl.Image = ((System.Drawing.Image)(resources.GetObject("lblGirl.Image")));
            this.lblGirl.Location = new System.Drawing.Point(533, 19);
            this.lblGirl.Name = "lblGirl";
            this.lblGirl.Size = new System.Drawing.Size(141, 167);
            this.lblGirl.TabIndex = 13;
            // 
            // lblMen
            // 
            this.lblMen.Image = ((System.Drawing.Image)(resources.GetObject("lblMen.Image")));
            this.lblMen.Location = new System.Drawing.Point(533, 19);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(141, 167);
            this.lblMen.TabIndex = 14;
            // 
            // lblperiodo
            // 
            this.lblperiodo.AutoSize = true;
            this.lblperiodo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblperiodo.Location = new System.Drawing.Point(48, 222);
            this.lblperiodo.Name = "lblperiodo";
            this.lblperiodo.Size = new System.Drawing.Size(163, 23);
            this.lblperiodo.TabIndex = 15;
            this.lblperiodo.Text = "Período Actual:";
            // 
            // lblSemanaActual
            // 
            this.lblSemanaActual.AutoSize = true;
            this.lblSemanaActual.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblSemanaActual.Location = new System.Drawing.Point(48, 265);
            this.lblSemanaActual.Name = "lblSemanaActual";
            this.lblSemanaActual.Size = new System.Drawing.Size(169, 23);
            this.lblSemanaActual.TabIndex = 16;
            this.lblSemanaActual.Text = "Semana Actual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(77, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Progreso de la Semana:";
            // 
            // InicioAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSemanaActual);
            this.Controls.Add(this.lblperiodo);
            this.Controls.Add(this.lblGirl);
            this.Controls.Add(this.sgProgreso);
            this.Controls.Add(this.lblHorasAcumuladas);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblMen);
            this.Name = "InicioAs";
            this.Size = new System.Drawing.Size(764, 586);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblHorasAcumuladas;
        private LiveCharts.WinForms.SolidGauge sgProgreso;
        private System.Windows.Forms.Label lblGirl;
        private System.Windows.Forms.Label lblMen;
        private System.Windows.Forms.Label lblperiodo;
        private System.Windows.Forms.Label lblSemanaActual;
        private System.Windows.Forms.Label label1;
    }
}
