namespace RHA.Forms.Administrador
{
    partial class ListaBalance
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
            this.components = new System.ComponentModel.Container();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.dB_BYTEMEDataSet = new RHA.DB_BYTEMEDataSet();
            this.dBBYTEMEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dB_BYTEMEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBYTEMEDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lblBienvenido.Location = new System.Drawing.Point(37, 28);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(258, 33);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Balance Asistentes";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dB_BYTEMEDataSet
            // 
            this.dB_BYTEMEDataSet.DataSetName = "DB_BYTEMEDataSet";
            this.dB_BYTEMEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBBYTEMEDataSetBindingSource
            // 
            this.dBBYTEMEDataSetBindingSource.DataSource = this.dB_BYTEMEDataSet;
            this.dBBYTEMEDataSetBindingSource.Position = 0;
            // 
            // ListaBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBienvenido);
            this.Name = "ListaBalance";
            this.Size = new System.Drawing.Size(672, 539);
            ((System.ComponentModel.ISupportInitialize)(this.dB_BYTEMEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBYTEMEDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.BindingSource dBBYTEMEDataSetBindingSource;
        private DB_BYTEMEDataSet dB_BYTEMEDataSet;
    }
}
