using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensajesEntidades;

namespace ChatUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensajeria.BuscarUsuarios();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = txtbName.Text;
            nuevoUsuario.Pass = txtbPassword.Text;
            nuevoUsuario.User = txtbUser.Text;
            Mensajeria.InstertarUsuario(nuevoUsuario);
        }
    }
}
