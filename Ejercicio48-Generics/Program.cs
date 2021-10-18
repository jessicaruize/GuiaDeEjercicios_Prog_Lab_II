using System;

namespace Ejercicio48_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> lista = new Contabilidad<Factura, Recibo>();
            lista += new Recibo(6);
            lista += new Recibo(9);
            lista += new Recibo(2);
            lista += new Recibo(4);
            lista += new Factura(4);
            lista += new Factura(6);
            lista += new Factura(9);
            lista += new Factura(1);
            Console.WriteLine(lista.Mostrar());
        }
    }
}
