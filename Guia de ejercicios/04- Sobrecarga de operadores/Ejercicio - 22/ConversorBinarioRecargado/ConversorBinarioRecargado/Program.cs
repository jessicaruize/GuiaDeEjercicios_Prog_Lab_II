using Entidades;
using System;

namespace ConversorBinarioRecargado
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroDecimal numero = 9;
            NumeroBinario binario = "1001";
            NumeroDecimal numeroDos = 123;
            NumeroBinario binarioDos = "10101";
            Console.WriteLine(numero.Numero);
            Console.WriteLine(binario.Numero);
            Console.WriteLine(numeroDos.Numero);
            Console.WriteLine(binarioDos.Numero);
            binarioDos = (NumeroBinario)numero;
            numeroDos = (NumeroDecimal)binario;
            Console.WriteLine(numeroDos.Numero);
            Console.WriteLine(binarioDos.Numero);
            Console.ReadKey();
        }
    }
}
