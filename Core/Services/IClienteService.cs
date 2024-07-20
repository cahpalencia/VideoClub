using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTOs;
using Core.Models;

namespace Core.Services
{
    public interface IClienteService
    {
        Task<ServiceResponse> GetAllClientesAsync();
        Task<ServiceResponse> GetClienteByIdAsync(int id);
        Task<ServiceResponse> AddClienteAsync(ClienteDTO cliente);
        Task<ServiceResponse> UpdateClienteAsync(ClienteDTO cliente);
        Task<ServiceResponse> DeleteClienteAsync(int id);
    }
}
