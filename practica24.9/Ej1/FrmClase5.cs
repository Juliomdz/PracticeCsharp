using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class FrmClase5 : Form
    {
        public FrmClase5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto es un mensaje");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esto es un mensaje sobrecargado", "Informe", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Escogio Aceptar");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea Crear un formulario?", "Creador De Formularios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (respuesta == DialogResult.Yes)
            {
                FrmClase5_02 form2 = new FrmClase5_02();

                form2.Show();
            }

        }
    }
}
