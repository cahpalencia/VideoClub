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
    public class PeliculasSucursalReposotory : IPeliculasSucursalRepository
    {
        private readonly UnedDbContext _context;
        public PeliculasSucursalReposotory(UnedDbContext context)
        {
            _context = context;
        }
        public async Task<PeliculasSucursal> AddPeliculasSucursalAsync(PeliculasSucursal peliculasSucursal)
        {
            _context.PeliculasSucursal.Add(peliculasSucursal);
            await _context.SaveChangesAsync();    
            return peliculasSucursal;
        }

        public async Task DeletePeliculasSucursalAsync(int id)
        {
            var peliculasSucursal = _context.PeliculasSucursal.Find(id);
            _context.PeliculasSucursal.Remove(peliculasSucursal);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PeliculasSucursal>> GetAllPeliculasSucursalAsync()
        {
            _context.ChangeTracker.Clear();
            return await _context.PeliculasSucursal.AsNoTracking().ToListAsync();
        }

        public Task<PeliculasSucursal> GetPeliculasSucursalByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PeliculasSucursal> UpdatePeliculasSucursalAsync(PeliculasSucursal peliculasSucursal)
        {
            _context.ChangeTracker.Clear();
            _context.PeliculasSucursal.Update(peliculasSucursal);
            await _context.SaveChangesAsync();
            return peliculasSucursal;
        }
    }
}
