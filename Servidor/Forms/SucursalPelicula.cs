using Core.Entities;
using Core.Services;
using System.Data;
namespace Servidor.Forms
{
    public partial class SucursalPelicula : Form
    {
        private readonly IPeliculasSucursalService _peliculasSucursalService;
        private readonly ISucursalService _sucursalService;
        private readonly IPeliculaService _peliculaService;
        private List<PeliculasSucursal> _peliculasSucursal;
        public SucursalPelicula(
            IPeliculasSucursalService peliculasSucursalService,
            ISucursalService sucursalService,
            IPeliculaService peliculaService
            )
        {
            _peliculasSucursalService = peliculasSucursalService;
            _sucursalService = sucursalService;
            _peliculaService = peliculaService;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sucursal = ((Sucursal)cboSucursal.SelectedItem).IdSucursal;
            SetDataSource(_peliculasSucursal.Where(m => m.IdSucursal == sucursal).ToList());
        }

        private async void SucursalPelicula_Load(object sender, EventArgs e)
        {
            var response = await _peliculasSucursalService.GetAllPeliculaSucursalAsync();
            if (!response.Success)
            {
                MessageBox.Show(response.Message, "Peliculas por sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var responseSucursal = await _sucursalService.GetAllSucursalesAsync();
            if (!responseSucursal.Success)
            {
                MessageBox.Show(responseSucursal.Message, "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var sucursales = (List<Sucursal>)responseSucursal.responseObject;
            _peliculasSucursal = (List<PeliculasSucursal>)response.responseObject;
            cboSucursal.DataSource = sucursales.Where(m => m.Estado == "Activo").ToList();
        }

        private async void SetDataSource(List<PeliculasSucursal> datasource)
        {
            foreach (var column in dtPeliculasSucursal.Columns)
            {
                if (column.ToString().Contains("DataGridViewComboBoxColumn"))
                {
                    var col = ((DataGridViewComboBoxColumn)column);
                    if (col.ValueMember == "IdPelicula")
                    {
                        var response = await _peliculaService.GetAllPeliculasAsync();
                        if (!response.Success)
                        {
                            MessageBox.Show(response.Message, "Peliculas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var peliculas = (List<Core.Entities.Pelicula>)response.responseObject;
                        col.DataSource = peliculas;
                        col.DisplayMember = "Titulo";
                        col.ValueMember = "IdPelicula";
                    }
                }
            }
            dtPeliculasSucursal.DataSource = null;
            dtPeliculasSucursal.DataSource = datasource;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            var response = await _peliculasSucursalService.GetAllPeliculaSucursalAsync();
            _peliculasSucursal = (List<PeliculasSucursal>)response.responseObject;
            var sucursal = ((Sucursal)cboSucursal.SelectedItem).IdSucursal;
            SetDataSource(_peliculasSucursal.Where(m => m.IdSucursal == sucursal).ToList());
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var sucursal = ((Sucursal)cboSucursal.SelectedItem).IdSucursal;
            var peliculasResponse = await _peliculaService.GetAllPeliculasAsync();
            if (peliculasResponse.Success == false)
            {
                MessageBox.Show(peliculasResponse.Message, "Peliculas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var peliculas = (List<Core.Entities.Pelicula>)peliculasResponse.responseObject;
            _peliculasSucursal.Add(new PeliculasSucursal { IdSucursal = sucursal, IdPelicula = peliculas.First().IdPelicula});
            SetDataSource(_peliculasSucursal.Where(m => m.IdSucursal == sucursal).ToList());
        }

        private bool VerificaPeliculasRepetidas()
        {
            var gruposDuplicados = _peliculasSucursal
                .GroupBy(p => new { p.IdSucursal, p.IdPelicula })
                .Where(g => g.Count() > 1)
                .ToList();
            if (gruposDuplicados.Any())
                MessageBox.Show("No se pueden agregar peliculas repetidas", "Peliculas por sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return gruposDuplicados.Any();
        }

        private async void GuardarInformacion()
        {
            var idSucursal = ((Sucursal)cboSucursal.SelectedItem).IdSucursal;
            var currentResponse = await _peliculasSucursalService.GetAllPeliculaSucursalAsync();
            if (!currentResponse.Success)
            {
                throw new Exception(currentResponse.Message);
            }
            var current = (List<PeliculasSucursal>)currentResponse.responseObject;
            foreach (var item in _peliculasSucursal)
            {
                if (current.Exists(m => m.IdSucursal == item.IdSucursal && m.IdPelicula == item.IdPelicula))
                {
                    var response = await _peliculasSucursalService.UpdatePeliculaSucursalAsync(item);
                    if (!response.Success)
                    {
                        throw new Exception(response.Message);
                    }
                }
                else
                {
                    var response = await _peliculasSucursalService.AddPeliculaSucursalAsync(item);
                    if (!response.Success)
                    {
                        throw new Exception(response.Message);
                    }
                }
            }
            var auxResponse = await _peliculasSucursalService.GetAllPeliculaSucursalAsync();
            if (!auxResponse.Success)
            {
                throw new Exception(auxResponse.Message);
            }
            _peliculasSucursal = (List<PeliculasSucursal>)auxResponse.responseObject;
            SetDataSource(_peliculasSucursal.Where(m => m.IdSucursal == idSucursal).ToList());
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (VerificaPeliculasRepetidas()) {
                return;
            }
            btnGuardar.Enabled = false;
            try
            {
                GuardarInformacion();
            }
            finally
            {
                btnGuardar.Enabled = true;
                MessageBox.Show("Guardado exitosamente", "Peliculas por sucursal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
