using System;
using System.Collections.Generic;

namespace Ejercicio26
{
    class Program
    {
        /*26. Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) 
         * distintos de  cero de forma aleatoria utilizando la clase Random. 
         * a. Mostrar el vector tal como fue ingresado 
         * b. Luego mostrar los positivos ordenados en forma decreciente. 
         * c. Por último, mostrar los negativos ordenados en forma creciente.
         */
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Random rdm = new Random();
            int aux;
            for(int i = 0; i < 20; i++)
            {
                do
                {
                    aux = rdm.Next(-100, 100);
                } while (aux == 0);
                lista.Add(aux);
            }
            Console.WriteLine("Lista sin ordenar: ");
            foreach(int i in lista)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Lista ordenados de forma decreciente: ");
            lista.Sort(Program.OrdenarLista);
            Console.WriteLine("Lista ordenada: ");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Lista positivos: ");
            foreach (int i in lista)
            {
                if(i > 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("lista negativos: ");
            for(int i = lista.Count-1; i >= 0; i--)
            {
                if(lista[i] < 0)
                {
                    Console.WriteLine(lista[i]);
                }
            }
            
            Console.ReadKey();
        }
        public static int OrdenarLista(int a, int b)
        {
            if(a>b)
            {
                return -1;
            }
            if(b<a)
            {
                return 1;
            }
            return 0;
        }
    }
}
