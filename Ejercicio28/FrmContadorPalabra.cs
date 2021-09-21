using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class FrmContadorPalabra : Form
    {
        public FrmContadorPalabra()
        {
            InitializeComponent();
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPAlabras();
            List<KeyValuePair<string, int>> podio = ObtenerPodio(contadorPalabras);
            MessageBox.Show(MostrarPodio(podio), "podio");
        }
        private List<KeyValuePair<string, int>> ObtenerPodio(Dictionary<string, int> contadorPalabras)
        {
            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();
            podio.Sort(CompararCantidadRepeticiones);
            return podio;
        }
        private string MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(podio.Count == 0)
            {
                stringBuilder.AppendLine("No se ingresaron palabras.");
            }
            else
            {
                for(int i= 0; i < 3 && i < podio.Count; i++)
                foreach(KeyValuePair<string, int> par in podio)
                {
                    stringBuilder.AppendLine($"Palabra: {par.Key} cantidad: {par.Value}");
                }
            }
            return stringBuilder.ToString();
        }
        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primero, KeyValuePair<string, int> segundo)
        {
            return segundo.Value - primero.Value;
        }
        private Dictionary<string, int> ObtenerContadorPAlabras()
        {
            string texto = rtxtContadorPalabra.Text;
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
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
