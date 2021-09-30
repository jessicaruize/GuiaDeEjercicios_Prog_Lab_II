using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class VehiculoDeCarrera
    {
        private short cantidadCombbustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
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
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }
        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public VehiculoDeCarrera(short numero, string escuadra)
        {
            this.cantidadCombbustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.Numero = numero;
            this.Escuderia = escuadra;
        }
        public string MostrarDatos()
        {
            string aux;
            StringBuilder cadena = new StringBuilder();
            if (this.enCompetencia)
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
        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return (v1.numero != v2.numero) && (v1.escuderia != v2.escuderia);
        }
        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
