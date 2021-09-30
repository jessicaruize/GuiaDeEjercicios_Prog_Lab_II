using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        private short cantidadCombbustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        public AutoF1(short numero, string escuadra)
        {
            this.cantidadCombbustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuadra;
        }
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombbustible;
            }
            set
            {
                this.cantidadCombbustible = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public string MostrarDatos()
        {
            string aux;
            StringBuilder cadena = new StringBuilder();
            if(this.enCompetencia)
            {
                aux = "Esta en competencia.";
            }
            else
            {
                aux = "No esta en competencia.";
            }
            cadena.AppendLine($"Auto nùmero: {this.numero}");
            cadena.AppendLine($"Escuderìa: {this.escuderia}");
            cadena.AppendLine($"{aux}");
            cadena.AppendLine($"Cantidad de combustible: {this.cantidadCombbustible}");
            cadena.AppendLine($"Vueltas restantes: {this.vueltasRestantes}\n");
            return cadena.ToString();
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero != a2.numero) && (a1.escuderia != a2.escuderia);
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 != a2);
        }
    }
}
