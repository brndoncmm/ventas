using BL.Rentas;
using System;
using System.Windows.Forms;

namespace Login
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;
        public FormLogin()
        {
            InitializeComponent();

             _seguridad = new SeguridadBL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contraseña;

            usuario = textBox1.Text;
            contraseña = textBox2.Text;

            var resultado = _seguridad.Autorizar(usuario, contraseña);

            if (usuario == "admin" && contraseña == "123")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
