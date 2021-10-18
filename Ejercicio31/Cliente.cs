using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) 
            : this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero; set => numero = value; }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if(c1 is not null && c2 is not null)
            {
                if (c1.Numero == c2.Numero)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
