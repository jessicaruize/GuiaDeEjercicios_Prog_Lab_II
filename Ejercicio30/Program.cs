using System;
using Entidades;
namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(60, "Rosa"); //ENtra
            AutoF1 a2 = new AutoF1(70, "Amarillo"); //Entra
            AutoF1 a3 = new AutoF1(80, "violeta"); //Lista llena
            AutoF1 a4 = new AutoF1(90, "Verde"); //Lista llena
            AutoF1 a5 = new AutoF1(100, "Azul"); //Entra
            AutoF1 a6 = new AutoF1(100, "Azul");// No entra, es igual al 5.
            Competencia c1 = new Competencia(3, 5);
            if(c1 + a1)
            {
                Console.WriteLine($"Se agrego a: {a1.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"No se agrego a: {a1.MostrarDatos()}");
            }
            if(c1 + a5)
            {
                Console.WriteLine($"Se agrego a: {a5.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"No se agrego a: {a5.MostrarDatos()}");
            }
            if(c1 + a6)
            {
                Console.WriteLine($"Se agrego a: {a6.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"No se seagrego a: {a6.MostrarDatos()}");
            }
            if(c1 + a2)
            {
                Console.WriteLine($"Se agrego a: {a2.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"No se agrego a: {a2.MostrarDatos()}");
            }
            if(c1 + a3)
            {
                Console.WriteLine($"Se agrego a: {a3.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"No se agrego a: {a3.MostrarDatos()}");
            }
            if(c1 + a4)
            {
                Console.WriteLine($"Se agrego a: {a4.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"No se agrego a: {a4.MostrarDatos()}");
            }

            Console.WriteLine($"\n\n\tLISTA\n{c1.MostrarDatos()}");
        }
    }
}
