using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Super super = new Super();
            super += 3;
            super += 3;
            super += 1;

            Console.WriteLine($"resultado {super.Resultado}");
    }
        public class Super
        {
            private Stack<int> numeros;
            public Super()
            {
                numeros = new Stack<int>();
            }
            public double Resultado
            {
                get
                {
                    int resultado = 0;
                    foreach (int num in this.numeros)
                    {
                        resultado += num;
                    }
                    return resultado;
                }
            }
            public static Super operator +(Super super, int num)
            {
                foreach (int item in super.numeros)
                {
                    num *= item;
                }
                super.numeros.Push(num);
                return super;
            }
        }
    }
}
