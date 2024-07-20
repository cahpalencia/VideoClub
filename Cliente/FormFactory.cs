using Cliente.Forms;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class FormFactory : IFormFactory
    {
        
        private readonly IPrestamoService _prestamoService;
        public FormFactory(
            IPrestamoService prestamoService)
        {
            _prestamoService = prestamoService;
        }

        public Login CreateLoginForm()
        {
            return new Login(_prestamoService);
        }

        public MisPrestamos CreateMisPrestamosForm()
        {
            return new MisPrestamos(_prestamoService);
        }

        public NuevoPrestamo CreateNuevoPrestamoForm()
        {
            return new NuevoPrestamo(_prestamoService);
        }
    }
}
