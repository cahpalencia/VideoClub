using Core.Services;
using Servidor;
using Servidor.Forms;

public class FormFactory : IFormFactory
{
    private readonly ICategoriaService _categoriaService;
    private readonly IPeliculaService _peliculaService;
    private readonly IEncargadoService _encargadoService;
    private readonly ISucursalService _sucursalService;
    private readonly IClienteService _clienteService;
    private readonly IPeliculasSucursalService _peliculasSucursalService;
    private readonly IPrestamoService _prestamoService;

    public FormFactory(
        ICategoriaService categoriaService,            
        IPeliculaService peliculaService,
        IEncargadoService encargadoService,
        ISucursalService sucursalService,
        IClienteService clienteService,
        IPeliculasSucursalService peliculasSucursalService,
        IPrestamoService prestamoService)
    {
        _categoriaService = categoriaService;
        _peliculaService = peliculaService;
        _encargadoService = encargadoService;
        _sucursalService = sucursalService;
        _clienteService = clienteService;
        _peliculasSucursalService = peliculasSucursalService;
        _prestamoService=prestamoService;
    }

    public Categoria CreateCategoriaForm()
    {
        return new Categoria(_categoriaService);
    }
    public Clientes CreateClienteForm()
    {
        return new Clientes(_clienteService);
    }
    public Encargado CreateEncargadoForm()
    {
        return new Encargado(_encargadoService);
    }

    public Eventos CreateEventosForm()
    {
        return new Eventos(
            _sucursalService,
            _prestamoService
            );
    }

    public Pelicula CreatePeliculaForm()
    {
        return new Pelicula(_categoriaService, _peliculaService);
    }

    public RecepcionPelicula CreateRecepcionPeliculaForm()
    {
        return new RecepcionPelicula(_prestamoService, _clienteService);
    }

    public Sucursales CreateSucursalForm()
    {
        return new Sucursales(_sucursalService, _encargadoService);
    }
    public SucursalPelicula CreateSucursalPeliculaForm()
    {
        return new SucursalPelicula(_peliculasSucursalService, _sucursalService, _peliculaService);
    }
}
