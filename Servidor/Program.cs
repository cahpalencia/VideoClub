using Microsoft.Extensions.DependencyInjection;
using Core.Repositories;
using Core.Services;
using App.Services;
using Infraestructure.Repositories;
using Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
namespace Servidor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            //formularios
            services.AddTransient<Main>();
            //repositories
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IPeliculaRepository, PeliculaRepository>();
            services.AddScoped<IEncargadoRepository, EncargadoRepository>();
            services.AddScoped<ISucursalRepository, SucursalRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IPeliculasSucursalRepository, PeliculasSucursalReposotory>();
            services.AddScoped<IPrestamoRepository,PrestamoRepositoryDATA>();
            //services
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IPeliculaService, PeliculaService>();
            services.AddScoped<IEncargadoService, EncargadoService>();
            services.AddScoped<ISucursalService, SucursalService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IPeliculasSucursalService, PeliculasSucursalService>();
            services.AddScoped<IPrestamoService, PrestamoService>();

            services.AddScoped<IFormFactory, FormFactory>();

            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            services.AddDbContext<UnedDbContext>(options =>
                options.UseSqlServer(connectionString));

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var mainForm = serviceProvider.GetRequiredService<Main>();
            Application.Run(mainForm);
        }
    }
}