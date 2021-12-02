﻿using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private static RealNameGenerator realNameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;
        static Negocio ()
        {
            realNameGenerator = new RealNameGenerator();
        }
        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas;
            clientes = new ConcurrentQueue<string>();
        }
        public List<Task> ComenzarAtencion()
        {
            List<Task> hilos = new List<Task>();
            foreach (Caja item in this.cajas)
            {
                hilos.Add(item.IniciarAtencion());
            }
            hilos.Add(Task.Run(GenerarClientes));
            hilos.Add(Task.Run(AsignarCajas));
            return hilos;
        }
        private void GenerarClientes()
        {
            do
            {
                string cliente = realNameGenerator.Generate();
                clientes.Enqueue(cliente);
                Thread.Sleep(1000);
            } while (true);
        }
        private void AsignarCajas()
        {
            do
            {
                Caja caja = this.cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First();
                clientes.TryDequeue(out string cliente);
                if (!string.IsNullOrWhiteSpace(cliente))
                {
                    caja.AgregarCliente(cliente);
                }

            } while (true);
        }
    }
}
