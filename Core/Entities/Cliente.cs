using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
        public Persona Persona { get; set; }
    }

}
