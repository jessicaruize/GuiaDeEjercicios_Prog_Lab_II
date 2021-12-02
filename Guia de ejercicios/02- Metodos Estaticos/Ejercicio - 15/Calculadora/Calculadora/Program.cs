using System;
using Biblioteca;
namespace Calculadora
{
    class Program
    {
        /*15. Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,  multiplicación y división). 
      * Para ello se le debe pedir al usuario que ingrese dos números y la  operación que desea realizar 
      * (pulsando el caracter +, -, * o /). El usuario decidirá cuándo finalizar el programa. 
      * Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase): 
      * a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la  operación matemática. 
      * El método devolverá el resultado de la operación. 
      * b. Validar (privado): Recibirá como parámetro el segundo número. 
      * Este método se debe  utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
      * Este método devolverá TRUE si el número es distinto de CERO. */
        static void Main(string[] args)
        {
            float numeroUno;
            float numeroDos;
            float resultado;
            string operador;
            string seguir;
            do
            {
                Console.WriteLine("Ingrese el primero nùmero: ");
                numeroUno = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo nùmero: ");
                numeroDos = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la operacion que desea realizar [+ - * /]: ");
                operador = Console.ReadLine();
                while (operador != "+" && operador != "-" && operador != "*" && operador != "/")
                {
                    Console.WriteLine("Ingrese la operacion que desea realizar [+ - * /]: ");
                    operador = Console.ReadLine();
                }
                resultado = Calculadora.Calcular(numeroUno, numeroDos, operador);
                Console.WriteLine($"El resultado de {numeroUno} {operador} {numeroDos} = {resultado}");
                Console.WriteLine("\nDATO IMPORTANTE: En caso de que haya intentado dividir algun nùmero por cero el resultado darà cero, ya que no es posible dividir ningun nùmero por cero.");
                Console.WriteLine("\n¿Desea realizar otra operaciòn ? [s / n]");
                seguir = Console.ReadLine();
            } while (seguir.ToLower() == "s");
        }
    }
}
