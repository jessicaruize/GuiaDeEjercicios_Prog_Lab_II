using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;
        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
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
                return this.totalGoles / this.partidosJugados;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"Datos del jugador {nombre}: \nDni: {this.dni}");
            cadena.AppendLine($"Total de goles: { this.totalGoles}");
            cadena.AppendLine($"Partidos jugados: { this.partidosJugados}");
            cadena.AppendLine($"Total de goles: {PromedioGoles}\n");
            return cadena.ToString();
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return j1.dni != j2.dni;
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return !(j1 != j2);
        }
    }
}
