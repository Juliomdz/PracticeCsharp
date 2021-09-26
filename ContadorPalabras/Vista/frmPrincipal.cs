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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorDePalabras();

            List<KeyValuePair<string, int>> podio = ObtenerPodio(contadorPalabras);             

            MostrarPodio(podio);
        }
        private List<KeyValuePair<string, int>> ObtenerPodio(Dictionary<string, int> contadorPalabras)
        {
            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();
            podio.Sort(CompararCantidadRepeticiones);
            return podio;
        }
        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (podio.Count == 0)
            {
                stringBuilder.AppendLine("No Se ingresaron Palabras.");
            }
            else
            {
                for (int i = 0; i < 3 && i < podio.Count; i++)
                {
                    KeyValuePair<string, int> par = podio[i];
                    stringBuilder.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                }
                /*
                foreach (KeyValuePair<string, int> par in podio)
                {
                    stringBuilder.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                }
                */
            }
            MessageBox.Show(stringBuilder.ToString(), "Podio");
        }
        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento,
                                                 KeyValuePair<string, int> segundoELemento)
        {
            return segundoELemento.Value - primerElemento.Value;
        }
        private Dictionary<string, int> ObtenerContadorDePalabras()
        {
            string texto = rtxtContadorPalabras.Text;
            String[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (contadorPalabras.ContainsKey(palabra))
                {
                    contadorPalabras[palabra]++;
                }
                else
                {
                    contadorPalabras.Add(palabra, 1);
                }
            }
            return contadorPalabras;
        }
    }
}
