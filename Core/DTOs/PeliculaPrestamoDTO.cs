using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class PeliculaPrestamoDTO
    {
        public int idPrestamo { get; set; }
        public int IdPelicula { get; set; }
        public int idSucursal { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public int Existencias { get; set; }
    }
}
