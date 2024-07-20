using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTOs;
using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
namespace Infraestructure.Repositories
{
    public class PrestamoRepositoryDATA: IPrestamoRepository
    {
        private readonly UnedDbContext _context;
        public PrestamoRepositoryDATA(UnedDbContext context)
        {
            _context = context;
        }
        public async Task<Prestamo> AddPrestamoAsync(Prestamo prestamo)
        {
            if(prestamo.IdPrestamo == 0)
            {
               prestamo.IdPrestamo = _context.Prestamo.Max(p => p.IdPrestamo) + 1;
            }
            _context.PeliculasSucursal.Where(
                m=>m.IdSucursal == prestamo.IdSucursal && 
                m.IdPelicula == prestamo.IdPelicula).First().Cantidad -= 1;
            _context.Prestamo.Add(prestamo);
            await _context.SaveChangesAsync();
            return prestamo;
        }

        public async Task<List<PeliculaPrestamoDTO>> GetAllDisponibleBySucursalAsync(int idSucursal)
        {
            var peliculas = await _context.Pelicula.AsNoTracking().ToListAsync();
            var categorias = await _context.CategoriaPelicula.AsNoTracking().ToListAsync();
            var peliculasSucursal = await _context.PeliculasSucursal.AsNoTracking().Where(p => p.IdSucursal == idSucursal).ToListAsync();

            var peliculasDisponibles = peliculasSucursal
                .Where(ps => ps.IdSucursal == idSucursal && ps.Cantidad > 0)
                .Join(peliculas, ps => ps.IdPelicula, p => p.IdPelicula, (ps, p) => new { p, ps.Cantidad })
                .Join(categorias, p => p.p.IdCategoria, c => c.IdCategoria, (p, c) => new PeliculaPrestamoDTO
                {
                    IdPelicula = p.p.IdPelicula,
                    idSucursal = idSucursal,
                    Titulo = p.p.Titulo,
                    Categoria = c.NombreCategoria,
                    Existencias = p.Cantidad
                }).ToList();
            return peliculasDisponibles;
        }

        public async Task<List<Sucursal>> GetAllSucursal()
        {
            return await _context.Sucursal.AsNoTracking().ToListAsync();
        }

        public async Task DeletePrestamoAsync(int id)
        {
            var prestamo = _context.Prestamo.Find(id);
            _context.Prestamo.Remove(prestamo);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Prestamo>> GetAllPrestamosAsync()
        {
            var prestamos = await _context.Prestamo.AsNoTracking().ToListAsync();
            return prestamos;
        }

        public async Task<Prestamo> GetPrestamoByIdAsync(int id)
        {
            return await _context.Prestamo.FindAsync(id);
        }

        public async Task<Prestamo> UpdatePrestamoAsync(Prestamo prestamo)
        {
            var prestamos = await _context.Prestamo.AsNoTracking().ToListAsync();
            if(prestamos.First(m=>m.IdPrestamo == prestamo.IdPrestamo).PendienteDevolucion == true && prestamo.PendienteDevolucion == false)
            {
                var pelisSucursal = await _context.PeliculasSucursal.Where(m => m.IdSucursal == prestamo.IdSucursal && m.IdPelicula == prestamo.IdPelicula).FirstAsync();
                pelisSucursal.Cantidad += 1;
                _context.PeliculasSucursal.Update(pelisSucursal);
            }
            _context.Prestamo.Update(prestamo);
            await _context.SaveChangesAsync();
            return prestamo;
        }

        public async Task<List<PrestamosDTO>> GetPrestamosByCliente(int idCliente)
        {
            var prestamos = await _context.Prestamo.AsNoTracking().Where(p => p.IdCliente == idCliente).ToListAsync();
            var peliculas = await _context.Pelicula.AsNoTracking().ToListAsync();
            var categorias = await _context.CategoriaPelicula.AsNoTracking().ToListAsync();
            var sucursales = await _context.Sucursal.AsNoTracking().ToListAsync();
            
            var prestamosResult = prestamos.Join(peliculas, p => p.IdPelicula, pel => pel.IdPelicula, (p, pel) => new { p, pel })
                .Join(categorias, p => p.pel.IdCategoria, c => c.IdCategoria, (p, c) => new { p, c })
                .Join(sucursales, p => p.p.p.IdSucursal, s => s.IdSucursal, (p, s) => new PrestamosDTO
                {
                    idPrestamo = p.p.p.IdPrestamo,
                    idCliente = p.p.p.IdCliente,
                    Pelicula = p.p.pel.Titulo,
                    Categoria = p.c.NombreCategoria,
                    Sucursal = s.Nombre,
                    FechaPrestamo = p.p.p.FechaPrestamo,
                    Devuelto = p.p.p.PendienteDevolucion
                }).ToList();
            return prestamosResult;
        }

        public async Task<ClienteDTO> GetClienteByIdentificacion(string identificacion)
        {
            
            if(_context.Cliente.Any(m => m.Identificacion == identificacion) == false)
            {
                throw new Exception("Cliente no encontrado");
            }
            var cliente = await _context.Cliente.AsNoTracking().FirstAsync(m => m.Identificacion == identificacion);
            cliente.Persona = await _context.Persona.AsNoTracking().FirstAsync(m => m.Identificacion == cliente.Identificacion);
            var personaDTO = new ClienteDTO
            {
                IdCliente = cliente.IdCliente,
                Identificacion = cliente.Identificacion,
                Nombre = cliente.Persona.Nombre,
                PrimerApellido = cliente.Persona.PrimerApellido,
                SegundoApellido = cliente.Persona.SegundoApellido,
                FechaNacimiento = cliente.Persona.FechaNacimiento,
                Activo = cliente.Activo
            };
            return personaDTO;
        }
    }
}
