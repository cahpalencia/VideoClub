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
    
    public class SucursalRepository : ISucursalRepository
    {
        private readonly UnedDbContext _context;
        public SucursalRepository(UnedDbContext context)
        {
            _context = context;
        }
        public async Task<Sucursal> AddSucursalAsync(Sucursal sucursal)
        {
            _context.Sucursal.Add(sucursal);
            await _context.SaveChangesAsync();
            return sucursal;
        }

        public async Task DeleteSucursalAsync(int id)
        {
            var sucursal = _context.Sucursal.Find(id);
            _context.Sucursal.Remove(sucursal);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Sucursal>> GetAllSucursalesAsync()
        {
            return await _context.Sucursal.AsNoTracking().ToListAsync();
        }

        public async Task<Sucursal> GetSucursalByIdAsync(int id)
        {
            return await _context.Sucursal.FindAsync(id);
        }

        public async Task<Sucursal> UpdateSucursalAsync(Sucursal sucursal)
        {
            _context.ChangeTracker.Clear();
            _context.Sucursal.Update(sucursal);
            await _context.SaveChangesAsync();
            return sucursal;
        }
    }
}
