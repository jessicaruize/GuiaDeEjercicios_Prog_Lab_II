using System;

namespace AñosBiciestos
{
    class Program
    {
        /* Escribir un programa que determine si un año es bisiesto. 
       * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, 
       * salvo si ellos  también son múltiplos de 400. Por ejemplo: 
       * el año 2000 es bisiesto pero 1900 no. Pedirle al usuario un año de inicio y 
       * otro de fin y mostrar todos los años bisiestos en ese rango. 
       * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).  */
        static void Main(string[] args)
        {
            int fecha1, fecha2;
            int i;
            Console.WriteLine("Ingrese año inicial: ");
            fecha1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese año de final: ");
            fecha2 = int.Parse(Console.ReadLine());
            Console.Write($"Los años bisiestos encontrados entre {fecha1} y {fecha2} son : ");
            for (i = fecha1; i < fecha2; i++)
            {
                if (i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
                {
                    Console.Write($" {i} ");
                }
            }
            Console.ReadKey();
        }
    }
}
