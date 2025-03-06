using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var FormLogin = new FormLogin();
            FormLogin.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormProductos = new FormProductos();
            FormProductos.MdiParent = this;
            FormProductos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormClientes = new FormClientes();
            FormClientes.MdiParent = this;
            FormClientes.Show();
        }

        private void rentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormRentas = new FormRentas();
            FormRentas.MdiParent = this;
            FormRentas.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }
    }
}
