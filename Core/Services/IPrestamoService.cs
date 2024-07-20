using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTOs;
using Core.Entities;
using Core.Models;
namespace Core.Services
{
    public interface IPrestamoService
    {
        Task<ServiceResponse> AddPrestamoAsync(Prestamo prestamo);
        Task<ServiceResponse> GetAllDisponibleBySucursalAsync(int idSucursal);
        Task<ServiceResponse> GetAllPrestamosByCliente(int idCliente);
        Task<ServiceResponse> GetAllSucursal();
        Task<ServiceResponse> DeletePrestamoAsync(int id);
        Task<ServiceResponse> GetAllPrestamosAsync();
        Task<ServiceResponse> GetPrestamoByIdAsync(int id);
        Task<ServiceResponse> UpdatePrestamoAsync(Prestamo prestamo);
        Task<ServiceResponse> GetUserByIdentificacion(string identificacion);

    }
}
