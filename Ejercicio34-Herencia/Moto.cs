using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Moto : VehiculoTerrestre
    {
        private short cilindrada;
        public Moto(short cilindrada, short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas) : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.cilindrada = cilindrada;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Moto");
            sb.Append(base.Mostrar());
            sb.AppendLine("Cilindrada: " + this.cilindrada);
            return sb.ToString(); ;
        }
    }
}
