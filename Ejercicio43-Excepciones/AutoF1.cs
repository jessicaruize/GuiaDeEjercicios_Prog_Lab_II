using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;
        public AutoF1(short numero, string escuaderia):base(numero, escuaderia)
        {
        }
        public AutoF1(short numero, string escuaderia, short caballosDeFuerza):base(numero, escuaderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza { get => caballosDeFuerza; set => caballosDeFuerza = value; }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return (a1.caballosDeFuerza != a2.caballosDeFuerza && a1 != a2);
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 != a2);
        }
        public override string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("AUTO F1");
            cadena.Append(base.MostrarDatos());
            cadena.AppendLine($"Caballos de fuerza: {this.CaballosDeFuerza}");
            return cadena.ToString();
        }
    }
}
