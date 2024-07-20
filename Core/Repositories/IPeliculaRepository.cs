using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IPeliculaRepository
    {
        Task<List<Pelicula>> GetAllPeliculasAsync();
        Task<List<Pelicula>> GetAllPeliculasByCategoriaAsync(int categoria);
        Task<Pelicula> GetPeliculaByIdAsync(int id);
        Task AddPeliculaAsync(Pelicula pelicula);
        Task UpdatePeliculaAsync(Pelicula pelicula);
        Task DeletePeliculaAsync(int id);
    }
}
