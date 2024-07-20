using Core.Entities;
using Core.Services;
using Core.Repositories;
using Core.DTOs;
using Core.Models;

namespace App.Services
{
    public class PrestamoService : IPrestamoService
    {
        private readonly IPrestamoRepository _prestamoRepository;
        public PrestamoService(
            IPrestamoRepository prestamoRepository)
        {
            _prestamoRepository = prestamoRepository;
        }
        public async Task<ServiceResponse> AddPrestamoAsync(Prestamo prestamo)
        {
            try
            {
                var response = new ServiceResponse();
                var prestamosExistentes = await _prestamoRepository.GetAllPrestamosAsync();
                if(prestamosExistentes.Exists(
                    p => p.IdPelicula == prestamo.IdPelicula && 
                    p.IdCliente == prestamo.IdCliente &&
                    p.PendienteDevolucion))
                {
                    response.Success = false;
                    response.Message = "El cliente ya tiene un prestamo de esta pelicula";
                    return response;
                }
                response.responseObject = await _prestamoRepository.AddPrestamoAsync(prestamo);
                response.Success = true;
                response.Message = "Prestamo agregado correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
            
        }

        public async Task<ServiceResponse> DeletePrestamoAsync(int id)
        {
            try
            {
                var response = new ServiceResponse();
                await _prestamoRepository.DeletePrestamoAsync(id);
                response.Success = true;
                response.Message = "Prestamo eliminado correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> GetAllDisponibleBySucursalAsync(int idSucursal)
        {
            try
            {
                var response = new ServiceResponse();   
                response.responseObject = await _prestamoRepository.GetAllDisponibleBySucursalAsync(idSucursal);
                response.Success = true;
                response.Message = "Prestamos obtenidos correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> GetAllPrestamosAsync()
        {
            try
            {
                var response = new ServiceResponse();
                response.responseObject = await _prestamoRepository.GetAllPrestamosAsync();
                response.Success = true;
                response.Message = "Prestamos obtenidos correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> GetAllPrestamosByCliente(int idCliente)
        {
            try
            {
                var response = new ServiceResponse();
                response.responseObject = await _prestamoRepository.GetPrestamosByCliente(idCliente);
                response.Success = true;
                response.Message = "Prestamos obtenidos correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> GetAllSucursal()
        {
            try
            {
                var response = new ServiceResponse();
                response.responseObject = await _prestamoRepository.GetAllSucursal();
                response.Success = true;
                response.Message = "Sucursales obtenidas correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> GetPrestamoByIdAsync(int id)
        {
            try
            {
                var response = new ServiceResponse();
                response.responseObject = await _prestamoRepository.GetPrestamoByIdAsync(id);
                response.Success = true;
                response.Message = "Prestamo obtenido correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> GetUserByIdentificacion(string identificacion)
        {
            try
            {
                var response = new ServiceResponse();
                response.responseObject = await _prestamoRepository.GetClienteByIdentificacion(identificacion);
                if(response.responseObject == null)
                {
                    response.Success = false;
                    response.Message = "Cliente no encontrado";
                    return response;
                }
                response.Success = true;
                response.Message = "Cliente obtenido correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse> UpdatePrestamoAsync(Prestamo prestamo)
        {
            try
            {
                var response = new ServiceResponse();
                response.responseObject = await _prestamoRepository.UpdatePrestamoAsync(prestamo);
                response.Success = true;
                response.Message = "Prestamo actualizado correctamente";
                return response;
            }
            catch (Exception ex)
            {
                return new ServiceResponse { Message = ex.Message, Success = false };
            }
        }
    }
}
