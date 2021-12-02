using Biblioteca;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja.MiDelegado clienteAtendido = (caja, cliente) =>
            {
                Console.WriteLine($"{DateTime.Now:HH:MM:ss} - Hilo {Task.CurrentId} - {caja.NombreCaja} - Atendiendo a {cliente}. Quedad{caja.CantidadDeClientesALaEspera} clientes en esta caja.");
            };
            List<Caja> cajas = new List<Caja>()
            {
                new Caja("Caja 1", clienteAtendido),
                new Caja("Caja 2", clienteAtendido)
            };
            Negocio negocio = new Negocio(cajas);
            Console.WriteLine("Asignando cajas...");
            List<Task> hilos = negocio.ComenzarAtencion();
            Task.WaitAll(hilos.ToArray());
        }
    }
}
