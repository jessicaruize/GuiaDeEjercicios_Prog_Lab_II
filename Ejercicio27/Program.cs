using System;
using System.Collections.Generic;

namespace Ejercicio27
{
    class Program
    {/*27. Realizar el ejercicio anterior pero esta vez con las siguientes colecciones: Pilas, Colas y Listas. */
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Queue<int> PositivosColas = new Queue<int>();
            Stack<int> positivosPilas = new Stack<int>();
            Queue<int> negativosColas = new Queue<int>();
            Stack<int> negativosPilas = new Stack<int>();
            Random rdm = new Random();
            int aux;
            for (int i = 0; i < 20; i++)
            {
                do
                {
                    aux = rdm.Next(-100, 100);
                } while (aux == 0);
                lista.Add(aux);
            }
            Console.WriteLine("Lista sin ordenar: ");
            foreach (int i in lista)
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
                if (i > 0)
                {
                    Console.WriteLine(i);
                    PositivosColas.Enqueue(i);
                }
                else
                {
                    negativosPilas.Push(i);
                }
            }
            Console.WriteLine("lista negativos: ");
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] < 0)
                {
                    Console.WriteLine(lista[i]);
                    negativosColas.Enqueue(lista[i]);
                }
                else
                {
                    positivosPilas.Push(lista[i]);
                }
            }
            Console.WriteLine("\nQueue positivos");
            foreach (int i in PositivosColas)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Queue negativos");
            foreach (int i in negativosColas)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nStack positivos");
            foreach (int i in positivosPilas)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Stack negativos");
            foreach (int i in negativosPilas)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        public static int OrdenarLista(int a, int b)
        {
            if (a > b)
            {
                return -1;
            }
            if (b < a)
            {
                return 1;
            }
            return 0;
        }
    }
}
