using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ejercicio31
{
    public class PuestoAtencion
    {
        public enum Puesto { Caja1, Caja2 }
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                return numeroActual += 1;
            }
        }

        static PuestoAtencion()
        {
            numeroActual = 0;    
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(3000);
            return true;
        }
    }
}
