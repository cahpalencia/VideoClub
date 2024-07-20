using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Repositories
{
    public interface IEncargadoRepository
    {
        Task<List<Encargado>> GetAllEncargadosAsync();
        Task<Encargado> GetEncargadoByIdAsync(int id);
        Task AddEncargadoAsync(Encargado encargado);
        Task UpdateEncargadoAsync(Encargado encargado);
        Task DeleteEncargadoAsync(int id);
    }
}
