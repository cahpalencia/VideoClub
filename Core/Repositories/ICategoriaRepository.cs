using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface ICategoriaRepository
    {
        Task<List<CategoriaPelicula>> GetAllCategoriasAsync();
        Task<CategoriaPelicula> GetCategoriaByIdAsync(int id);
        Task AddCategoriaAsync(CategoriaPelicula categoria);
        Task UpdateCategoriaAsync(CategoriaPelicula categoria);
        Task DeleteCategoriaAsync(int id);
    }

}
