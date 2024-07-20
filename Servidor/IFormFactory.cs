using Servidor;
using Servidor.Forms;

public interface IFormFactory
{
    Categoria CreateCategoriaForm();
    Pelicula CreatePeliculaForm();
    Encargado CreateEncargadoForm();
    Sucursales CreateSucursalForm();
    Clientes CreateClienteForm();
    SucursalPelicula CreateSucursalPeliculaForm();
    Eventos CreateEventosForm();
    RecepcionPelicula CreateRecepcionPeliculaForm();

    // Add methods for other forms
}
