using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DTOs;
using Core.Entities;
using Core.Services;

namespace Cliente.Forms
{
    public partial class NuevoPrestamo : Form
    {
        private readonly IPrestamoService _prestamoService;
        private List<PeliculaPrestamoDTO> peliculasDisponibles;
        public NuevoPrestamo(
            IPrestamoService prestamoService)
        {
            _prestamoService = prestamoService;

            InitializeComponent();



        }

        private async void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            var response = await _prestamoService.GetAllSucursal();
            if (response.Success == false)
            {
                MessageBox.Show(response.Message, "Peliculas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var sucursales = (List<Sucursal>)response.responseObject;
            cboSucursal.DataSource = sucursales;
            cboSucursal.DisplayMember = "Nombre";
            cboSucursal.ValueMember = "IdSucursal";
        }

        private async void SetDataSouce()
        {
            if (cboSucursal.SelectedIndex != -1)
            {
                int idSucursal = (int)cboSucursal.SelectedValue;
                var response  = await _prestamoService.GetAllDisponibleBySucursalAsync(idSucursal);
                if (response.Success == false)
                {
                    MessageBox.Show(response.Message, "Peliculas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                peliculasDisponibles = (List<PeliculaPrestamoDTO>)response.responseObject;
                dtPeliculas.DataSource = null;
                dtPeliculas.DataSource = peliculasDisponibles;
            }
        }

        private void cboSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDataSouce();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dtPeliculas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una pelicula");
                return;
            }
            var prestamo = new Prestamo
            {
                IdSucursal = (int)cboSucursal.SelectedValue,
                IdCliente = (Application.OpenForms["Main"] as Main).userId,
                IdPelicula = (int)dtPeliculas.SelectedRows[0].Cells[0].Value,
                FechaPrestamo = DateTime.Now,
                PendienteDevolucion = true,
                IdPrestamo = 0
            };
            var response = await _prestamoService.AddPrestamoAsync(prestamo);
            if (!response.Success)
            {
                MessageBox.Show(response.Message, "Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var nuevoPrestamo = (Prestamo)response.responseObject;
            SetDataSouce();
            MessageBox.Show("Prestamo generado: #" + nuevoPrestamo.IdPrestamo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
