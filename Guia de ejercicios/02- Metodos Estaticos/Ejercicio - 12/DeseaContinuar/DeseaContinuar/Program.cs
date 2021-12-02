using Biblioteca;
using System;

namespace DeseaContinuar
{
    class Program
    {
        /*12. Realizar un programa que sume números enteros hasta que el usuario lo determine, 
      * por medio de  un mensaje "¿Continuar? (S/N)". 
      * En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, 
      * se validará el ingreso de  opciones. 
      * El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y 
      * FALSE si se ingresó cualquier otro valor.*/
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acumulador = 0;
            char respuesta;
            do
            {

                Console.WriteLine("Ingrese un nùmero: ");
                numeroIngresado = int.Parse(Console.ReadLine());
                acumulador += numeroIngresado;
                Console.WriteLine("¡Desea continuar?[S/N] ");
                respuesta = char.Parse(Console.ReadLine());
            } while (ValidarRespuesta.ValidaS_N(respuesta));
            Console.WriteLine($"Suma de todos los nùmeros ingresados: {acumulador}");
            Console.ReadKey();
        }
    }
}
