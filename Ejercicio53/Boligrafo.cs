using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio53
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor colorTinta)
        {
            this.colorTinta = colorTinta;
            this.tinta = unidades;
        }
 
        public ConsoleColor Color { get => this.colorTinta; set => this.colorTinta = value; }
        public float UnidadesDeEscritura { get => this.tinta; set => this.tinta = value; }

        public EscrituraWrapper Escribir(string texto) //forma implicita
        {
            if (texto.Length > 0)
            {
                this.tinta -= (float)(texto.Length * 0.3);
            }
            return new EscrituraWrapper(texto, this.Color);
        }
        public bool Recargar(int unidades)
        {
            if(unidades > 0)
            {
                this.tinta += unidades;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Informacion: ");
            sb.AppendLine("Boligrafo.");
            sb.AppendLine("Color: " + this.Color.ToString());
            sb.AppendLine("Tinta: " + this.UnidadesDeEscritura);
            return sb.ToString();
        }
    }
}
