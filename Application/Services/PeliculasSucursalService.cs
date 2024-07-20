using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Services;
using Core.Repositories;
using Core.Models;

namespace App.Services
{
    public class PeliculasSucursalService : IPeliculasSucursalService
    {
        private readonly IPeliculasSucursalRepository _peliculasSucursalRepository;
        public PeliculasSucursalService(IPeliculasSucursalRepository peliculasSucursalRepository)
        {
            _peliculasSucursalRepository = peliculasSucursalRepository;
        }
        public async Task<ServiceResponse> AddPeliculaSucursalAsync(PeliculasSucursal peliculaSucursal)
        {
            var response = new ServiceResponse();
            try
            {
                response.responseObject = await _peliculasSucursalRepository.AddPeliculasSucursalAsync(peliculaSucursal);
                response.Success = true;
                response.Message = "Pelicula agregada correctamente";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<ServiceResponse> DeletePeliculaSucursalAsync(int id)
        {
            try
            {
                await _peliculasSucursalRepository.DeletePeliculasSucursalAsync(id);
                return new ServiceResponse { Message = "Pelicula eliminada correctamente", Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
            
        }

        public async Task<ServiceResponse> GetAllPeliculasBySucursalAsync(int idSucursal)
        {
            var response = new ServiceResponse();
            try
            {
                var peliculas = await _peliculasSucursalRepository.GetAllPeliculasSucursalAsync();
                response.responseObject = peliculas.Where(p => p.IdSucursal == idSucursal).ToList();
                response.Success = true;
                response.Message = "Peliculas obtenidas correctamente";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
            

        }

        public async Task<ServiceResponse> GetAllPeliculaSucursalAsync()
        {
            try
            {
                var response = new ServiceResponse();
                response.responseObject = await _peliculasSucursalRepository.GetAllPeliculasSucursalAsync();
                response.Success = true;
                response.Message = "Peliculas obtenidas correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> GetPeliculaSucursalByIdAsync(int id)
        {
            try
            {
                var response = new ServiceResponse();
                response.responseObject = await _peliculasSucursalRepository.GetPeliculasSucursalByIdAsync(id);
                response.Success = true;
                response.Message = "Pelicula obtenida correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> UpdatePeliculaSucursalAsync(PeliculasSucursal peliculaSucursal)
        {
            try
            {
                var response = new ServiceResponse();    
                response.responseObject = await _peliculasSucursalRepository.UpdatePeliculasSucursalAsync(peliculaSucursal);
                response.Success = true;
                response.Message = "Pelicula actualizada correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }
    }
}
