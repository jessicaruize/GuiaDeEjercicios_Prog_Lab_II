using System;

namespace Ejercicio02
{
    class Program
    {
        /*
         Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
        Se debe validar que el número sea  mayor que cero, caso contrario, 
        mostrar el mensaje: "ERROR. ¡Reingresar número!". 
        Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación. 
         */
        static void Main(string[] args)
        {
            int numero;
            double cuadrado;
            double cubo;
            Console.WriteLine("Ingrese un nùmero mayor a cero: ");
            numero = int.Parse(Console.ReadLine());
            while(numero < 0)
            {
                Console.WriteLine("Error, ingrese un nùmero mayor a cero: ");
                numero = int.Parse(Console.ReadLine());
            }
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine($"El nùmero ingresado es: {numero} \nAl cuadrado: {cuadrado} \nAl cubo: {cubo}");

        }
    }
}
