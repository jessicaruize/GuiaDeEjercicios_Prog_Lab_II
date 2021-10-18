using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Automovil : VehiculoTerrestre
    {
        private int cantidadPasajeros;
        public Automovil(int cantidadPasajeros, short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas) : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Automovil");
            sb.Append(base.Mostrar());
            sb.AppendLine("Cantidad de pasajeros: " + this.cantidadPasajeros);
            return sb.ToString(); ;
        }
    }
}
