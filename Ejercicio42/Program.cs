using System;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase c = new OtraClase();
            }
            catch(MiExcepcion e)
            {
                Exception ex = e;
                do
                {
                    Console.WriteLine(ex.Message);
                    ex = ex.InnerException;
                } while (!object.ReferenceEquals(ex, null));
            }
            Console.ReadKey();
        }
    }
}
