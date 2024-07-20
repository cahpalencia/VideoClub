using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class PrestamosDTO
    {
        public int idPrestamo { get; set; }
        public int idCliente { get; set; }
        public string Pelicula { get; set; }
        public string Categoria { get; set; }
        public string  Sucursal { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public bool Devuelto { get; set; }
    }
}
