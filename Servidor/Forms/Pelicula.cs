using Core.Entities;
using Core.Services;
using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public partial class Pelicula : Form
    {
        private readonly IPeliculaService _peliculaService;
        private readonly ICategoriaService _categoriaService;
        private List<Core.Entities.Pelicula> peliculas;
        public Pelicula(ICategoriaService categoriaService, IPeliculaService peliculaService)
        {
            _categoriaService = categoriaService;
            _peliculaService = peliculaService;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Pelicula_Load(object sender, EventArgs e)
        {
            var responseCategorias = await _categoriaService.GetAllCategoriasAsync();
            if (responseCategorias.Success == false)
            {
                MessageBox.Show(responseCategorias.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var categorias = (List<CategoriaPelicula>)responseCategorias.responseObject;
            var peliculasResponse = await _peliculaService.GetAllPeliculasAsync();
            if (peliculasResponse.Success == false)
            {
                MessageBox.Show(peliculasResponse.Message, "Peliculas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            peliculas = (List<Core.Entities.Pelicula>)peliculasResponse.responseObject;
            cboCategorias.DataSource = categorias;
        }


        private void cboCategorias_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCategorias.SelectedIndex != -1)
            {
                int idCategoria = ((CategoriaPelicula)cboCategorias.SelectedItem).IdCategoria;
                dtPeliculas.DataSource = null;
                dtPeliculas.DataSource = peliculas.Where(m => m.IdCategoria == idCategoria).ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            peliculas.Add(new Core.Entities.Pelicula
            {
                IdPelicula = peliculas.Count()+1,
                IdCategoria = (int)cboCategorias.SelectedValue
            });
            dtPeliculas.DataSource = null;
            dtPeliculas.DataSource = peliculas.Where(m => m.IdCategoria == (int)cboCategorias.SelectedValue).ToList();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var currentResponse = await _peliculaService.GetAllPeliculasAsync();
                if (currentResponse.Success == false)
                {
                    throw new Exception(currentResponse.Message);
                }
                var current = (List<Core.Entities.Pelicula>)currentResponse.responseObject;
                foreach (var item in peliculas)
                {
                    if (current.Exists(m=>m.IdPelicula == item.IdPelicula))
                    {
                        var response = await _peliculaService.UpdatePeliculaAsync(item);
                        if (response.Success == false)
                        {
                            throw new Exception(response.Message);
                        }
                    }
                    else
                    {
                        var response = await _peliculaService.AddPeliculaAsync(item);
                        if (response.Success == false)
                        {
                            throw new Exception(response.Message);
                        }
                    }
                }
                MessageBox.Show("Guardado exitosamente", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            var response = await _peliculaService.GetAllPeliculasAsync();
            if (response.Success == false)
            {
                MessageBox.Show(response.Message, "Peliculas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            peliculas = (List<Core.Entities.Pelicula>)response.responseObject;
            dtPeliculas.DataSource=null;
            dtPeliculas.DataSource = peliculas.Where(m => m.IdCategoria == (int)cboCategorias.SelectedValue).ToList();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
