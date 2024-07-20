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
    public partial class Encargado : Form
    {
        private readonly IEncargadoService _encargadoService;
        private List<Core.DTOs.EncargadoDTO> encargados;
        public Encargado(IEncargadoService encargadoService)
        {
            _encargadoService = encargadoService;
            InitializeComponent();
        }

        private async void Encargado_Load(object sender, EventArgs e)
        {
            var response = await _encargadoService.GetAllEncargadosAsync();
            if (response.Success == false)
            {
                MessageBox.Show(response.Message, "Encargados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            encargados = (List<Core.DTOs.EncargadoDTO>)response.responseObject;
            dtEncargados.DataSource = encargados;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            encargados.Add(new Core.DTOs.EncargadoDTO { IdEncargado = encargados.Count + 1, FechaIngreso = DateTime.Now });
            dtEncargados.DataSource = null;
            dtEncargados.DataSource = encargados;
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            var response = await _encargadoService.GetAllEncargadosAsync();
            if (response.Success == false)
            {
                MessageBox.Show(response.Message, "Encargados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            encargados = (List<Core.DTOs.EncargadoDTO>)response.responseObject;
            dtEncargados.DataSource = null;
            dtEncargados.DataSource = encargados;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                var currentResponse = await _encargadoService.GetAllEncargadosAsync();
                if (currentResponse.Success == false)
                {
                    throw new Exception(currentResponse.Message);
                }
                var current = (List<Core.DTOs.EncargadoDTO>)currentResponse.responseObject;
                var newEncargados = dtEncargados.DataSource as List<Core.DTOs.EncargadoDTO>;
                foreach (var item in newEncargados)
                {
                    if (current.Where(m=>m.IdEncargado == item.IdEncargado).Count()==0)
                    {
                        var response = await _encargadoService.AddEncargadoAsync(item);
                        if (response.Success == false)
                        {
                            throw new Exception(response.Message);
                        }
                    }
                    else
                    {
                        var response = await _encargadoService.UpdateEncargadoAsync(item);
                        if (response.Success == false)
                        {
                            throw new Exception(response.Message);
                        }
                    }
                }
                MessageBox.Show("Guardado exitosamente", "Encargados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
