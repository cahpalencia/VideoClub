using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Models;
using Core.Repositories;
using Core.Services;

namespace App.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;

        }
        public async Task<ServiceResponse> AddCategoriaAsync(CategoriaPelicula categoria)
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                await _categoriaRepository.AddCategoriaAsync(categoria);
                serviceResponse.Success = true;
                serviceResponse.Message = "Categoria agregada correctamente";
                serviceResponse.responseObject = categoria;
                serviceResponse.Method = "AddCategoriaAsync";
                serviceResponse.responseCode = 200;
                return serviceResponse;
            }
            catch (Exception ex)
            {
                serviceResponse.responseCode = 500;
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
            
        }

        public async Task<ServiceResponse> DeleteCategoriaAsync(int id)
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                await _categoriaRepository.DeleteCategoriaAsync(id);
                serviceResponse.Success = true;
                serviceResponse.Message = "Categoria eliminada correctamente";
                serviceResponse.Method = "DeleteCategoriaAsync";
                serviceResponse.responseCode = 200;
                return serviceResponse;
            }
            catch (Exception ex)
            {
                serviceResponse.responseCode = 500;
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
            
        }

        public async Task<ServiceResponse> GetAllCategoriasAsync()
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                serviceResponse.responseObject =  await _categoriaRepository.GetAllCategoriasAsync();
                serviceResponse.Success = true;
                serviceResponse.Message = "Categorias obtenidas correctamente";
                serviceResponse.Method = "GetAllCategoriasAsync";
                serviceResponse.responseCode = 200;
                return serviceResponse;
            }
            catch (Exception ex)
            {
                serviceResponse.responseCode = 500;
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse> GetCategoriaByIdAsync(int id)
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                serviceResponse.responseObject = await _categoriaRepository.GetCategoriaByIdAsync(id);
                serviceResponse.Success = true;
                serviceResponse.Message = "Categoria obtenida correctamente";
                serviceResponse.Method = "GetCategoriaByIdAsync";
                serviceResponse.responseCode = 200;
                return serviceResponse;
            }
            catch (Exception ex)
            {
                serviceResponse.responseCode = 500;
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse> UpdateCategoriaAsync(CategoriaPelicula categoria)
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                await _categoriaRepository.UpdateCategoriaAsync(categoria);
                serviceResponse.Success = true;
                serviceResponse.Message = "Categoria actualizada correctamente";
                serviceResponse.responseObject = categoria;
                serviceResponse.Method = "UpdateCategoriaAsync";
                serviceResponse.responseCode = 200;
                return serviceResponse;
            }
            catch (Exception ex)
            {
                serviceResponse.responseCode = 500;
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
            
        }
    }
}
