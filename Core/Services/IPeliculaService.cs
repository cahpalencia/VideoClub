using Core.Entities;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IPeliculaService
    {
        Task<ServiceResponse> GetAllPeliculasAsync();
        Task<ServiceResponse> GetAllPeliculasByCategoriaAsync(int categoria);
        Task<ServiceResponse> GetPeliculaByIdAsync(int id);
        Task<ServiceResponse> AddPeliculaAsync(Pelicula pelicula);
        Task<ServiceResponse> UpdatePeliculaAsync(Pelicula pelicula);
        Task<ServiceResponse> DeletePeliculaAsync(int id);
    }
}
