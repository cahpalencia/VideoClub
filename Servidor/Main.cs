using Core.Entities;
using Core.Services;
using Servidor.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace Servidor
{
    public partial class Main : Form
    {
        private readonly IFormFactory _formFactory;

        public Main(
            IFormFactory formFactory
            )
        {
            _formFactory = formFactory;
            InitializeComponent();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var categoriasForm = _formFactory.CreateCategoriaForm();
            categoriasForm.MdiParent = this;
            categoriasForm.Show();
        }



        private void Main_Load(object sender, EventArgs e)
        {

        }



        private void películasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var peliculasForm = _formFactory.CreatePeliculaForm();
            peliculasForm.MdiParent = this;
            peliculasForm.Show();
        }

        private void encargadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var encargadoForm = _formFactory.CreateEncargadoForm();
            encargadoForm.MdiParent = this;
            encargadoForm.Show();
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sucursalesForm = _formFactory.CreateSucursalForm();
            sucursalesForm.MdiParent = this;
            sucursalesForm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clientesForm = _formFactory.CreateClienteForm();
            clientesForm.MdiParent = this;
            clientesForm.Show();
        }

        private void peliculasPorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var peliculasSucursalForm = _formFactory.CreateSucursalPeliculaForm();
            peliculasSucursalForm.MdiParent = this;
            peliculasSucursalForm.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void eventosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var eventosForm = _formFactory.CreateEventosForm();
            eventosForm.MdiParent = this;
            eventosForm.Show();
        }

        private void recepciónPeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var recepcionPeliculaForm = _formFactory.CreateRecepcionPeliculaForm();
            recepcionPeliculaForm.MdiParent = this;
            recepcionPeliculaForm.Show();
        }
    }
}
