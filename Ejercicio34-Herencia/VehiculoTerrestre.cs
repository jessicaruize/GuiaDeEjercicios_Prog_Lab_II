using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cantidadMarchas;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de ruedad: " + this.cantidadRuedas);
            sb.AppendLine("Cantidad de puertas: " + this.cantidadPuertas);
            sb.AppendLine("Cantidad de marchas: " + this.cantidadMarchas);
            sb.AppendLine("Color: " + this.color);
            return sb.ToString();
        }
    }
}
