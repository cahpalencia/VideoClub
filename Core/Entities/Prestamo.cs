using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int IdCliente { get; set; }
        public int IdSucursal { get; set; }
        public int IdPelicula { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public bool PendienteDevolucion { get; set; }
    }

}
