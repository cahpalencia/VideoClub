using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Core.DTOs;
using Core.Entities;
using Core.Models;
using Core.Repositories;

namespace Infraestructure.Repositories
{
    public class PrestamoRepositoryTCP : IPrestamoRepository
    {
        private readonly string _serverIp;
        private readonly int _serverPort;
        public PrestamoRepositoryTCP(TcpSettings serverSettings)
        {
            _serverIp = serverSettings.ServerIp;
            _serverPort = int.Parse(serverSettings.ServerPort);
        }
        public async Task<Prestamo> AddPrestamoAsync(Prestamo prestamo)
        {
            var request = new TcpRequest
            {
                Action = "AddPrestamo",
                Data = JsonSerializer.Serialize(prestamo)
            };
            var response = await SendRequestAsync(request);
            var data = JsonSerializer.Deserialize<ServiceResponse>(response);
            if(!data.Success)
            {
                throw new Exception(data.Message);
            }
            data.responseObject = JsonSerializer.Deserialize<Prestamo>(data.responseObject.ToString());
            return (Prestamo)data.responseObject;
        }

        public async Task DeletePrestamoAsync(int id)
        {
            var request = new TcpRequest
            {
                Action = "DeletePrestamo",
                Data = id.ToString()
            };
            await SendRequestAsync(request);
        }

        public async Task<List<PeliculaPrestamoDTO>> GetAllDisponibleBySucursalAsync(int idSucursal)
        {
            var request = new TcpRequest
            {
                Action = "GetAllDisponibleBySucursal",
                Data = idSucursal.ToString()
            };
            var response = await SendRequestAsync(request);
            var data = new ServiceResponse();
            data.responseObject = new List<PeliculaPrestamoDTO>();
            data = JsonSerializer.Deserialize<ServiceResponse>(response);
            if (!data.Success)
            {
                throw new Exception(data.Message);
            }
            data.responseObject = JsonSerializer.Deserialize<List<PeliculaPrestamoDTO>>(data.responseObject.ToString());
            return (List<PeliculaPrestamoDTO>)data.responseObject;
        }

        public async Task<List<Prestamo>> GetAllPrestamosAsync()
        {
            var request = new TcpRequest
            {
                Action = "GetAllPrestamos"
            };
            var response = await SendRequestAsync(request);
            
            var data = JsonSerializer.Deserialize<ServiceResponse>(response);
            if (!data.Success)
            {
                throw new Exception(data.Message);
            }
            data.responseObject = JsonSerializer.Deserialize<List<Prestamo>>(data.responseObject.ToString());
            return (List<Prestamo>)data.responseObject;
        }

        public async Task<List<Sucursal>> GetAllSucursal()
        {
            var request = new TcpRequest
            {
                Action = "GetAllSucursal",
                Data = ""
            };
            var response = await SendRequestAsync(request);
            var data = new ServiceResponse();
            data.responseObject = new List<Sucursal>();
            data = JsonSerializer.Deserialize<ServiceResponse>(response);
            if (!data.Success)
            {
                throw new Exception(data.Message);
            }
            data .responseObject = JsonSerializer.Deserialize<List<Sucursal>>(data.responseObject.ToString());
            return (List<Sucursal>)data.responseObject;
        }

        public async Task<ClienteDTO> GetClienteByIdentificacion(string identificacion)
        {
            var request = new TcpRequest
            {
                Action = "GetClienteByIdentificacion",
                Data = identificacion
            };
            var response = await SendRequestAsync(request);
            var data = JsonSerializer.Deserialize<ServiceResponse>(response);
            
            if (!data.Success)
            {
                throw new Exception(data.Message);
            }
            data.responseObject = JsonSerializer.Deserialize<ClienteDTO>(data.responseObject.ToString());
            return (ClienteDTO)data.responseObject;
        }

        public async Task<Prestamo> GetPrestamoByIdAsync(int id)
        {
            var request = new TcpRequest
            {
                Action = "GetPrestamoById",
                Data = id.ToString()
            };
            var response = await SendRequestAsync(request);
            var data = new ServiceResponse();
            data.responseObject = new Prestamo();
            data = JsonSerializer.Deserialize<ServiceResponse>(response);
            if (!data.Success)
            {
                throw new Exception(data.Message);
            }
            data.responseObject = JsonSerializer.Deserialize<Prestamo>(data.responseObject.ToString());
            return (Prestamo)data.responseObject;
        }

        public async Task<List<PrestamosDTO>> GetPrestamosByCliente(int idCliente)
        {
            var request = new TcpRequest
            {
                Action = "GetPrestamosByCliente",
                Data = idCliente.ToString()
            };
            var response = await SendRequestAsync(request);
            var data = new ServiceResponse();
            data.responseObject = new List<PrestamosDTO>();
            data = JsonSerializer.Deserialize<ServiceResponse>(response);
            if (!data.Success)
            {
                throw new Exception(data.Message);
            }
            data.responseObject = JsonSerializer.Deserialize<List<PrestamosDTO>>(data.responseObject.ToString());
            return (List<PrestamosDTO>)data.responseObject;
        }

        public async Task<Prestamo> UpdatePrestamoAsync(Prestamo prestamo)
        {
            var request = new TcpRequest
            {
                Action = "UpdatePrestamo",
                Data = JsonSerializer.Serialize(prestamo)
            };
            var response = await SendRequestAsync(request);
            var data = new ServiceResponse();
            data.responseObject = new Prestamo();
            data = JsonSerializer.Deserialize<ServiceResponse>(response);
            if (!data.Success)
            {
                throw new Exception(data.Message);
            }
            data.responseObject = JsonSerializer.Deserialize<Prestamo>(data.responseObject.ToString());
            return (Prestamo)data.responseObject;
        }

        private async Task<string> SendRequestAsync(TcpRequest request)
        {
            using (var client = new TcpClient(_serverIp, _serverPort))
            using (var networkStream = client.GetStream())
            {
                var requestData = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(request));
                await networkStream.WriteAsync(requestData, 0, requestData.Length);

                var buffer = new byte[1048576];
                var byteCount = await networkStream.ReadAsync(buffer, 0, buffer.Length);
                var responseData = Encoding.UTF8.GetString(buffer, 0, byteCount);

                return responseData;
            }
        }
    }
}
