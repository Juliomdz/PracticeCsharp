using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_OnClick(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string titulo = "Hola Windows Forms";
            string mensaje = $"Soy {nombre} {apellido}";
            FrmSaludo frmSaludo = new FrmSaludo(titulo, mensaje);
            frmSaludo.ShowDialog();
        }
    }
}
