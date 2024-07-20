using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Repositories
{
    public interface ISucursalRepository
    {
        Task<List<Sucursal>> GetAllSucursalesAsync();
        Task<Sucursal> GetSucursalByIdAsync(int id);
        Task<Sucursal> AddSucursalAsync(Sucursal sucursal);
        Task<Sucursal> UpdateSucursalAsync(Sucursal sucursal);
        Task DeleteSucursalAsync(int id);
    }
}
