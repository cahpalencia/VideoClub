using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Encargado
    {
        public int IdEncargado { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Persona Persona { get; set; }
    }

}
