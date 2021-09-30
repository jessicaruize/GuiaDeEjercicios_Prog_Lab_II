using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas)
            : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }
        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            cadena.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas}");
            foreach (AutoF1 a in competidores)
            {
                cadena.AppendLine($"\n{a.MostrarDatos()}");
            }
            return cadena.ToString();
        }
    }
}
