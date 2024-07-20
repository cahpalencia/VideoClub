using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTOs;
using Core.Services;
using Core.Repositories;
using Core.Entities;
using Core.Models;

namespace App.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<ServiceResponse> AddClienteAsync(ClienteDTO cliente)
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                var cl = new Cliente
                {
                    IdCliente = cliente.IdCliente,
                    Identificacion = cliente.Identificacion,
                    FechaRegistro = cliente.FechaRegistro,
                    Activo = cliente.Activo,
                    Persona = new Persona
                    {
                        Identificacion = cliente.Identificacion,
                        Nombre = cliente.Nombre,
                        PrimerApellido = cliente.PrimerApellido,
                        SegundoApellido = cliente.SegundoApellido,
                        FechaNacimiento = cliente.FechaNacimiento
                    }
                };
                await _clienteRepository.AddClienteAsync(cl);
                serviceResponse.Success = true;
                serviceResponse.Message = "Cliente agregado correctamente";
                serviceResponse.responseObject = cliente;
                serviceResponse.Method = "AddClienteAsync";
                serviceResponse.responseCode = 200;
                return serviceResponse;
            }
            catch (Exception ex)
            {
                serviceResponse.responseCode = 500;
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
            
            
        }

        public async Task<ServiceResponse> DeleteClienteAsync(int id)
        {
            try
            {
                await _clienteRepository.DeleteClienteAsync(id);
                return new ServiceResponse
                {
                    Success = true,
                    Message = "Cliente eliminado correctamente",
                    Method = "DeleteClienteAsync",
                    responseCode = 200
                };
            }
            catch (Exception ex)
            {
                return new ServiceResponse
                {
                    responseCode = 500,
                    Success = false,
                    Message = ex.Message
                };
            }
            
        }

        public async Task<ServiceResponse> GetAllClientesAsync()
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                var clientes = await _clienteRepository.GetAllClientesAsync();
                var clientesDTO = new List<ClienteDTO>();
                foreach (var cliente in clientes)
                {
                    clientesDTO.Add(new ClienteDTO
                    {
                        IdCliente = cliente.IdCliente,
                        Identificacion = cliente.Identificacion,
                        FechaRegistro = cliente.FechaRegistro,
                        Activo = cliente.Activo,
                        Nombre = cliente.Persona.Nombre,
                        PrimerApellido = cliente.Persona.PrimerApellido,
                        SegundoApellido = cliente.Persona.SegundoApellido,
                        FechaNacimiento = cliente.Persona.FechaNacimiento
                    });
                }
                serviceResponse.responseObject = clientesDTO;
                serviceResponse.Success = true;
                serviceResponse.Message = "Clientes obtenidos correctamente";
                serviceResponse.Method = "GetAllClientesAsync";
                serviceResponse.responseCode = 200;
                return serviceResponse;
            }
            catch (Exception ex)
            {
                serviceResponse.responseCode = 500;
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
            
        }

        public async Task<ServiceResponse> GetClienteByIdAsync(int id)
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                var cliente = await _clienteRepository.GetClienteByIdAsync(id);
                var clienteDto =  new ClienteDTO
                {
                    IdCliente = cliente.IdCliente,
                    Identificacion = cliente.Identificacion,
                    FechaRegistro = cliente.FechaRegistro,
                    Activo = cliente.Activo,
                    Nombre = cliente.Persona.Nombre,
                    PrimerApellido = cliente.Persona.PrimerApellido,
                    SegundoApellido = cliente.Persona.SegundoApellido,
                    FechaNacimiento = cliente.Persona.FechaNacimiento
                };
                serviceResponse.responseObject = clienteDto;
                serviceResponse.Success = true;
                serviceResponse.Message = "Cliente obtenido correctamente";
                serviceResponse.Method = "GetClienteByIdAsync";
                serviceResponse.responseCode = 200;
                return serviceResponse;
            }
            catch (Exception ex)
            {
                serviceResponse.responseCode = 500;
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
            
        }

        public async Task<ServiceResponse> UpdateClienteAsync(ClienteDTO cliente)
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                var cl = new Cliente
                {
                    IdCliente = cliente.IdCliente,
                    Identificacion = cliente.Identificacion,
                    FechaRegistro = cliente.FechaRegistro,
                    Activo = cliente.Activo,
                    Persona = new Persona
                    {
                        Identificacion = cliente.Identificacion,
                        Nombre = cliente.Nombre,
                        PrimerApellido = cliente.PrimerApellido,
                        SegundoApellido = cliente.SegundoApellido,
                        FechaNacimiento = cliente.FechaNacimiento
                    }
                };
                await _clienteRepository.UpdateClienteAsync(cl);
                serviceResponse.Success = true;
                serviceResponse.Message = "Cliente actualizado correctamente";
                serviceResponse.responseObject = cliente;
                serviceResponse.Method = "UpdateClienteAsync";
                serviceResponse.responseCode = 200;
                return serviceResponse;
            }
            catch (Exception ex)
            {
                serviceResponse.responseCode = 500;
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
            
        }
    }
}
