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
            this.buttonDetectarCapitulos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBoxPrologo = new System.Windows.Forms.CheckBox();
            this.checkBoxEpilogo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSeleccionarFichero
            // 
            this.buttonSeleccionarFichero.Location = new System.Drawing.Point(287, 12);
            this.buttonSeleccionarFichero.Name = "buttonSeleccionarFichero";
            this.buttonSeleccionarFichero.Size = new System.Drawing.Size(131, 20);
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
            // buttonDetectarCapitulos
            // 
            this.buttonDetectarCapitulos.Location = new System.Drawing.Point(12, 77);
            this.buttonDetectarCapitulos.Name = "buttonDetectarCapitulos";
            this.buttonDetectarCapitulos.Size = new System.Drawing.Size(159, 23);
            this.buttonDetectarCapitulos.TabIndex = 2;
            this.buttonDetectarCapitulos.Text = "Detectar Capitulos";
            this.buttonDetectarCapitulos.UseVisualStyleBackColor = true;
            this.buttonDetectarCapitulos.Click += new System.EventHandler(this.buttonDetectarCapitulos_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(177, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 251);
            this.listBox1.TabIndex = 3;
            // 
            // checkBoxPrologo
            // 
            this.checkBoxPrologo.AutoSize = true;
            this.checkBoxPrologo.Location = new System.Drawing.Point(12, 106);
            this.checkBoxPrologo.Name = "checkBoxPrologo";
            this.checkBoxPrologo.Size = new System.Drawing.Size(62, 17);
            this.checkBoxPrologo.TabIndex = 4;
            this.checkBoxPrologo.Text = "Prologo";
            this.checkBoxPrologo.UseVisualStyleBackColor = true;
            // 
            // checkBoxEpilogo
            // 
            this.checkBoxEpilogo.AutoSize = true;
            this.checkBoxEpilogo.Location = new System.Drawing.Point(110, 106);
            this.checkBoxEpilogo.Name = "checkBoxEpilogo";
            this.checkBoxEpilogo.Size = new System.Drawing.Size(61, 17);
            this.checkBoxEpilogo.TabIndex = 5;
            this.checkBoxEpilogo.Text = "Epilogo";
            this.checkBoxEpilogo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Crear archivos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxEpilogo);
            this.Controls.Add(this.checkBoxPrologo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonDetectarCapitulos);
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
        private System.Windows.Forms.Button buttonDetectarCapitulos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBoxPrologo;
        private System.Windows.Forms.CheckBox checkBoxEpilogo;
        private System.Windows.Forms.Button button1;
    }
}

