using Core.DTOs;
using Core.Repositories;
using Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Forms
{
    public partial class Login : Form
    {
        private readonly IPrestamoService _prestamoService;
        public Login(IPrestamoService prestamoService)
        {
            _prestamoService = prestamoService;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Debe ingresar una identificación","Conexion Videoteca",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            var response = await _prestamoService.GetUserByIdentificacion(txtIdentificacion.Text);
            if(!response.Success)
            {
                MessageBox.Show(response.Message, "Conexion Videoteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cliente = response.responseObject as ClienteDTO;
            (Application.OpenForms["Main"] as Main).userId = cliente.IdCliente;
            MessageBox.Show("Bienvenido " + cliente.Nombre + " " + cliente.PrimerApellido, "Conexion Videoteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
