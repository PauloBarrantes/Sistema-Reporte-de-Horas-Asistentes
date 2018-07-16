namespace RHA.Forms.Asistentes
{
    partial class BalanceHorasAs
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
            this.lblmsjBalance = new System.Windows.Forms.Label();
            this.dgvAsistentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmsjBalance
            // 
            this.lblmsjBalance.AutoSize = true;
            this.lblmsjBalance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsjBalance.Location = new System.Drawing.Point(28, 23);
            this.lblmsjBalance.Name = "lblmsjBalance";
            this.lblmsjBalance.Size = new System.Drawing.Size(285, 33);
            this.lblmsjBalance.TabIndex = 3;
            this.lblmsjBalance.Text = "Mi Balance de Horas";
            // 
            // dgvAsistentes
            // 
            this.dgvAsistentes.AllowUserToAddRows = false;
            this.dgvAsistentes.AllowUserToDeleteRows = false;
            this.dgvAsistentes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAsistentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistentes.Location = new System.Drawing.Point(34, 81);
            this.dgvAsistentes.Name = "dgvAsistentes";
            this.dgvAsistentes.ReadOnly = true;
            this.dgvAsistentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAsistentes.RowHeadersWidth = 50;
            this.dgvAsistentes.Size = new System.Drawing.Size(698, 474);
            this.dgvAsistentes.TabIndex = 9;
            // 
            // BalanceHorasAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAsistentes);
            this.Controls.Add(this.lblmsjBalance);
            this.Name = "BalanceHorasAs";
            this.Size = new System.Drawing.Size(764, 586);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmsjBalance;
        private System.Windows.Forms.DataGridView dgvAsistentes;
    }
}
