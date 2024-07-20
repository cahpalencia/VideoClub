using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;
using Core.Entities;
using System.Text.Json;
using Core.Models;
using Core.Services;

namespace Servidor.Forms
{
    public partial class Eventos : Form
    {

        private readonly ISucursalService _sucursalService; 
        private readonly IPrestamoService _prestamoService;

        private bool _isListening = false;
        public Eventos(ISucursalService sucursalService, IPrestamoService prestamoService)
        {
            _sucursalService = sucursalService;
            InitializeComponent();
            _prestamoService=prestamoService;
        }

        private void Eventos_Load(object sender, EventArgs e)
        {

        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            _isListening = true;
            var task = Task.Run(() => Listening());
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            _isListening = false;

        }

        private async void Listening()
        {
            var response = new ServiceResponse();
            TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 15500);
            server.Start();
            this.Invoke((MethodInvoker)delegate
            {
                lstEventos.Items.Insert(0, "Servidor iniciado. Esperando conexiones...");
            });
            while (_isListening)
            {
                TcpClient client = server.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                var request = JsonSerializer.Deserialize<TcpRequest>(dataReceived);
                switch (request.Action)
                {
                    case "GetAllSucursal":
                        response = await _prestamoService.GetAllSucursal();
                        if (!response.Success)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lstEventos.Items.Insert(0, $"Error: " + response.Message);
                            });
                        }
                        else {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lstEventos.Items.Insert(0, $"Solicitud Recibida: ObtenerSucursales");
                            });
                        }
                        var responseBytes = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(response));
                        stream.Write(responseBytes, 0, responseBytes.Length);
                        break;
                    case "GetAllDisponibleBySucursal":
                        
                        var idSucursal = int.Parse(request.Data);
                        response = await _prestamoService.GetAllDisponibleBySucursalAsync(idSucursal);
                        if (!response.Success)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lstEventos.Items.Insert(0, $"Error: " + response.Message);
                            });
                        }
                        else {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lstEventos.Items.Insert(0, $"Solicitud Recibida: Obtener Peliculas de Sucursal: " + idSucursal);
                            });
                        }
                        
                        var responseDisponibleBytes = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(response));
                        stream.Write(responseDisponibleBytes, 0, responseDisponibleBytes.Length);
                        break;
                    case "AddPrestamo":
                        var prestamo = JsonSerializer.Deserialize<Prestamo>(request.Data);
                        response = await _prestamoService.AddPrestamoAsync(prestamo);
                        if (!response.Success)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lstEventos.Items.Insert(0, $"Error: " + response.Message);
                            });
                        }
                        else {
                            var nuevoPrestamo = (Prestamo)response.responseObject;
                            this.Invoke((MethodInvoker)delegate
                            {
                                lstEventos.Items.Insert(0, $"Solicitud Recibida: Generar Prestamo Pelicula, Cliente: " + nuevoPrestamo.IdCliente + " Nro Prestamo: " + nuevoPrestamo.IdPrestamo);
                            });
                        }
                        var nuevoPrestamoBytes = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(response));
                        stream.Write(nuevoPrestamoBytes, 0, nuevoPrestamoBytes.Length);
                        break;
                    case "GetPrestamosByCliente":
                        var idCliente = int.Parse(request.Data);
                        response = await _prestamoService.GetAllPrestamosByCliente(idCliente);
                        if (!response.Success)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lstEventos.Items.Insert(0, $"Error: " + response.Message);
                            });
                        }
                        else {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lstEventos.Items.Insert(0, $"Solicitud Recibida: Obtener Prestamos de Cliente: " + idCliente);
                            });
                        }
                        var responsePrestamosBytes = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(response));
                        stream.Write(responsePrestamosBytes, 0, responsePrestamosBytes.Length);
                        break;
                    case "GetClienteByIdentificacion":
                        var identificacion = request.Data;
                        response = await _prestamoService.GetUserByIdentificacion(identificacion);
                        if (!response.Success)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lstEventos.Items.Insert(0, $"Error: " + response.Message);
                            });
                        }
                        else {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lstEventos.Items.Insert(0, $"Solicitud Recibida: Obtener Cliente por Identificacion: " + identificacion);
                            });
                        }
                        var responseClienteBytes = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(response));
                        stream.Write(responseClienteBytes, 0, responseClienteBytes.Length);
                        break;
                    case "GetAllPrestamos":
                        response = await _prestamoService.GetAllPrestamosAsync();
                        if (!response.Success)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lstEventos.Items.Insert(0, $"Error: " + response.Message);
                            });
                        }
                        else {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lstEventos.Items.Insert(0, $"Solicitud Recibida: Obtener Todos los Prestamos");
                            });
                        }
                        var responseAllPrestamosBytes = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(response));
                        stream.Write(responseAllPrestamosBytes, 0, responseAllPrestamosBytes.Length);
                        break;
                    default:
                        break;
                }
                stream.Close();
                client.Close();
            }
            server.Stop();
            this.Invoke((MethodInvoker)delegate
            {
                lstEventos.Items.Insert(0, "Servidor detenido...");
            });

        }

        private void Eventos_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
