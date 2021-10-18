using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio53
{
    public class EscrituraWrapper
    {
        public ConsoleColor color;
        public string texto;

        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.color = color;
            this.texto = texto;
        }

        //public ConsoleColor Color { get => color; set => color = value; }
        //public string Texto { get => texto; set => texto = value; }
    }
}
