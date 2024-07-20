using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Cliente
{
    public partial class Main : Form
    {
        private readonly IFormFactory _formFactory;
        public int userId = 0;
        public Main(IFormFactory formFactory)
        {
            InitializeComponent();
            _formFactory=formFactory;
        }






        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nuevoPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuevoPrestamo = _formFactory.CreateNuevoPrestamoForm();
            nuevoPrestamo.MdiParent = this;
            nuevoPrestamo.Show();
        }

        private void misPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var misPrestamos = _formFactory.CreateMisPrestamosForm();
            misPrestamos.MdiParent = this;
            misPrestamos.Show();
        }

        private void Main_MouseEnter(object sender, EventArgs e)
        {
            //if (userId == 0)
            //{
            //    this.prestamosToolStripMenuItem.Visible = false;
            //}
            //else
            //{
            //    this.prestamosToolStripMenuItem.Visible = true;
            //}
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var login = _formFactory.CreateLoginForm();
            //login.MdiParent = this;
            login.ShowDialog();
        }
    }
}
