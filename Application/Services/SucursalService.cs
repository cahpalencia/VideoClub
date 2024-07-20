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
    public class SucursalService : ISucursalService
    {
        private readonly ISucursalRepository _sucursalRepository;
        public SucursalService(ISucursalRepository sucursalRepository)
        {
            _sucursalRepository = sucursalRepository;
        }
        public async Task<ServiceResponse> AddSucursalAsync(Sucursal sucursal)
        {
            try
            {
                var response = new ServiceResponse();
                response.responseObject = await _sucursalRepository.AddSucursalAsync(sucursal);
                response.Success = true;
                response.Message = "Sucursal agregada correctamente";
                return response;

            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> DeleteSucursalAsync(int id)
        {
            try
            {
                var response = new ServiceResponse();
                await _sucursalRepository.DeleteSucursalAsync(id);
                response.Success = true;
                response.Message = "Sucursal eliminada correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
            
        }

        public async Task<ServiceResponse> GetAllSucursalesAsync()
        {
            try
            {
                var response = new ServiceResponse();
                response.responseObject = await _sucursalRepository.GetAllSucursalesAsync();
                response.Success = true;
                response.Message = "Sucursales obtenidas correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> GetSucursalByIdAsync(int id)
        {
            try
            {
                var response = new ServiceResponse();
                response.responseObject = await _sucursalRepository.GetSucursalByIdAsync(id);
                response.Success = true;
                response.Message = "Sucursal obtenida correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> UpdateSucursalAsync(Sucursal sucursal)
        {
            try
            {
                var response = new ServiceResponse();
                response.responseObject = await _sucursalRepository.UpdateSucursalAsync(sucursal);
                response.Success = true;
                response.Message = "Sucursal actualizada correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }
    }
}
