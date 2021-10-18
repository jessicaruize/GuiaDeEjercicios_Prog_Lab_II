using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(int dni, string nombre) : this(nombre)
        {
            this.Dni = dni;
        }
        public long Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public virtual string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"Datos del jugador {Nombre}: \nDni: {this.Dni}");
            return cadena.ToString();
        }
    }
}
