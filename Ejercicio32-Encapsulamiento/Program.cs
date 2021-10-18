using System;

namespace Ejercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(3, "Palermo");
            Jugador jugador1 = new Jugador(1234, "Juan", 6, 5);
            Jugador jugador2 = new Jugador(1234, "Pepe", 2, 6);
            Jugador jugador3 = new Jugador(1695, "Ana", 9, 10);
            Jugador jugador4 = new Jugador(2948, "Maria", 3, 5);
            Jugador jugador5 = new Jugador(5847, "Victoria", 7, 6);
            if (equipo + jugador1)
            {
                Console.WriteLine(jugador1.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"\nNo se agrego a {jugador1.MostrarDatos()}");
            }
            if (equipo + jugador2)
            {
                Console.WriteLine(jugador2.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"\nNo se agrego a {jugador2.MostrarDatos()}");
            }
            if (equipo + jugador3)
            {
                Console.WriteLine(jugador3.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"\nNo se agrego a {jugador3.MostrarDatos()}");
            }
            if (equipo + jugador4)
            {
                Console.WriteLine(jugador4.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"\nNo se agrego a {jugador4.MostrarDatos()}");
            }
            if (equipo + jugador5)
            {
                Console.WriteLine(jugador5.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"\nNo se agrego a {jugador5.MostrarDatos()}");
            }
            Console.ReadKey();
        }
    }
}
