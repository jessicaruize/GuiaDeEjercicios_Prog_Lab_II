using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio49_Generics
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;
        public MotoCross(short numero, string escuaderia) : base(numero, escuaderia)
        {
        }
        public MotoCross(short numero, string escuaderia, short cilindrada) : this(numero, escuaderia)
        {
            this.cilindrada = cilindrada;
        }
        public short Cilindrada { get => cilindrada; set => cilindrada = value; }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return (a1.cilindrada != a2.cilindrada && a1 != a2);
        }
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return !(a1 != a2);
        }
        public override string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("MOTO CROSS");
            cadena.Append(base.MostrarDatos());
            cadena.AppendLine($"Cilindrada: {this.cilindrada}");
            return cadena.ToString();
        }
    }
}