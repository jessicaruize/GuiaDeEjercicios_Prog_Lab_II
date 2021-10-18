using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Camion : VehiculoTerrestre
    {
        private int pesoCarga;

        public Camion(int pesoCarga, short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas) : base (cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.pesoCarga = pesoCarga;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Camion");
            sb.Append(base.Mostrar());
            sb.AppendLine("Peso carga: " + this.pesoCarga);
            return sb.ToString();
        }
    }
}
