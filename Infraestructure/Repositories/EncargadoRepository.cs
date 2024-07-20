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
    public class EncargadoRepository : IEncargadoRepository
    {
        private readonly UnedDbContext _context;

        public EncargadoRepository(UnedDbContext context)
        {
            _context = context;
        }
        public async Task AddEncargadoAsync(Encargado encargado)
        {
            _context.Persona.Add(encargado.Persona);
            _context.Encargado.Add(encargado);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEncargadoAsync(int id)
        {
            var encargado = _context.Encargado.Find(id);
            _context.Persona.Remove(encargado.Persona);
            _context.Encargado.Remove(encargado);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Encargado>> GetAllEncargadosAsync()
        {
            var encargados = await _context.Encargado.AsNoTracking().ToListAsync();
            foreach (var encargado in encargados)
            {
                encargado.Persona = await _context.Persona.AsNoTracking().FirstAsync(p => p.Identificacion== encargado.Identificacion);
            }
            return encargados;
        }

        public async Task<Encargado> GetEncargadoByIdAsync(int id)
        {
            var encargado = _context.Encargado.Find(id);
            encargado.Persona = await _context.Persona.AsNoTracking().FirstAsync(p => p.Identificacion == encargado.Identificacion);
            return encargado;
        }

        public async Task UpdateEncargadoAsync(Encargado encargado)
        {
            _context.ChangeTracker.Clear();
            _context.Encargado.Update(encargado);
            _context.Persona.Update(encargado.Persona);
            await _context.SaveChangesAsync();
        }
    }
}
