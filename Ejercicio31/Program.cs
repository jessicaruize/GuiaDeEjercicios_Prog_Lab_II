using System;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            bool atendido;
            bool agregado;
            Negocio negocio = new Negocio("DW");
            Cliente c1 = new Cliente(PuestoAtencion.NumeroActual, "Rebeca");
            Cliente c2 = new Cliente(PuestoAtencion.NumeroActual, "Dario");
            Cliente c3 = new Cliente(PuestoAtencion.NumeroActual, "Lourdes");
            Cliente c4 = new Cliente(PuestoAtencion.NumeroActual, "Florencia");
            Cliente c5 = new Cliente(PuestoAtencion.NumeroActual, "Anabella");
            agregado = negocio + c1; 
            agregado = negocio + c2; 
            agregado = negocio + c3; 
            agregado = negocio + c4; 
            agregado = negocio + c5;
            Console.WriteLine("Hay " + negocio.ClientesPendientes + " clientes pendientes.");
            atendido = ~negocio;
            Console.WriteLine("Hay " + negocio.ClientesPendientes + " clientes pendientes.");
            atendido = ~negocio;
            atendido = ~negocio;
            Console.WriteLine("Hay " + negocio.ClientesPendientes + " clientes pendientes.");
            atendido = ~negocio;
            Console.WriteLine("Hay " + negocio.ClientesPendientes + " clientes pendientes.");
        }
    }
}
