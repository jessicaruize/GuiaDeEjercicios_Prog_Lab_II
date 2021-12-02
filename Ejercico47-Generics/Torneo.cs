using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico47_Generics
{
    public class Torneo<T>
        where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre) : this()
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
            return !(torneo == equipo);
        }
        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo is not null && equipo is not null && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            return false; 
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Equipos correspondientes al torneo: {this.nombre}");
            foreach(T equipo in this.equipos)
            {
                sb.AppendLine(equipo.Ficha());

            }
            return sb.ToString();
        }
        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random rdm = new Random();
            return $"[{equipo1.Nombre}] [{rdm.Next(0, 10)}] - [{equipo2.Nombre}] [{rdm.Next(0, 10)}]";
        }
        public string JugarPartido
        {
            get
            {
                if (this.equipos.Count > 1)
                {
                    Random rdm = new Random();
                    T equipo1 = this.equipos.ElementAt(rdm.Next(0, this.equipos.Count));
                    T equipo2;
                    do
                    {
                        equipo2 = this.equipos.ElementAt(rdm.Next(0, this.equipos.Count));
                    } while (equipo1 == equipo2);
                    return CalcularPartido(equipo1, equipo2);
                }
                return "Error, debe haber mas de un equipo.";
            }
        }
    }
    
}
