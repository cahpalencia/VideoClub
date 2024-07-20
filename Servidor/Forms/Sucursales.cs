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

namespace Servidor
{
    public partial class Sucursales : Form
    {
        private readonly ISucursalService _sucursalService;
        private readonly IEncargadoService _encargadoService;
        private List<Core.Entities.Sucursal> sucursales;
        public Sucursales(ISucursalService sucursalService, IEncargadoService encargadoService)
        {
            _sucursalService = sucursalService;
            _encargadoService = encargadoService;
            InitializeComponent();
        }

        private async void SetDataSource()
        {
            foreach (var column in dtSucursales.Columns)
            {
                if (column.ToString().Contains("DataGridViewComboBoxColumn"))
                {
                    var col = ((DataGridViewComboBoxColumn)column);
                    if (col.ValueMember == "IdEncargado")
                    {
                        var response = await _encargadoService.GetAllEncargadosAsync();
                        if (response.Success == false)
                        {
                            MessageBox.Show(response.Message, "Encargados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var encargados = (List<Core.DTOs.EncargadoDTO>)response.responseObject;
                        col.DataSource = encargados;
                        col.DisplayMember = "Nombre";
                        col.ValueMember = "IdEncargado";
                    }
                }
            }
            dtSucursales.DataSource = null;
            dtSucursales.DataSource = sucursales;
        }

        private async void Sucursales_Load(object sender, EventArgs e)
        {
            var response = await _sucursalService.GetAllSucursalesAsync();
            if (response.Success == false)
            {
                MessageBox.Show(response.Message, "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sucursales = (List<Core.Entities.Sucursal>)response.responseObject;
            SetDataSource();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var response = await _encargadoService.GetAllEncargadosAsync();
            if(response.Success == false)
            {
                MessageBox.Show(response.Message, "Encargados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var encargados = (List<Core.DTOs.EncargadoDTO>)response.responseObject;
            sucursales.Add(new Core.Entities.Sucursal { 
                IdSucursal = sucursales.Count + 1,
                IdEncargado = encargados.First().IdEncargado, 
                Estado = "Activo" });
            SetDataSource();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var currentResponse = await _sucursalService.GetAllSucursalesAsync();
                if (currentResponse.Success == false)
                {
                    throw new Exception(currentResponse.Message);
                }
                var current = (List<Core.Entities.Sucursal>)currentResponse.responseObject;
                var newSucursales = dtSucursales.DataSource as List<Core.Entities.Sucursal>;
                foreach (var item in newSucursales)
                {
                    if (current.Exists(m => m.IdSucursal == item.IdSucursal))
                    {
                        var response = await _sucursalService.UpdateSucursalAsync(item);
                        if (response.Success == false)
                        {
                            throw new Exception(response.Message);
                        }
                    }
                    else
                    {
                        var response = await _sucursalService.AddSucursalAsync(item);
                        if (response.Success == false)
                        {
                            throw new Exception(response.Message);
                        }
                    }
                }
                MessageBox.Show("Guardado exitosamente", "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            var response = await _sucursalService.GetAllSucursalesAsync();
            if (response.Success == false)
            {
                MessageBox.Show(response.Message, "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sucursales = (List<Core.Entities.Sucursal>)response.responseObject;
            SetDataSource();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
