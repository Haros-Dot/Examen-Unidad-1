namespace ExamenU
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnincrementar = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnincrementar
            // 
            this.btnincrementar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnincrementar.Location = new System.Drawing.Point(66, 94);
            this.btnincrementar.Name = "btnincrementar";
            this.btnincrementar.Size = new System.Drawing.Size(75, 75);
            this.btnincrementar.TabIndex = 0;
            this.btnincrementar.Text = "+1";
            this.btnincrementar.UseVisualStyleBackColor = true;
            this.btnincrementar.Click += new System.EventHandler(this.btnincrementar_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(189, 94);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 75);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "-1";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(105, 50);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(105, 20);
            this.pantalla.TabIndex = 2;
            this.pantalla.Text = "0";
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 220);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnincrementar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen U1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnincrementar;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox pantalla;
    }
}

