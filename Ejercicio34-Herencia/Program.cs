using System;

namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(20, 6, 2, Colores.Blanco, 210);
            Moto moto = new Moto(30, 2, 0, Colores.Rojo, 110);
            Automovil auto = new Automovil(30, 4, 3, Colores.Negro, 300);
            Console.WriteLine(camion.Mostrar());
            Console.WriteLine(moto.Mostrar());
            Console.WriteLine(auto.Mostrar());
        }
    }
}
