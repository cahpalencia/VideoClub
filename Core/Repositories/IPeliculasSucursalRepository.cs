using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;    

namespace Core.Repositories
{
    public interface IPeliculasSucursalRepository
    {
        Task<PeliculasSucursal> AddPeliculasSucursalAsync(PeliculasSucursal peliculasSucursal);
        Task DeletePeliculasSucursalAsync(int id);
        Task<List<PeliculasSucursal>> GetAllPeliculasSucursalAsync();
        Task<PeliculasSucursal> GetPeliculasSucursalByIdAsync(int id);
        Task<PeliculasSucursal> UpdatePeliculasSucursalAsync(PeliculasSucursal peliculasSucursal);
    }
}
