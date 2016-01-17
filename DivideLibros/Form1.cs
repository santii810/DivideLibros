using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivideLibros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSeleccionarFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!String.IsNullOrEmpty(ofd.FileName))
            {
                string nombreFichero = ofd.FileName;
                FileInfo fichero = new FileInfo(nombreFichero);
                this.textBoxFichero.Text = fichero.Name;
            }
        }
    }
}
