using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;
        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre)
        {
            this.Dni = dni;
            this.Nombre = nombre;
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
        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }

        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"Datos del jugador {Nombre}: \nDni: {this.Dni}");
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
