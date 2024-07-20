using Core.Entities;
using Core.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public partial class Categoria : Form
    {
        private readonly ICategoriaService _categoriaService;
        private List<CategoriaPelicula> categorias;
        public Categoria(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
            InitializeComponent();
        }

        private async void Categoria_Load(object sender, EventArgs e)
        {
            var response = await _categoriaService.GetAllCategoriasAsync();
            if(response.Success)
            {
                categorias = (List<CategoriaPelicula>)response.responseObject;
                dtCategorias.DataSource = categorias;
            }
            else
            {
                MessageBox.Show(response.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtCategorias_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            categorias.Add(new CategoriaPelicula { IdCategoria = categorias.Count+1 });
            dtCategorias.DataSource = null;
            dtCategorias.DataSource = categorias;
        }



        private async void btnCancel_Click(object sender, EventArgs e)
        {
            var response = await _categoriaService.GetAllCategoriasAsync();
            if (response.Success)
            {
                categorias = (List<CategoriaPelicula>)response.responseObject;
                dtCategorias.DataSource = categorias;
            }
            else
            {
                MessageBox.Show(response.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var currentResponse = await _categoriaService.GetAllCategoriasAsync();
                if (!currentResponse.Success)
                {
                    throw new Exception(currentResponse.Message);
                }
                var current = (List<CategoriaPelicula>)currentResponse.responseObject;

                var newCategorias = dtCategorias.DataSource as List<CategoriaPelicula>;
                foreach (var item in newCategorias)
                {
                    if (current.Exists(m=>m.IdCategoria == item.IdCategoria))
                    {
                        var response = await _categoriaService.UpdateCategoriaAsync(item);
                        if (!response.Success)
                        {
                            throw new Exception(response.Message);
                        }
                    }
                    else
                    {
                        var response = await _categoriaService.AddCategoriaAsync(item);
                        if (!response.Success)
                        {
                            throw new Exception(response.Message);
                        }
                    }
                }
                MessageBox.Show("Guardado exitosamente", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
