using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivideLibros
{
    public partial class Texto : Form
    {
        public Texto(List<string> lineas)
        {
            InitializeComponent();
            foreach (string item in lineas)
            {
                textBox1.Text = textBox1.Text +  item + "\r\n";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
