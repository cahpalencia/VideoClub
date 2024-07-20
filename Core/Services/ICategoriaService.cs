using Core.Entities;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface ICategoriaService
    {
        Task<ServiceResponse> GetAllCategoriasAsync();
        Task<ServiceResponse> GetCategoriaByIdAsync(int id);
        Task<ServiceResponse> AddCategoriaAsync(CategoriaPelicula categoria);
        Task<ServiceResponse> UpdateCategoriaAsync(CategoriaPelicula categoria);
        Task<ServiceResponse> DeleteCategoriaAsync(int id);
    }

}
