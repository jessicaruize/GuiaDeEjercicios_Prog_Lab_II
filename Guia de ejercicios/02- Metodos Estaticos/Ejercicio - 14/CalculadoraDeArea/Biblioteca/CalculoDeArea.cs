using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double cuadrado)
        {
            return Math.Pow(cuadrado, 2);
        }
        public static double CalcularTriangulo(double baseNumero, double altura)
        {
            return (baseNumero * altura) / 2;
        }
        public static double CalcularCirculo(double radio)
        {
            double pi = 3.14;
            return Math.Pow((pi * radio), 2);
        }
    }
}
