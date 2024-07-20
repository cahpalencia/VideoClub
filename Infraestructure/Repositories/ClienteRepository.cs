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
    public class ClienteRepository: IClienteRepository
    {
        private readonly UnedDbContext _context;
        public ClienteRepository(UnedDbContext context)
        {
            _context = context;
        }
        public async Task AddClienteAsync(Cliente cliente)
        {
            _context.Persona.Add(cliente.Persona);
            await _context.SaveChangesAsync();
            _context.Cliente.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClienteAsync(int id)
        {
            var cliente = _context.Cliente.Find(id);
            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Cliente>> GetAllClientesAsync()
        {
            var clientes = await _context.Cliente.AsNoTracking().ToListAsync();
            foreach (var cliente in clientes)
            {
                cliente.Persona = await _context.Persona.AsNoTracking().FirstAsync(m => m.Identificacion == cliente.Identificacion);
            }
            return clientes;
        }

        public async Task<Cliente> GetClienteByIdAsync(int id)
        {
            return await _context.Cliente.AsNoTracking().FirstAsync(m => m.IdCliente == id);
        }

        public async Task<ClienteDTO> GetUserByIdentificacion(string identificacion)
        {
            var cliente = await _context.Cliente.AsNoTracking().FirstAsync(m => m.Identificacion == identificacion);
            var personaDTO = new ClienteDTO
            {
                IdCliente = cliente.IdCliente,
                Identificacion = cliente.Identificacion,
                Nombre = cliente.Persona.Nombre,
                PrimerApellido = cliente.Persona.PrimerApellido,
                SegundoApellido = cliente.Persona.SegundoApellido,
                FechaNacimiento = cliente.Persona.FechaNacimiento
            };
            return personaDTO;
        }

        public async Task UpdateClienteAsync(Cliente cliente)
        {
            _context.ChangeTracker.Clear();
            _context.Persona.Update(cliente.Persona);
            _context.Cliente.Update(cliente);
            await _context.SaveChangesAsync();
        }
    }
}
