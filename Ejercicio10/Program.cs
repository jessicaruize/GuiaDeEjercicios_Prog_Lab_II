using System;

namespace Ejercicio10
{   /*10. Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla  una pirámide como la siguiente: 
        * 
       *** 
      ***** 
     ******* 
    ********* 
    Nota: Utilizar estructuras repetitivas y selectivas.
    Ruiz Jessica*/
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            int k = 1;
            string cargar = "*"; 
            Console.WriteLine("Ingrese la altura de la piramide");
            altura = int.Parse(Console.ReadLine());
            for (int i = 0; i < altura; i++)
            {
                for(int j = 0; j<altura; j++)
                {
                    if (j < altura - k)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.WriteLine(cargar);
                        cargar += "**";
                        break;
                    }
                }
                k++;
            }
            Console.ReadKey();
        }
    }
}
