using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideLibros
{
    class Capitulo
    {
        public string nombre { get; set; }
        public int lineaInicio { get; set; }
        public int lineaFin { get; set; }
    }

    class TipoDeteccion
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }

    class Repositorios
    {
        static public List<TipoDeteccion> getTipoDetecciones()
        {
            List<TipoDeteccion> retorno = new List<TipoDeteccion>();
            retorno.Add(new TipoDeteccion { nombre = "PROLOGO + Solo numeros",
                descripcion = "Esta detecta el progolo y el epilogo si estan situados en el inicio y el final respectivamente. Por otro lado detectara como capitulos las lineas que tengan solamente un  numero."});
            return retorno;
        }
    }
}
