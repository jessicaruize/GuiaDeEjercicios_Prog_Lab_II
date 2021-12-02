using System;

namespace Ejercicio43_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            bool agrego;
            Competencia cF = new Competencia(10, 5, Competencia.TipoCompetencia.F1);
            Competencia cM = new Competencia(15, 2, Competencia.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(10, "UGF23");
            AutoF1 a = new AutoF1(10, "ODS23");
            Console.WriteLine(cF + new AutoF1(12, "ADS23"));
            Console.WriteLine(cF + new AutoF1(15, "EDS23"));
            Console.WriteLine(cF + new AutoF1(11, "IDS23"));
            Console.WriteLine(cF + a);
            Console.WriteLine(cM + new MotoCross(11, "RSD23"));
            Console.WriteLine(cM + new MotoCross(15, "SDE23"));
            Console.WriteLine(cM + new MotoCross(13, "TSD23"));
            Console.WriteLine(cM + m);
            //Console.WriteLine(cF.MostrarDatos());
            //Console.WriteLine(cM.MostrarDatos());
            Console.WriteLine(cF + new MotoCross(10, "YEW23")); //No se debe sumar
            Console.WriteLine(cM + new AutoF1(10, "YEW23")); //No se debe sumar
            Console.WriteLine(cF - new MotoCross(10, "YEW23")); //No de debe eliminar
            Console.WriteLine(cM - new AutoF1(10, "YEW23")); // no se debe eliminar

            Console.WriteLine(cF + new AutoF1(10, "ODS23")); //No se debe agregar
            Console.WriteLine(cM + new MotoCross(10, "UGF23")); // No se debe agregar
            Console.WriteLine(cF - a); //Se debe eliminar
            Console.WriteLine(cM - m); // Se debe eliminar

            //Console.WriteLine(cF.MostrarDatos());
            //Console.WriteLine(cM.MostrarDatos());

        }
    }
}
