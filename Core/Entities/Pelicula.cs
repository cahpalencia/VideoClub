using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Pelicula
    {
        public int IdPelicula { get; set; }
        public int IdCategoria { get; set; }
        public string Titulo { get; set; }
        public int AnioLanzamiento { get; set; }
        public string Idioma { get; set; }
    }

}
