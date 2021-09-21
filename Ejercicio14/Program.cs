using System;
using Biblioteca;

namespace Ejercicio14
{
    class Program
    {/*14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el  cálculo del área que corresponda: 
       a. double CalcularCuadrado(double) 
       b. double CalcularTriangulo(double, double) 
       c. double CalcularCirculo(double) 
       El ingreso de los datos como la visualización se deberán realizar desde el método Main().      
     */
        static void Main(string[] args)
        {
            int opcion;
            double numeroUno;
            double numeroDos;
            double resultado;
            Console.WriteLine("Ingrese la opcion que desea: \n1_Calcular cuadrado. " +
                              "\n2_Calcular triangulo. \n3_Calcular circulo.");
            opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el valor de un lado del cuadrado: ");
                    numeroUno = double.Parse(Console.ReadLine());
                    resultado = CalculoDeArea.CalcularCuadrado(numeroUno);
                    Console.WriteLine($"El valor del area del cuadrado es: {resultado}");
                    break;
                case 2:
                    Console.WriteLine("Ingrese el valor de la base del triangulo: ");
                    numeroUno = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de la altura del triangulo: ");
                    numeroDos = double.Parse(Console.ReadLine());
                    resultado = CalculoDeArea.CalcularTriangulo(numeroUno, numeroDos);
                    Console.WriteLine($"El valor del area del cuadrado es: {resultado}");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el valor del radio del triangulo: ");
                    numeroUno = double.Parse(Console.ReadLine());
                    resultado = CalculoDeArea.CalcularCirculo(numeroUno);
                    Console.WriteLine($"El valor del area del cuadrado es: {resultado}");
                    break;
                default:
                    Console.WriteLine("Ha ingresado un valor incorrecto.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
