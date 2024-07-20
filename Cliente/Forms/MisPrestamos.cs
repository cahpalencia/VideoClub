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
using Core.Services;
namespace Cliente.Forms
{
    public partial class MisPrestamos : Form
    {
        private readonly IPrestamoService _prestamoService;

        public MisPrestamos(IPrestamoService prestamoService)
        {
            InitializeComponent();
            _prestamoService=prestamoService;
        }

        private async void MisPrestamos_Load(object sender, EventArgs e)
        {
            var response = await _prestamoService.GetAllPrestamosByCliente((Application.OpenForms["Main"] as Main).userId);
            if (response.Success == false)
            {
                MessageBox.Show(response.Message, "Prestamos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<PrestamosDTO> prestamos = new List<PrestamosDTO>();
            foreach(var item in (List<PrestamosDTO>)response.responseObject)
            {
                if (item.Devuelto == true)
                {
                    prestamos.Add(item);
                }
            }
            dtPrestamos.DataSource = null;
            dtPrestamos.DataSource = prestamos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
