using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    
    public class PeliculaRepository : IPeliculaRepository
    {
        private readonly UnedDbContext _context;
        public PeliculaRepository(UnedDbContext context)
        {
            _context = context;
        }
        public async Task AddPeliculaAsync(Pelicula pelicula)
        {
            _context.Pelicula.Add(pelicula);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePeliculaAsync(int id)
        {
            var pelicula = _context.Pelicula.Find(id);
            _context.Pelicula.Remove(pelicula);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Pelicula>> GetAllPeliculasAsync()
        {
            _context.ChangeTracker.Clear(); 
            return await _context.Pelicula.AsNoTracking().ToListAsync();
        }

        public async Task<List<Pelicula>> GetAllPeliculasByCategoriaAsync(int categoria)
        {
            return await _context.Pelicula.AsNoTracking().Where(m=>m.IdCategoria == categoria).ToListAsync();
        }

        public async Task<Pelicula> GetPeliculaByIdAsync(int id)
        {
            return await _context.Pelicula.FindAsync(id);
        }

        public async Task UpdatePeliculaAsync(Pelicula pelicula)
        {
            _context.ChangeTracker.Clear();
            _context.Pelicula.Update(pelicula);
            await _context.SaveChangesAsync();
        }
    }
}
