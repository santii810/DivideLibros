using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideLibros
{
    class GestorFicheros
    {
        FileStream fich;
        public string nombreFichero { get; set; }

        public bool abrirFichero(string ruta)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    fich = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public List<string> leerLineas()
        {
            if (abrirFichero(nombreFichero))
            {
                List<string> retorno = new List<string>();
                StreamReader lector = new StreamReader(fich, Encoding.Default, true);
                while (!lector.EndOfStream)
                    retorno.Add(lector.ReadLine());
                lector.Close();
                return retorno;
            }
            return null;
        }
    }
}