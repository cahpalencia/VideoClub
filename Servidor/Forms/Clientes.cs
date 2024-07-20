using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Services;
using Core.DTOs;
using Azure;

namespace Servidor.Forms
{
    public partial class Clientes : Form
    {
        private readonly IClienteService _clienteService;
        private List<ClienteDTO> clientes = new List<ClienteDTO>();
        public Clientes(IClienteService clienteService)
        {
            InitializeComponent();
            _clienteService=clienteService;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clientes.Add(new ClienteDTO { IdCliente = clientes.Count() + 1, FechaRegistro = DateTime.Now });
            dtClientes.DataSource = null;
            dtClientes.DataSource = clientes;

        }

        private async void Cliente_Load(object sender, EventArgs e)
        {
            var response = await _clienteService.GetAllClientesAsync();
            if(response.Success == false)
            {
                MessageBox.Show("Error al cargar los datos","Clientes",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            clientes = (List<ClienteDTO>)response.responseObject;
            dtClientes.DataSource = null;
            dtClientes.DataSource = clientes;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var currentResponse = await _clienteService.GetAllClientesAsync();
                if(currentResponse.Success == false)
                {
                    throw new Exception(currentResponse.Message);
                }
                var current = currentResponse.responseObject as List<ClienteDTO>;
                var newClientes = dtClientes.DataSource as List<ClienteDTO>;
                foreach (var item in newClientes)
                {
                    if (current.Any(m => m.IdCliente == item.IdCliente))
                    {
                        var response = await _clienteService.UpdateClienteAsync(item);
                        if(response.Success == false)
                        {
                            throw new Exception(response.Message);
                        }
                    }
                    else
                    {
                        var response = await _clienteService.AddClienteAsync(item);
                        if (response.Success == false)
                        {
                            throw new Exception(response.Message);
                        }
                    }
                }
                MessageBox.Show("Guardado exitosamente", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Clientes",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            var response = await _clienteService.GetAllClientesAsync();
            if (response.Success == false)
            {
                MessageBox.Show(response.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clientes = (List<ClienteDTO>)response.responseObject;
            dtClientes.DataSource = null;
            dtClientes.DataSource = clientes;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
