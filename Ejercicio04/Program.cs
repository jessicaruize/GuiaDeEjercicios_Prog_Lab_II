using System;

namespace Ejercicio04
{
    class Program
    {
        /*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos  (excluido el mismo) que son divisores del número. 
        El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. Escribir una aplicación que encuentre los 4 primeros números perfectos. 
        Nota: Utilizar estructuras repetitivas y selectivas. */
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador = 0;
            int numero = 1;
            Console.Write("Los primeros 4 numeros perfectos son: ");
            do
            {
                for (int i = 1; i < numero; i++)
                {
                    if ((numero % i) == 0)
                    {
                        acumulador += i;
                    }
                }
                if (acumulador == numero)
                {
                    Console.Write($"{numero} - ");
                    contador++;
                }
                numero++;
                acumulador = 0;
            } while (contador < 4);
            Console.ReadKey();
        }
    }
}