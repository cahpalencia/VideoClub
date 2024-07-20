using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly UnedDbContext _dbContext;
        public CategoriaRepository(UnedDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddCategoriaAsync(CategoriaPelicula categoria)
        {
            _dbContext.CategoriaPelicula.Add(categoria);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCategoriaAsync(int id)
        {
            var categoria = _dbContext.CategoriaPelicula.Find(id);
            _dbContext.CategoriaPelicula.Remove(categoria);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<CategoriaPelicula>> GetAllCategoriasAsync()
        {
            var categorias = new List<CategoriaPelicula>();
            categorias = await _dbContext.CategoriaPelicula.AsNoTracking().ToListAsync();
            return categorias;
        }

        public async Task<CategoriaPelicula> GetCategoriaByIdAsync(int id)
        {
            return await _dbContext.CategoriaPelicula.FirstAsync(m => m.IdCategoria == id);
        }

        public async Task UpdateCategoriaAsync(CategoriaPelicula categoria)
        {
            _dbContext.ChangeTracker.Clear();
            _dbContext.Update(categoria);
            await _dbContext.SaveChangesAsync();
        }
    }
}
