using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        private DirectorTecnico(string nombre) : base(nombre)
        {
        }
        public override string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(base.MostrarDatos());
            cadena.AppendLine($"Fecha de nacimiento: { this.fechaNacimiento}");
            return cadena.ToString();
        }
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            if (d1 is not null & d2 is not null && d1.Nombre == d2.Nombre && d1.fechaNacimiento == d2.fechaNacimiento)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
    }
}
