using System;
using Biblioteca;
namespace Ejercicio13
{
    class Program
    {/*. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): 
      * string DecimalBinario(int). Convierte un número de entero a binario. 
      * int BinarioDecimal(string). Convierte un número binario a entero. 
      * NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control. */
        static void Main(string[] args)
        {
            int numero;
            string binario;
            int respuesta;
            Console.WriteLine("Ingrese la opcion que desea realizar: \n1_Convetir un nùmero decimal" +
                " a binario.\n2_Convertir un nùmero binario a decimal.");
            respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
            {
                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());
                binario = Conversor.DecimaBinario(numero);
                Console.WriteLine($"El nùmero {numero} en binario es: {binario}");
            }
            if (respuesta == 2)
            {
                Console.WriteLine("Ingrese un numero:");
                binario = Console.ReadLine();
                numero = Conversor.BinarioDecimal(binario);
                Console.WriteLine($"El nùmero {binario} en decimal es: {numero}");
            }
        }
    }
}
