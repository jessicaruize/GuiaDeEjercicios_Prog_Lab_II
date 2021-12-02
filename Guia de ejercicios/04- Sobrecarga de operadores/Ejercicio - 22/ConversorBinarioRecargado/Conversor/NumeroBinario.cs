using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        private string numero;
        private NumeroBinario(string binario)
        {
            this.numero = binario;
        }
        public string Numero
        {
            get
            {
                return this.numero;
            }
        }
        public double BinarioDecimal(string binario)
        {
            double numero = 0;
            int cantidadCaracteres = binario.Length;
            foreach (char caracter in binario)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    numero += (int)Math.Pow(2, cantidadCaracteres);
                }
            }
            return numero;
        }
        public static implicit operator NumeroBinario(string binario)
        {
            return new NumeroBinario(binario);
        }
        public static explicit operator NumeroDecimal(NumeroBinario numeroBinario)
        {
            return (NumeroDecimal)numeroBinario.BinarioDecimal(numeroBinario.Numero);
        }
        public static string operator +(NumeroBinario binario, NumeroDecimal numero)
        {
            return numero.DecimaBinario(((NumeroDecimal)binario).Numero + numero.Numero);
        }
        public static string operator -(NumeroBinario binario, NumeroDecimal numero)
        {
            return numero.DecimaBinario(((NumeroDecimal)binario).Numero - numero.Numero);
        }
        public static bool operator ==(NumeroBinario binario, NumeroDecimal numero)
        {
            return ((NumeroDecimal)binario).Numero == numero.Numero;
        }
        public static bool operator !=(NumeroBinario binario, NumeroDecimal numero)
        {
            return !(binario == numero);
         }
    }
}
