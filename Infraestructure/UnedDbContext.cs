using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure
{
    public class UnedDbContext : DbContext
    {
        public UnedDbContext(DbContextOptions<UnedDbContext> options)
            : base(options)
        {

        }

        public DbSet<Sucursal> Sucursal { get; set; }
        public DbSet<Encargado> Encargado { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<CategoriaPelicula> CategoriaPelicula { get; set; }
        public DbSet<Pelicula> Pelicula { get; set; }
        public DbSet<PeliculasSucursal> PeliculasSucursal { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<PeliculasSucursal>()
                .HasKey(ps => new { ps.IdSucursal, ps.IdPelicula });

            modelBuilder.Entity<Sucursal>().HasKey(s => s.IdSucursal);
            modelBuilder.Entity<Encargado>().Ignore(m=>m.Persona).HasKey(e => e.IdEncargado);
            modelBuilder.Entity<Persona>().HasKey(p => p.Identificacion);
            modelBuilder.Entity<Cliente>().Ignore(m=>m.Persona).HasKey(c => c.IdCliente);
            modelBuilder.Entity<CategoriaPelicula>().HasKey(cp => cp.IdCategoria);
            modelBuilder.Entity<Pelicula>().HasKey(p => p.IdPelicula);
            modelBuilder.Entity<Prestamo>().HasKey(pr => pr.IdPrestamo);    
            
        }
    }
}
