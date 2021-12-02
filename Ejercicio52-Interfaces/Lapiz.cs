using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52_Interfaces
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(float tamanioMina)
        {
            this.tamanioMina = tamanioMina;
        }

        public ConsoleColor Color { get => ConsoleColor.Gray; set => new NotImplementedException(); }

        public float UnidadesDeEscritura{ get => this.tamanioMina; set => this.tamanioMina = value; }

        EscrituraWrapper IAcciones.Escribir(string texto) //forma explicita
        {
            if(texto.Length > 0)
            {
                this.tamanioMina -= (float)(texto.Length * 0.1);
            }
            return new EscrituraWrapper(texto, this.Color);
        }
        bool IAcciones.Recargar(int unidades) //forma explicita
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Informacion: ");
            sb.AppendLine("Lapiz.");
            sb.AppendLine("Color: " + this.Color);
            sb.AppendLine("Tinta: " + this.UnidadesDeEscritura);
            return sb.ToString();
        }
    }
}
