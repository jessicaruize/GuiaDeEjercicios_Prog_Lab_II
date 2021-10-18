using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico47_Generics
{
    class Torneo<T>
        where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre) : base()
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            if(torneo is not null && equipo is not null)
            {
                foreach(T item in torneo.equipos)
                {
                    if(item == equipo)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {

        }
    }
}
