using Core.DTOs;
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
using Core.Entities;

namespace Servidor.Forms
{
    public partial class RecepcionPelicula : Form
    {
        private List<PrestamosDTO> prestamo;

        private readonly IPrestamoService _prestamoService;
        private readonly IClienteService _clienteService;
        public RecepcionPelicula(IPrestamoService prestamoService, IClienteService clienteService)
        {
            _prestamoService = prestamoService;
            _clienteService = clienteService;
            InitializeComponent();
        }

        private async void RecepcionPelicula_Load(object sender, EventArgs e)
        {
            var response = await _clienteService.GetAllClientesAsync();
            if (response.Success == false)
            {
                MessageBox.Show(response.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var clientes = (List<ClienteDTO>)response.responseObject;
            cboClientes.DataSource = clientes;
        }



        private async void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex != -1)
            {
                var cliente = ((ClienteDTO)cboClientes.SelectedItem);
                lblNombre.Text = "Nombre: " + cliente.Nombre;
                lblApellido1.Text = "Primer Apellido: " + cliente.PrimerApellido;
                lblApellido2.Text = "Segundo Apellido: " + cliente.SegundoApellido;

                var prestamoResponse = await _prestamoService.GetAllPrestamosByCliente(cliente.IdCliente);
                if (prestamoResponse.Success == false)
                {
                    MessageBox.Show(prestamoResponse.Message, "Prestamos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                prestamo = (List<PrestamosDTO>)prestamoResponse.responseObject;
                dtPrestamos.DataSource = null;
                dtPrestamos.DataSource = prestamo;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var listaPrestamos = (List<PrestamosDTO>)dtPrestamos.DataSource;
                foreach (var item in listaPrestamos)
                {
                    var respPrestamo = await _prestamoService.GetPrestamoByIdAsync(item.idPrestamo);
                    if (respPrestamo.Success == false)
                    {
                        throw new Exception(respPrestamo.Message);
                    }
                    var prestamo = (Prestamo)respPrestamo.responseObject;
                    prestamo.PendienteDevolucion=item.Devuelto;
                    var response = await _prestamoService.UpdatePrestamoAsync(prestamo);
                    if (response.Success == false)
                    {
                        throw new Exception(response.Message);
                    }
                }
                MessageBox.Show("Prestamos actualizados correctamente", "Prestamos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Prestamos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
