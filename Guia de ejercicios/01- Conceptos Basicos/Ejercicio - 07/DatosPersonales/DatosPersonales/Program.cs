using System;

namespace DatosPersonales
{
    class Program
    {
        /* Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año)
       * y  calcule el número de días vividos por esa persona hasta la fecha actual 
       * (tomar la fecha del sistema con DateTime.Now). 
       * Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos. */
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime();
            Console.WriteLine("Ingrese su fecha de nacimiento en el siguiente formato DD-MM-YYYY: ");
            fecha = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(DateTime.Now.Subtract(fecha).Days);
            Console.ReadKey();
        }
    }
}
}
