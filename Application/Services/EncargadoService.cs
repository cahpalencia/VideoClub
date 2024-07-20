using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.DTOs;
using Core.Repositories;
using Core.Services;
using Core.Models;
using System.Reflection.Metadata;
namespace App.Services
{
    public class EncargadoService : IEncargadoService
    {
        private readonly IEncargadoRepository _encargadoRepository;

        public EncargadoService(IEncargadoRepository encargadoRepository)
        {
            _encargadoRepository = encargadoRepository;
        }
        public async Task<ServiceResponse> AddEncargadoAsync(EncargadoDTO encargado)
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                var enc = new Encargado
                {
                    IdEncargado = encargado.IdEncargado,
                    Identificacion = encargado.Identificacion,
                    FechaIngreso = encargado.FechaIngreso,
                    Persona = new Persona
                    {
                        Nombre = encargado.Nombre,
                        Identificacion = encargado.Identificacion,
                        PrimerApellido = encargado.PrimerApellido,
                        SegundoApellido = encargado.SegundoApellido,
                        FechaNacimiento = encargado.FechaNacimiento
                    }
                };
                await _encargadoRepository.AddEncargadoAsync(enc);
                serviceResponse.Success = true;
                serviceResponse.Message = "Encargado agregado correctamente";
                serviceResponse.responseObject = encargado;
                serviceResponse.Method = "AddEncargadoAsync";
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

        public async Task<ServiceResponse> DeleteEncargadoAsync(int id)
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                await _encargadoRepository.DeleteEncargadoAsync(id);
                serviceResponse.Success = true;
                serviceResponse.Message = "Encargado eliminado correctamente";
                serviceResponse.Method = "DeleteEncargadoAsync";
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

        public async Task<ServiceResponse> GetAllEncargadosAsync()
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                var encargados = await _encargadoRepository.GetAllEncargadosAsync();
                var encargadosDTO = new List<EncargadoDTO>();
                foreach (var encargado in encargados)
                {
                    encargadosDTO.Add(new EncargadoDTO
                    {
                        IdEncargado = encargado.IdEncargado,
                        Identificacion = encargado.Identificacion,
                        Nombre = encargado.Persona.Nombre,
                        PrimerApellido = encargado.Persona.PrimerApellido,
                        SegundoApellido = encargado.Persona.SegundoApellido,
                        FechaIngreso = encargado.FechaIngreso,
                        FechaNacimiento= encargado.Persona.FechaNacimiento
                    });
                }
                serviceResponse.responseObject = encargadosDTO;
                serviceResponse.Success = true;
                serviceResponse.Message = "Encargados obtenidos correctamente";
                serviceResponse.Method = "GetAllEncargadosAsync";
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

        public async Task<ServiceResponse> GetEncargadoByIdAsync(int id)
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                var encargado = await _encargadoRepository.GetEncargadoByIdAsync(id);
                var enc = new EncargadoDTO
                {
                    IdEncargado = encargado.IdEncargado,
                    Identificacion = encargado.Identificacion,
                    Nombre = encargado.Persona.Nombre,
                    PrimerApellido = encargado.Persona.PrimerApellido,
                    SegundoApellido = encargado.Persona.SegundoApellido,
                    FechaIngreso = encargado.FechaIngreso,
                    FechaNacimiento = encargado.Persona.FechaNacimiento
                };
                serviceResponse.responseObject = enc;
                serviceResponse.Success = true;
                serviceResponse.Message = "Encargado obtenido correctamente";
                serviceResponse.Method = "GetEncargadoByIdAsync";
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

        public async Task<ServiceResponse> UpdateEncargadoAsync(EncargadoDTO encargado)
        {
            var serviceResponse = new ServiceResponse();
            try
            {
                var enc = new Encargado
                {
                    IdEncargado = encargado.IdEncargado,
                    Identificacion = encargado.Identificacion,
                    FechaIngreso = encargado.FechaIngreso,
                    Persona = new Persona
                    {
                        Nombre = encargado.Nombre,
                        Identificacion = encargado.Identificacion,
                        PrimerApellido = encargado.PrimerApellido,
                        SegundoApellido = encargado.SegundoApellido,
                        FechaNacimiento = encargado.FechaNacimiento
                    }
                };
                await _encargadoRepository.UpdateEncargadoAsync(enc);
                serviceResponse.Success = true;
                serviceResponse.Message = "Encargado actualizado correctamente";
                serviceResponse.responseObject = encargado;
                serviceResponse.Method = "UpdateEncargadoAsync";
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
