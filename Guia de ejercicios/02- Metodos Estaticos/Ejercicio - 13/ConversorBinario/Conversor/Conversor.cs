using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conversor
    {
        public static string DecimaBinario(int numero)
        {
            string binario = string.Empty;
            int resultadoDivision = numero;
            int restoDivision;
            do
            {
                restoDivision = resultadoDivision % 2;
                resultadoDivision /= 2;
                binario = restoDivision.ToString() + binario;
            }while (resultadoDivision > 0);
            return binario;
        }
        public static int BinarioDecimal(string binario)
        {
            int numero = 0;
            int cantidadCaracteres = binario.Length;
            foreach (char caracter in binario)
            {
                cantidadCaracteres--;
                if(caracter == '1')
                {
                    numero += (int)Math.Pow(2, cantidadCaracteres);
                }
            }
            return numero;
        }
    }
}
