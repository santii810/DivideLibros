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
        #region variables globales
        GestorFicheros gestor = new GestorFicheros();
        List<string> lineasLibro = new List<string>();
        List<Capitulo> capitulos = new List<Capitulo>();
        List<TipoDeteccion> detecciones = new List<TipoDeteccion>();
        FileInfo fichero;
        TipoDeteccion tipoDeteccion = new TipoDeteccion();
        #endregion

        public Form1()
        {
            InitializeComponent();
            detecciones = Repositorios.getTipoDetecciones();
            foreach (TipoDeteccion item in detecciones)
            {
                comboBox1.Items.Add(item.nombre);
            }
        }

        #region Clases privadas
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

        private void reset()
        {
            lineasLibro.Clear();
            capitulos.Clear();
            //listBox1.Items.Clear();
        }

        private bool buscarPrologo()
        {
            for (int i = 0; i < lineasLibro.Count; i++)
            {
                if (prepareToCompareString(lineasLibro[i]).Equals("PROLOGO"))
                {
                    lineasLibro.RemoveRange(0, i - 1);
                    capitulos.Add(new Capitulo { nombre = "00_PROLOGO", lineaInicio = 0 });
                    return true;
                }
            }
            return false;
        }
        private void buscarCapitulos(bool prologo)
        {
            for (int i = 0; i < lineasLibro.Count; i++)
            {
                int capi;
                if (int.TryParse(lineasLibro[i], out capi))
                {
                    if (capitulos.Count != 0) capitulos.Last().lineaFin = i - 1;
                    if (capi < 10) capitulos.Add(new Capitulo { nombre = "0" + lineasLibro[i], lineaInicio = i });
                    else capitulos.Add(new Capitulo { nombre = lineasLibro[i], lineaInicio = i });
                }
            }
        }
        private bool buscarEpilogo()
        {
            for (int i = capitulos.Last().lineaInicio; i < lineasLibro.Count; i++)
            {
                if (prepareToCompareString(lineasLibro[i]).Equals("EPILOGO"))
                {
                    if (capitulos.Count != 0) capitulos.Last().lineaFin = i - 1;
                    capitulos.Add(new Capitulo { nombre = capitulos.Count + "_EPILOGO", lineaInicio = i, lineaFin = lineasLibro.Count });
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region listeners
        private void buttonSeleccionarFichero_Click(object sender, EventArgs e)
        {
            reset();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!String.IsNullOrEmpty(ofd.FileName))
            {
                fichero = new FileInfo(ofd.FileName);
                this.textBoxFichero.Text = fichero.Name;
                gestor.nombreFichero = fichero.FullName;
                //leer todas las lineas del fichero
                lineasLibro = gestor.leerLineas();

            }
        }

        private void buttonDetectarCapitulos_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxFichero.Text))
            {
                switch (tipoDeteccion.id)
                {
                    case 1:
                        bool hayPrologo = buscarPrologo();
                        buscarCapitulos(hayPrologo);
                        if (!buscarEpilogo())
                            capitulos.Last().lineaFin = lineasLibro.Count;
                        this.listBox1.DataSource = capitulos.Select(k => k.nombre).ToList();
                        break;
                    default:
                        MessageBox.Show("Debes elegir un tipo de deteccion");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un fichero");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(fichero.Directory + @"\capitulos_" + fichero.Name);
            string directorio = fichero.Directory + @"\capitulos_" + fichero.Name + @"\";
            string prefijo = textBoxPrefijo.Text;
            foreach (Capitulo item in capitulos)
            {
                gestor.agregar(directorio + prefijo + "_" + item.nombre + ".txt", lineasLibro.GetRange(item.lineaInicio, (item.lineaFin - item.lineaInicio)));
            }
            MessageBox.Show("Ficheros generados");

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            List<string> lineasMostrar = lineasLibro.GetRange(capitulos[listBox1.SelectedIndex].lineaInicio, (capitulos[listBox1.SelectedIndex].lineaFin - capitulos[listBox1.SelectedIndex].lineaInicio));
            Texto form = new Texto(lineasMostrar);
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Rellena el tipo de deteccion
            foreach (TipoDeteccion item in detecciones)
            {
                if (item.nombre.Equals(comboBox1.SelectedItem.ToString()))
                {
                    tipoDeteccion = item;
                }
            }
        }


        #endregion

    }
}
