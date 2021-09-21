using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class NumeroDecimal
    {
        private double numero;
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        public double Numero
        {
            get
            {
                return this.numero;
            }
        }
        public string DecimaBinario(double numero)
        {
            string binario = string.Empty;
            int resultadoDivision = (int)numero;
            int restoDivision;
            do
            {
                restoDivision = resultadoDivision % 2;
                resultadoDivision /= 2;
                binario = restoDivision.ToString() + binario;
            } while (resultadoDivision > 0);
            return binario;
        }
        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }
        public static explicit operator NumeroBinario(NumeroDecimal numero)
        {
            return numero.DecimaBinario(numero.Numero);
        }
        public static bool operator == (NumeroDecimal numero, NumeroBinario binario)
        {
            return numero.Numero == ((NumeroDecimal)binario).Numero;
        }
        public static bool operator !=(NumeroDecimal numero, NumeroBinario binario)
        {
            return !(numero == binario);
        }
        public static double operator +(NumeroDecimal numero, NumeroBinario binario)
        {
            return numero.Numero + ((NumeroDecimal)binario).Numero;
        }
        public static double operator -(NumeroDecimal numero, NumeroBinario binario)
        {
            return numero.Numero - ((NumeroDecimal)binario).Numero;
        }
    }
}
