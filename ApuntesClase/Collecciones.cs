using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CladeDeIntroduccion
{
    class Collecciones
    {
        ////ARRAYS
        //int[] edades = new int[5];
        //edades = { 20, 18, 23, 45, 10 }; //???
        //int[] edades2 = { 20, 18, 23, 45, 10 };
        //int[,] valores = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        //int elemento = valores[2, 1]; //FILA - COLUMNA.
        //int a1 = valores.Length; //devielve la cantidad de elementos que puede tener el array.
        //a1 = valores.Rank; //cuantas dimensiones tiene
        //a1 = valores.GetLength(0); //devuelve la cantidad de elementos que hay en la dimension pasada por parametro.
        //Array.Reverse(valores); // Da vuelta el array.

        ////ARRAY MULTIDIMENSIONAL
        //int[][] aM = new int[3][];
        ///*aM[0] = new int[5];
        //aM[1] = new int[4];
        //aM[2] = new int[2];*/

        //aM[0] = new int[] { 3,4,6,4,3};
        //aM[1] = new int[] { 5,2,7,3};
        //aM[2] = new int[] { 2, 5 };
        ////Acceso aM[F][C]

        ////Contains compara direcciones de memoria, compara la referencia.

        ////COLLECCIONES
        //// LIST Se puede ordenar (Sort)
        //List<int> numeros = new List<int>();
        //numeros.Add(4); //agregar
        //numeros.Add(7);
        //numeros.Add(20);
        //numeros[0] = 100; //pisar
        //numeros.Remove(7); // elimina
        //numeros.RemoveAt(0); // elimina pasandole el indice.
        //a1 = numeros.Count; //devuelve la cantidad de elementos
        //numeros.Insert(1, -5); // inserta un valor en el indice indicado.

        //                        //DICTIONARY: Son utiles usarlo por la clave, no por el valor.
        //Dictionary<string, string> valorD = new Dictionary<string, string>();
        //valorD.Add("taco", "Mexico");
        //valorD.Add("burrito", "Mexico");
        //valorD.Add("pizza", "Italia");
        //foreach (KeyValuePair<string, string> item in valorD)
        //{
        //    Console.WriteLine($"key: {item.Key} Valor: {item.Value}");
        //}
        //a1 = valorD.Count; //devuelve la cantidad de elementos.
        //valorD.Remove("taco"); // key parametro, elimina.
        //valorD["taco"] = "EEUU";
        //bool aux = valorD.ContainsKey("taco"); // busca si esta el key en el diccionario
        //aux = valorD.ContainsValue("Colombia"); // busca si esta el valor en el diccionario
        //Console.WriteLine("Hello World!");

        ////QUEUE (cola: primero en entrar, primero en salir) Coleccion no indexda

        //Queue<string> clientes = new Queue<string>();
        //clientes.Enqueue("Margarita");
        //clientes.Enqueue("Morena");
        //clientes.Enqueue("Malena");//agregar
        //clientes.Dequeue(); //retorna y elimina el primer elemento 
        //clientes.Peek(); //devuelve el primer elemento sin borrarlo.

        ////STACK (Pila: Lo mismo queue pero en otro orden) Ultimo en entrar, primero en salir.s

        //Stack<string> paises = new Stack<string>();
        //paises.Push("Argentina"); //agrega.
        //paises.Push("Nicaragua");
        //paises.Push("Brasil");
        //paises.Pop();//elimina al ultimo (Brasil);
        //paises.Peek();//Devuelve el ultimo sin borrar
    }
}
