using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;
        public Jugador(int dni, string nombre) : base (dni, nombre)
        {
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) 
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public float PromedioGoles
        {
            get
            {
                return this.TotalGoles / this.PartidosJugados;
            }
        }

        public int PartidosJugados { get => partidosJugados; }
        public int TotalGoles { get => totalGoles; }

        public override string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(base.MostrarDatos());
            cadena.AppendLine($"Total de goles: { this.TotalGoles}");
            cadena.AppendLine($"Partidos jugados: { this.PartidosJugados}");
            cadena.AppendLine($"Total de goles: {PromedioGoles}\n");
            return cadena.ToString();
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return j1.Dni != j2.Dni;
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return !(j1 != j2);
        }
    }
}
