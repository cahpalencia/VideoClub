using Core.Entities;
using Core.Models;
using Core.Repositories;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class PeliculaService: IPeliculaService
    {
        private readonly IPeliculaRepository _peliculaRepository;
        public PeliculaService(IPeliculaRepository peliculaRepository)
        {
            _peliculaRepository = peliculaRepository;
        }

        public async Task<ServiceResponse> AddPeliculaAsync(Pelicula pelicula)
        {
            try
            {
                await _peliculaRepository.AddPeliculaAsync(pelicula);
                return new ServiceResponse { Message = "Pelicula agregada correctamente", Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
            
        }

        public async Task<ServiceResponse> DeletePeliculaAsync(int id)
        {
            try
            {
                await _peliculaRepository.DeletePeliculaAsync(id);
                return new ServiceResponse { Message = "Pelicula eliminada correctamente", Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> GetAllPeliculasAsync()
        {
            var response = new ServiceResponse();
            try
            {
                response.responseObject = await _peliculaRepository.GetAllPeliculasAsync();
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

        public async Task<ServiceResponse> GetAllPeliculasByCategoriaAsync(int categoria)
        {
            var response = new ServiceResponse();
            try
            {
                response.responseObject = await _peliculaRepository.GetAllPeliculasByCategoriaAsync(categoria);
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

        public async Task<ServiceResponse> GetPeliculaByIdAsync(int id)
        {
            var response = new ServiceResponse();
            try
            {
                response.responseObject = await _peliculaRepository.GetPeliculaByIdAsync(id);
                response.Success = true;
                response.Message = "Pelicula obtenida correctamente";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<ServiceResponse> UpdatePeliculaAsync(Pelicula pelicula)
        {
            try
            {
                await _peliculaRepository.UpdatePeliculaAsync(pelicula);
                return new ServiceResponse { Message = "Pelicula actualizada correctamente", Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }
    }
}
