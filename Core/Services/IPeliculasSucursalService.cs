using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Models;
namespace Core.Services
{
    public interface IPeliculasSucursalService
    {
        Task<ServiceResponse> AddPeliculaSucursalAsync(PeliculasSucursal peliculaSucursal);
        Task<ServiceResponse> DeletePeliculaSucursalAsync(int id);
        Task<ServiceResponse> GetAllPeliculaSucursalAsync();
        Task<ServiceResponse> GetAllPeliculasBySucursalAsync(int idSucursal);
        Task<ServiceResponse> GetPeliculaSucursalByIdAsync(int id);
        Task<ServiceResponse> UpdatePeliculaSucursalAsync(PeliculasSucursal peliculaSucursal);
    }
}
