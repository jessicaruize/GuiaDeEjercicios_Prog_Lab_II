using System;
using Biblioteca;
namespace Ejercicio11
{
    class Program
    { /*11. Realizar una clase llamada Validación que posea un método estático llamado Validar,
       * que posea la  siguiente firma: bool Validar(int valor, int min, int max): 
       * a. valor: dato a validar  
       * b. min y max: rango en el cual deberá estar la variable valor. 
       * Pedir al usuario que ingrese 10 números enteros. 
       * Validar con el método desarrollado  anteriormente que estén 
       * dentro del rango -100 y 100. 
       * Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio. 
       * Nota: Utilizar variables escalares, NO utilizar vectores. */
        static void Main(string[] args)
        {
            int valorMinimo = -100;
            int valorMaximo = 100;
            int cantidadDeNumerosPedidos = 10;
            int acumulador = 0;
            int i = 1;
            float promedio;
            int numeroIngresado;
            int numeroIngresadoMinimo = int.MaxValue;
            int numeroIngresadoMaximo = int.MinValue;
            do
            {
                Console.WriteLine("ingrese un nùmero mayor a -100 y menor a 100: ");
                numeroIngresado = int.Parse(Console.ReadLine());
                while(!Validacion.Validar(numeroIngresado, valorMaximo, valorMinimo))
                {
                    Console.WriteLine("ERROR. ingrese un nùmero mayor a -100 y menor a cien: ");
                    numeroIngresado = int.Parse(Console.ReadLine());
                }
                if(numeroIngresado < numeroIngresadoMinimo)
                {
                    numeroIngresadoMinimo = numeroIngresado;
                }
                if(numeroIngresado > numeroIngresadoMaximo)
                {
                    numeroIngresadoMaximo = numeroIngresado;
                }
                acumulador += numeroIngresado;
                i++;
            } while (i < cantidadDeNumerosPedidos);
            promedio = acumulador / (float)cantidadDeNumerosPedidos;
            Console.WriteLine($"Valor mìnimo: {numeroIngresadoMinimo} \nValor màximo: {numeroIngresadoMaximo} \nPromedio: {promedio}");
        }
    }
}
