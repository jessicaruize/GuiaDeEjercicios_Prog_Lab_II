using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;
        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) 
            : base(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.caballosDeFuerza == a2.caballosDeFuerza) && (a1.CantidadCombustible == a2.CantidadCombustible)
                && (a1.Escuderia == a2.Escuderia) && (a1.Numero == a2.Numero) && (a1.VueltasRestantes == a2.VueltasRestantes)
                && (a1.EnCompetencia == a2.EnCompetencia);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        
       
    }
}
