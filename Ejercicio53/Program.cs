using System;
using System.Collections.Generic;

namespace Ejercicio53
{
    class Program
    {
        static void Main(string[] args)
        {
            bool aux;
            Cartuchera1 c1 = new Cartuchera1();
            Cartuchera2 c2 = new Cartuchera2();
            c1.ListaGenerica.Add(new Lapiz(5));
            c1.ListaGenerica.Add(new Lapiz(10));
            c1.ListaGenerica.Add(new Boligrafo(8, ConsoleColor.Green));
            c1.ListaGenerica.Add(new Boligrafo(15, ConsoleColor.Red));
            c2.ListaBoligrafo.Add(new Boligrafo(9, ConsoleColor.White));
            c2.ListaBoligrafo.Add(new Boligrafo(18, ConsoleColor.Yellow));
            c2.ListaBoligrafo.Add(new Boligrafo(29, ConsoleColor.Black));
            c2.ListaLapiz.Add(new Lapiz(15));
            c2.ListaLapiz.Add(new Lapiz(25));
            c2.ListaLapiz.Add(new Lapiz(17)); 
            Console.WriteLine(c1.ProbarElementos()); 
            Console.WriteLine(c2.ProbarElementos()); 
            
        }
    }
}
