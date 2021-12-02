using System;

namespace Ejercico47_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo relampago");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo Final");
            EquipoBasquet b1 = new EquipoBasquet("Club Atlètico Argentino", Convert.ToDateTime("05/05/2005"));
            EquipoBasquet b2 = new EquipoBasquet("Club Atlètico peñarol", Convert.ToDateTime("25/06/2001"));
            EquipoBasquet b3 = new EquipoBasquet("Club Deportivo Libertad", Convert.ToDateTime("10/07/2002"));
            EquipoFutbol f1 = new EquipoFutbol("Club Atlètico Uniòn", Convert.ToDateTime("22/02/2090"));
            EquipoFutbol f2 = new EquipoFutbol("Club Atlètico Lanùs", Convert.ToDateTime("03/09/2010"));
            EquipoFutbol f3 = new EquipoFutbol("Racing Club", Convert.ToDateTime("03/02/2020"));
            bool aux = torneoFutbol + f1;
            aux = torneoFutbol + f2;
            aux = torneoFutbol + f3;
            aux = torneoBasquet + b1;
            aux = torneoBasquet + b2;
            aux = torneoBasquet + b3;
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
        }
    }
}
