using System;
using Entidades;
namespace Ejercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Title = "Ejercicio Nº38 Guia 2017";
            Sobrescrito sobrecarga = new Sobrescrito();
            Console.WriteLine(sobrecarga.ToString());
            string objeto = "¡Este es mi mètodo ToString sobrescrito!";
            Console.WriteLine("------------------------------");
            Console.WriteLine("Comparacion Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));
            Console.WriteLine("-------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());*/
            Console.Title = "Ejercicio Nº39 Guia 2017";
            SobreSobrescrito sobrecarga = new SobreSobrescrito();
            Console.WriteLine(sobrecarga.MiMetodo());
            Console.ReadKey();
        }
    }
}
