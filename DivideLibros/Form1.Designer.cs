namespace DivideLibros
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
            this.buttonSeleccionarFichero = new System.Windows.Forms.Button();
            this.textBoxFichero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSeleccionarFichero
            // 
            this.buttonSeleccionarFichero.Location = new System.Drawing.Point(287, 12);
            this.buttonSeleccionarFichero.Name = "buttonSeleccionarFichero";
            this.buttonSeleccionarFichero.Size = new System.Drawing.Size(131, 36);
            this.buttonSeleccionarFichero.TabIndex = 0;
            this.buttonSeleccionarFichero.Text = "Seleccionar fichero";
            this.buttonSeleccionarFichero.UseVisualStyleBackColor = true;
            this.buttonSeleccionarFichero.Click += new System.EventHandler(this.buttonSeleccionarFichero_Click);
            // 
            // textBoxFichero
            // 
            this.textBoxFichero.Location = new System.Drawing.Point(12, 12);
            this.textBoxFichero.Name = "textBoxFichero";
            this.textBoxFichero.Size = new System.Drawing.Size(269, 20);
            this.textBoxFichero.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 359);
            this.Controls.Add(this.textBoxFichero);
            this.Controls.Add(this.buttonSeleccionarFichero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeleccionarFichero;
        private System.Windows.Forms.TextBox textBoxFichero;
    }
}

