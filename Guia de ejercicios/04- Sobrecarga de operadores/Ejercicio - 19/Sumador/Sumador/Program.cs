using Biblioteca;
using System;

namespace Sumemmos
{
    class Program
    {
        static void Main(string[] args)
        {
            int casteo;
            long suma;
            bool CantidadIgual;
            Sumador sumadorUno = new Sumador();
            Sumador sumadorDos = new Sumador();
            //probar las funciones.
            Console.WriteLine(sumadorUno.Sumar(50, 30));
            Console.WriteLine(sumadorDos.Sumar(22, 58));
            casteo = (int)sumadorUno;
            suma = sumadorUno + sumadorDos;
            CantidadIgual = sumadorUno | sumadorDos;
            Console.WriteLine(casteo);
            Console.WriteLine(suma);
            Console.WriteLine(CantidadIgual);
        }
    }
}
