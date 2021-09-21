using System;
using Billetes;
namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar billeteD = 90;
            Peso billeteP = 660; // (Peso)billeteD;
            Euro billeteE = 90; // (Euro)billeteD;
            Dolar sumaBilleteD;
            Peso sumaBilleteP;
            Euro sumaBilleteE;
            Dolar restaBilleteD;
            Peso restaBilleteP;
            Euro restaBilleteE;
            Console.WriteLine(billeteD.GetCantidad);
            Console.WriteLine(billeteP.GetCantidad);
            Console.WriteLine(billeteE.GetCantidad);
            Console.WriteLine("--------------------------------------------------");
            sumaBilleteD = billeteD + billeteP;
            sumaBilleteP = billeteP + billeteE;
            sumaBilleteE = billeteE + billeteD;
            Console.WriteLine(sumaBilleteP.GetCantidad);
            Console.WriteLine(sumaBilleteE.GetCantidad);
            Console.WriteLine(sumaBilleteD.GetCantidad);
            Console.WriteLine("-----------------------------------------------------");
            restaBilleteD = billeteD - billeteP;
            restaBilleteP = billeteP - billeteE;
            restaBilleteE = billeteE - billeteD;
            Console.WriteLine(restaBilleteD.GetCantidad);
            Console.WriteLine(restaBilleteP.GetCantidad);
            Console.WriteLine(restaBilleteE.GetCantidad);
            Console.WriteLine("-----------------------------------------------------");
            Console.ReadKey();
        }
    }
}
