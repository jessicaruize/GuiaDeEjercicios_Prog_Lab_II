using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre)
            :this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            bool aux = false;
            if(e.cantidadDeJugadores > e.jugadores.Count)
            {
                foreach(Jugador jAux in e.jugadores)
                {
                    if(jAux == j)
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                aux = true;
            }
            return aux;
        }

    }
}
