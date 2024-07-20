using App.Services;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Infraestructure;
using Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;

namespace Cliente
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            var ipServer = System.Configuration.ConfigurationManager.AppSettings["serverIp"];
            var portServer = System.Configuration.ConfigurationManager.AppSettings["serverPort"];
            var serverSettings = new TcpSettings(ipServer, portServer);
            services.AddSingleton(serverSettings);
            //formularios
            services.AddTransient<Main>();
            //repositories
            services.AddScoped<IPrestamoRepository,PrestamoRepositoryTCP>();
            //services
            services.AddScoped<IPrestamoService, PrestamoService>();
            services.AddScoped<IFormFactory, FormFactory>();


            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var mainForm = serviceProvider.GetRequiredService<Main>();
            Application.Run(mainForm);
        }
    }
}