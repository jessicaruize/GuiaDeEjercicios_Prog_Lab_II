using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43_Excepciones
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombbustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        public VehiculoDeCarrera(short numero, string escuaderia)
        {
            this.cantidadCombbustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.Numero = numero;
            this.Escuderia = escuaderia;
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

        public string Escuderia 
        {
            get
            {
                return escuderia;
            }
            set
            {
                escuderia = value;
            } 
        }
        public short Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }
        public virtual string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"Vehìculo nùmero: {this.numero}");
            cadena.AppendLine($"Escuderìa: {this.escuderia}");
            cadena.AppendLine(this.enCompetencia ? "Esta en competencia" : "No esta en competencia");
            cadena.AppendLine($"Cantidad de combustible: {this.cantidadCombbustible}");
            cadena.AppendLine($"Vueltas restantes: {this.vueltasRestantes}\n");
            return cadena.ToString();
        }
        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return (a1.numero != a2.numero) && (a1.escuderia != a2.escuderia);
        }
        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 != a2);
        }
    }
}
