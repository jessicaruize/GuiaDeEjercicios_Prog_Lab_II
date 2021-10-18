using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    public class Competencia
    {
        public enum TipoCompetencia { F1, MotoCross}
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private TipoCompetencia tipo;
        private List<VehiculoDeCarrera> competidores;

        public short CantidadCompetidores { get => cantidadCompetidores; set => cantidadCompetidores = value; }
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }
        public TipoCompetencia Tipo { get => tipo; set => tipo = value; }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public  Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo
            ) 
            : this()
        {
            this.CantidadCompetidores = cantidadCompetidores;
            this.CantidadVueltas = cantidadVueltas;
            this.Tipo = tipo;
        }
        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"Cantidad de competidores: {this.CantidadCompetidores}");
            cadena.AppendLine($"Cantidad de vueltas: {this.CantidadVueltas}");
            cadena.AppendLine($"Tipo de competencia: {this.Tipo}");
            foreach(VehiculoDeCarrera a in competidores)
            {
                cadena.AppendLine($"\n{a.MostrarDatos()}");
            }
            return cadena.ToString();
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            if ((c.Tipo == TipoCompetencia.MotoCross && v.GetType() == typeof(MotoCross)) || (c.Tipo == TipoCompetencia.F1 && v.GetType() == typeof(AutoF1)))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            if(c == v && c.CantidadCompetidores > c.competidores.Count)
            {
                foreach(VehiculoDeCarrera vL in c.competidores)
                {
                    if (v == vL)
                    {
                        return false;
                    }
                }
                Random rnd = new Random();
                v.EnCompetencia = true;
                v.VueltasRestantes = c.CantidadVueltas;
                v.CantidadCombustible = (short)rnd.Next(15, 100);
                c.competidores.Add(v);
                return true;
            }
            return false; 
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            if(c == v)
            {
                foreach(VehiculoDeCarrera vL in c.competidores)
                {
                    if(vL == v)
                    {
                        return c.competidores.Remove(v);
                    }
                }
            }
            return false;
        }
    }
}
