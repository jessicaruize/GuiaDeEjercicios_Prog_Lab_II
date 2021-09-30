using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public  Competencia(short cantidadCompetidores, short cantidadVueltas) 
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
            foreach(AutoF1 a in competidores)
            {
                cadena.AppendLine($"\n{a.MostrarDatos()}");
            }
            return cadena.ToString();
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach(AutoF1 b in c.competidores)
            {
                if(a == b)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c != a && c.cantidadCompetidores > c.competidores.Count)
            {
                Random rnd = new Random();
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)rnd.Next(15, 100);
                return true;
            }
            return false; 
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            if(c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }
    }
}
