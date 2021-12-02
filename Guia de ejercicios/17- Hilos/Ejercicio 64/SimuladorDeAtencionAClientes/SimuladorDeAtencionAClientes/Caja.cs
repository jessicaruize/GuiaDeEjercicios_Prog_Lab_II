using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Caja
    {
        public delegate void MiDelegado(Caja caja, string cliente);
        private static Random rmd;
        private Queue<string> clientesALaEspera;
        private string nombreCaja;
        private MiDelegado delegadoClienteAtendido;
        static Caja()
        {
            rmd = new Random();
        }
        public Caja(string nombreCaja, MiDelegado delegado)
        {
            clientesALaEspera = new Queue<string>();
            this.nombreCaja = nombreCaja;
            this.delegadoClienteAtendido = delegado;
        }
        public string NombreCaja 
        {
            get
            {
                return this.nombreCaja;
            }
        }
        public int CantidadDeClientesALaEspera
        {
            get
            {
                return this.clientesALaEspera.Count;
            }
        }
        internal void AgregarCliente(string cliente)
        {
            this.clientesALaEspera.Enqueue(cliente);
        }
        internal Task IniciarAtencion()
        {
            return Task.Run(AtenderCientes);
        }
        private void AtenderCientes()
        {
            string cliente = string.Empty;
            do
            {
                if (this.clientesALaEspera.Any())
                {
                    cliente = this.clientesALaEspera.Dequeue();
                    if(this.delegadoClienteAtendido is not null)
                    {
                        this.delegadoClienteAtendido.Invoke(this, cliente);
                    }
                }
                Thread.Sleep(rmd.Next(1000, 5001));
            }while(true);
        }
    }
}