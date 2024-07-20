using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTOs;
using Core.Entities;

namespace Core.Repositories
{
    public interface IPrestamoRepository
    {
        Task<Prestamo> AddPrestamoAsync(Prestamo prestamo);
        Task DeletePrestamoAsync(int id);
        Task<List<PeliculaPrestamoDTO>> GetAllDisponibleBySucursalAsync(int idSucursal);
        Task<List<PrestamosDTO>> GetPrestamosByCliente(int idCliente);
        Task<List<Sucursal>> GetAllSucursal();
        Task<List<Prestamo>> GetAllPrestamosAsync();
        Task<Prestamo> GetPrestamoByIdAsync(int id);
        Task<Prestamo> UpdatePrestamoAsync(Prestamo prestamo);
        Task<ClienteDTO> GetClienteByIdentificacion(string identificacion);
    }
}
