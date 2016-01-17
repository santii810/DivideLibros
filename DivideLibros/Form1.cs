using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivideLibros
{
    public partial class Form1 : Form
    {

        GestorFicheros gestor = new GestorFicheros();
        List<string> lineasLibro = new List<string>();
        List<Capitulo> capitulos = new List<Capitulo>();

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
                FileInfo fichero = new FileInfo(ofd.FileName);
                this.textBoxFichero.Text = fichero.Name;
                gestor.nombreFichero = fichero.FullName;

            }
        }

        private void buttonDetectarCapitulos_Click(object sender, EventArgs e)
        {
            lineasLibro = gestor.leerLineas();
            if (checkBoxPrologo.Checked)
            {
                int cont = 0;

                foreach (string item in lineasLibro)
                {


                    if (prepareToCompareString(item).Equals("PROLOGO"))
                    {
                        lineasLibro.RemoveRange(0, cont - 1);
                        capitulos.Add(new Capitulo
                        {
                            nombre = "00_PROLOGO",
                            lineaInicio = 0
                        });
                        break;
                    }
                    cont++;

                }

            }
            int j;
            for (int i = 0; i < lineasLibro.Count; i++)
            {
                string linea = lineasLibro[i];
                if (int.TryParse(linea.Trim(), out j))
                {
                    if (capitulos.Count != 0) capitulos.Last().lineaFin = i - 1;
                    capitulos.Add(new Capitulo
                    {
                        nombre = linea,
                        lineaInicio = i
                    });


                }

            }


            if (checkBoxEpilogo.Checked)
            {
                for (int i = capitulos.Last().lineaInicio; i < lineasLibro.Count; i++)
                {
                    if (prepareToCompareString(lineasLibro[i]).Equals("EPILOGO"))
                    {
                        if (capitulos.Count != 0) capitulos.Last().lineaFin = i - 1;
                        capitulos.Add(new Capitulo
                        {
                            nombre = "EPILOGO",
                            lineaInicio = i,
                            lineaFin = lineasLibro.Count
                        });
                        break;
                    }
                }
            }

            if (capitulos.Last().lineaFin == 0) capitulos.Last().lineaFin = lineasLibro.Count;
            this.listBox1.DataSource = capitulos.Select(k => k.nombre).ToList();
        }




        private string prepareToCompareString(string s)
        {
            Regex replace_a_Accents = new Regex("[á|à|ä|â]", RegexOptions.Compiled);
            Regex replace_e_Accents = new Regex("[é|è|ë|ê]", RegexOptions.Compiled);
            Regex replace_i_Accents = new Regex("[í|ì|ï|î]", RegexOptions.Compiled);
            Regex replace_o_Accents = new Regex("[ó|ò|ö|ô]", RegexOptions.Compiled);
            Regex replace_u_Accents = new Regex("[ú|ù|ü|û]", RegexOptions.Compiled);
            s = replace_a_Accents.Replace(s, "a");
            s = replace_e_Accents.Replace(s, "e");
            s = replace_i_Accents.Replace(s, "i");
            s = replace_o_Accents.Replace(s, "o");
            s = replace_u_Accents.Replace(s, "u");
            s = s.ToUpper().Replace(" ", "");
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Capitulo item in capitulos)
            {
                gestor.agregar(item.nombre, lineasLibro.GetRange(item.lineaInicio, (item.lineaFin - item.lineaInicio)));
            }
        }
    }
}
