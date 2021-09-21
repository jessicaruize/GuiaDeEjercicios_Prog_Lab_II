using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sumador
    {
        int cantidadSuma;
        public Sumador():this(0)
        {
        }
        public Sumador(int cantidadSumas)
        {
            this.cantidadSuma = cantidadSumas;
        }
        public long Sumar(long a, long b)
        {
            this.cantidadSuma++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSuma++;
            return (a + b);
        }
        public static explicit operator int (Sumador s)
        {
            return s.cantidadSuma;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSuma + s2.cantidadSuma;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSuma == s2.cantidadSuma;
        }
    }
}
