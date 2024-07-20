using Cliente.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Services;

namespace Cliente
{
    public interface IFormFactory
    {
        NuevoPrestamo CreateNuevoPrestamoForm();
        MisPrestamos CreateMisPrestamosForm();
        Login CreateLoginForm();
    }
}
