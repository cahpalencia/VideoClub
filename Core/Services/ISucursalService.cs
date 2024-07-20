using Core.Entities;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public  interface ISucursalService
    {
        Task<ServiceResponse> GetAllSucursalesAsync();
        Task<ServiceResponse> GetSucursalByIdAsync(int id);
        Task<ServiceResponse> AddSucursalAsync(Sucursal sucursal);
        Task<ServiceResponse> UpdateSucursalAsync(Sucursal sucursal);
        Task<ServiceResponse> DeleteSucursalAsync(int id);
    }
}
