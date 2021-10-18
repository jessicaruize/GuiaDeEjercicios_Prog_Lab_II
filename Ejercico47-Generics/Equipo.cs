using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico47_Generics
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        protected Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public static bool operator == (Equipo e1, Equipo e2)
        {
            if(e1 is not null && e1 is not null)
            {
                if(e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator != (Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(nombre + " fundados el " + fechaCreacion);
            return sb.ToString();
        }
    }
}
