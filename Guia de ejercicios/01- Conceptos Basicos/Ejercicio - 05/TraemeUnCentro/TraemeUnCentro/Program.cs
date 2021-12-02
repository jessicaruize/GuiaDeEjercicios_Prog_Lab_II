using System;

namespace TraemeUnCentro
{
    class Program
    {
        /*Un centro numérico es un número que separa una lista de números enteros 
     * (comenzando en 1) en  dos grupos de números, cuyas sumas son iguales. 
     *  El primer centro numérico es el 6, el cual separa la lista (1 a 8)
     *  en los grupos: (1; 2; 3; 4; 5) y (7; 8)  cuyas sumas son ambas iguales a 15. 
     *  El segundo centro numérico es el 35, el cual separa la lista (1 a  49) 
     *  en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595. 
     *  Se pide elaborar una aplicación que calcule los centros numéricos entre 1 
     *  y el número que el  usuario ingrese por consola. 
     *  Nota: Utilizar estructuras repetitivas y selectivas.*/
        class Program
        {
            static void Main(string[] args)
            {
                int numero;
                int i, j;
                int centro = 1;
                int acumulador1 = 1;
                int acumulador2 = 0;
                Console.WriteLine("Ingrese un nùmero: ");
                numero = int.Parse(Console.ReadLine());
                Console.Write($"El centro numerico de {numero} es: ");
                do
                {
                    for (i = 1; i < centro; i++)
                    {
                        acumulador1 += i;
                    }
                    for (j = centro + 1; j < (centro * 2); j++)
                    {
                        if (acumulador1 == acumulador2)
                        {
                            Console.Write($" - {centro}");
                            break;
                        }
                        else
                        {
                            acumulador2 += j;
                        }
                    }
                    centro += 1;
                    acumulador1 = 0;
                    acumulador2 = 0;
                } while (centro < numero + 1);
                Console.ReadKey();
                /*for(i= 1; i < numero; i++)
                {
                    acumulador1 = 0;
                    acumulador2 = 0;
                    for(j= 1; j < i; j++)
                    {
                        acumulador1 += j;
                    }
                    for(k= i+1; ;k++)
                    {
                        acumulador2 += k;
                        if(acumulador2 >= acumulador1)
                        {
                            break;
                        }
                    }
                    if(acumulador1 == acumulador2)
                    {
                        Console.WriteLine($"El centro numerico de {numero} es: {i}");
                    }
                }
                Console.ReadKey();*/
            }
        }
}
