using System;

namespace Ejercicio09
{
    /*9. Escribir un programa que imprima por pantalla una pirámide como 
    la siguiente: 
    * 
    *** 
    ***** 
    ******* 
    ********* 
    El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el  ejemplo anterior la altura ingresada fue de 5. 
    Nota: Utilizar estructuras repetitivas y selectivas.*/
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string agregar = "*";
            Console.WriteLine("Ingrese la altura de la piramide: ");
            numero = int.Parse(Console.ReadLine());
            for(int i = 0; i < numero; i++)
            {
                if(i==0)
                {
                    Console.WriteLine(agregar);
                }
                else
                {
                    agregar += "**";
                    Console.WriteLine(agregar);
                }
            }
            Console.ReadKey();
        }
    }
}