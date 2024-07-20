using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.DTOs;
using Core.Models;

namespace Core.Services
{
    public interface IEncargadoService
    {
        Task<ServiceResponse> GetAllEncargadosAsync();
        Task<ServiceResponse> GetEncargadoByIdAsync(int id);
        Task<ServiceResponse> AddEncargadoAsync(EncargadoDTO encargado);
        Task<ServiceResponse> UpdateEncargadoAsync(EncargadoDTO encargado);
        Task<ServiceResponse> DeleteEncargadoAsync(int id);
    }
}
