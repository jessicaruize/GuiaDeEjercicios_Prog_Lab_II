using System;

namespace Ejercicio03
{
    class Program
    {
        /* Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario  por consola. 
        Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%). */
        static void Main(string[] args)
        {
            int numero;
            bool esPrimo;
            Console.WriteLine("Ingrese un nùmero: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write($"Los nùmero primos que se encuentran entre 0 y {numero} son : ");
            for(int i = 2; i < numero; i++)
            {
                esPrimo = true;
                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if(esPrimo)
                {
                    Console.Write($"{i} - ");
                }
            }
            Console.ReadKey();
        }
    }
}
